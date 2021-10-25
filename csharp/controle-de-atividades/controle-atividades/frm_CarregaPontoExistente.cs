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
    public partial class frm_CarregaPontoExistente : Form
    {

        public Util.Constantes.RestaurarPontoDia restaurarPontoDia;

        public frm_CarregaPontoExistente()
        {
            InitializeComponent();
            lblMensagem.Text = "Foi encontrado um registro de ponto para o dia atual.\n\nDeseja manter o ponto existente, ou recuperar alguns dos intervalos, ou sobrescrever o existente?";
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            restaurarPontoDia = Util.Constantes.RestaurarPontoDia.Entrada;
            this.Close();
        }

        private void btnAlmoco_Click(object sender, EventArgs e)
        {
            restaurarPontoDia = Util.Constantes.RestaurarPontoDia.Almoco;
            this.Close();
        }

        private void btnJanta_Click(object sender, EventArgs e)
        {
            restaurarPontoDia = Util.Constantes.RestaurarPontoDia.Janta;
            this.Close();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            restaurarPontoDia = Util.Constantes.RestaurarPontoDia.Saida;
            this.Close();
        }

        private void btnNovoPonto_Click(object sender, EventArgs e)
        {
            restaurarPontoDia = Util.Constantes.RestaurarPontoDia.NovoPonto;
            this.Close();
        }
    }
}
