using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financeiro
{
    public partial class frm_Fontes : Form
    {

        public frm_Fontes(String _nomeFonte)
        {
            InitializeComponent();
            txtNome.Text = _nomeFonte;

            cmbTipo.SelectedIndex = 3;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            txtDiaFechamento.Visible = false;
            btnCalendarioFechamento.Visible = false;
            lblFechamento.Visible = false;
            lblFonteDestino.Visible = false;
            cmbFonteDestino.Visible = false;
            lblDiaFatura.Visible = false;
            txtDiaFatura.Visible = false;
            btnCalendarioFatura.Visible = false;

            cmbFonteDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            if(Fonte.fontes() != null)
            {
                foreach (Fonte fonteDestino in Fonte.fontes())
                    cmbFonteDestino.Items.Add(fonteDestino);
            }

            txtDiaFechamento.Text = "00";
            txtDiaFatura.Text = "00";
        }

        private void btnCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime DataMinima = DateTime.Parse("01/" + DateTime.Now.Month.ToString("d02") + "/" + DateTime.Now.Year.ToString("d04"));
            DateTime DataMaxima = DateTime.Parse(DateTime.DaysInMonth(Convert.ToInt32(DataMinima.Year), Convert.ToInt32(DataMinima.Month)) + "/" + DateTime.Now.Month.ToString("d02") + " / " + DateTime.Now.Year.ToString("d04"));

            int X = this.Location.X + btnCalendarioFechamento.Location.X + e.X;
            int Y = this.Location.Y + btnCalendarioFechamento.Location.Y + e.Y;
            frm_Calendario _Calendario = new frm_Calendario(DataMinima, DateTime.Now.Date,X,Y,DataMaxima);
            _Calendario.ShowDialog();

            if (_Calendario.DialogResult == DialogResult.OK)
                txtDiaFechamento.Text = _Calendario.dtRetorno.Day.ToString("d02");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Fonte fonte = new Fonte()
                {
                    nome = txtNome.Text,
                    tipo = cmbTipo.Text,
                    diaFechamento = txtDiaFechamento.Text,
                    diaFatura = txtDiaFatura.Text,
                    fonteDestino = cmbFonteDestino.Text == "" ? null : Fonte.getFonteNome(cmbFonteDestino.Text)
                };
                fonte.ValidaClasse();
                Fonte.gravaFonte(fonte);

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipo.Text == "Cartão de Crédito")
            {
                txtDiaFechamento.Visible = true;
                btnCalendarioFechamento.Visible = true;
                lblFechamento.Visible = true;
                lblFonteDestino.Visible = true;
                cmbFonteDestino.Visible = true;
                lblDiaFatura.Visible = true;
                txtDiaFatura.Visible = true;
                btnCalendarioFatura.Visible = true;
            }
            else
            {
                txtDiaFechamento.Visible = false;
                btnCalendarioFechamento.Visible = false;
                lblFechamento.Visible = false;
                txtDiaFechamento.Text = "00";

                lblFonteDestino.Visible = false;
                cmbFonteDestino.Visible = false;
                lblDiaFatura.Visible = false;
                txtDiaFatura.Visible = false;
                btnCalendarioFatura.Visible = false;
                txtDiaFatura.Text = "00";
            }
        }

        private void btnCalendarioFatura_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime DataMinima = DateTime.Parse("01/" + DateTime.Now.Month.ToString("d02") + "/" + DateTime.Now.Year.ToString("d04"));
            DateTime DataMaxima = DateTime.Parse(DateTime.DaysInMonth(Convert.ToInt32(DataMinima.Year), Convert.ToInt32(DataMinima.Month)) + "/" + DateTime.Now.Month.ToString("d02") + " / " + DateTime.Now.Year.ToString("d04"));

            int X = this.Location.X + btnCalendarioFatura.Location.X + e.X;
            int Y = this.Location.Y + btnCalendarioFatura.Location.Y + e.Y;
            frm_Calendario _Calendario = new frm_Calendario(DataMinima, DateTime.Now.Date, X, Y, DataMaxima);
            _Calendario.ShowDialog();

            if (_Calendario.DialogResult == DialogResult.OK)
                txtDiaFatura.Text = _Calendario.dtRetorno.Day.ToString("d02");
        }
    }
}
