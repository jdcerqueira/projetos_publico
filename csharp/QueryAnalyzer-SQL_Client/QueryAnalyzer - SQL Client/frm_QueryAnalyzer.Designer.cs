
namespace QueryAnalyzer___SQL_Client
{
    partial class frm_QueryAnalyzer
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
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.cmbBaseDados = new System.Windows.Forms.ComboBox();
            this.dgvResultSet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(12, 36);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(776, 166);
            this.txtQuery.TabIndex = 2;
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuery_KeyDown);
            this.txtQuery.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtQuery_PreviewKeyDown);
            // 
            // cmbBaseDados
            // 
            this.cmbBaseDados.FormattingEnabled = true;
            this.cmbBaseDados.Items.AddRange(new object[] {
            "OFPJD000"});
            this.cmbBaseDados.Location = new System.Drawing.Point(13, 13);
            this.cmbBaseDados.Name = "cmbBaseDados";
            this.cmbBaseDados.Size = new System.Drawing.Size(177, 21);
            this.cmbBaseDados.TabIndex = 3;
            this.cmbBaseDados.TabStop = false;
            // 
            // dgvResultSet
            // 
            this.dgvResultSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultSet.Location = new System.Drawing.Point(13, 208);
            this.dgvResultSet.Name = "dgvResultSet";
            this.dgvResultSet.Size = new System.Drawing.Size(775, 230);
            this.dgvResultSet.TabIndex = 4;
            this.dgvResultSet.TabStop = false;
            // 
            // frm_QueryAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultSet);
            this.Controls.Add(this.cmbBaseDados);
            this.Controls.Add(this.txtQuery);
            this.Name = "frm_QueryAnalyzer";
            this.Text = "Query Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ComboBox cmbBaseDados;
        private System.Windows.Forms.DataGridView dgvResultSet;
    }
}

