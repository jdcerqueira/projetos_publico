
namespace ibpjchupacabra.Listagem
{
    partial class frm_ChaveAcesso
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
            this.dgvChaveAcesso = new System.Windows.Forms.DataGridView();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaveAcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChaveAcesso
            // 
            this.dgvChaveAcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChaveAcesso.Location = new System.Drawing.Point(12, 35);
            this.dgvChaveAcesso.Name = "dgvChaveAcesso";
            this.dgvChaveAcesso.Size = new System.Drawing.Size(776, 291);
            this.dgvChaveAcesso.TabIndex = 0;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(13, 13);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(35, 13);
            this.lblTotalRegistros.TabIndex = 1;
            this.lblTotalRegistros.Text = "label1";
            // 
            // frm_ChaveAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.dgvChaveAcesso);
            this.Name = "frm_ChaveAcesso";
            this.Text = "Listagem de Chaves de Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaveAcesso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChaveAcesso;
        private System.Windows.Forms.Label lblTotalRegistros;
    }
}