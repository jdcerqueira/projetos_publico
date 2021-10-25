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
    public partial class frm_RelogioCongelaTela : Form
    {
        int tempoEsperaParametro;
        Timer intervalo = new Timer();
        public frm_RelogioCongelaTela(int _TempoEsperaEmSegundos)
        {
            tempoEsperaParametro = _TempoEsperaEmSegundos;

            InitializeComponent();
            lblRelogio.Visible = false;

            intervalo.Interval = 1000; // a cada 1 segundo
            intervalo.Enabled = true;
            intervalo.Tick += new EventHandler(atualizaRelogio);
            calculaTempo();
        }

        private void calculaTempo()
        {
            this.Cursor = Cursors.WaitCursor;

            lblRelogio.Visible = true;
            if (tempoEsperaParametro <= 10)
            {
                lblRelogio.ForeColor = Color.Red;
            }

            DateTime tempoEspera = DateTime.Now.Date;
            lblRelogio.Text = tempoEspera.AddSeconds(tempoEsperaParametro).TimeOfDay.ToString();

            if (tempoEsperaParametro > 0)
                tempoEsperaParametro -= 1;
            else
            {
                intervalo.Enabled = false;
                MessageBox.Show("Tempo esgotado.\nO computador está liberado para uso.", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Close();
            }
        }

        private void atualizaRelogio(object sender, EventArgs e)
        {
            calculaTempo();
        }
    }
}
