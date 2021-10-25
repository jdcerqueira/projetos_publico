
namespace app_tabela_creighton
{
    partial class frm_Dia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnFluxoIntenso = new System.Windows.Forms.Button();
            this.grpMenstruacao = new System.Windows.Forms.GroupBox();
            this.btnFluxoLeve = new System.Windows.Forms.Button();
            this.btnFluxoModerado = new System.Windows.Forms.Button();
            this.btnFluxoMuitoLeve = new System.Windows.Forms.Button();
            this.grpSecrecao = new System.Windows.Forms.GroupBox();
            this.btnSecrecaoMolhado = new System.Windows.Forms.Button();
            this.btnSecrecaoUmido = new System.Windows.Forms.Button();
            this.btnSecrecaoBrilhante = new System.Windows.Forms.Button();
            this.btnSecrecaoSeco = new System.Windows.Forms.Button();
            this.grpMuco = new System.Windows.Forms.GroupBox();
            this.btnMucoDez = new System.Windows.Forms.Button();
            this.btnMucoOito = new System.Windows.Forms.Button();
            this.btnMucoSeis = new System.Windows.Forms.Button();
            this.btnCorAmarelo = new System.Windows.Forms.Button();
            this.btnCorTransparente = new System.Windows.Forms.Button();
            this.btnLubrificacao = new System.Windows.Forms.Button();
            this.btnCorBrancoTransparente = new System.Windows.Forms.Button();
            this.btnCorBranco = new System.Windows.Forms.Button();
            this.btnCorVermelho = new System.Windows.Forms.Button();
            this.btnConsistenciaGrudento = new System.Windows.Forms.Button();
            this.btnCorMarromPreto = new System.Windows.Forms.Button();
            this.btnConsistenciaPastosa = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.grpCor = new System.Windows.Forms.GroupBox();
            this.grpConsistencia = new System.Windows.Forms.GroupBox();
            this.grpLubrificacao = new System.Windows.Forms.GroupBox();
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.grpMenstruacao.SuspendLayout();
            this.grpSecrecao.SuspendLayout();
            this.grpMuco.SuspendLayout();
            this.grpCor.SuspendLayout();
            this.grpConsistencia.SuspendLayout();
            this.grpLubrificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(583, 38);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodigo.Size = new System.Drawing.Size(268, 107);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnFluxoIntenso
            // 
            this.btnFluxoIntenso.Location = new System.Drawing.Point(6, 19);
            this.btnFluxoIntenso.Name = "btnFluxoIntenso";
            this.btnFluxoIntenso.Size = new System.Drawing.Size(133, 23);
            this.btnFluxoIntenso.TabIndex = 2;
            this.btnFluxoIntenso.Text = "Fluxo Intenso";
            this.btnFluxoIntenso.UseVisualStyleBackColor = true;
            this.btnFluxoIntenso.Click += new System.EventHandler(this.btnMenstruacaoIntenso_Click);
            // 
            // grpMenstruacao
            // 
            this.grpMenstruacao.Controls.Add(this.btnFluxoLeve);
            this.grpMenstruacao.Controls.Add(this.btnFluxoModerado);
            this.grpMenstruacao.Controls.Add(this.btnFluxoMuitoLeve);
            this.grpMenstruacao.Controls.Add(this.btnFluxoIntenso);
            this.grpMenstruacao.Location = new System.Drawing.Point(12, 12);
            this.grpMenstruacao.Name = "grpMenstruacao";
            this.grpMenstruacao.Size = new System.Drawing.Size(565, 50);
            this.grpMenstruacao.TabIndex = 3;
            this.grpMenstruacao.TabStop = false;
            this.grpMenstruacao.Text = "Menstruação";
            // 
            // btnFluxoLeve
            // 
            this.btnFluxoLeve.Location = new System.Drawing.Point(284, 19);
            this.btnFluxoLeve.Name = "btnFluxoLeve";
            this.btnFluxoLeve.Size = new System.Drawing.Size(133, 23);
            this.btnFluxoLeve.TabIndex = 5;
            this.btnFluxoLeve.Text = "Fluxo Leve";
            this.btnFluxoLeve.UseVisualStyleBackColor = true;
            this.btnFluxoLeve.Click += new System.EventHandler(this.btnMenstruacaoLeve_Click);
            // 
            // btnFluxoModerado
            // 
            this.btnFluxoModerado.Location = new System.Drawing.Point(145, 19);
            this.btnFluxoModerado.Name = "btnFluxoModerado";
            this.btnFluxoModerado.Size = new System.Drawing.Size(133, 23);
            this.btnFluxoModerado.TabIndex = 5;
            this.btnFluxoModerado.Text = "Fluxo Moderado";
            this.btnFluxoModerado.UseVisualStyleBackColor = true;
            this.btnFluxoModerado.Click += new System.EventHandler(this.btnMenstruacaoModerado_Click);
            // 
            // btnFluxoMuitoLeve
            // 
            this.btnFluxoMuitoLeve.Location = new System.Drawing.Point(423, 19);
            this.btnFluxoMuitoLeve.Name = "btnFluxoMuitoLeve";
            this.btnFluxoMuitoLeve.Size = new System.Drawing.Size(133, 23);
            this.btnFluxoMuitoLeve.TabIndex = 3;
            this.btnFluxoMuitoLeve.Text = "Fluxo Muito Leve";
            this.btnFluxoMuitoLeve.UseVisualStyleBackColor = true;
            this.btnFluxoMuitoLeve.Click += new System.EventHandler(this.btnMenstruacaoMuitoLeve_Click);
            // 
            // grpSecrecao
            // 
            this.grpSecrecao.Controls.Add(this.btnSecrecaoMolhado);
            this.grpSecrecao.Controls.Add(this.btnSecrecaoUmido);
            this.grpSecrecao.Controls.Add(this.btnSecrecaoBrilhante);
            this.grpSecrecao.Controls.Add(this.btnSecrecaoSeco);
            this.grpSecrecao.Location = new System.Drawing.Point(12, 151);
            this.grpSecrecao.Name = "grpSecrecao";
            this.grpSecrecao.Size = new System.Drawing.Size(565, 50);
            this.grpSecrecao.TabIndex = 8;
            this.grpSecrecao.TabStop = false;
            this.grpSecrecao.Text = "Secreção";
            // 
            // btnSecrecaoMolhado
            // 
            this.btnSecrecaoMolhado.Location = new System.Drawing.Point(284, 19);
            this.btnSecrecaoMolhado.Name = "btnSecrecaoMolhado";
            this.btnSecrecaoMolhado.Size = new System.Drawing.Size(133, 23);
            this.btnSecrecaoMolhado.TabIndex = 5;
            this.btnSecrecaoMolhado.Text = "Molhado";
            this.btnSecrecaoMolhado.UseVisualStyleBackColor = true;
            this.btnSecrecaoMolhado.Click += new System.EventHandler(this.btnInfertilMolhado_Click);
            // 
            // btnSecrecaoUmido
            // 
            this.btnSecrecaoUmido.Location = new System.Drawing.Point(145, 19);
            this.btnSecrecaoUmido.Name = "btnSecrecaoUmido";
            this.btnSecrecaoUmido.Size = new System.Drawing.Size(133, 23);
            this.btnSecrecaoUmido.TabIndex = 5;
            this.btnSecrecaoUmido.Text = "Úmido";
            this.btnSecrecaoUmido.UseVisualStyleBackColor = true;
            this.btnSecrecaoUmido.Click += new System.EventHandler(this.btnInfertilUmido_Click);
            // 
            // btnSecrecaoBrilhante
            // 
            this.btnSecrecaoBrilhante.Location = new System.Drawing.Point(423, 19);
            this.btnSecrecaoBrilhante.Name = "btnSecrecaoBrilhante";
            this.btnSecrecaoBrilhante.Size = new System.Drawing.Size(133, 23);
            this.btnSecrecaoBrilhante.TabIndex = 3;
            this.btnSecrecaoBrilhante.Text = "Brilhante";
            this.btnSecrecaoBrilhante.UseVisualStyleBackColor = true;
            this.btnSecrecaoBrilhante.Click += new System.EventHandler(this.btnInfertilBrilhante_Click);
            // 
            // btnSecrecaoSeco
            // 
            this.btnSecrecaoSeco.Location = new System.Drawing.Point(6, 19);
            this.btnSecrecaoSeco.Name = "btnSecrecaoSeco";
            this.btnSecrecaoSeco.Size = new System.Drawing.Size(133, 23);
            this.btnSecrecaoSeco.TabIndex = 2;
            this.btnSecrecaoSeco.Text = "Seco";
            this.btnSecrecaoSeco.UseVisualStyleBackColor = true;
            this.btnSecrecaoSeco.Click += new System.EventHandler(this.btnInfertilSeco_Click);
            // 
            // grpMuco
            // 
            this.grpMuco.Controls.Add(this.btnMucoDez);
            this.grpMuco.Controls.Add(this.btnMucoOito);
            this.grpMuco.Controls.Add(this.btnMucoSeis);
            this.grpMuco.Location = new System.Drawing.Point(12, 207);
            this.grpMuco.Name = "grpMuco";
            this.grpMuco.Size = new System.Drawing.Size(565, 49);
            this.grpMuco.TabIndex = 9;
            this.grpMuco.TabStop = false;
            this.grpMuco.Text = "Muco";
            // 
            // btnMucoDez
            // 
            this.btnMucoDez.Location = new System.Drawing.Point(284, 19);
            this.btnMucoDez.Name = "btnMucoDez";
            this.btnMucoDez.Size = new System.Drawing.Size(133, 23);
            this.btnMucoDez.TabIndex = 5;
            this.btnMucoDez.Text = "acima de 2,5cm";
            this.btnMucoDez.UseVisualStyleBackColor = true;
            this.btnMucoDez.Click += new System.EventHandler(this.btnFertilDez_Click);
            // 
            // btnMucoOito
            // 
            this.btnMucoOito.Location = new System.Drawing.Point(145, 19);
            this.btnMucoOito.Name = "btnMucoOito";
            this.btnMucoOito.Size = new System.Drawing.Size(133, 23);
            this.btnMucoOito.TabIndex = 5;
            this.btnMucoOito.Text = "entre 1cm e 2cm";
            this.btnMucoOito.UseVisualStyleBackColor = true;
            this.btnMucoOito.Click += new System.EventHandler(this.btnFertilOito_Click);
            // 
            // btnMucoSeis
            // 
            this.btnMucoSeis.Location = new System.Drawing.Point(6, 19);
            this.btnMucoSeis.Name = "btnMucoSeis";
            this.btnMucoSeis.Size = new System.Drawing.Size(133, 23);
            this.btnMucoSeis.TabIndex = 2;
            this.btnMucoSeis.Text = "até 0,5 cm";
            this.btnMucoSeis.UseVisualStyleBackColor = true;
            this.btnMucoSeis.Click += new System.EventHandler(this.btnFertilSeis_Click);
            // 
            // btnCorAmarelo
            // 
            this.btnCorAmarelo.Location = new System.Drawing.Point(284, 19);
            this.btnCorAmarelo.Name = "btnCorAmarelo";
            this.btnCorAmarelo.Size = new System.Drawing.Size(133, 23);
            this.btnCorAmarelo.TabIndex = 11;
            this.btnCorAmarelo.Text = "Amarelo";
            this.btnCorAmarelo.UseVisualStyleBackColor = true;
            this.btnCorAmarelo.Click += new System.EventHandler(this.btnFertilAmarelo_Click);
            // 
            // btnCorTransparente
            // 
            this.btnCorTransparente.Location = new System.Drawing.Point(284, 48);
            this.btnCorTransparente.Name = "btnCorTransparente";
            this.btnCorTransparente.Size = new System.Drawing.Size(133, 23);
            this.btnCorTransparente.TabIndex = 12;
            this.btnCorTransparente.Text = "Transparente";
            this.btnCorTransparente.UseVisualStyleBackColor = true;
            this.btnCorTransparente.Click += new System.EventHandler(this.btnFertilTransparente_Click);
            // 
            // btnLubrificacao
            // 
            this.btnLubrificacao.Location = new System.Drawing.Point(6, 19);
            this.btnLubrificacao.Name = "btnLubrificacao";
            this.btnLubrificacao.Size = new System.Drawing.Size(133, 23);
            this.btnLubrificacao.TabIndex = 9;
            this.btnLubrificacao.Text = "Lubrificação";
            this.btnLubrificacao.UseVisualStyleBackColor = true;
            this.btnLubrificacao.Click += new System.EventHandler(this.btnFertilLubrificacao_Click);
            // 
            // btnCorBrancoTransparente
            // 
            this.btnCorBrancoTransparente.Location = new System.Drawing.Point(145, 48);
            this.btnCorBrancoTransparente.Name = "btnCorBrancoTransparente";
            this.btnCorBrancoTransparente.Size = new System.Drawing.Size(133, 23);
            this.btnCorBrancoTransparente.TabIndex = 8;
            this.btnCorBrancoTransparente.Text = "Branco \\ Transparente";
            this.btnCorBrancoTransparente.UseVisualStyleBackColor = true;
            this.btnCorBrancoTransparente.Click += new System.EventHandler(this.btnFertilBrancoTransparente_Click);
            // 
            // btnCorBranco
            // 
            this.btnCorBranco.Location = new System.Drawing.Point(6, 48);
            this.btnCorBranco.Name = "btnCorBranco";
            this.btnCorBranco.Size = new System.Drawing.Size(133, 23);
            this.btnCorBranco.TabIndex = 7;
            this.btnCorBranco.Text = "Branco";
            this.btnCorBranco.UseVisualStyleBackColor = true;
            this.btnCorBranco.Click += new System.EventHandler(this.btnFertilBranco_Click);
            // 
            // btnCorVermelho
            // 
            this.btnCorVermelho.Location = new System.Drawing.Point(145, 19);
            this.btnCorVermelho.Name = "btnCorVermelho";
            this.btnCorVermelho.Size = new System.Drawing.Size(133, 23);
            this.btnCorVermelho.TabIndex = 7;
            this.btnCorVermelho.Text = "Vermelho";
            this.btnCorVermelho.UseVisualStyleBackColor = true;
            this.btnCorVermelho.Click += new System.EventHandler(this.btnFertilVermelho_Click);
            // 
            // btnConsistenciaGrudento
            // 
            this.btnConsistenciaGrudento.Location = new System.Drawing.Point(145, 19);
            this.btnConsistenciaGrudento.Name = "btnConsistenciaGrudento";
            this.btnConsistenciaGrudento.Size = new System.Drawing.Size(133, 23);
            this.btnConsistenciaGrudento.TabIndex = 6;
            this.btnConsistenciaGrudento.Text = "Consistência Grudento";
            this.btnConsistenciaGrudento.UseVisualStyleBackColor = true;
            this.btnConsistenciaGrudento.Click += new System.EventHandler(this.btnFertilGrudento_Click);
            // 
            // btnCorMarromPreto
            // 
            this.btnCorMarromPreto.Location = new System.Drawing.Point(6, 19);
            this.btnCorMarromPreto.Name = "btnCorMarromPreto";
            this.btnCorMarromPreto.Size = new System.Drawing.Size(133, 23);
            this.btnCorMarromPreto.TabIndex = 4;
            this.btnCorMarromPreto.Text = "Marrom ou Preto";
            this.btnCorMarromPreto.UseVisualStyleBackColor = true;
            this.btnCorMarromPreto.Click += new System.EventHandler(this.btnFertilMarromPreto_Click);
            // 
            // btnConsistenciaPastosa
            // 
            this.btnConsistenciaPastosa.Location = new System.Drawing.Point(6, 19);
            this.btnConsistenciaPastosa.Name = "btnConsistenciaPastosa";
            this.btnConsistenciaPastosa.Size = new System.Drawing.Size(133, 23);
            this.btnConsistenciaPastosa.TabIndex = 3;
            this.btnConsistenciaPastosa.Text = "Consistência Pastosa";
            this.btnConsistenciaPastosa.UseVisualStyleBackColor = true;
            this.btnConsistenciaPastosa.Click += new System.EventHandler(this.btnFertilPastosa_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(729, 9);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(122, 23);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar Código";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // grpCor
            // 
            this.grpCor.Controls.Add(this.btnCorMarromPreto);
            this.grpCor.Controls.Add(this.btnCorVermelho);
            this.grpCor.Controls.Add(this.btnCorTransparente);
            this.grpCor.Controls.Add(this.btnCorAmarelo);
            this.grpCor.Controls.Add(this.btnCorBranco);
            this.grpCor.Controls.Add(this.btnCorBrancoTransparente);
            this.grpCor.Location = new System.Drawing.Point(12, 68);
            this.grpCor.Name = "grpCor";
            this.grpCor.Size = new System.Drawing.Size(565, 77);
            this.grpCor.TabIndex = 9;
            this.grpCor.TabStop = false;
            this.grpCor.Text = "Cores";
            // 
            // grpConsistencia
            // 
            this.grpConsistencia.Controls.Add(this.btnConsistenciaPastosa);
            this.grpConsistencia.Controls.Add(this.btnConsistenciaGrudento);
            this.grpConsistencia.Location = new System.Drawing.Point(12, 262);
            this.grpConsistencia.Name = "grpConsistencia";
            this.grpConsistencia.Size = new System.Drawing.Size(287, 49);
            this.grpConsistencia.TabIndex = 10;
            this.grpConsistencia.TabStop = false;
            this.grpConsistencia.Text = "Consistência";
            // 
            // grpLubrificacao
            // 
            this.grpLubrificacao.Controls.Add(this.btnLubrificacao);
            this.grpLubrificacao.Location = new System.Drawing.Point(305, 262);
            this.grpLubrificacao.Name = "grpLubrificacao";
            this.grpLubrificacao.Size = new System.Drawing.Size(272, 49);
            this.grpLubrificacao.TabIndex = 11;
            this.grpLubrificacao.TabStop = false;
            this.grpLubrificacao.Text = "Consistência";
            // 
            // dgvTabela
            // 
            this.dgvTabela.AllowUserToAddRows = false;
            this.dgvTabela.AllowUserToDeleteRows = false;
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Location = new System.Drawing.Point(584, 152);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.ReadOnly = true;
            this.dgvTabela.RowHeadersWidth = 10;
            this.dgvTabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabela.Size = new System.Drawing.Size(267, 159);
            this.dgvTabela.TabIndex = 12;
            // 
            // frm_Dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 321);
            this.Controls.Add(this.dgvTabela);
            this.Controls.Add(this.grpLubrificacao);
            this.Controls.Add(this.grpConsistencia);
            this.Controls.Add(this.grpCor);
            this.Controls.Add(this.grpMuco);
            this.Controls.Add(this.grpSecrecao);
            this.Controls.Add(this.grpMenstruacao);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Dia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão de Código";
            this.grpMenstruacao.ResumeLayout(false);
            this.grpSecrecao.ResumeLayout(false);
            this.grpMuco.ResumeLayout(false);
            this.grpCor.ResumeLayout(false);
            this.grpConsistencia.ResumeLayout(false);
            this.grpLubrificacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnFluxoIntenso;
        private System.Windows.Forms.GroupBox grpMenstruacao;
        private System.Windows.Forms.Button btnFluxoLeve;
        private System.Windows.Forms.Button btnFluxoModerado;
        private System.Windows.Forms.Button btnFluxoMuitoLeve;
        private System.Windows.Forms.GroupBox grpSecrecao;
        private System.Windows.Forms.Button btnSecrecaoMolhado;
        private System.Windows.Forms.Button btnSecrecaoUmido;
        private System.Windows.Forms.Button btnSecrecaoBrilhante;
        private System.Windows.Forms.Button btnSecrecaoSeco;
        private System.Windows.Forms.GroupBox grpMuco;
        private System.Windows.Forms.Button btnCorBranco;
        private System.Windows.Forms.Button btnCorVermelho;
        private System.Windows.Forms.Button btnConsistenciaGrudento;
        private System.Windows.Forms.Button btnMucoDez;
        private System.Windows.Forms.Button btnMucoOito;
        private System.Windows.Forms.Button btnCorMarromPreto;
        private System.Windows.Forms.Button btnConsistenciaPastosa;
        private System.Windows.Forms.Button btnMucoSeis;
        private System.Windows.Forms.Button btnCorAmarelo;
        private System.Windows.Forms.Button btnCorTransparente;
        private System.Windows.Forms.Button btnLubrificacao;
        private System.Windows.Forms.Button btnCorBrancoTransparente;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.GroupBox grpCor;
        private System.Windows.Forms.GroupBox grpConsistencia;
        private System.Windows.Forms.GroupBox grpLubrificacao;
        private System.Windows.Forms.DataGridView dgvTabela;
    }
}