
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ibpj_controle_servicos
{
    partial class frm_MenuDinamico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MenuDinamico));
            this.cmbFiltroFamilia = new System.Windows.Forms.ComboBox();
            this.dgvMenuDinamico = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEstilo = new System.Windows.Forms.Button();
            this.txtLiderSolicitante = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPersistirArquivo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbEstilo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrdem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtScriptVolta = new System.Windows.Forms.TextBox();
            this.txtScriptIda = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpOperacao = new System.Windows.Forms.GroupBox();
            this.rdbAprovacao = new System.Windows.Forms.RadioButton();
            this.rdbEntradaDeDados = new System.Windows.Forms.RadioButton();
            this.rdbConsulta = new System.Windows.Forms.RadioButton();
            this.cmbServico = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoPermissao = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.chkContratos = new System.Windows.Forms.CheckedListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkFiltro = new System.Windows.Forms.CheckBox();
            this.btnTodosFiltro = new System.Windows.Forms.Button();
            this.btnVinculadosFiltro = new System.Windows.Forms.Button();
            this.dgvFiltroImplantacao = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCarPalavraChave = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCarDescricao = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAmbiente = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkTagCampanha = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFiltroGrupo = new System.Windows.Forms.ComboBox();
            this.lblFiltroServico = new System.Windows.Forms.Label();
            this.cmbFiltroServico = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFiltroFiltroImplantacao = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalItensListados = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.dgvScriptGeral = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuDinamico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpOperacao.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroImplantacao)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScriptGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltroFamilia
            // 
            this.cmbFiltroFamilia.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFiltroFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroFamilia.FormattingEnabled = true;
            this.cmbFiltroFamilia.Location = new System.Drawing.Point(59, 12);
            this.cmbFiltroFamilia.Name = "cmbFiltroFamilia";
            this.cmbFiltroFamilia.Size = new System.Drawing.Size(433, 21);
            this.cmbFiltroFamilia.TabIndex = 0;
            this.cmbFiltroFamilia.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroFamilia_SelectedIndexChanged);
            // 
            // dgvMenuDinamico
            // 
            this.dgvMenuDinamico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuDinamico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuDinamico.Location = new System.Drawing.Point(3, 3);
            this.dgvMenuDinamico.Name = "dgvMenuDinamico";
            this.dgvMenuDinamico.Size = new System.Drawing.Size(875, 239);
            this.dgvMenuDinamico.TabIndex = 1;
            this.dgvMenuDinamico.SelectionChanged += new System.EventHandler(this.dgvMenuDinamico_SelectionChanged);
            this.dgvMenuDinamico.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMenuDinamico_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Família";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEstilo);
            this.groupBox1.Controls.Add(this.txtLiderSolicitante);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbColuna);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnPersistirArquivo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.cmbEstilo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtUrl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOrdem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNivel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnEstilo
            // 
            this.btnEstilo.Location = new System.Drawing.Point(690, 11);
            this.btnEstilo.Name = "btnEstilo";
            this.btnEstilo.Size = new System.Drawing.Size(35, 23);
            this.btnEstilo.TabIndex = 21;
            this.btnEstilo.Text = "...";
            this.btnEstilo.UseVisualStyleBackColor = true;
            this.btnEstilo.Click += new System.EventHandler(this.btnEstilo_Click);
            // 
            // txtLiderSolicitante
            // 
            this.txtLiderSolicitante.Location = new System.Drawing.Point(509, 65);
            this.txtLiderSolicitante.Name = "txtLiderSolicitante";
            this.txtLiderSolicitante.Size = new System.Drawing.Size(216, 20);
            this.txtLiderSolicitante.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(421, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Líder solicitante";
            // 
            // cmbColuna
            // 
            this.cmbColuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbColuna.Location = new System.Drawing.Point(375, 65);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(40, 21);
            this.cmbColuna.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(329, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Coluna";
            // 
            // btnPersistirArquivo
            // 
            this.btnPersistirArquivo.Location = new System.Drawing.Point(731, 63);
            this.btnPersistirArquivo.Name = "btnPersistirArquivo";
            this.btnPersistirArquivo.Size = new System.Drawing.Size(128, 23);
            this.btnPersistirArquivo.TabIndex = 16;
            this.btnPersistirArquivo.Text = "Atualizar Arquivos";
            this.btnPersistirArquivo.UseVisualStyleBackColor = true;
            this.btnPersistirArquivo.Click += new System.EventHandler(this.btnPersistirArquivo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(731, 37);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(731, 11);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(128, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbEstilo
            // 
            this.cmbEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstilo.FormattingEnabled = true;
            this.cmbEstilo.Location = new System.Drawing.Point(508, 13);
            this.cmbEstilo.Name = "cmbEstilo";
            this.cmbEstilo.Size = new System.Drawing.Size(176, 21);
            this.cmbEstilo.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(470, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Estilo";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(375, 39);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(350, 20);
            this.txtUrl.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "URL";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(69, 65);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(252, 20);
            this.txtDescricao.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Alternativo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(252, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Texto";
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(221, 13);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(100, 20);
            this.txtOrdem.TabIndex = 5;
            this.txtOrdem.Leave += new System.EventHandler(this.txtOrdem_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sequencial";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(375, 13);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(89, 20);
            this.txtNivel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(69, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(83, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(15, 238);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 271);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvMenuDinamico);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Itens";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtScriptVolta);
            this.tabPage2.Controls.Add(this.txtScriptIda);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scripts de Atualização";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtScriptVolta
            // 
            this.txtScriptVolta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtScriptVolta.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtScriptVolta.Location = new System.Drawing.Point(442, 3);
            this.txtScriptVolta.Multiline = true;
            this.txtScriptVolta.Name = "txtScriptVolta";
            this.txtScriptVolta.ReadOnly = true;
            this.txtScriptVolta.Size = new System.Drawing.Size(435, 239);
            this.txtScriptVolta.TabIndex = 1;
            // 
            // txtScriptIda
            // 
            this.txtScriptIda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtScriptIda.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtScriptIda.Location = new System.Drawing.Point(3, 3);
            this.txtScriptIda.Multiline = true;
            this.txtScriptIda.Name = "txtScriptIda";
            this.txtScriptIda.ReadOnly = true;
            this.txtScriptIda.Size = new System.Drawing.Size(439, 239);
            this.txtScriptIda.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(15, 93);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(885, 139);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 113);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Detalhes do Item";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(877, 113);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Permissão";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grpOperacao);
            this.groupBox2.Controls.Add(this.cmbServico);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbGrupo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbTipoPermissao);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(865, 101);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // grpOperacao
            // 
            this.grpOperacao.Controls.Add(this.rdbAprovacao);
            this.grpOperacao.Controls.Add(this.rdbEntradaDeDados);
            this.grpOperacao.Controls.Add(this.rdbConsulta);
            this.grpOperacao.Location = new System.Drawing.Point(574, 40);
            this.grpOperacao.Name = "grpOperacao";
            this.grpOperacao.Size = new System.Drawing.Size(285, 48);
            this.grpOperacao.TabIndex = 17;
            this.grpOperacao.TabStop = false;
            this.grpOperacao.Text = "Operação";
            // 
            // rdbAprovacao
            // 
            this.rdbAprovacao.AutoSize = true;
            this.rdbAprovacao.Location = new System.Drawing.Point(195, 25);
            this.rdbAprovacao.Name = "rdbAprovacao";
            this.rdbAprovacao.Size = new System.Drawing.Size(77, 17);
            this.rdbAprovacao.TabIndex = 20;
            this.rdbAprovacao.TabStop = true;
            this.rdbAprovacao.Text = "Aprovação";
            this.rdbAprovacao.UseVisualStyleBackColor = true;
            // 
            // rdbEntradaDeDados
            // 
            this.rdbEntradaDeDados.AutoSize = true;
            this.rdbEntradaDeDados.Location = new System.Drawing.Point(78, 25);
            this.rdbEntradaDeDados.Name = "rdbEntradaDeDados";
            this.rdbEntradaDeDados.Size = new System.Drawing.Size(111, 17);
            this.rdbEntradaDeDados.TabIndex = 19;
            this.rdbEntradaDeDados.TabStop = true;
            this.rdbEntradaDeDados.Text = "Entrada de Dados";
            this.rdbEntradaDeDados.UseVisualStyleBackColor = true;
            // 
            // rdbConsulta
            // 
            this.rdbConsulta.AutoSize = true;
            this.rdbConsulta.Location = new System.Drawing.Point(6, 25);
            this.rdbConsulta.Name = "rdbConsulta";
            this.rdbConsulta.Size = new System.Drawing.Size(66, 17);
            this.rdbConsulta.TabIndex = 18;
            this.rdbConsulta.TabStop = true;
            this.rdbConsulta.Text = "Consulta";
            this.rdbConsulta.UseVisualStyleBackColor = true;
            // 
            // cmbServico
            // 
            this.cmbServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServico.FormattingEnabled = true;
            this.cmbServico.Location = new System.Drawing.Point(106, 67);
            this.cmbServico.Name = "cmbServico";
            this.cmbServico.Size = new System.Drawing.Size(462, 21);
            this.cmbServico.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Serviço";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(106, 40);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(462, 21);
            this.cmbGrupo.TabIndex = 14;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Grupo";
            // 
            // cmbTipoPermissao
            // 
            this.cmbTipoPermissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPermissao.FormattingEnabled = true;
            this.cmbTipoPermissao.Location = new System.Drawing.Point(106, 13);
            this.cmbTipoPermissao.Name = "cmbTipoPermissao";
            this.cmbTipoPermissao.Size = new System.Drawing.Size(215, 21);
            this.cmbTipoPermissao.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tipo de Permissão";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.chkContratos);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(877, 113);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Contratos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // chkContratos
            // 
            this.chkContratos.FormattingEnabled = true;
            this.chkContratos.Items.AddRange(new object[] {
            "1 - Padrão",
            "2 - Consulta",
            "3 - Consulta com Manutenção de Cobrança",
            "4 - Consulta Transferência de Arquivos Webta",
            "5 - Consulta com Manutenção de Cobrança e Transferência de Arquivos Webta",
            "6 - Investimentos",
            "7 - Ativos Escriturais",
            "8 - Ativos Escriturais com Transferência de Arquivos Webta",
            "9 - Contrato Pessoa Fisica",
            "10 - Contrato Não Correntista",
            "11 - Site Independente - WebTA",
            "12 - Não Correntista Sem Representatividade"});
            this.chkContratos.Location = new System.Drawing.Point(6, 13);
            this.chkContratos.Name = "chkContratos";
            this.chkContratos.Size = new System.Drawing.Size(865, 94);
            this.chkContratos.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox4);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(877, 113);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Filtro";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkFiltro);
            this.groupBox4.Controls.Add(this.btnTodosFiltro);
            this.groupBox4.Controls.Add(this.btnVinculadosFiltro);
            this.groupBox4.Controls.Add(this.dgvFiltroImplantacao);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(865, 101);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // chkFiltro
            // 
            this.chkFiltro.AutoSize = true;
            this.chkFiltro.Location = new System.Drawing.Point(765, 74);
            this.chkFiltro.Name = "chkFiltro";
            this.chkFiltro.Size = new System.Drawing.Size(84, 17);
            this.chkFiltro.TabIndex = 3;
            this.chkFiltro.Text = "Está no filtro";
            this.chkFiltro.UseVisualStyleBackColor = true;
            // 
            // btnTodosFiltro
            // 
            this.btnTodosFiltro.Location = new System.Drawing.Point(765, 45);
            this.btnTodosFiltro.Name = "btnTodosFiltro";
            this.btnTodosFiltro.Size = new System.Drawing.Size(94, 23);
            this.btnTodosFiltro.TabIndex = 2;
            this.btnTodosFiltro.Text = "Todos";
            this.btnTodosFiltro.UseVisualStyleBackColor = true;
            this.btnTodosFiltro.Click += new System.EventHandler(this.btnTodosFiltro_Click);
            // 
            // btnVinculadosFiltro
            // 
            this.btnVinculadosFiltro.Location = new System.Drawing.Point(765, 16);
            this.btnVinculadosFiltro.Name = "btnVinculadosFiltro";
            this.btnVinculadosFiltro.Size = new System.Drawing.Size(94, 23);
            this.btnVinculadosFiltro.TabIndex = 1;
            this.btnVinculadosFiltro.Text = "Vinculados";
            this.btnVinculadosFiltro.UseVisualStyleBackColor = true;
            this.btnVinculadosFiltro.Click += new System.EventHandler(this.btnFiltroMenu_Click);
            // 
            // dgvFiltroImplantacao
            // 
            this.dgvFiltroImplantacao.AllowUserToAddRows = false;
            this.dgvFiltroImplantacao.AllowUserToDeleteRows = false;
            this.dgvFiltroImplantacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltroImplantacao.Location = new System.Drawing.Point(3, 16);
            this.dgvFiltroImplantacao.Name = "dgvFiltroImplantacao";
            this.dgvFiltroImplantacao.ReadOnly = true;
            this.dgvFiltroImplantacao.Size = new System.Drawing.Size(756, 82);
            this.dgvFiltroImplantacao.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox5);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(877, 113);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Acesso Rápido (CAR)";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCarPalavraChave);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.txtCarDescricao);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtCar);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(865, 101);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // txtCarPalavraChave
            // 
            this.txtCarPalavraChave.Location = new System.Drawing.Point(99, 65);
            this.txtCarPalavraChave.Name = "txtCarPalavraChave";
            this.txtCarPalavraChave.Size = new System.Drawing.Size(618, 20);
            this.txtCarPalavraChave.TabIndex = 11;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Palavras-Chaves";
            // 
            // txtCarDescricao
            // 
            this.txtCarDescricao.Location = new System.Drawing.Point(99, 39);
            this.txtCarDescricao.Name = "txtCarDescricao";
            this.txtCarDescricao.Size = new System.Drawing.Size(618, 20);
            this.txtCarDescricao.TabIndex = 7;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 42);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "Descrição";
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(99, 13);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(100, 20);
            this.txtCar.TabIndex = 1;
            this.txtCar.Leave += new System.EventHandler(this.txtCar_Leave);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 13);
            this.label31.TabIndex = 0;
            this.label31.Text = "CAR";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(877, 113);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Dados Complementares";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbAmbiente);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.chkTagCampanha);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(865, 101);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // cmbAmbiente
            // 
            this.cmbAmbiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmbiente.FormattingEnabled = true;
            this.cmbAmbiente.Items.AddRange(new object[] {
            "Ambos ",
            "Legado",
            "Grupo Econômico",
            "Nova Home (facelift)"});
            this.cmbAmbiente.Location = new System.Drawing.Point(63, 19);
            this.cmbAmbiente.Name = "cmbAmbiente";
            this.cmbAmbiente.Size = new System.Drawing.Size(215, 21);
            this.cmbAmbiente.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Ambiente";
            // 
            // chkTagCampanha
            // 
            this.chkTagCampanha.AutoSize = true;
            this.chkTagCampanha.Location = new System.Drawing.Point(63, 46);
            this.chkTagCampanha.Name = "chkTagCampanha";
            this.chkTagCampanha.Size = new System.Drawing.Size(151, 17);
            this.chkTagCampanha.TabIndex = 12;
            this.chkTagCampanha.Text = "Tagueamento campanha?";
            this.chkTagCampanha.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Grupo";
            // 
            // cmbFiltroGrupo
            // 
            this.cmbFiltroGrupo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFiltroGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroGrupo.FormattingEnabled = true;
            this.cmbFiltroGrupo.Location = new System.Drawing.Point(59, 39);
            this.cmbFiltroGrupo.Name = "cmbFiltroGrupo";
            this.cmbFiltroGrupo.Size = new System.Drawing.Size(433, 21);
            this.cmbFiltroGrupo.TabIndex = 6;
            this.cmbFiltroGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroGrupo_SelectedIndexChanged);
            // 
            // lblFiltroServico
            // 
            this.lblFiltroServico.AutoSize = true;
            this.lblFiltroServico.Location = new System.Drawing.Point(498, 42);
            this.lblFiltroServico.Name = "lblFiltroServico";
            this.lblFiltroServico.Size = new System.Drawing.Size(43, 13);
            this.lblFiltroServico.TabIndex = 9;
            this.lblFiltroServico.Text = "Serviço";
            // 
            // cmbFiltroServico
            // 
            this.cmbFiltroServico.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFiltroServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroServico.FormattingEnabled = true;
            this.cmbFiltroServico.Location = new System.Drawing.Point(547, 39);
            this.cmbFiltroServico.Name = "cmbFiltroServico";
            this.cmbFiltroServico.Size = new System.Drawing.Size(349, 21);
            this.cmbFiltroServico.TabIndex = 8;
            this.cmbFiltroServico.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroServico_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Filtro";
            // 
            // cmbFiltroFiltroImplantacao
            // 
            this.cmbFiltroFiltroImplantacao.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFiltroFiltroImplantacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroFiltroImplantacao.FormattingEnabled = true;
            this.cmbFiltroFiltroImplantacao.Location = new System.Drawing.Point(59, 66);
            this.cmbFiltroFiltroImplantacao.Name = "cmbFiltroFiltroImplantacao";
            this.cmbFiltroFiltroImplantacao.Size = new System.Drawing.Size(837, 21);
            this.cmbFiltroFiltroImplantacao.TabIndex = 10;
            this.cmbFiltroFiltroImplantacao.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroFiltroImplantacao_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total de Itens listados";
            // 
            // lblTotalItensListados
            // 
            this.lblTotalItensListados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalItensListados.AutoSize = true;
            this.lblTotalItensListados.Location = new System.Drawing.Point(128, 512);
            this.lblTotalItensListados.Name = "lblTotalItensListados";
            this.lblTotalItensListados.Size = new System.Drawing.Size(41, 13);
            this.lblTotalItensListados.TabIndex = 13;
            this.lblTotalItensListados.Text = "label14";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.dgvScriptGeral);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(881, 245);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Script Geral";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // dgvScriptGeral
            // 
            this.dgvScriptGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScriptGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScriptGeral.Location = new System.Drawing.Point(3, 3);
            this.dgvScriptGeral.Name = "dgvScriptGeral";
            this.dgvScriptGeral.Size = new System.Drawing.Size(875, 239);
            this.dgvScriptGeral.TabIndex = 0;
            // 
            // frm_MenuDinamico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 534);
            this.Controls.Add(this.lblTotalItensListados);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbFiltroFiltroImplantacao);
            this.Controls.Add(this.lblFiltroServico);
            this.Controls.Add(this.cmbFiltroServico);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbFiltroGrupo);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltroFamilia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_MenuDinamico";
            this.Text = "Menu Dinâmico - NetEmpresa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuDinamico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpOperacao.ResumeLayout(false);
            this.grpOperacao.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltroImplantacao)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScriptGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        #region Combos do formulário
        private void carregaComboTipoPermissao()
        {
            cmbTipoPermissao.Items.Clear();
            cmbTipoPermissao.DataSource = TipoPermissao.retornaTipoPermissoes();
            cmbTipoPermissao.DisplayMember = "descricao";
            cmbTipoPermissao.ValueMember = "indice";
            cmbTipoPermissao.SelectedIndex = 0;
        }
        private void carregaComboGrupoServico(List<GrupoServico.Grupo> grupos)
        {
            cmbGrupo.DataSource = grupos;
            cmbGrupo.DisplayMember = "dsApresentaCombo";
            cmbGrupo.ValueMember = "cdGrupo";
            cmbGrupo.SelectedValue = 0;
            cmbGrupo.Refresh();
        }
        private void carregaComboServicos(List<Servico> servicos)
        {
            cmbServico.DataSource = servicos;
            cmbServico.DisplayMember = "dsApresentaCombo";
            cmbServico.ValueMember = "cdServico";
            cmbServico.SelectedValue = 0;
            cmbServico.Refresh();
        }
        private void carregaComboEstilo(List<Estilo> estilos)
        {
            cmbEstilo.DataSource = estilos;
            cmbEstilo.DisplayMember = "dsApresentaCombo";
            cmbEstilo.ValueMember = "codigo";
            cmbEstilo.SelectedValue = 0;
            cmbEstilo.Refresh();
        }
        private void carregaComboEstilo(List<Estilo> estilos, Boolean _PosicionaUltimoInserido)
        {
            cmbEstilo.DataSource = estilos;
            cmbEstilo.DisplayMember = "dsApresentaCombo";
            cmbEstilo.ValueMember = "codigo";
            cmbEstilo.SelectedValue = estilos.OrderByDescending(x => x.codigo).ToList()[0].codigo;
            cmbEstilo.Refresh();
        }
        #endregion
        #region Combos de filtro
        private void carregaComboFamilia(int? posiciona)
        {
            familias = MenuDinamico.Familia.familias(arquivoMenu);
            cmbFiltroFamilia.DataSource = familias;
            cmbFiltroFamilia.DisplayMember = "dsApresentaCombo";
            cmbFiltroFamilia.ValueMember = "codigo";
            cmbFiltroFamilia.SelectedValue = Convert.ToInt32(posiciona);
            cmbFiltroFamilia.Refresh();
        }
        private void carregaComboGrupoServico()
        {
            grupos = GrupoServico.Grupo.grupos(arquivoServicos);

            cmbFiltroGrupo.DataSource = grupos;
            cmbFiltroGrupo.DisplayMember = "dsApresentaCombo";
            cmbFiltroGrupo.ValueMember = "cdGrupo";
            cmbFiltroGrupo.SelectedValue = 0;
            cmbFiltroGrupo.Refresh();

            lblFiltroServico.Visible = false;
            cmbFiltroServico.Visible = false;
        }
        private void carregaComboServicos()
        {
            if (cmbFiltroGrupo.SelectedValue == null || !int.TryParse(cmbFiltroGrupo.SelectedValue.ToString(), out _) || cmbFiltroGrupo.SelectedValue.ToString() == "0")
            {
                lblFiltroServico.Visible = false;
                cmbFiltroServico.Visible = false;

            }
            else
            {
                servicos = Servico.servicos(arquivoServicos.Find(x => x.cdGrupo == Convert.ToInt32(cmbFiltroGrupo.SelectedValue.ToString())).servicos);
                cmbFiltroServico.DataSource = servicos;
                cmbFiltroServico.DisplayMember = "dsApresentaCombo";
                cmbFiltroServico.ValueMember = "cdServico";

                lblFiltroServico.Visible = true;
                cmbFiltroServico.Visible = true;
            }

            cmbFiltroServico.SelectedValue = 0;
            cmbFiltroServico.Refresh();
        }
        private void carregaComboFiltroImplantacao()
        {
            cmbFiltroFiltroImplantacao.DataSource = arquivoFiltros;
            cmbFiltroFiltroImplantacao.DisplayMember = "dsApresentaCombo";
            cmbFiltroFiltroImplantacao.ValueMember = "cdServicoImplt";
            cmbFiltroFiltroImplantacao.SelectedValue = 0;
            cmbFiltroFiltroImplantacao.Refresh();
        }
        #endregion
        #region Carrega datagrids
        private void adicionaRegistroDataGrid()
        {
            List<MenuDinamico> menuDinamicosFiltrados = aplicaFiltroDataGridMenuDinamico();

            if (cmbFiltroFamilia.Text == "[Todos os itens]")
            {
                foreach (MenuDinamico menuDinamico in menuDinamicosFiltrados)
                    dgvMenuDinamico.Rows.Add
                    (
                        menuDinamico.codigo,
                        menuDinamico.nivel,
                        menuDinamico.ordem,
                        retornaFamilia(menuDinamico),
                        retornaSubFamilia(menuDinamico),
                        retornaSubFamiliaComplementar(menuDinamico),
                        menuDinamico.nome,
                        menuDinamico.descricao,
                        menuDinamico.codigoPai,
                        menuDinamico.tipoPermissao,
                        menuDinamico.car == null ? "" : menuDinamico.car.car,
                        menuDinamico.car == null ? "" : menuDinamico.car.palavra_chave,
                        menuDinamico.car == null ? "" : menuDinamico.car.descricao,
                        menuDinamico.url,
                        menuDinamico.estilo,
                        menuDinamico.contratos.Contains(1) ? "x" : "",
                        menuDinamico.contratos.Contains(2) ? "x" : "",
                        menuDinamico.contratos.Contains(3) ? "x" : "",
                        menuDinamico.contratos.Contains(4) ? "x" : "",
                        menuDinamico.contratos.Contains(5) ? "x" : "",
                        menuDinamico.contratos.Contains(6) ? "x" : "",
                        menuDinamico.contratos.Contains(7) ? "x" : "",
                        menuDinamico.contratos.Contains(8) ? "x" : "",
                        menuDinamico.contratos.Contains(9) ? "x" : "",
                        menuDinamico.contratos.Contains(10) ? "x" : "",
                        menuDinamico.contratos.Contains(11) ? "x" : "",
                        menuDinamico.contratos.Contains(12) ? "x" : "",
                        menuDinamico.trincaPermissao == null ? "" : menuDinamico.trincaPermissao.cdGrupo.ToString(),
                        menuDinamico.trincaPermissao == null || menuDinamico.trincaPermissao.cdServico == null ? "" : menuDinamico.trincaPermissao.cdServico.ToString(),
                        menuDinamico.trincaPermissao == null || menuDinamico.trincaPermissao.cdOperacao == null ? "" : menuDinamico.trincaPermissao.cdOperacao.ToString(),
                        menuDinamico.indicadorFiltro == 0 ? "" : "x",
                        menuDinamico.coluna,
                        menuDinamico.ambiente,
                        menuDinamico.tagCampanha,
                        menuDinamico.liderSolicitante
                    );
            }
            else
            {
                foreach (MenuDinamico menuDinamico in menuDinamicosFiltrados)
                    dgvMenuDinamico.Rows.Add
                    (
                        menuDinamico.codigo,
                        menuDinamico.nivel,
                        menuDinamico.ordem,
                        retornaFamilia(menuDinamico),
                        retornaSubFamilia(menuDinamico),
                        retornaSubFamiliaComplementar(menuDinamico),
                        menuDinamico.nome,
                        menuDinamico.descricao,
                        menuDinamico.codigoPai,
                        menuDinamico.tipoPermissao,
                        menuDinamico.car == null ? "" : menuDinamico.car.car,
                        menuDinamico.car == null ? "" : menuDinamico.car.palavra_chave,
                        menuDinamico.car == null ? "" : menuDinamico.car.descricao,
                        menuDinamico.url,
                        menuDinamico.estilo,
                        menuDinamico.contratos.Contains(1) ? "x" : "",
                        menuDinamico.contratos.Contains(2) ? "x" : "",
                        menuDinamico.contratos.Contains(3) ? "x" : "",
                        menuDinamico.contratos.Contains(4) ? "x" : "",
                        menuDinamico.contratos.Contains(5) ? "x" : "",
                        menuDinamico.contratos.Contains(6) ? "x" : "",
                        menuDinamico.contratos.Contains(7) ? "x" : "",
                        menuDinamico.contratos.Contains(8) ? "x" : "",
                        menuDinamico.contratos.Contains(9) ? "x" : "",
                        menuDinamico.contratos.Contains(10) ? "x" : "",
                        menuDinamico.contratos.Contains(11) ? "x" : "",
                        menuDinamico.contratos.Contains(12) ? "x" : "",
                        menuDinamico.trincaPermissao == null ? "" : menuDinamico.trincaPermissao.cdGrupo.ToString(),
                        menuDinamico.trincaPermissao == null || menuDinamico.trincaPermissao.cdServico == null ? "" : menuDinamico.trincaPermissao.cdServico.ToString(),
                        menuDinamico.trincaPermissao == null || menuDinamico.trincaPermissao.cdOperacao == null ? "" : menuDinamico.trincaPermissao.cdOperacao.ToString(),
                        menuDinamico.indicadorFiltro == 0 ? "" : "x",
                        menuDinamico.coluna,
                        menuDinamico.ambiente,
                        menuDinamico.tagCampanha,
                        menuDinamico.liderSolicitante
                    );
            }
        }
        private void carregaDataGridMenuDinamico()
        {
            dgvMenuDinamico.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dgvMenuDinamico.AllowUserToAddRows = false;
            dgvMenuDinamico.ReadOnly = true;
            dgvMenuDinamico.MultiSelect = false;
            dgvMenuDinamico.Rows.Clear();
            dgvMenuDinamico.ColumnCount = MenuDinamico.total_colunas_datagrid;

            dgvMenuDinamico.Columns[MenuDinamico.idx_codigo].Name = "codigo";
            dgvMenuDinamico.Columns[MenuDinamico.idx_nivel].Name = "nivel";
            dgvMenuDinamico.Columns[MenuDinamico.idx_ordem].Name = "ordem";
            dgvMenuDinamico.Columns[MenuDinamico.idx_familia].Name = "familia";
            dgvMenuDinamico.Columns[MenuDinamico.idx_subfamilia].Name = "subfamilia";
            dgvMenuDinamico.Columns[MenuDinamico.idx_subfamiliacomplementar].Name = "subfamiliacomplementar";
            dgvMenuDinamico.Columns[MenuDinamico.idx_nome].Name = "nome";
            dgvMenuDinamico.Columns[MenuDinamico.idx_descricao].Name = "descricao";
            dgvMenuDinamico.Columns[MenuDinamico.idx_codigoPai].Name = "codigoPai";
            dgvMenuDinamico.Columns[MenuDinamico.idx_tipoPermissao].Name = "tipoPermissao";
            dgvMenuDinamico.Columns[MenuDinamico.idx_car].Name = "car";
            dgvMenuDinamico.Columns[MenuDinamico.idx_car_palavra_chave].Name = "car_palavra_chave";
            dgvMenuDinamico.Columns[MenuDinamico.idx_car_descricao].Name = "car_descricao";
            dgvMenuDinamico.Columns[MenuDinamico.idx_url].Name = "url";
            dgvMenuDinamico.Columns[MenuDinamico.idx_estilo].Name = "estilo";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_padrao].Name = "contrato_padrao";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_consulta].Name = "contrato_consulta";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_consulta_cobranca].Name = "contrato_consulta_cobranca";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_consulta_webta].Name = "contrato_consulta_webta";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_consulta_cobranca_webta].Name = "contrato_consulta_cobranca_webta";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_investimentos].Name = "contrato_investimentos";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_ativos_escriturais].Name = "contrato_ativos_escriturais";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_ativos_escritutais_webta].Name = "contrato_ativos_escriturais_webta";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_pessoa_fisica].Name = "contrato_pessoa_fisica";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_nao_correntista].Name = "contrato_nao_correntista";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_site_independente].Name = "contrato_site_independente";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_nao_correntista_sem_representatividade].Name = "contrato_nao_correntista_sem_representatividade";
            dgvMenuDinamico.Columns[MenuDinamico.idx_grupo].Name = "grupo";
            dgvMenuDinamico.Columns[MenuDinamico.idx_servico].Name = "servico";
            dgvMenuDinamico.Columns[MenuDinamico.idx_operacao].Name = "operacao";
            dgvMenuDinamico.Columns[MenuDinamico.idx_indicadorFiltro].Name = "indicadorFiltro";
            dgvMenuDinamico.Columns[MenuDinamico.idx_coluna].Name = "coluna";
            dgvMenuDinamico.Columns[MenuDinamico.idx_ambiente].Name = "ambiente";
            dgvMenuDinamico.Columns[MenuDinamico.idx_tagCampanha].Name = "tagCampanha";
            dgvMenuDinamico.Columns[MenuDinamico.idx_lider_solicitante].Name = "lider_solicitante";

            dgvMenuDinamico.Columns[MenuDinamico.idx_codigo].HeaderText = "Código";
            dgvMenuDinamico.Columns[MenuDinamico.idx_nivel].HeaderText = "Nível";
            dgvMenuDinamico.Columns[MenuDinamico.idx_ordem].HeaderText = "Sequencial";
            dgvMenuDinamico.Columns[MenuDinamico.idx_familia].Name = "Família";
            dgvMenuDinamico.Columns[MenuDinamico.idx_subfamilia].Name = "Sub Família";
            dgvMenuDinamico.Columns[MenuDinamico.idx_subfamiliacomplementar].Name = "Sub Família Complementar";
            dgvMenuDinamico.Columns[MenuDinamico.idx_nome].HeaderText = "Texto do Link";
            dgvMenuDinamico.Columns[MenuDinamico.idx_descricao].HeaderText = "Texto Alternativo";
            dgvMenuDinamico.Columns[MenuDinamico.idx_codigoPai].HeaderText = "Menu Pai";
            dgvMenuDinamico.Columns[MenuDinamico.idx_tipoPermissao].HeaderText = "Tipo de Permissão";
            dgvMenuDinamico.Columns[MenuDinamico.idx_car].HeaderText = "Acesso Direto";
            dgvMenuDinamico.Columns[MenuDinamico.idx_car_palavra_chave].HeaderText = "Palavra-Chave do Acesso Direto";
            dgvMenuDinamico.Columns[MenuDinamico.idx_car_descricao].HeaderText = "Descrição do Acesso Direto";
            dgvMenuDinamico.Columns[MenuDinamico.idx_url].HeaderText = "URL Serviço";
            dgvMenuDinamico.Columns[MenuDinamico.idx_estilo].HeaderText = "Estilo Específico";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_padrao].HeaderText = "1 - Padrão";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_consulta].HeaderText = "2 - Consulta";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_consulta_cobranca].HeaderText = "3 - Consulta com Manutenção de Cobrança";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_consulta_webta].HeaderText = "4 - Consulta Transferência de Arquivos Webta";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_consulta_cobranca_webta].HeaderText = "5 - Consulta com Manutenção de Cobrança e Transferência de Arquivos Webta";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_investimentos].HeaderText = "6 - Investimentos";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_ativos_escriturais].HeaderText = "7 - Ativos Escriturais";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_ativos_escritutais_webta].HeaderText = "8 - Ativos Escriturais com Transferência de Arquivos Webta";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_pessoa_fisica].HeaderText = "9 - Contrato Pessoa Fisica";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_nao_correntista].HeaderText = "10 - Contrato Não Correntista";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_site_independente].HeaderText = "11 - Site Independente - WebTA";
            dgvMenuDinamico.Columns[MenuDinamico.idx_contrato_nao_correntista_sem_representatividade].HeaderText = "12 - Não Correntista Sem Representatividade";
            dgvMenuDinamico.Columns[MenuDinamico.idx_grupo].HeaderText = "Grupo";
            dgvMenuDinamico.Columns[MenuDinamico.idx_servico].HeaderText = "Serviço";
            dgvMenuDinamico.Columns[MenuDinamico.idx_operacao].HeaderText = "Operação";
            dgvMenuDinamico.Columns[MenuDinamico.idx_indicadorFiltro].HeaderText = "Utiliza Filtro?";
            dgvMenuDinamico.Columns[MenuDinamico.idx_coluna].HeaderText = "Nº da Coluna";
            dgvMenuDinamico.Columns[MenuDinamico.idx_ambiente].HeaderText = "Ambiente - 0 Ambos, 1 - Legado, 2 - GE, 3 - Nova Home";
            dgvMenuDinamico.Columns[MenuDinamico.idx_tagCampanha].HeaderText = "Tag Campanha?";
            dgvMenuDinamico.Columns[MenuDinamico.idx_lider_solicitante].HeaderText = "Líder Solicitante";
        }
        private void carregaDataGridFiltroMenu(MenuDinamico menuDinamico)
        {
            dgvFiltroImplantacao.Rows.Clear();
            dgvFiltroImplantacao.ColumnCount = 2;
            dgvFiltroImplantacao.ReadOnly = false;
            dgvFiltroImplantacao.AllowUserToAddRows = false;

            dgvFiltroImplantacao.Columns[0].Name = "codigo";
            dgvFiltroImplantacao.Columns[1].Name = "descricao";

            dgvFiltroImplantacao.Columns[0].HeaderText = "Código";
            dgvFiltroImplantacao.Columns[1].HeaderText = "Descrição";

            dgvFiltroImplantacao.Columns[0].ReadOnly = true;
            dgvFiltroImplantacao.Columns[1].ReadOnly = true;

            DataGridViewCheckBoxColumn exibirFiltro = new DataGridViewCheckBoxColumn();
            exibirFiltro.Name = "exibirFiltro";
            exibirFiltro.HeaderText = "Exibir";
            exibirFiltro.ReadOnly = false;
            exibirFiltro.FillWeight = 10;
            dgvFiltroImplantacao.Columns.Add(exibirFiltro);

            DataGridViewCheckBoxColumn escondeFiltro = new DataGridViewCheckBoxColumn();
            escondeFiltro.Name = "escondeFiltro";
            escondeFiltro.HeaderText = "Esconder";
            escondeFiltro.ReadOnly = false;
            escondeFiltro.FillWeight = 10;
            dgvFiltroImplantacao.Columns.Add(escondeFiltro);

            foreach (FiltroImplantacao filtroImplantacao in arquivoFiltros)
            {
                if (filtroImplantacao.cdServicoImplt != 0)
                {
                    Boolean exibir = false;
                    Boolean esconder = false;
                    if (menuDinamico.filtros != null && !menuDinamico.filtros.Contains(null))
                    {
                        FiltroMenu filtroMenu = menuDinamico.filtros.Find(x => x.cdServicoImplt == filtroImplantacao.cdServicoImplt);
                        if (filtroMenu != null)
                        {
                            exibir = filtroMenu.cdIndcdSelec == 1;
                            esconder = filtroMenu.cdIndcdSelec == 0;
                        }
                    }

                    dgvFiltroImplantacao.Rows.Add(filtroImplantacao.cdServicoImplt, filtroImplantacao.dsServicoImplt, exibir, esconder);
                }
            }

            dgvFiltroImplantacao.Refresh();
        }
        private void carregaDataGridFiltroMenu()
        {
            dgvFiltroImplantacao.Rows.Clear();
            dgvFiltroImplantacao.ColumnCount = 2;
            dgvFiltroImplantacao.ReadOnly = false;
            dgvFiltroImplantacao.AllowUserToAddRows = false;

            dgvFiltroImplantacao.Columns[0].Name = "codigo";
            dgvFiltroImplantacao.Columns[1].Name = "descricao";

            dgvFiltroImplantacao.Columns[0].HeaderText = "Código";
            dgvFiltroImplantacao.Columns[1].HeaderText = "Descrição";

            dgvFiltroImplantacao.Columns[0].ReadOnly = true;
            dgvFiltroImplantacao.Columns[1].ReadOnly = true;

            DataGridViewCheckBoxColumn exibirFiltro = new DataGridViewCheckBoxColumn();
            exibirFiltro.Name = "exibirFiltro";
            exibirFiltro.HeaderText = "Exibir";
            exibirFiltro.ReadOnly = false;
            exibirFiltro.FillWeight = 10;
            dgvFiltroImplantacao.Columns.Add(exibirFiltro);

            DataGridViewCheckBoxColumn escondeFiltro = new DataGridViewCheckBoxColumn();
            escondeFiltro.Name = "escondeFiltro";
            escondeFiltro.HeaderText = "Esconder";
            escondeFiltro.ReadOnly = false;
            escondeFiltro.FillWeight = 10;
            dgvFiltroImplantacao.Columns.Add(escondeFiltro);

            foreach (FiltroImplantacao filtroImplantacao in arquivoFiltros)
            {
                if (filtroImplantacao.cdServicoImplt != 0)
                {
                    Boolean exibir = false;
                    Boolean esconder = false;
                    dgvFiltroImplantacao.Rows.Add(filtroImplantacao.cdServicoImplt, filtroImplantacao.dsServicoImplt, exibir, esconder);
                }
            }

            dgvFiltroImplantacao.Refresh();
        }
        private void carregaDataGridFiltroMenu(DataGridView dgv)
        {
            List<List<String>> filtrosMarcados = new List<List<String>>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[2].Value.ToString().ToLower() == "true" || row.Cells[3].Value.ToString().ToLower() == "true")
                {
                    List<String> registro = new List<String>();
                    registro.Add(row.Cells[0].Value.ToString());
                    registro.Add(row.Cells[1].Value.ToString());
                    registro.Add(row.Cells[2].Value.ToString());
                    registro.Add(row.Cells[3].Value.ToString());
                    filtrosMarcados.Add(registro);
                }
            }

            carregaDataGridFiltroMenu();

            foreach (List<String> registros in filtrosMarcados)
            {
                foreach (DataGridViewRow row in dgvFiltroImplantacao.Rows)
                {
                    if (row.Cells[0].Value.ToString() == registros[0].ToString())
                    {
                        row.Cells[0].Value = registros[0].ToString();
                        row.Cells[1].Value = registros[1].ToString();
                        row.Cells[2].Value = registros[2].ToString();
                        row.Cells[3].Value = registros[3].ToString();
                    }
                }
            }

            dgvFiltroImplantacao.Refresh();
        }
        private void carregaDataGridFiltroMenu(DataGridView dgv, Boolean _SomenteVinculados)
        {
            List<List<String>> filtrosMarcados = new List<List<String>>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[2].Value.ToString().ToLower() == "true" || row.Cells[3].Value.ToString().ToLower() == "true")
                {
                    List<String> registro = new List<String>();
                    registro.Add(row.Cells[0].Value.ToString());
                    registro.Add(row.Cells[1].Value.ToString());
                    registro.Add(row.Cells[2].Value.ToString());
                    registro.Add(row.Cells[3].Value.ToString());
                    filtrosMarcados.Add(registro);
                }
            }

            dgvFiltroImplantacao.Rows.Clear();

            dgvFiltroImplantacao.ColumnCount = 2;
            dgvFiltroImplantacao.ReadOnly = false;
            dgvFiltroImplantacao.AllowUserToAddRows = false;

            dgvFiltroImplantacao.Columns[0].Name = "codigo";
            dgvFiltroImplantacao.Columns[1].Name = "descricao";

            dgvFiltroImplantacao.Columns[0].HeaderText = "Código";
            dgvFiltroImplantacao.Columns[1].HeaderText = "Descrição";

            dgvFiltroImplantacao.Columns[0].ReadOnly = true;
            dgvFiltroImplantacao.Columns[1].ReadOnly = true;

            DataGridViewCheckBoxColumn exibirFiltro = new DataGridViewCheckBoxColumn();
            exibirFiltro.Name = "exibirFiltro";
            exibirFiltro.HeaderText = "Exibir";
            exibirFiltro.ReadOnly = false;
            exibirFiltro.FillWeight = 10;
            dgvFiltroImplantacao.Columns.Add(exibirFiltro);

            DataGridViewCheckBoxColumn escondeFiltro = new DataGridViewCheckBoxColumn();
            escondeFiltro.Name = "escondeFiltro";
            escondeFiltro.HeaderText = "Esconder";
            escondeFiltro.ReadOnly = false;
            escondeFiltro.FillWeight = 10;
            dgvFiltroImplantacao.Columns.Add(escondeFiltro);

            foreach (List<String> registros in filtrosMarcados)
            {
                dgvFiltroImplantacao.Rows.Add(registros[0], registros[1], registros[2], registros[3]);
            }

            dgvFiltroImplantacao.Refresh();
        }
        private void carregaDataGridScriptGeral()
        {
            dgvScriptGeral.Rows.Clear();
            dgvScriptGeral.ColumnCount = 2;
            dgvScriptGeral.AllowUserToAddRows = false;
            dgvScriptGeral.ReadOnly = true;

            dgvScriptGeral.Columns[0].Name = "codigo";
            dgvScriptGeral.Columns[1].Name = "script";
            dgvScriptGeral.Columns[0].HeaderText = "Item";
            dgvScriptGeral.Columns[1].HeaderText = "Script";

            foreach (DataGridViewRow row in dgvMenuDinamico.Rows)
            {
                String script = "Execute dbo.pMltMenuDnamc01 ";
                script += row.Cells[MenuDinamico.idx_car].Value.ToString() == "" ? "NULL" : $"'{row.Cells[MenuDinamico.idx_car].Value.ToString()}'";
                script += row.Cells[MenuDinamico.idx_car_palavra_chave].Value == null || row.Cells[MenuDinamico.idx_car_palavra_chave].Value.ToString() == "" ? ",NULL" : $",'{row.Cells[MenuDinamico.idx_car_palavra_chave].Value.ToString()}'";
                script += row.Cells[MenuDinamico.idx_car_descricao].Value == null || row.Cells[MenuDinamico.idx_car_descricao].Value.ToString() == "" ? ",NULL" : $",'{row.Cells[MenuDinamico.idx_car_descricao].Value.ToString()}'";
                script += row.Cells[MenuDinamico.idx_grupo].Value.ToString() == "" ? ",NULL" : $",{row.Cells[MenuDinamico.idx_grupo].Value.ToString()}";
                script += row.Cells[MenuDinamico.idx_servico].Value.ToString() == "" ? ",NULL" : $",{row.Cells[MenuDinamico.idx_servico].Value.ToString()}";
                script += row.Cells[MenuDinamico.idx_operacao].Value.ToString() == "" ? ",NULL" : $",{row.Cells[MenuDinamico.idx_operacao].Value.ToString()}";
                script += $",{row.Cells[MenuDinamico.idx_codigo].Value.ToString()}";
                script += row.Cells[MenuDinamico.idx_codigoPai].Value == null ? ",NULL" : $",{row.Cells[MenuDinamico.idx_codigoPai].Value.ToString()}";
                script += row.Cells[MenuDinamico.idx_indicadorFiltro].Value.ToString().ToLower() == "x" ? ",1" : ",0";
                script += row.Cells[MenuDinamico.idx_tipoPermissao].Value == null ? ",NULL" : $",'{row.Cells[MenuDinamico.idx_tipoPermissao].Value.ToString()}'";
                script += $",'{row.Cells[MenuDinamico.idx_nome].Value.ToString()}'";
                script += $",'{row.Cells[MenuDinamico.idx_url].Value.ToString()}'";
                script += $",{row.Cells[MenuDinamico.idx_nivel].Value.ToString()}";
                script += $",'{row.Cells[MenuDinamico.idx_ordem].Value.ToString()}'";
                script += $",{row.Cells[MenuDinamico.idx_coluna].Value.ToString()}";
                script += $",'{row.Cells[MenuDinamico.idx_descricao].Value.ToString()}'";
                script += row.Cells[MenuDinamico.idx_estilo].Value == null ? ",NULL" : $",{row.Cells[MenuDinamico.idx_estilo].Value.ToString()}";

                String contratos = "";

                contratos += row.Cells[MenuDinamico.idx_contrato_padrao].Value.ToString().ToLower() == "x" ? "01," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_consulta].Value.ToString().ToLower() == "x" ? "02," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_consulta_cobranca].Value.ToString().ToLower() == "x" ? "03," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_consulta_webta].Value.ToString().ToLower() == "x" ? "04," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_consulta_cobranca_webta].Value.ToString().ToLower() == "x" ? "05," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_investimentos].Value.ToString().ToLower() == "x" ? "06," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_ativos_escriturais].Value.ToString().ToLower() == "x" ? "07," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_ativos_escritutais_webta].Value.ToString().ToLower() == "x" ? "08," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_pessoa_fisica].Value.ToString().ToLower() == "x" ? "09," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_nao_correntista].Value.ToString().ToLower() == "x" ? "10," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_site_independente].Value.ToString().ToLower() == "x" ? "11," : "";
                contratos += row.Cells[MenuDinamico.idx_contrato_nao_correntista_sem_representatividade].Value.ToString().ToLower() == "x" ? "12," : "";

                if (contratos.Length - 1 <= 0)
                    contratos = "";
                else
                    contratos = contratos.Substring(0, contratos.Length - 1);

                script += $",'{contratos}'";
                script += $",{row.Cells[MenuDinamico.idx_ambiente].Value.ToString()}";

                //Execute dbo.pMltMenuDnamc01 'S','Saldo;Extrato;Consultar;conta;corrente;CNPJ','Saldos e Extratos',NULL,NULL,NULL,1000,1,0,'C','Saldos e Extratos','[SERVIDOR url.base]/ibpjtelainicial/menuSaldoExtrato.jsf?CTRL=[CONTROLE]',2,'0101',1,'Saldos e Extratos',4,'01,02,03,04,05,06,07,09,10',0
                dgvScriptGeral.Rows.Add
                (
                    row.Cells[MenuDinamico.idx_codigo].Value.ToString(),
                    script
                );
            }

            dgvScriptGeral.Refresh();
        }
        #endregion
        #region Comportamentos da tela
        private void defineModoTela()
        {
            if (modoTela == Util.ModoTela.Alterar)
            {
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Atualizar";
                btnPersistirArquivo.Enabled = true;
                btnPersistirArquivo.Text = "Excluir";
            }
            else if (modoTela == Util.ModoTela.Inserir)
            {
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Incluir";
                btnPersistirArquivo.Enabled = true;
                btnPersistirArquivo.Text = "Atualizar Arquivos";
            }
        }
        private void defineCoresDataGrid()
        {
            foreach (DataGridViewRow row in dgvMenuDinamico.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);

                if (row.Cells[MenuDinamico.idx_nivel].Value.ToString() == MenuDinamico.nivel_paginaInicial.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.NavajoWhite;
                    row.DefaultCellStyle.SelectionBackColor = Color.NavajoWhite;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else if (row.Cells[MenuDinamico.idx_nivel].Value.ToString() == MenuDinamico.nivel_familia.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.ForestGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.ForestGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else if (row.Cells[MenuDinamico.idx_nivel].Value.ToString() == MenuDinamico.nivel_subfamilia.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else if (row.Cells[MenuDinamico.idx_nivel].Value.ToString() == MenuDinamico.nivel_subfamiliacomplementar.ToString() && row.Cells[MenuDinamico.idx_url].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.MediumPurple;
                    row.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else if (row.Cells[MenuDinamico.idx_nivel].Value.ToString() == MenuDinamico.nivel_item_subfamiliacomplementar.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    row.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
        }
        private void limpaCamposNaTela()
        {
            txtCodigo.Text = proximoCodigoMenu().ToString();
            txtOrdem.Text = "";
            txtNivel.Text = defineNivel().ToString();
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtUrl.Text = "";
            cmbColuna.SelectedIndex = 0;
            txtLiderSolicitante.Text = "";
            carregaComboEstilo(arquivoEstilos);

            // Aba de permissão
            cmbTipoPermissao.SelectedValue = "";
            carregaComboGrupoServico(GrupoServico.Grupo.grupos(arquivoServicos));
            carregaComboServicos(Servico.servicos(new List<Servico>()));
            rdbConsulta.Checked = false;
            rdbEntradaDeDados.Checked = false;
            rdbAprovacao.Checked = false;

            // Aba de contratos
            chkContratos.SetItemChecked(0, false);
            chkContratos.SetItemChecked(1, false);
            chkContratos.SetItemChecked(2, false);
            chkContratos.SetItemChecked(3, false);
            chkContratos.SetItemChecked(4, false);
            chkContratos.SetItemChecked(5, false);
            chkContratos.SetItemChecked(6, false);
            chkContratos.SetItemChecked(7, false);
            chkContratos.SetItemChecked(8, false);
            chkContratos.SetItemChecked(9, false);
            chkContratos.SetItemChecked(10, false);
            chkContratos.SetItemChecked(11, false);

            // Aba de filtro
            //carregaComboFiltroImplantacao();
            //carregaComboFamilia();
            //carregaComboGrupoServico();
            //carregaComboServicos();
            chkFiltro.Checked = false;
            carregaDataGridFiltroMenu(new MenuDinamico());

            // Aba de CAR
            txtCar.Text = "";
            txtCarDescricao.Text = "";
            txtCarPalavraChave.Text = "";

            //Aba Dados complementares
            cmbAmbiente.SelectedIndex = 0;
            chkTagCampanha.Checked = false;

            menuDinamicoTela = new MenuDinamico();
            carregaDataGridScriptGeral();
        }
        private void atualizaLabelTotalItensMenu()
        {
            lblTotalItensListados.Text = dgvMenuDinamico.Rows.Count.ToString();
        }
        private void preencheCamposTelaMenuDinamico(int _indiceGridMenuDinamico)
        {
            limpaCamposNaTela();
            MenuDinamico menuGridMenuDinamicoEscolhido = arquivoMenu.Find(menu => menu.codigo == Convert.ToInt32(dgvMenuDinamico.Rows[_indiceGridMenuDinamico].Cells[MenuDinamico.idx_codigo].Value));
            menuDinamicoTela = menuGridMenuDinamicoEscolhido;


            // Aba de detalhes do item
            txtCodigo.Text = menuGridMenuDinamicoEscolhido.codigo.ToString();
            txtOrdem.Text = menuGridMenuDinamicoEscolhido.ordem;
            txtNivel.Text = menuGridMenuDinamicoEscolhido.nivel.ToString();
            txtNome.Text = menuGridMenuDinamicoEscolhido.nome;
            txtDescricao.Text = menuGridMenuDinamicoEscolhido.descricao;
            txtUrl.Text = menuGridMenuDinamicoEscolhido.url;
            cmbColuna.SelectedIndex = menuGridMenuDinamicoEscolhido.coluna == 1 ? 0 : 1;
            txtLiderSolicitante.Text = menuGridMenuDinamicoEscolhido.liderSolicitante;

            carregaComboEstilo(arquivoEstilos);
            if (menuGridMenuDinamicoEscolhido.estilo != null)
                cmbEstilo.SelectedValue = menuGridMenuDinamicoEscolhido.estilo;


            // Aba de permissão
            cmbTipoPermissao.SelectedValue = menuGridMenuDinamicoEscolhido.tipoPermissao == null ? "" : menuGridMenuDinamicoEscolhido.tipoPermissao;
            carregaComboGrupoServico(GrupoServico.Grupo.grupos(arquivoServicos));
            carregaComboServicos(Servico.servicos(new List<Servico>()));

            if (menuGridMenuDinamicoEscolhido.trincaPermissao != null)
            {
                cmbGrupo.SelectedValue = menuGridMenuDinamicoEscolhido.trincaPermissao.cdGrupo;
                if (menuGridMenuDinamicoEscolhido.trincaPermissao.cdServico != null)
                {
                    carregaComboServicos(Servico.servicos(arquivoServicos.Find(x => x.cdGrupo == Convert.ToInt32(cmbGrupo.SelectedValue.ToString())).servicos));
                    cmbServico.SelectedValue = menuGridMenuDinamicoEscolhido.trincaPermissao.cdServico;
                }
                else
                    cmbServico.SelectedValue = 0;

                rdbConsulta.Checked = menuGridMenuDinamicoEscolhido.trincaPermissao.cdOperacao != null && menuGridMenuDinamicoEscolhido.trincaPermissao.cdOperacao == 1;
                rdbEntradaDeDados.Checked = menuGridMenuDinamicoEscolhido.trincaPermissao.cdOperacao != null && menuGridMenuDinamicoEscolhido.trincaPermissao.cdOperacao == 2;
                rdbAprovacao.Checked = menuGridMenuDinamicoEscolhido.trincaPermissao.cdOperacao != null && menuGridMenuDinamicoEscolhido.trincaPermissao.cdOperacao == 3;
            }

            // Aba de contratos
            chkContratos.SetItemChecked(0, menuGridMenuDinamicoEscolhido.contratos.Contains(1));
            chkContratos.SetItemChecked(1, menuGridMenuDinamicoEscolhido.contratos.Contains(2));
            chkContratos.SetItemChecked(2, menuGridMenuDinamicoEscolhido.contratos.Contains(3));
            chkContratos.SetItemChecked(3, menuGridMenuDinamicoEscolhido.contratos.Contains(4));
            chkContratos.SetItemChecked(4, menuGridMenuDinamicoEscolhido.contratos.Contains(5));
            chkContratos.SetItemChecked(5, menuGridMenuDinamicoEscolhido.contratos.Contains(6));
            chkContratos.SetItemChecked(6, menuGridMenuDinamicoEscolhido.contratos.Contains(7));
            chkContratos.SetItemChecked(7, menuGridMenuDinamicoEscolhido.contratos.Contains(8));
            chkContratos.SetItemChecked(8, menuGridMenuDinamicoEscolhido.contratos.Contains(9));
            chkContratos.SetItemChecked(9, menuGridMenuDinamicoEscolhido.contratos.Contains(10));
            chkContratos.SetItemChecked(10, menuGridMenuDinamicoEscolhido.contratos.Contains(11));
            chkContratos.SetItemChecked(11, menuGridMenuDinamicoEscolhido.contratos.Contains(12));

            // Aba de filtro
            chkFiltro.Checked = menuGridMenuDinamicoEscolhido.indicadorFiltro == 1;
            carregaDataGridFiltroMenu(menuGridMenuDinamicoEscolhido);

            // Aba de CAR
            if (menuGridMenuDinamicoEscolhido.car != null)
            {
                txtCar.Text = menuGridMenuDinamicoEscolhido.car.car;
                txtCarDescricao.Text = menuGridMenuDinamicoEscolhido.car.descricao;
                txtCarPalavraChave.Text = menuGridMenuDinamicoEscolhido.car.palavra_chave;
            }

            // Aba dados complementares
            cmbAmbiente.SelectedIndex = menuGridMenuDinamicoEscolhido.ambiente.Value;
            chkTagCampanha.Checked = menuGridMenuDinamicoEscolhido.tagCampanha == 1;
        }
        private void posicionaItemGridMenu(int _codigo)
        {
            foreach (DataGridViewRow row in dgvMenuDinamico.Rows)
            {
                row.Selected = false;

                if (row.Cells[MenuDinamico.idx_codigo].Value.ToString() == _codigo.ToString())
                {
                    row.Selected = true;
                    row.DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                    dgvFiltroImplantacao.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }

            dgvMenuDinamico.Refresh();
        }
        #endregion
        #region Funções gerais
        private String retornaFamilia(MenuDinamico menuDinamico)
        {
            if (menuDinamico.codigoPai == null || !arquivoMenu.Exists(x => x.codigo == menuDinamico.codigoPai))
                return "";

            return arquivoMenu.Find(x => x.codigo == menuDinamico.codigoPai).descricao;
        }
        private String retornaSubFamilia(MenuDinamico menuDinamico)
        {
            if (menuDinamico.nivel >= 4)
            {
                // 010101
                String ordemPai = menuDinamico.ordem.Substring(0, 6);

                if (!(arquivoMenu.Exists(x => x.ordem.Trim() == ordemPai)))
                    return "";

                return arquivoMenu.Find(x => x.ordem.Trim() == ordemPai).nome;
            }


            return "";
        }
        private String retornaSubFamiliaComplementar(MenuDinamico menuDinamico)
        {
            if (menuDinamico.nivel == 5)
            {
                // 010101
                String ordemPai = menuDinamico.ordem.Substring(0, 8);

                if (!(arquivoMenu.Exists(x => x.ordem.Trim() == ordemPai)))
                    return "";

                return arquivoMenu.Find(x => x.ordem.Trim() == ordemPai).nome;
            }


            return "";
        }
        private int proximoCodigoMenu()
        {
            if (txtOrdem.Text.Trim() == "")
                return 0;

            if (txtNivel.Text == "1")
                return arquivoMenu.OrderByDescending(x => x.codigo).ToList().FirstOrDefault(x => x.nivel == 1).codigo + 1;

            if (txtNivel.Text == "2")
                return familias.OrderByDescending(x => x.codigo).ToList().FirstOrDefault().codigo + Util.IntervaloFamilia;

            if (Convert.ToInt32(txtNivel.Text.Trim()) >= 3)
            {
                if (!arquivoMenu.Exists(x => x.ordem.Trim() == txtOrdem.Text.Trim().Substring(0, 4)))
                {
                    MessageBox.Show("Esta ordem é inválida, pois não existe uma referência de família.", "Validação de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtOrdem.Text = "";
                    txtOrdem.Select();
                    return 0;
                }

                int codigoFamilia = arquivoMenu.Find(x => x.ordem.Trim() == txtOrdem.Text.Trim().Substring(0, 4)).codigo;
                for (int i = codigoFamilia + 1; i < codigoFamilia + (Util.IntervaloFamilia - 1); i++)
                {
                    MessageBox.Show($"Indicador: {i}");


                    if (!arquivoMenu.Exists(x => x.codigo == i))
                    {
                        MessageBox.Show($"Menu não encontrado: {i}");
                        return i;
                    }
                        
                }
            }

            return -1;
        }
        private int defineNivel()
        {
            if (txtOrdem.Text.Trim() == "")
                return 0;

            return txtOrdem.Text.Trim().Length / 2;
        }
        private void preparaScriptAlteracoes(MenuDinamico menuDinamico)
        {
            //MenuDinamico _menuAnterior = arquivoMenu.Find(x=>x.codigo == menuDinamico.codigo);
            //List<List<String>> scriptsAlteracoes = MenuDinamico.retornaAtualizacaoCampos(_menuAnterior, menuDinamico);

            //Gera a IDA

            //Gera a VOLTA


            //script_atualizacaoVolta.AppendLine($"UPDATE dbo.tMenuDnamc SET ");
        }
        #endregion
        #region Funcionalidades de controles na tela
        private void selecaoComboFiltroFamilia()
        {
            limpaCamposNaTela();
            carregaDataGridMenuDinamico();
            adicionaRegistroDataGrid();
            defineCoresDataGrid();
            dgvMenuDinamico.Refresh();
            atualizaLabelTotalItensMenu();
        }
        private void selecaoLinhaDataGridMenuDinamico()
        {
            int linhaAtual = dgvMenuDinamico.CurrentRow.Index;
            foreach (DataGridViewRow row in dgvMenuDinamico.Rows)
            {
                row.DefaultCellStyle.Font = new Font(Font, FontStyle.Regular);
                if (row.Index == linhaAtual)
                    row.DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
            }
        }
        private void selecaoComboFiltroGrupoServico()
        {
            limpaCamposNaTela();
            carregaComboServicos();
            carregaDataGridMenuDinamico();
            adicionaRegistroDataGrid();
            defineCoresDataGrid();
            dgvMenuDinamico.Refresh();
            atualizaLabelTotalItensMenu();
        }
        private void selecaoComboFiltroServico()
        {
            limpaCamposNaTela();
            carregaDataGridMenuDinamico();
            adicionaRegistroDataGrid();
            defineCoresDataGrid();
            dgvMenuDinamico.Refresh();
            atualizaLabelTotalItensMenu();
        }
        private void selecaoComboFiltroFiltroImplantacao()
        {
            limpaCamposNaTela();

            carregaDataGridMenuDinamico();
            adicionaRegistroDataGrid();
            defineCoresDataGrid();
            dgvMenuDinamico.Refresh();
            lblTotalItensListados.Text = dgvMenuDinamico.Rows.Count.ToString();
        }
        private void selecaoDuploCliqueDataGridMenuDinamico()
        {
            modoTela = Util.ModoTela.Alterar;
            preencheCamposTelaMenuDinamico(dgvMenuDinamico.CurrentRow.Index);
            defineModoTela();
        }
        private void selecaoComboFormularioGrupoServico()
        {
            if (cmbGrupo.SelectedValue != null && int.TryParse(cmbGrupo.SelectedValue.ToString(), out _))
                if (cmbGrupo.SelectedValue.ToString() == "0")
                    carregaComboServicos(Servico.servicos(new List<Servico>()));
                else
                    carregaComboServicos(Servico.servicos(arquivoServicos.Find(x => x.cdGrupo == Convert.ToInt32(cmbGrupo.SelectedValue.ToString())).servicos));
        }
        private void validacaoFormularioAtributoOrdem()
        {
            if (!int.TryParse(txtOrdem.Text.Trim(), out _) && txtOrdem.Text != "")
            {
                MessageBox.Show("O campo ordem deve ser numérico.", "Validação de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtOrdem.Text = "";
                txtOrdem.Select();
            }
            else
            {
                txtNivel.Text = defineNivel().ToString();
                txtCodigo.Text = modoTela == Util.ModoTela.Inserir ? proximoCodigoMenu().ToString() : txtCodigo.Text;
            }
        }
        private void cliqueBotaoCancelar()
        {
            limpaCamposNaTela();
            modoTela = Util.ModoTela.Inserir;
            defineModoTela();
        }
        private void cliqueBotaolFiltroMenu()
        {
            carregaDataGridFiltroMenu(dgvFiltroImplantacao, _SomenteVinculados: true);
        }
        private void cliqueBotaoTodosFiltro()
        {
            carregaDataGridFiltroMenu(dgvFiltroImplantacao);
        }
        private void cliqueBotaoPersistirArquivo()
        {
            if (modoTela == Util.ModoTela.Inserir)
            {
                MenuDinamico.persisteArquivo(arquivoMenu);
                Estilo.persisteArquivo(arquivoEstilos.FindAll(x => x.codigo != 0).OrderBy(x => x.codigo).ToList());
            }
            else if (modoTela == Util.ModoTela.Alterar)
            {
                exluirItemLista();
            }
        }
        private void validacaoFormularioAtributoCar()
        {
            if (txtCar.Text != "")
            {
                if (!chkFiltro.Checked)
                {
                    if (arquivoMenu.Exists(x => x.car != null && x.car.car.Trim().ToLower() == txtCar.Text.Trim().ToLower() && x.codigo != Convert.ToInt32(txtCodigo.Text)))
                    {
                        MessageBox.Show("Acesso direto já existente em outro item.", "Validação Formulário", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtCar.Select();
                    }
                }
            }
        }
        private void cliqueBotaoEstilo()
        {
            frm_Estilo _Estilo = new frm_Estilo();
            _Estilo.ShowDialog();
            if (_Estilo.DialogResult == DialogResult.OK)
            {
                arquivoEstilos = _Estilo.arquivoEstilos;
                carregaComboEstilo(arquivoEstilos, true);
            }
        }
        #endregion
        #region Funcionalidades de Ação
        private List<MenuDinamico> aplicaFiltroDataGridMenuDinamico()
        {
            // Aplica filtro de família
            List<MenuDinamico> filtrado = aplicaFiltroDataGridFamilia();

            // Aplica filtro de grupos
            filtrado = filtrado.FindAll
            (
                x => ((cmbFiltroGrupo.SelectedValue == null) ||
                      (!int.TryParse(cmbFiltroGrupo.SelectedValue.ToString(), out _)) ||
                      (cmbFiltroGrupo.SelectedValue.ToString() == "0") ||
                      (x.trincaPermissao != null && x.trincaPermissao.cdGrupo == Convert.ToInt32(cmbFiltroGrupo.SelectedValue.ToString())))
            );

            // Aplica filtro de serviços
            filtrado = filtrado.FindAll
            (
                x => ((cmbFiltroServico.SelectedValue == null) ||
                      (!int.TryParse(cmbFiltroServico.SelectedValue.ToString(), out _)) ||
                      (cmbFiltroServico.SelectedValue.ToString() == "0") ||
                      (x.trincaPermissao.cdServico != null && x.trincaPermissao.cdServico == Convert.ToInt32(cmbFiltroServico.SelectedValue.ToString())))
            );


            // Aplica filtro de filtros de implantação
            filtrado = filtrado.FindAll
            (
                menu => (cmbFiltroFiltroImplantacao.SelectedValue == null ||
                         !int.TryParse(cmbFiltroFiltroImplantacao.SelectedValue.ToString(), out _) ||
                         cmbFiltroFiltroImplantacao.SelectedValue.ToString() == "0") ||
                         !menu.filtros.Contains(null) &&
                         menu.filtros.Where(filtro => filtro.cdServicoImplt == Convert.ToInt32(cmbFiltroFiltroImplantacao.SelectedValue)).Any()
            );



            if (filtrado == null)
                return new List<MenuDinamico>();

            return filtrado.OrderBy(x => x.ordem).ToList();
        }
        private List<MenuDinamico> aplicaFiltroDataGridFamilia()
        {
            // Aplica filtro de família
            List<MenuDinamico> filtrado = arquivoMenu.FindAll
            (
                x => ((cmbFiltroFamilia.SelectedValue == null) ||
                     (!int.TryParse(cmbFiltroFamilia.SelectedValue.ToString(), out _)) ||
                     (cmbFiltroFamilia.SelectedValue.ToString() == "0") ||
                        ((x.codigo == Convert.ToInt32(cmbFiltroFamilia.SelectedValue.ToString())) ||
                            (x.codigoPai == Convert.ToInt32(cmbFiltroFamilia.SelectedValue.ToString()))))
            );


            if (filtrado == null)
                return new List<MenuDinamico>();

            return filtrado.OrderBy(x => x.ordem).ToList();
        }
        public void atualizaListaMenu(MenuDinamico menuDinamico)
        {
            for (int i = 0; i < arquivoMenu.Count; i++)
            {
                if (arquivoMenu[i].codigo == menuDinamico.codigo)
                    arquivoMenu[i] = menuDinamico;
            }
        }
        public MenuDinamico mapeiaAlteracoesAbaDetalhes(MenuDinamico menuDinamico, out StringBuilder _scriptIdaParcial, out StringBuilder _scriptVoltaParcial)
        {
            MenuDinamico retorno = menuDinamico;
            _scriptIdaParcial = new StringBuilder();
            _scriptVoltaParcial = new StringBuilder();

            retorno.codigo = Convert.ToInt32(txtCodigo.Text);
            retorno.ordem = txtOrdem.Text;
            retorno.nivel = Convert.ToInt32(txtNivel.Text);
            retorno.estilo = Convert.ToInt32(cmbEstilo.SelectedValue.ToString());

            if (Convert.ToInt32(cmbEstilo.SelectedValue.ToString()) == 0)
                retorno.estilo = null;

            retorno.nome = txtNome.Text;
            retorno.descricao = txtDescricao.Text;
            retorno.url = txtUrl.Text;
            retorno.coluna = Convert.ToInt32(cmbColuna.Text);
            retorno.liderSolicitante = txtLiderSolicitante.Text;

            if (retorno.ordem.Trim().Length <= 2)
                retorno.codigoPai = null;
            else
                retorno.codigoPai = arquivoMenu.Find
                (
                    x =>
                    ((retorno.nivel == 2 && x.ordem.Trim() == retorno.ordem.Trim().Substring(0, 2)) ||
                    (retorno.nivel > 2 && x.ordem.Trim() == retorno.ordem.Trim().Substring(0, 4)))
                ).codigo;

            return retorno;
        }
        public MenuDinamico mapeiaAlteracoesAbaPermissao(MenuDinamico menuDinamico)
        {
            MenuDinamico retorno = menuDinamico;

            retorno.tipoPermissao = cmbTipoPermissao.SelectedValue.ToString();
            retorno.trincaPermissao = null;
            if (cmbGrupo.SelectedValue != null && int.TryParse(cmbGrupo.SelectedValue.ToString(), out _) && cmbGrupo.SelectedValue.ToString() != "0")
            {
                retorno.trincaPermissao = new ServicoMenu();
                retorno.trincaPermissao.cdGrupo = Convert.ToInt32(cmbGrupo.SelectedValue);
                retorno.trincaPermissao.cdServico = null;
                retorno.trincaPermissao.cdOperacao = null;

                if (cmbServico.SelectedValue != null && int.TryParse(cmbServico.SelectedValue.ToString(), out _) && cmbServico.SelectedValue.ToString() != "0")
                    retorno.trincaPermissao.cdServico = Convert.ToInt32(cmbServico.SelectedValue);

                if (rdbAprovacao.Checked)
                    retorno.trincaPermissao.cdOperacao = 3;
                else if (rdbEntradaDeDados.Checked)
                    retorno.trincaPermissao.cdOperacao = 2;
                else if (rdbConsulta.Checked)
                    retorno.trincaPermissao.cdOperacao = 1;
            }

            return retorno;
        }
        public MenuDinamico mapeiaAlteracoesAbaContratos(MenuDinamico menuDinamico)
        {
            MenuDinamico retorno = menuDinamico;

            List<int?> contratos = new List<int?>();

            for (int i = 0; i < chkContratos.Items.Count; i++)
            {
                if (chkContratos.GetItemChecked(i))
                    contratos.Add((i + 1));
            }

            retorno.contratos = contratos.Count == 0 ? null : contratos;
            return retorno;
        }
        public MenuDinamico mapeiaAlteracoesAbaFiltros(MenuDinamico menuDinamico)
        {
            MenuDinamico retorno = menuDinamico;


            List<FiltroMenu> filtroMenus = new List<FiltroMenu>();
            foreach (DataGridViewRow row in dgvFiltroImplantacao.Rows)
            {
                if (row.Cells[2].Value.ToString().ToLower() == "true" || row.Cells[3].Value.ToString().ToLower() == "true")
                {
                    filtroMenus.Add
                    (
                        new FiltroMenu()
                        {
                            cdServicoImplt = Convert.ToInt32(row.Cells[0].Value.ToString()),
                            cdIndcdSelec = row.Cells[2].Value.ToString().ToLower() == "true" ? 1 : 0
                        }
                    );
                }
            }

            retorno.indicadorFiltro = chkFiltro.Checked ? 1 : 0;

            if (filtroMenus.Count == 0)
            {
                retorno.filtros = new List<FiltroMenu>();
                retorno.filtros.Add(null);
            }
            else
                retorno.filtros = filtroMenus;

            return retorno;
        }
        public MenuDinamico mapeiaAlteracoesAbaCar(MenuDinamico menuDinamico)
        {
            MenuDinamico retorno = menuDinamico;

            if (txtCar.Text == "")
            {
                retorno.car = null;
                return retorno;
            }

            retorno.car = new AcessoDireto()
            {
                car = txtCar.Text,
                descricao = txtCarDescricao.Text,
                palavra_chave = txtCarPalavraChave.Text
            };

            return retorno;
        }
        public MenuDinamico mapeiaAlteracoesAbaDadosComplementares(MenuDinamico menuDinamico)
        {

            int? tagCampanha = null;
            if (chkTagCampanha.Checked)
                tagCampanha = 1;

            MenuDinamico retorno = menuDinamico;
            retorno.tagCampanha = tagCampanha;
            retorno.ambiente = cmbAmbiente.SelectedIndex;

            return retorno;
        }
        private void reordenarListaMenu(MenuDinamico menuDinamico)
        {
            List<int> filhosAlterados = reordenarListaMenu(menuDinamico, _AtualizaDependentes: true);

            if (arquivoMenu.Exists(x => x.ordem.Trim() == menuDinamico.ordem.Trim() && x.codigo != menuDinamico.codigo))
            {
                if (MessageBox.Show("A alteração realizada surtirá conflitos de ordenação com outros itens.\n" +
                    "Deseja realizar a reordenação dos demais itens?",
                    "Reordenação de Menu Dinâmico",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Dictionary<int, MenuDinamico> menusOrdenados = new Dictionary<int, MenuDinamico>();
                    String ordem = menuDinamico.ordem;
                    int nivel = menuDinamico.nivel;
                    String ordem_condicao = ordem.Trim().Substring(0, (nivel - 1) * 2);

                    // garante a ordenação na lista
                    foreach (MenuDinamico menu in arquivoMenu.OrderBy(x => x.ordem).ToList().FindAll
                    (
                        x =>
                        x.codigo != menuDinamico.codigo &&
                        (x.ordem.Trim() == ordem.Trim() ||
                        (String.Compare(x.ordem.Trim(), ordem.Trim(), StringComparison.OrdinalIgnoreCase) >= 0 &&
                        x.nivel >= nivel &&
                        x.ordem.Trim().Substring(0, ((nivel - 1) * 2)) == ordem_condicao)) &&
                        !filhosAlterados.Contains(x.codigo)
                    ))
                    {
                        String parte1 = menu.ordem.Trim().Substring(0, (nivel * 2));
                        parte1 = (Convert.ToInt64(parte1) + 1).ToString().PadLeft((nivel * 2), '0');
                        String parte2 = menu.ordem.Trim().Length != parte1.Trim().Length ?
                                parte1 + menu.ordem.Trim().Substring(parte1.Trim().Length, menu.ordem.Trim().Length - parte1.Trim().Length) :
                                parte1;
                        menu.ordem = parte2;
                    }
                }
            }
        }
        private List<int> reordenarListaMenu(MenuDinamico menuDinamico, Boolean _AtualizaDependentes)
        {
            List<int> codigos = new List<int>();

            // verifica se tem filhos
            if (modoTela == Util.ModoTela.Alterar &&
                menuDinamico.ordem.Trim() != menuDinamicoTela.ordem.Trim() &&
                menuDinamico.nivel == menuDinamicoTela.nivel)
            {

                if (arquivoMenu.Exists(
                            x =>
                            x.nivel > menuDinamicoTela.nivel &&
                            x.ordem.Trim().Substring(0, (menuDinamicoTela.nivel * 2)) == menuDinamicoTela.ordem.Trim()))
                {
                    if (MessageBox.Show("Existem itens abaixo do item atualizado.\nDeseja atualizar os itens descendentes?",
                        "Alteração de Menu Dinâmico",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (MenuDinamico itemFilho in arquivoMenu.FindAll(
                            x =>
                            x.nivel > menuDinamicoTela.nivel &&
                            x.ordem.Trim().Substring(0, (menuDinamicoTela.nivel * 2)) == menuDinamicoTela.ordem.Trim()))
                        {
                            itemFilho.ordem = menuDinamico.ordem.Trim() +
                                itemFilho.ordem.Substring((menuDinamicoTela.nivel * 2), itemFilho.ordem.Trim().Length - (menuDinamicoTela.nivel * 2));
                            codigos.Add(itemFilho.codigo);
                        }
                    }
                }
            }

            return codigos;
        }
        private MenuDinamico iniciaMenuDinamicoAlterado(MenuDinamico menuDinamico)
        {
            MenuDinamico retorno = new MenuDinamico();

            retorno.codigo = menuDinamico.codigo;
            retorno.nome = menuDinamico.nome;
            retorno.descricao = menuDinamico.descricao;
            retorno.url = menuDinamico.url;
            retorno.nivel = menuDinamico.nivel;
            retorno.ordem = menuDinamico.ordem;
            retorno.coluna = menuDinamico.coluna;
            retorno.tipoPermissao = menuDinamico.tipoPermissao;
            retorno.codigoPai = menuDinamico.codigoPai;
            retorno.indicadorFiltro = menuDinamico.indicadorFiltro;
            retorno.estilo = menuDinamico.estilo;

            if (menuDinamico.car == null)
                retorno.car = null;
            else
                retorno.car = new AcessoDireto()
                {
                    car = menuDinamico.car.car,
                    descricao = menuDinamico.car.descricao,
                    palavra_chave = menuDinamico.car.palavra_chave
                };


            retorno.ambiente = menuDinamico.ambiente;
            retorno.tagCampanha = menuDinamico.tagCampanha;

            List<int?> contratos = new List<int?>();
            if (menuDinamico.contratos == null)
                contratos.Add(null);
            else
                foreach (int? contrato in menuDinamico.contratos)
                    contratos.Add(contrato);

            retorno.contratos = contratos;

            if (menuDinamico.trincaPermissao == null)
                retorno.trincaPermissao = null;
            else
                retorno.trincaPermissao = new ServicoMenu()
                {
                    cdGrupo = menuDinamico.trincaPermissao.cdGrupo,
                    cdServico = menuDinamico.trincaPermissao.cdServico,
                    cdOperacao = menuDinamico.trincaPermissao.cdOperacao
                };

            List<FiltroMenu> filtros = new List<FiltroMenu>();

            if (menuDinamico.filtros == null)
                filtros = null;
            else
                foreach (FiltroMenu filtro in menuDinamico.filtros)
                    filtros.Add(filtro);

            retorno.filtros = filtros;
            retorno.liderSolicitante = menuDinamico.liderSolicitante;

            return retorno;
        }
        private void cliqueBotaoSalvar()
        {
            MenuDinamico menuDinamico = new MenuDinamico();
            StringBuilder scriptIdaParcial;
            StringBuilder scriptVoltaParcial;

            // cria um novo objeto de menu dinamico para evitar conflitos de ponteiro
            menuDinamico = iniciaMenuDinamicoAlterado(menuDinamicoTela);

            menuDinamico = mapeiaAlteracoesAbaDetalhes(menuDinamico, out scriptIdaParcial, out scriptVoltaParcial);
            menuDinamico = mapeiaAlteracoesAbaPermissao(menuDinamico);
            menuDinamico = mapeiaAlteracoesAbaContratos(menuDinamico);
            menuDinamico = mapeiaAlteracoesAbaFiltros(menuDinamico);
            menuDinamico = mapeiaAlteracoesAbaCar(menuDinamico);
            menuDinamico = mapeiaAlteracoesAbaDadosComplementares(menuDinamico);

            try
            {
                menuDinamico.ValidaPreenchimentoClasse();
                reordenarListaMenu(menuDinamico);

                script_atualizacaoIda.AppendLine("UPDATE dbo.tMenuDnamc SET ");
                script_atualizacaoIda.Append(scriptIdaParcial);

                txtScriptIda.Text = script_atualizacaoIda.ToString();

                if (modoTela == Util.ModoTela.Alterar)
                {
                    preparaScriptAlteracoes(menuDinamico);
                    atualizaListaMenu(menuDinamico);
                    MessageBox.Show("Item atualizado com sucesso.", "Atualização de Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    modoTela = Util.ModoTela.Inserir;
                }
                else if (modoTela == Util.ModoTela.Inserir)
                {
                    incluiListMenu(menuDinamico);
                    MessageBox.Show("Item incluído com sucesso.", "Inclusão de Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (menuDinamico.nivel == 2)
                        carregaComboFamilia(menuDinamico.codigo);
                    else
                        carregaComboFamilia(menuDinamico.codigoPai);
                }

                carregaDataGridMenuDinamico();
                adicionaRegistroDataGrid();
                defineCoresDataGrid();
                dgvMenuDinamico.Refresh();

                defineModoTela();
                limpaCamposNaTela();
                posicionaItemGridMenu(menuDinamico.codigo);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show("ERR: " + ex.Message, "Validação de Preenchimento (Menu Dinâmico)", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR: " + ex.Message, "Exceção Genérica (Menu Dinâmico)", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        public void incluiListMenu(MenuDinamico menuDinamico)
        {
            arquivoMenu.Add(menuDinamico);
        }
        private void exluirItemLista()
        {
            for (int i = 0; i < arquivoMenu.Count; i++)
            {
                if (arquivoMenu[i].codigo == Convert.ToInt32(txtCodigo.Text))
                {
                    arquivoMenu.RemoveAt(i);
                    MessageBox.Show("Registro excluído com sucesso.", "Exclusão de Linha (Menu Dinâmico)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                }
            }

            modoTela = Util.ModoTela.Inserir;

            carregaComboFamilia(0);
            carregaDataGridMenuDinamico();
            adicionaRegistroDataGrid();
            defineCoresDataGrid();
            dgvMenuDinamico.Refresh();
            limpaCamposNaTela();
            defineModoTela();
            lblTotalItensListados.Text = dgvMenuDinamico.Rows.Count.ToString();

        }
        #endregion

        private System.Windows.Forms.ComboBox cmbFiltroFamilia;
        private System.Windows.Forms.DataGridView dgvMenuDinamico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrdem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpOperacao;
        private System.Windows.Forms.ComboBox cmbServico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoPermissao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCarPalavraChave;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCarDescricao;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.RadioButton rdbAprovacao;
        private System.Windows.Forms.RadioButton rdbEntradaDeDados;
        private System.Windows.Forms.RadioButton rdbConsulta;
        private System.Windows.Forms.CheckedListBox chkContratos;
        private System.Windows.Forms.DataGridView dgvFiltroImplantacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFiltroGrupo;
        private System.Windows.Forms.Label lblFiltroServico;
        private System.Windows.Forms.ComboBox cmbFiltroServico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFiltroFiltroImplantacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalItensListados;
        private System.Windows.Forms.ComboBox cmbEstilo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPersistirArquivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLiderSolicitante;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbAmbiente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkTagCampanha;
        private System.Windows.Forms.Button btnVinculadosFiltro;
        private System.Windows.Forms.Button btnTodosFiltro;
        private System.Windows.Forms.TextBox txtScriptIda;
        private System.Windows.Forms.TextBox txtScriptVolta;
        private System.Windows.Forms.CheckBox chkFiltro;
        private System.Windows.Forms.Button btnEstilo;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView dgvScriptGeral;
    }
}

