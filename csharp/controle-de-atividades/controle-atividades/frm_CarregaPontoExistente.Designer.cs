
namespace controle_atividades
{
    partial class frm_CarregaPontoExistente
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnAlmoco = new System.Windows.Forms.Button();
            this.btnJanta = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnNovoPonto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(12, 9);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(698, 168);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "lblMensagem";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(103, 180);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(99, 55);
            this.btnEntrada.TabIndex = 1;
            this.btnEntrada.Text = "Restaurar Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnAlmoco
            // 
            this.btnAlmoco.Location = new System.Drawing.Point(208, 180);
            this.btnAlmoco.Name = "btnAlmoco";
            this.btnAlmoco.Size = new System.Drawing.Size(99, 55);
            this.btnAlmoco.TabIndex = 2;
            this.btnAlmoco.Text = "Restaurar Almoço";
            this.btnAlmoco.UseVisualStyleBackColor = true;
            this.btnAlmoco.Click += new System.EventHandler(this.btnAlmoco_Click);
            // 
            // btnJanta
            // 
            this.btnJanta.Location = new System.Drawing.Point(313, 180);
            this.btnJanta.Name = "btnJanta";
            this.btnJanta.Size = new System.Drawing.Size(99, 55);
            this.btnJanta.TabIndex = 3;
            this.btnJanta.Text = "Restaurar Janta";
            this.btnJanta.UseVisualStyleBackColor = true;
            this.btnJanta.Click += new System.EventHandler(this.btnJanta_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Location = new System.Drawing.Point(418, 180);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(99, 55);
            this.btnSaida.TabIndex = 4;
            this.btnSaida.Text = "Restaurar Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnNovoPonto
            // 
            this.btnNovoPonto.Location = new System.Drawing.Point(523, 180);
            this.btnNovoPonto.Name = "btnNovoPonto";
            this.btnNovoPonto.Size = new System.Drawing.Size(99, 55);
            this.btnNovoPonto.TabIndex = 5;
            this.btnNovoPonto.Text = "Gerar um novo ponto";
            this.btnNovoPonto.UseVisualStyleBackColor = true;
            this.btnNovoPonto.Click += new System.EventHandler(this.btnNovoPonto_Click);
            // 
            // frm_CarregaPontoExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 249);
            this.Controls.Add(this.btnNovoPonto);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnJanta);
            this.Controls.Add(this.btnAlmoco);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CarregaPontoExistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reaproveitamento de ponto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnAlmoco;
        private System.Windows.Forms.Button btnJanta;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnNovoPonto;
    }
}