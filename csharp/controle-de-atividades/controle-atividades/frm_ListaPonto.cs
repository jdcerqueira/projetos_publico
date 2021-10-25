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
    public partial class frm_ListaPonto : Form
    {
        String ano;
        String mes;
        DateTime dtHrAtual = DateTime.Now;
        List<Ponto> listaPontos = new List<Ponto>();

        public frm_ListaPonto()
        {
            InitializeComponent();
            ano = dtHrAtual.Year.ToString("d4");
            mes = dtHrAtual.Month.ToString("d2");
            listaPontos = new Ponto().listaPontosMes(ano, mes);

            preparaDataGridPontos();
            aplicaMes(mes, ano);
            atualizaGridPontos(dtHrAtual.Date);

            this.Text += " - " + Util.Constantes.versaoProduto;
            txtDataSelecionada.Text = "01/" + mes + "/" + ano;
        }
       
        

        private void btnCalendario_MouseClick(object sender, MouseEventArgs e)
        {
            int x = this.Location.X + btnCalendario.Location.X + e.X;
            int y = this.Location.Y + btnCalendario.Location.Y + e.Y;

            frm_Calendario _Calendario = new frm_Calendario
            (
                DateTime.MinValue,
                DateTime.Now,
                x,
                y
            );

            _Calendario.ShowDialog();
            if(_Calendario.DialogResult == DialogResult.OK)
            {
                if (ano != _Calendario.dtRetorno.Year.ToString("d4") || mes != _Calendario.dtRetorno.Month.ToString("d2"))
                {
                    ano = _Calendario.dtRetorno.Year.ToString("d4");
                    mes = _Calendario.dtRetorno.Month.ToString("d2");
                    listaPontos = new Ponto().listaPontosMes(ano, mes);
                }

                aplicaMes(mes, ano);
                atualizaGridPontos(_Calendario.dtRetorno);
                posicionaDia(_Calendario.dtRetorno);

                preparaDataGridAtividades();
                preencheAtividades(_Calendario.dtRetorno.Date.ToString());

                txtDataSelecionada.Text = _Calendario.dtRetorno.ToString("dd/MM/yyyy");
            }
        }

        private void dgvPontos_SelectionChanged(object sender, EventArgs e)
        {
            String dataSelecionada = dgvPontos.Rows[dgvPontos.CurrentRow.Index].Cells["Dia"].Value.ToString() 
                + "/" + mes 
                + "/" + ano
                + " 00:00:00";
            preparaDataGridAtividades();
            preencheAtividades(dataSelecionada);
            txtDataSelecionada.Text = Util.StringToDatetime(dataSelecionada).ToString("dd/MM/yyyy");
        }
    }
}
