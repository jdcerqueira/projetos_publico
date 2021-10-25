using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controle_atividades_negocio;

namespace controle_atividades
{
    public partial class frm_Atividades : Form
    {

        public Atividades Atividades;
        public frm_Atividades(Util.Constantes.ModoTela modoTela, Atividades _Atividades)
        {
            InitializeComponent();

            txtInicio.ReadOnly = true;
            txtFim.ReadOnly = true;
            txtPrevisao.ReadOnly = true;

            if (modoTela == Util.Constantes.ModoTela.Leitura)
            {
                txtNome.Text = _Atividades.Nome;
                txtDescricao.Text = _Atividades.Descricao;
                txtInicio.Text = _Atividades.Atuacao.inicio;
                txtFim.Text = _Atividades.Atuacao.fim;
                txtPrevisao.Text = _Atividades.previsao.ToString();
                
                btnSalvar.Enabled = true;
                btnCalendarioFim.Enabled = true;
            }
            else if(modoTela == Util.Constantes.ModoTela.Escrita)
            {
                DateTime dtHrAgora = DateTime.Now;
                DateTime dtagora = dtHrAgora.Date;

                txtInicio.Text = dtHrAgora.ToString();
                btnCalendarioFim.Enabled = false;
            }
        }

        private void cancelaTela()
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                cancelaTela();
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                cancelaTela();
        }

        private void txtInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                cancelaTela();
        }

        private void txtFim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                cancelaTela();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String mensagemErro = "";
            DateTime? previsao;

            if (txtPrevisao.Text == "")
                previsao = null;
            else
                previsao = Util.StringToDatetime(txtPrevisao.Text);

            if (txtNome.Text == "")
                mensagemErro += "\nÉ obrigatório informar o nome da atividade.";
            if (txtDescricao.Text == "")
                mensagemErro += "\nÉ obrigatório informar a descrição da atividade.";
            if (txtPrevisao.Text != "")
                if (txtInicio.Text != "" && Util.StringToDatetime(txtPrevisao.Text) <= Util.StringToDatetime(txtInicio.Text))
                    mensagemErro += "\nA previsão da atividade deve ser maior que a data de início da atividade.";
            if (txtFim.Text != "")
                if(txtInicio.Text == "")
                    mensagemErro += "\nPara realizar a finalização de uma atividade, deve-se informar a data de ínicio.";
                else if (Util.StringToDatetime(txtFim.Text) < Util.StringToDatetime(txtInicio.Text))
                    mensagemErro += "\nO fim da atividade deve ser maior que a data de início da atividade.";

            if (mensagemErro == "")
            {
                Atividades = new Atividades()
                {
                    Nome = txtNome.Text,
                    Descricao = txtDescricao.Text,
                    Atuacao = new Intervalo() { inicio = txtInicio.Text, fim = txtFim.Text },
                    status = (txtFim.Text != ""),
                    previsao = previsao
                };
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show(mensagemErro, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelaTela();
        }

        private void btnCalendarioInicio_MouseClick(object sender, MouseEventArgs e)
        {
            int X = this.Location.X + btnCalendarioInicio.Location.X + e.X;
            int Y = this.Location.Y + btnCalendarioInicio.Location.Y + e.Y;

            frm_Calendario _Calendario = new frm_Calendario(DateTime.MinValue, DateTime.Now.Date, X, Y);
            _Calendario.ShowDialog();

            if(_Calendario.DialogResult == DialogResult.OK)
                txtInicio.Text = _Calendario.dtRetorno.ToString();
            else
                txtInicio.Text = "";
        }

        private void btnCalendarioPrevisao_MouseClick(object sender, MouseEventArgs e)
        {
            int X = this.Location.X + btnCalendarioPrevisao.Location.X + e.X;
            int Y = this.Location.Y + btnCalendarioPrevisao.Location.Y + e.Y;

            DateTime inicio = txtInicio.Text == "" ? DateTime.Now : Util.StringToDatetime(txtInicio.Text).AddMinutes(Util.Constantes.minutosDiaCheio);

            frm_Calendario _Calendario = new frm_Calendario
            (
                inicio,
                inicio, 
                X, 
                Y
            );
            _Calendario.ShowDialog();

            if (_Calendario.DialogResult == DialogResult.OK)
                txtPrevisao.Text = _Calendario.dtRetorno.AddMinutes(Util.Constantes.minutosDiaCheio).ToString();
            else
                txtPrevisao.Text = "";
        }

        private void btnCalendarioFim_MouseClick(object sender, MouseEventArgs e)
        {
            int X = this.Location.X + btnCalendarioFim.Location.X + e.X;
            int Y = this.Location.Y + btnCalendarioFim.Location.Y + e.Y;

            DateTime inicio = txtInicio.Text == "" ? DateTime.Now : Util.StringToDatetime(txtInicio.Text).AddMinutes(Util.Constantes.minutosDiaCheio);

            frm_Calendario _Calendario = new frm_Calendario(inicio, DateTime.Now.Date, X, Y);
            _Calendario.ShowDialog();

            if (_Calendario.DialogResult == DialogResult.OK)
            {
                txtFim.Text = _Calendario.dtRetorno.ToString();
                if (_Calendario.dtRetorno.Date == DateTime.Now.Date)
                    txtFim.Text = _Calendario.dtRetorno.AddMinutes(DateTime.Now.TimeOfDay.TotalMinutes).ToString();
            }
            else
                txtFim.Text = "";
        }
    }
}
