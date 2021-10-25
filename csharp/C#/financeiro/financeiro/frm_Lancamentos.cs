using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financeiro
{
    public partial class frm_Lancamentos : Form
    {
        private DateTime dtHrAtual = DateTime.Now;
        private List<Fonte> Fontes;
        private List<Lancamento> Lancamentos;
        private Lancamento lancamento;

        private const int dgvIndex_dataLancamento = 0;
        private const int dgvIndex_fonte = 1;
        private const int dgvIndex_valor = 2;
        private const int dgvIndex_descricao = 3;
        private const int dgvIndex_responsavel = 4;
        private const int dgvIndex_motivo = 5;
        private const int dgvIndex_fixa = 6;
        private const int dgvIndex_quitado = 7;
        private const int dgvIndex_tipoDespesa = 8;
        private const int dgvIndex_parcelas = 9;
        private const int dgvIndex_parcelaAtual = 10;
        private Util.Constantes.ModoTela modoTela = Util.Constantes.ModoTela.Insercao;

        public frm_Lancamentos()
        {
            
            InitializeComponent();

            // Inicializacao de valores
            txtDataLancamento.Text = dtHrAtual.Date.ToString("dd/MM/yyyy");

            valoresDefault();
            carregaComboFontes();

            DateTime DataSelecionada = DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            atualizaLancamentos(DataSelecionada.Year.ToString("d04"), DataSelecionada.Month.ToString("d02"), Fonte.getFonteNome(cmbFonte.Text));
            regrasDeControles();
            regraTela();
        }

        public void regraTela()
        {
            switch (modoTela)
            {
                case Util.Constantes.ModoTela.Insercao:
                    txtDataLancamento.Enabled = true;
                    txtDescricao.Enabled = true;
                    txtMotivo.Enabled = true;
                    txtResponsavel.Enabled = true;
                    cmbFonte.Enabled = true;
                    btnCalendario.Enabled = true;
                    cmbParcelas.Enabled = true;
                    grpTipoLancamento.Enabled = true;
                    chkFixa.Enabled = true;
                    break;
                case Util.Constantes.ModoTela.Alteracao:
                    txtDataLancamento.Enabled = false;
                    txtDescricao.Enabled = false;
                    txtMotivo.Enabled = false;
                    txtResponsavel.Enabled = false;
                    cmbFonte.Enabled = false;
                    btnCalendario.Enabled = false;
                    cmbParcelas.Enabled = false;
                    grpTipoLancamento.Enabled = false;
                    chkFixa.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            int X = this.Location.X + btnCalendario.Location.X + e.X;
            int Y = this.Location.Y + btnCalendario.Location.Y + e.Y;
            frm_Calendario _Calendario = new frm_Calendario(DateTime.MinValue,DateTime.Now,X,Y);
            _Calendario.ShowDialog();
            if (_Calendario.DialogResult == DialogResult.OK)
            {
                txtDataLancamento.Text = _Calendario.dtRetorno.ToString("dd/MM/yyyy");
                Lancamento.geraLancamentosFixosMesAnterior(_Calendario.dtRetorno.Year.ToString("d04"), _Calendario.dtRetorno.Month.ToString("d02"), _Calendario.dtRetorno);
            }
                

            valoresDefault();
            DateTime DataSelecionada = DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            atualizaLancamentos(DataSelecionada.Year.ToString("d04"), DataSelecionada.Month.ToString("d02"), Fonte.getFonteNome(cmbFonte.Text));
            regrasDeControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            valoresDefault();
            modoTela = Util.Constantes.ModoTela.Insercao;
            regraTela();
            txtDescricao.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (modoTela == Util.Constantes.ModoTela.Insercao)
                salvarRegistro();
            else if (modoTela == Util.Constantes.ModoTela.Alteracao)
                salvarRegistro(_Alterar: true, lancamento);

            regraTela();
                
        }        

        private void cmbFonte_Leave(object sender, EventArgs e)
        {
            if(modoTela == Util.Constantes.ModoTela.Insercao)
            {
                // Verifica se já existe essa fonte ou abre a tela para cadastro de fontes
                if ((Fontes == null || !Fontes.Exists(x => x.nome == cmbFonte.Text) && cmbFonte.Text != ""))
                {
                    frm_Fontes _Fontes = new frm_Fontes(cmbFonte.Text);
                    _Fontes.ShowDialog();
                    if (_Fontes.DialogResult == DialogResult.OK)
                        carregaComboFontes();
                }

                if (Fonte.getFonteNome(cmbFonte.Text) != null)
                    Lancamento.geraLancamentoFaturaCartaoCredito
                    (
                        DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Year.ToString("d04"),
                        DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Month.ToString("d02"),
                        Fonte.getFonteNome(cmbFonte.Text)
                    );

                atualizaLancamentos
                (
                    DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Year.ToString("d04"),
                    DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Month.ToString("d02"),
                    Fonte.getFonteNome(cmbFonte.Text)
                );

                preparaViewLancamentos();
            }
        }


        private void cmbFonte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(modoTela == Util.Constantes.ModoTela.Insercao)
            {
                if (Fonte.getFonteNome(cmbFonte.Text) != null)
                    Lancamento.geraLancamentoFaturaCartaoCredito
                    (
                        DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Year.ToString("d04"),
                        DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Month.ToString("d02"),
                        Fonte.getFonteNome(cmbFonte.Text)
                    );

                atualizaLancamentos
                (
                    DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Year.ToString("d04"),
                    DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).Month.ToString("d02"),
                    Fonte.getFonteNome(cmbFonte.Text)
                );
                preparaViewLancamentos();
            }
        }

        private void dgvLancamentos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modoTela = Util.Constantes.ModoTela.Alteracao;

            int row = dgvLancamentos.CurrentRow.Index;
            lancamento = new Lancamento()
            {
                dataLancamento = DateTime.ParseExact(dgvLancamentos.Rows[row].Cells[dgvIndex_dataLancamento].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                descricao = dgvLancamentos.Rows[row].Cells[dgvIndex_descricao].Value.ToString(),
                motivo = dgvLancamentos.Rows[row].Cells[dgvIndex_motivo].Value.ToString(),
                responsavel = dgvLancamentos.Rows[row].Cells[dgvIndex_responsavel].Value.ToString(),
                quitado = dgvLancamentos.Rows[row].Cells[dgvIndex_quitado].Value.ToString().ToLower() == "true",
                fonte = Fonte.getFonteNome(dgvLancamentos.Rows[row].Cells[dgvIndex_fonte].Value.ToString()),
                parcelas = Convert.ToInt32(dgvLancamentos.Rows[row].Cells[dgvIndex_parcelas].Value.ToString()),
                parcelaAtual = Convert.ToInt32(dgvLancamentos.Rows[row].Cells[dgvIndex_parcelaAtual].Value.ToString()),
                valor = retornaValor(dgvLancamentos.Rows[row].Cells[dgvIndex_valor].Value.ToString()),
                fixa = dgvLancamentos.Rows[row].Cells[dgvIndex_fixa].Value.ToString().ToLower() == "true",
                tipoDespesa = dgvLancamentos.Rows[row].Cells[dgvIndex_tipoDespesa].Value.ToString()
            };

            txtDataLancamento.Text = lancamento.dataLancamento.ToString("dd/MM/yyyy");
            txtDescricao.Text = lancamento.descricao;
            txtMotivo.Text = lancamento.motivo;
            txtResponsavel.Text = lancamento.responsavel;
            chkQuitado.Checked = lancamento.quitado;
            cmbFonte.Text = lancamento.fonte.nome;
            cmbParcelas.Text = lancamento.parcelas.ToString();
            //mskValor.Mask = "$9,999,999.00";

            int acrescentaZero = (10 - lancamento.valor.ToString().Length);

            mskValor.Text = new String(' ',acrescentaZero) + lancamento.valor.ToString(); //String.Format("{0:C2}", lancamento.valor.ToString());
            chkFixa.Checked = lancamento.fixa;
            rdbDespesa.Checked = lancamento.tipoDespesa == "D";
            rdbReceita.Checked = lancamento.tipoDespesa == "R";

            regraTela();
        }
    }
}
