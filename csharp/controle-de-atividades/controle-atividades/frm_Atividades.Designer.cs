
namespace controle_atividades
{
    partial class frm_Atividades
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.txtPrevisao = new System.Windows.Forms.TextBox();
            this.lblPrevisao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalendarioInicio = new System.Windows.Forms.Button();
            this.btnCalendarioPrevisao = new System.Windows.Forms.Button();
            this.btnCalendarioFim = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Início";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fim";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(454, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(71, 31);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(454, 20);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescricao_KeyDown);
            // 
            // txtInicio
            // 
            this.txtInicio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInicio.Location = new System.Drawing.Point(71, 57);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.ReadOnly = true;
            this.txtInicio.Size = new System.Drawing.Size(144, 20);
            this.txtInicio.TabIndex = 6;
            this.txtInicio.TabStop = false;
            this.txtInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInicio_KeyDown);
            // 
            // txtFim
            // 
            this.txtFim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFim.Location = new System.Drawing.Point(353, 57);
            this.txtFim.Name = "txtFim";
            this.txtFim.ReadOnly = true;
            this.txtFim.Size = new System.Drawing.Size(138, 20);
            this.txtFim.TabIndex = 7;
            this.txtFim.TabStop = false;
            this.txtFim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFim_KeyDown);
            // 
            // txtPrevisao
            // 
            this.txtPrevisao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrevisao.Location = new System.Drawing.Point(71, 83);
            this.txtPrevisao.Name = "txtPrevisao";
            this.txtPrevisao.ReadOnly = true;
            this.txtPrevisao.Size = new System.Drawing.Size(144, 20);
            this.txtPrevisao.TabIndex = 9;
            this.txtPrevisao.TabStop = false;
            // 
            // lblPrevisao
            // 
            this.lblPrevisao.AutoSize = true;
            this.lblPrevisao.Location = new System.Drawing.Point(12, 86);
            this.lblPrevisao.Name = "lblPrevisao";
            this.lblPrevisao.Size = new System.Drawing.Size(48, 13);
            this.lblPrevisao.TabIndex = 8;
            this.lblPrevisao.Text = "Previsão";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(353, 83);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(62, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(429, 83);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(62, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalendarioInicio
            // 
            this.btnCalendarioInicio.Location = new System.Drawing.Point(225, 55);
            this.btnCalendarioInicio.Name = "btnCalendarioInicio";
            this.btnCalendarioInicio.Size = new System.Drawing.Size(28, 23);
            this.btnCalendarioInicio.TabIndex = 12;
            this.btnCalendarioInicio.Text = "...";
            this.btnCalendarioInicio.UseVisualStyleBackColor = true;
            this.btnCalendarioInicio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalendarioInicio_MouseClick);
            // 
            // btnCalendarioPrevisao
            // 
            this.btnCalendarioPrevisao.Location = new System.Drawing.Point(225, 81);
            this.btnCalendarioPrevisao.Name = "btnCalendarioPrevisao";
            this.btnCalendarioPrevisao.Size = new System.Drawing.Size(28, 23);
            this.btnCalendarioPrevisao.TabIndex = 13;
            this.btnCalendarioPrevisao.Text = "...";
            this.btnCalendarioPrevisao.UseVisualStyleBackColor = true;
            this.btnCalendarioPrevisao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalendarioPrevisao_MouseClick);
            // 
            // btnCalendarioFim
            // 
            this.btnCalendarioFim.Location = new System.Drawing.Point(497, 55);
            this.btnCalendarioFim.Name = "btnCalendarioFim";
            this.btnCalendarioFim.Size = new System.Drawing.Size(28, 23);
            this.btnCalendarioFim.TabIndex = 14;
            this.btnCalendarioFim.Text = "...";
            this.btnCalendarioFim.UseVisualStyleBackColor = true;
            this.btnCalendarioFim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalendarioFim_MouseClick);
            // 
            // frm_Atividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 109);
            this.Controls.Add(this.btnCalendarioFim);
            this.Controls.Add(this.btnCalendarioPrevisao);
            this.Controls.Add(this.btnCalendarioInicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtPrevisao);
            this.Controls.Add(this.lblPrevisao);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Atividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFim;
        private System.Windows.Forms.TextBox txtPrevisao;
        private System.Windows.Forms.Label lblPrevisao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalendarioInicio;
        private System.Windows.Forms.Button btnCalendarioPrevisao;
        private System.Windows.Forms.Button btnCalendarioFim;
    }
}