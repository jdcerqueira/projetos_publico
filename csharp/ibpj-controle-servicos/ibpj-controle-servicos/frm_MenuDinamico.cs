using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ibpj_controle_servicos
{
    public partial class frm_MenuDinamico : Form
    {
        #region Variáveis globais da classe
        StringBuilder script_atualizacaoIda = new StringBuilder();
        StringBuilder script_insercaoIda = new StringBuilder();

        StringBuilder script_atualizacaoVolta = new StringBuilder();
        StringBuilder script_insercaoVolta = new StringBuilder();

        List<MenuDinamico> arquivoMenu = MenuDinamico.carregaArquivoJson();
        List<GrupoServico> arquivoServicos = GrupoServico.carregaArquivoJson();
        List<FiltroImplantacao> arquivoFiltros = FiltroImplantacao.carregaArquivoJson();
        List<Estilo> arquivoEstilos = Estilo.carregaArquivoJson();

        List<MenuDinamico.Familia> familias;
        List<GrupoServico.Grupo> grupos;
        List<Servico> servicos;

        MenuDinamico menuDinamicoTela;

        Util.ModoTela modoTela = Util.ModoTela.Inserir;

        private const String itemComboInicial = "[Todos os itens]";
        #endregion

        public frm_MenuDinamico()
        {
            InitializeComponent();

            //Combos de filtro
            carregaComboFamilia(0);
            carregaComboGrupoServico();
            carregaComboFiltroImplantacao();
            
            //Data Grids
            carregaDataGridMenuDinamico();

            //Combos do formulário
            carregaComboTipoPermissao();
            
            adicionaRegistroDataGrid();
            defineCoresDataGrid();
            dgvMenuDinamico.Refresh();

            // Inicializa os campos com valores padrão
            limpaCamposNaTela();

            //Modo tela
            defineModoTela();

            //Contador de itens
            atualizaLabelTotalItensMenu();
        }

        private void cmbFiltroFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecaoComboFiltroFamilia();
        }
        private void dgvMenuDinamico_SelectionChanged(object sender, EventArgs e)
        {
            selecaoLinhaDataGridMenuDinamico();
        }
        private void cmbFiltroGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecaoComboFiltroGrupoServico();
        }
        private void cmbFiltroServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecaoComboFiltroServico();
        }
        private void cmbFiltroFiltroImplantacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecaoComboFiltroFiltroImplantacao();
        }
        private void dgvMenuDinamico_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selecaoDuploCliqueDataGridMenuDinamico();
        }
        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecaoComboFormularioGrupoServico();
        }
        private void txtOrdem_Leave(object sender, EventArgs e)
        {
            validacaoFormularioAtributoOrdem();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cliqueBotaoCancelar();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cliqueBotaoSalvar();
        }
        private void btnFiltroMenu_Click(object sender, EventArgs e)
        {
            cliqueBotaolFiltroMenu();
        }
        private void btnTodosFiltro_Click(object sender, EventArgs e)
        {
            cliqueBotaoTodosFiltro();
        }
        private void btnPersistirArquivo_Click(object sender, EventArgs e)
        {
            cliqueBotaoPersistirArquivo();
        }
        private void txtCar_Leave(object sender, EventArgs e)
        {
            validacaoFormularioAtributoCar();

            
        }
        private void btnEstilo_Click(object sender, EventArgs e)
        {
            cliqueBotaoEstilo();
            
        }
    }
}
