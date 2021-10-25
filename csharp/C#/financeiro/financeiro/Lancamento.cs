using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financeiro
{
    public class Lancamento
    {
        [Required (ErrorMessage ="O campo data é obrigatório.")]
        [DataType (DataType.Date, ErrorMessage = "O campo data precisa ser do tipo data.")]
        public DateTime dataLancamento { get; set; }

        [Required (ErrorMessage = "O campo descrição é obrigatório.")]
        [StringLength(maximumLength:50,ErrorMessage = "O campo descrição só aceita 50 caracteres.")]
        public String descricao { get; set; }

        [Required(ErrorMessage = "O campo motivo é obrigatório.")]
        [StringLength(maximumLength: 100, ErrorMessage = "O campo motivo só aceita 100 caracteres.")]
        public String motivo { get; set; }

        public Fonte fonte { get; set; }

        [Required (ErrorMessage = "O campo responsável é obrigatório.")]
        [StringLength(maximumLength:30, ErrorMessage = "O campo responsável só aceita 30 caracteres.")]
        public String responsavel { get; set; }

        [Required (ErrorMessage = "O campo valor é obrigatório.")]
        [DataType (DataType.Currency, ErrorMessage = "O campo valor deve ser um campo monetário.")]
        public Decimal valor { get; set; }

        [Required (ErrorMessage = "O campo tipo lançamento é obrigatório.")]
        [StringLength(maximumLength:1, ErrorMessage = "Erro na escolha do campo tipo de lançamento.")]
        public String tipoDespesa { get; set; }

        [Required(ErrorMessage = "O campo quitado é obrigatório.")]
        public Boolean quitado { get; set; }

        [Required(ErrorMessage = "O campo lançamento fixo é obrigatório.")]
        public Boolean fixa { get; set; }

        [Required (ErrorMessage = "O campo parcelas é obrigatório.")]
        [Range(minimum:1, maximum: Util.Constantes.totalParcelas, ErrorMessage = "O número de parcelas deve variar entre 1 e 36.")]
        public int parcelas { get; set; }

        public int parcelaAtual { get; set; }


        public void ValidaClasse()
        {
            ValidationContext validationContext = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            Boolean validate = Validator.TryValidateObject(this, validationContext, validationResults, true);

            if (!validate)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (ValidationResult validation in validationResults)
                    stringBuilder.AppendLine(validation.ErrorMessage);

                throw new ValidationException(stringBuilder.ToString());
            }
        }

        public void ValidacaoCadastral()
        {
            if (this.fonte == null)
                throw new Exception("O campo fonte é obrigatório");            
        }

        public static void geraLancamentosFixosMesAnterior(String _Ano,String _Mes, DateTime _DataAtual)
        {
            DateTime DataInicio = DateTime.ParseExact("01" + "/" + _Mes + "/" + _Ano, "dd/MM/yyyy", CultureInfo.InvariantCulture).AddMonths(-1);
            DateTime DataFim = DateTime.ParseExact(DateTime.DaysInMonth(DataInicio.Year, DataInicio.Month).ToString("d02") + "/" + DataInicio.Month.ToString("d02") + "/" + DataInicio.Year.ToString("d04"), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            String diretorioLancamento = Util.Constantes.diretorioLancamentos + "/" + _DataAtual.Year.ToString("d04");
            String arquivo = diretorioLancamento + "/" + _DataAtual.Month.ToString("d02") + ".json";

            // caso o arquivo já exista não há necessidade de carregar o histório de despesas fixas
            if (!File.Exists(arquivo))
            {
                diretorioLancamento = Util.Constantes.diretorioLancamentos + "/" + DataInicio.Year.ToString("d04");
                arquivo = diretorioLancamento + "/" + DataInicio.Month.ToString("d02") + ".json";

                if (File.Exists(arquivo))
                {
                    // Não retorna cartão de crédito e nem parceladas, somente lancamentos com flag fixa
                    List<Lancamento> lancamentosFixos = Lancamento.Lancamentos(DataInicio.Year.ToString("d04"), DataInicio.Month.ToString("d02")).FindAll(x=>x.fixa && x.parcelas==1).OrderBy(x=>x.dataLancamento).ToList();
                    foreach(Lancamento lancamento in lancamentosFixos)
                    {
                        lancamento.dataLancamento = DateTime.ParseExact(lancamento.dataLancamento.Day.ToString("d02") + "/" + _DataAtual.Month.ToString("d02") + "/" + _DataAtual.Year.ToString("d04"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        lancamento.quitado = false;
                        lancamento.gravaLancamento();
                    }
                        

                    MessageBox.Show("Foram carregados dados de despesas fixas para o mês corrente.", "Carregamento Automático", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void geraLancamentosParcelados()
        {

        }

        public static List<Lancamento> Lancamentos(String _Ano, String _Mes, Fonte _Fonte)
        {
            String diretorioLancamento = Util.Constantes.diretorioLancamentos;
            String arquivo = "";

            if (_Fonte.tipo == "Cartão de Crédito")
            {
                List<Lancamento> retorno = new List<Lancamento>();

                String DataParametro = _Fonte.diaFechamento + "/" + _Mes + "/" + _Ano;

                DateTime DataFim = DateTime.ParseExact(DataParametro, "dd/MM/yyyy", CultureInfo.InvariantCulture).AddMinutes(1439);
                DateTime DataInicio = DateTime.ParseExact(DataParametro,"dd/MM/yyyy",CultureInfo.InvariantCulture).AddMonths(-1);

                diretorioLancamento += @"\" + DataInicio.Year.ToString("d04");
                arquivo = diretorioLancamento + @"\" + DataInicio.Month.ToString("d02") + ".json";

                if(File.Exists(arquivo))
                    retorno.AddRange(JsonConvert.DeserializeObject<List<Lancamento>>(File.ReadAllText(arquivo)).FindAll(x => x.dataLancamento > DataInicio && x.fonte.nome == _Fonte.nome));

                diretorioLancamento = Util.Constantes.diretorioLancamentos + @"\" + DataFim.Year.ToString("d04");
                arquivo = diretorioLancamento + @"\" + DataFim.Month.ToString("d02") + ".json";

                if (File.Exists(arquivo))
                    retorno.AddRange(JsonConvert.DeserializeObject<List<Lancamento>>(File.ReadAllText(arquivo)).FindAll(x => x.dataLancamento <= DataFim && x.fonte.nome == _Fonte.nome));

                return retorno.OrderBy(x => x.dataLancamento).ToList();
            }

            diretorioLancamento = Util.Constantes.diretorioLancamentos + @"\" + _Ano;
            arquivo = diretorioLancamento + @"\" + _Mes + ".json";

            if (!File.Exists(arquivo))
                return null;

            List<Lancamento> lancamentos = JsonConvert.DeserializeObject<List<Lancamento>>(File.ReadAllText(arquivo));
            return lancamentos.FindAll(x=>x.fonte.nome == _Fonte.nome).OrderBy(x=>x.dataLancamento).ToList();
        }

        public static Boolean verificaExistenciaLancamentoCartaoCredito(Lancamento lancamentoCartaoCredito, Lancamento lancamentoDestino)
        {
            if (lancamentoCartaoCredito.fonte.nome != lancamentoDestino.fonte.nome)
                return false;

            if (lancamentoCartaoCredito.descricao != lancamentoDestino.descricao)
                return false;

            if (lancamentoCartaoCredito.dataLancamento != lancamentoDestino.dataLancamento)
                return false;

            if (lancamentoCartaoCredito.motivo != lancamentoDestino.motivo)
                return false;

            //MessageBox.Show("Data lançamento: " + lancamentoCartaoCredito.dataLancamento +"\n"+ lancamentoDestino.dataLancamento);
            //MessageBox.Show("Descricao: " + lancamentoCartaoCredito.descricao + "\n" + lancamentoDestino.descricao);
            //MessageBox.Show("Motivo: " + lancamentoCartaoCredito.motivo + "\n" + lancamentoDestino.motivo);
            //MessageBox.Show("Fonte: " + lancamentoCartaoCredito.fonte.nome + "\n" + lancamentoDestino.fonte.nome);

            return true;
        }

        public static void geraLancamentoFaturaCartaoCredito(String _Ano, String _Mes, Fonte _FonteDestino)
        {
            //Fontes que geram despesa de fatura
            List<Fonte> FontesCartaoDeCredito = Fonte.fontes(true).FindAll(x => x.fonteDestino.nome == _FonteDestino.nome);
            //List<Lancamento> LancamentosFonteDestino = Lancamento.Lancamentos(_Ano, _Mes, _FonteDestino);

            foreach (Fonte fonteCartaoDeCredito in FontesCartaoDeCredito)
            {
                Lancamento lancamentoCartaoDeCredito = new Lancamento()
                {
                    dataLancamento = DateTime.ParseExact(fonteCartaoDeCredito.diaFatura + "/" + _Mes + "/" + _Ano, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                    descricao = Util.Constantes.nomeDespesaAutomaticaCartaoCredito(fonteCartaoDeCredito.nome),
                    motivo = Util.Constantes.motivoDespesaAutomaticaCartaoCredito,
                    fonte = _FonteDestino,
                    fixa = false,
                    parcelaAtual = 1,
                    parcelas = 1,
                    quitado = DateTime.ParseExact(fonteCartaoDeCredito.diaFatura + "/" + _Mes + "/" + _Ano, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture) <= DateTime.Now,
                    responsavel = "João",
                    tipoDespesa = "D",
                    valor = 0
                };

                foreach (Lancamento lancamento in Lancamento.Lancamentos(_Ano, _Mes, fonteCartaoDeCredito))
                    lancamentoCartaoDeCredito.valor += lancamento.valor;

                lancamentoCartaoDeCredito.gravaLancamento(_Sobrescrever:true);
            }
        }


        public static List<Lancamento> Lancamentos(String _Ano, String _Mes)
        {
            String diretorioLancamento = Util.Constantes.diretorioLancamentos + @"\" + _Ano;
            String arquivo = diretorioLancamento + @"\" + _Mes + ".json";

            if (!File.Exists(arquivo))
                return null;

            return JsonConvert.DeserializeObject<List<Lancamento>>(File.ReadAllText(arquivo)).FindAll(x=>x.fonte.tipo != "Cartão de Crédito").OrderBy(x=>x.dataLancamento).ToList();
        }

        public static List<Lancamento> Lancamentos(String _Ano, String _Mes, Boolean gravaArquivo)
        {
            String diretorioLancamento = Util.Constantes.diretorioLancamentos + @"\" + _Ano;
            String arquivo = diretorioLancamento + @"\" + _Mes + ".json";

            if (!File.Exists(arquivo))
                return null;

            return JsonConvert.DeserializeObject<List<Lancamento>>(File.ReadAllText(arquivo)).OrderBy(x=>x.dataLancamento).ToList();
        }

        public void gravaLancamento(Boolean _Sobrescrever)
        {
            String ano = this.dataLancamento.Year.ToString("d04");
            String mes = this.dataLancamento.Month.ToString("d02");

            String diretorioLancamento = Util.Constantes.diretorioLancamentos + @"\" + ano;
            String arquivo = diretorioLancamento + @"\" + mes + ".json";

            //
            try
            {
                if (!Directory.Exists(diretorioLancamento))
                    Directory.CreateDirectory(diretorioLancamento);

                List<Lancamento> lancamentos = Lancamento.Lancamentos(ano, mes, true);
                if (lancamentos == null)
                    lancamentos = new List<Lancamento>();


                Boolean atualizado = false;

                for (int indiceLancamento = 0; indiceLancamento < (lancamentos.Count); indiceLancamento++)
                {
                    Lancamento lancamento = lancamentos[indiceLancamento];

                    //StringBuilder stringBuilder = new StringBuilder();
                    //stringBuilder.AppendLine("No objeto: " + this.dataLancamento + " - " + this.descricao + " - " + this.fonte.nome);
                    //stringBuilder.AppendLine("Na origem: " + lancamento.dataLancamento + " - " + lancamento.descricao + " - " + lancamento.fonte.nome);
                    //MessageBox.Show(stringBuilder.ToString());

                    if (Lancamento.verificaExistenciaLancamentoCartaoCredito(this, lancamento))
                    {
                        lancamentos[indiceLancamento] = this;
                        atualizado = true;
                        //MessageBox.Show("Atualizado");
                        break;
                    }
                }

                if (!atualizado)
                {
                    //MessageBox.Show("Inserido");
                    lancamentos.Add(this);
                }
                    

                File.WriteAllText(arquivo, JsonConvert.SerializeObject(lancamentos, Formatting.Indented));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void gravaLancamento()
        {
            String ano = this.dataLancamento.Year.ToString("d04");
            String mes = this.dataLancamento.Month.ToString("d02");

            String diretorioLancamento = Util.Constantes.diretorioLancamentos + @"\" + ano;
            String arquivo = diretorioLancamento + @"\" + mes + ".json";

            //
            try
            {
                if (!Directory.Exists(diretorioLancamento))
                    Directory.CreateDirectory(diretorioLancamento);

                List<Lancamento> lancamentos = Lancamento.Lancamentos(ano,mes,true);
                if (lancamentos == null)
                    lancamentos = new List<Lancamento>();

                lancamentos.Add(this);

                File.WriteAllText(arquivo,JsonConvert.SerializeObject(lancamentos,Formatting.Indented));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
