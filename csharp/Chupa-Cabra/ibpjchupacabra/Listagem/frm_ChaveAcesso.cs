using ibpjchupacabradao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibpjchupacabra.Listagem
{
    public partial class frm_ChaveAcesso : Form
    {
        public frm_ChaveAcesso()
        {
            InitializeComponent();
            atualizaBaseChupaCabra();
            preparaDataGridChaveAcesso();
            populaDataGridChaveAcesso();
            lblTotalRegistros.Text = dgvChaveAcesso.Rows.Count.ToString();
        }

        private void atualizaBaseChupaCabra()
        {
            int ivc = 1;
            foreach (ChaveAcesso.ChaveAcessoUnit item in ChaveAcesso.carregaArquivoProducao("chaveJson.json"))
            {
                new ChaveAcesso.ChaveAcessoDAO("ChaveAcesso").Inserir(item, ivc);
                ivc++;
            } 
        }

        private void preparaDataGridChaveAcesso()
        {
            dgvChaveAcesso.ColumnCount = 2;
            dgvChaveAcesso.Columns[0].Name = "numeroChaveAcesso";
            dgvChaveAcesso.Columns[1].Name = "nomePessoa";
            dgvChaveAcesso.Columns["numeroChaveAcesso"].HeaderText = "Chave de Acesso";
            dgvChaveAcesso.Columns["nomePessoa"].HeaderText = "Nome";
            dgvChaveAcesso.Rows.Clear();
            dgvChaveAcesso.ReadOnly = true;
            dgvChaveAcesso.AllowUserToAddRows = false;
        }

        private void populaDataGridChaveAcesso()
        {
            ChaveAcesso.ChaveAcessoList chaveAcessoList = new ChaveAcesso.ChaveAcessoList();
            chaveAcessoList.chaveAcessos = new List<ChaveAcesso.ChaveAcessoUnit>();
            chaveAcessoList.chaveAcessos = new ChaveAcesso.ChaveAcessoDAO("ChaveAcesso").SelecionarTudo();

            dgvChaveAcesso.Rows.Clear();
            foreach (ChaveAcesso.ChaveAcessoUnit chaveAcesso in chaveAcessoList.chaveAcessos)
            {
                dgvChaveAcesso.Rows.Add(chaveAcesso.numeroChaveAcesso.ToString(), chaveAcesso.nomePessoa);
            }
        }
    }
}
