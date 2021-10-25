using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibpj_controle_servicos
{
    public partial class frm_Estilo : Form
    {
        public List<Estilo> arquivoEstilos = Estilo.carregaArquivoJson();

        public frm_Estilo()
        {
            InitializeComponent();
            txtCodigo.Text = defineProximoIdEstilo().ToString();
        }

        private int defineProximoIdEstilo()
        {
            return arquivoEstilos.OrderByDescending(x => x.codigo).ToList()[0].codigo + 1;
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            arquivoEstilos.Add(new Estilo(Convert.ToInt32(txtCodigo.Text), txtClasse.Text, txtDescricao.Text));
            arquivoEstilos = arquivoEstilos.OrderBy(x=>x.codigo).ToList();
            this.Close();
        }
    }
}
