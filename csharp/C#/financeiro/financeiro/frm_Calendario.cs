using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financeiro
{
    public partial class frm_Calendario : Form
    {
        public DateTime dtRetorno;
        public frm_Calendario(DateTime DataInicial, DateTime DataSelecionada, int x, int y, DateTime? DataMaxima = null)
        {
            InitializeComponent();

            calendar.MinDate = DataInicial.Date;

            if (DataMaxima != null)
                calendar.MaxDate = (DateTime) DataMaxima;

            calendar.SelectionStart = DataSelecionada.Date;
            calendar.MaxSelectionCount = 1;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            dtRetorno = calendar.SelectionStart.Date;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void calendar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
