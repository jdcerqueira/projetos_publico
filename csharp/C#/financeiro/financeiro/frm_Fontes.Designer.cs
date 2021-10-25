
namespace financeiro
{
    partial class frm_Fontes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDiaFechamento = new System.Windows.Forms.TextBox();
            this.lblFechamento = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalendarioFechamento = new System.Windows.Forms.Button();
            this.lblFonteDestino = new System.Windows.Forms.Label();
            this.cmbFonteDestino = new System.Windows.Forms.ComboBox();
            this.btnCalendarioFatura = new System.Windows.Forms.Button();
            this.txtDiaFatura = new System.Windows.Forms.TextBox();
            this.lblDiaFatura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtDiaFechamento
            // 
            this.txtDiaFechamento.Location = new System.Drawing.Point(84, 59);
            this.txtDiaFechamento.Name = "txtDiaFechamento";
            this.txtDiaFechamento.ReadOnly = true;
            this.txtDiaFechamento.Size = new System.Drawing.Size(126, 20);
            this.txtDiaFechamento.TabIndex = 3;
            this.txtDiaFechamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFechamento
            // 
            this.lblFechamento.AutoSize = true;
            this.lblFechamento.Location = new System.Drawing.Point(12, 62);
            this.lblFechamento.Name = "lblFechamento";
            this.lblFechamento.Size = new System.Drawing.Size(66, 13);
            this.lblFechamento.TabIndex = 2;
            this.lblFechamento.Text = "Fechamento";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Cartão de Crédito",
            "Vale Refeição",
            "Vale Alimentação",
            "Conta-Corrente",
            "Conta-Poupança"});
            this.cmbTipo.Location = new System.Drawing.Point(84, 32);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(156, 21);
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(84, 138);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(165, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalendarioFechamento
            // 
            this.btnCalendarioFechamento.Location = new System.Drawing.Point(215, 57);
            this.btnCalendarioFechamento.Name = "btnCalendarioFechamento";
            this.btnCalendarioFechamento.Size = new System.Drawing.Size(25, 23);
            this.btnCalendarioFechamento.TabIndex = 8;
            this.btnCalendarioFechamento.Text = "...";
            this.btnCalendarioFechamento.UseVisualStyleBackColor = true;
            this.btnCalendarioFechamento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalendario_MouseClick);
            // 
            // lblFonteDestino
            // 
            this.lblFonteDestino.AutoSize = true;
            this.lblFonteDestino.Location = new System.Drawing.Point(12, 114);
            this.lblFonteDestino.Name = "lblFonteDestino";
            this.lblFonteDestino.Size = new System.Drawing.Size(66, 13);
            this.lblFonteDestino.TabIndex = 9;
            this.lblFonteDestino.Text = "Despesa em";
            // 
            // cmbFonteDestino
            // 
            this.cmbFonteDestino.FormattingEnabled = true;
            this.cmbFonteDestino.Location = new System.Drawing.Point(84, 111);
            this.cmbFonteDestino.Name = "cmbFonteDestino";
            this.cmbFonteDestino.Size = new System.Drawing.Size(156, 21);
            this.cmbFonteDestino.TabIndex = 10;
            // 
            // btnCalendarioFatura
            // 
            this.btnCalendarioFatura.Location = new System.Drawing.Point(215, 83);
            this.btnCalendarioFatura.Name = "btnCalendarioFatura";
            this.btnCalendarioFatura.Size = new System.Drawing.Size(25, 23);
            this.btnCalendarioFatura.TabIndex = 13;
            this.btnCalendarioFatura.Text = "...";
            this.btnCalendarioFatura.UseVisualStyleBackColor = true;
            this.btnCalendarioFatura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalendarioFatura_MouseClick);
            // 
            // txtDiaFatura
            // 
            this.txtDiaFatura.Location = new System.Drawing.Point(84, 85);
            this.txtDiaFatura.Name = "txtDiaFatura";
            this.txtDiaFatura.ReadOnly = true;
            this.txtDiaFatura.Size = new System.Drawing.Size(126, 20);
            this.txtDiaFatura.TabIndex = 12;
            this.txtDiaFatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiaFatura
            // 
            this.lblDiaFatura.AutoSize = true;
            this.lblDiaFatura.Location = new System.Drawing.Point(12, 88);
            this.lblDiaFatura.Name = "lblDiaFatura";
            this.lblDiaFatura.Size = new System.Drawing.Size(37, 13);
            this.lblDiaFatura.TabIndex = 11;
            this.lblDiaFatura.Text = "Fatura";
            // 
            // frm_Fontes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 166);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalendarioFatura);
            this.Controls.Add(this.txtDiaFatura);
            this.Controls.Add(this.lblDiaFatura);
            this.Controls.Add(this.cmbFonteDestino);
            this.Controls.Add(this.lblFonteDestino);
            this.Controls.Add(this.btnCalendarioFechamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtDiaFechamento);
            this.Controls.Add(this.lblFechamento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Fontes";
            this.Text = "Cadastro de Fontes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDiaFechamento;
        private System.Windows.Forms.Label lblFechamento;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalendarioFechamento;
        private System.Windows.Forms.Label lblFonteDestino;
        private System.Windows.Forms.ComboBox cmbFonteDestino;
        private System.Windows.Forms.Button btnCalendarioFatura;
        private System.Windows.Forms.TextBox txtDiaFatura;
        private System.Windows.Forms.Label lblDiaFatura;
    }
}