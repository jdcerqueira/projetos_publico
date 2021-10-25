using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static controle_atividades_negocio.Conexao;

namespace controle_atividades_negocio
{
    public class Ponto
    {

        //const String caminhoPastas = @"C:\João\05 - Planilhas e Controles\02 - Planilhas de Ponto Remoto\";
        const String caminhoPastas = @"";

        public Intervalo Expediente { get; set; }
        public Intervalo Almoco { get; set; }
        public Intervalo Janta { get; set; }
        public String SaldoHoras { get; set; }
        public String HorasExtras { get; set; }
        public List<Atividades> Atividades { get; set; }

        public void criaArquivo(Ponto ponto, String dataPonto)
        {
            //Criar o diretorio do arquivo
            String ano = DateTime.ParseExact(dataPonto, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).Year.ToString("d4");
            String mes = DateTime.ParseExact(dataPonto, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).Month.ToString("d2");
            String dia = DateTime.ParseExact(dataPonto, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture).Day.ToString("d2");

            String diretorio = caminhoPastas + ano + @"\" + mes;
            String arquivo = diretorio + @"\" + dia + ".json";
            String jsonConteudo = JsonConvert.SerializeObject(ponto, Formatting.Indented);
            
            Diretorio criaDiretorio = new Conexao.Diretorio(diretorio,Util.Constantes.ModoDiretorio.Criacao);
            if (criaDiretorio.status)
            {
                MessageBox.Show(criaDiretorio.mensagem, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Arquivo criaArquivo = new Conexao.Arquivo(arquivo, jsonConteudo);
                if (criaArquivo.status)
                {
                    MessageBox.Show(criaArquivo.mensagem, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Util.Configuracoes.atualizaArquivoConf(ano, mes, dia);
                }
                else
                    MessageBox.Show(criaArquivo.mensagem, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                MessageBox.Show(criaDiretorio.mensagem, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public List<Ponto> listaPontosMes(String _ano, String _mes)
        {
            List<Ponto> pontos = new List<Ponto>();
            String diretorio = caminhoPastas + _ano + @"\" + _mes;
            foreach(String arquivo in new Conexao.Diretorio(diretorio, Util.Constantes.ModoDiretorio.ListaArquivos).arquivos)
            {
                pontos.Add(JsonConvert.DeserializeObject<Ponto>(File.ReadAllText(arquivo)));
            }

            return pontos;
        }

        public Ponto arquivoPonto(String caminhoArquivo)
        {
            return JsonConvert.DeserializeObject<Ponto>(Conexao.Arquivo.leArquivo(caminhoPastas + caminhoArquivo));
        }
    }
}
