using controle_atividades_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_atividades
{
    public partial class frm_Relogio : UserControl
    {
        Timer timer = new Timer();
        DateTime DataAberturaTela = DateTime.Now;
        String HoraSaida = "";

        public frm_Relogio()
        {
            InitializeComponent();
            lblDataHora.Text = DataAberturaTela.ToString();

            timer.Enabled = true;
            timer.Interval = 1000; // a cada 1 segundo
            timer.Tick += new System.EventHandler(atualizaRelogio);

        }

        public void atualizaRelogio(String DataHoraInicio = "", String HoraExpediente = "")
        {
            if (Util.StringToDatetime(HoraExpediente).TimeOfDay.ToString() == "00:00:00")
                HoraSaida = "";
            else
                HoraSaida = Util.StringToDatetime(DataHoraInicio).Add(Util.StringToDatetime(HoraExpediente).TimeOfDay).TimeOfDay.ToString();

            //MessageBox.Show("DataHoraInicio: " + DataHoraInicio + "\nHoraExpediente: " + HoraExpediente);
        }

        private void atualizaRelogio(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString() + (HoraSaida == "" ? "" : " - (" + HoraSaida + ")");
        }

        public String DataHora()
        {
            return lblDataHora.Text;
        }

        public String DataDiaAberturaTela()
        {
            return DataAberturaTela.Date.ToString("dd/MM/yyyy");
        }
    }
}
