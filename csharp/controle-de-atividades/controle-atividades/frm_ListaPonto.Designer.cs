
using controle_atividades_negocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace controle_atividades
{
    partial class frm_ListaPonto
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


        private void preparaDataGridPontos()
        {
            dgvPontos.Rows.Clear();
            dgvPontos.ColumnCount = 9;
            dgvPontos.AllowUserToAddRows = false;
            dgvPontos.ReadOnly = true;

            dgvPontos.Columns[0].Name = "Dia";
            dgvPontos.Columns[1].Name = "Entrada";
            dgvPontos.Columns[2].Name = "Almoco_Ini";
            dgvPontos.Columns[3].Name = "Almoco_Fim";
            dgvPontos.Columns[4].Name = "Janta_Ini";
            dgvPontos.Columns[5].Name = "Janta_Fim";
            dgvPontos.Columns[6].Name = "Saida";
            dgvPontos.Columns[7].Name = "Saldo_Horas";
            dgvPontos.Columns[8].Name = "Horas_Extras";

            dgvPontos.Columns["Dia"].HeaderText = "Dia";
            dgvPontos.Columns["Entrada"].HeaderText = "Entrada";
            dgvPontos.Columns["Almoco_Ini"].HeaderText = "Almoço Início";
            dgvPontos.Columns["Almoco_Fim"].HeaderText = "Almoço Fim";
            dgvPontos.Columns["Janta_Ini"].HeaderText = "Janta Inicio";
            dgvPontos.Columns["Janta_Fim"].HeaderText = "Janta Fim";
            dgvPontos.Columns["Saida"].HeaderText = "Saída";
            dgvPontos.Columns["Saldo_Horas"].HeaderText = "Saldo de Horas";
            dgvPontos.Columns["Horas_Extras"].HeaderText = "Horas Extras";
        }

        private void preparaDataGridAtividades()
        {
            dgvAtividades.Rows.Clear();
            dgvAtividades.ColumnCount = 6;
            dgvAtividades.AllowUserToAddRows = false;
            dgvAtividades.ReadOnly = true;

            //dgvAtividades.DefaultCellStyle.SelectionBackColor = Color.White;
            //dgvAtividades.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvAtividades.Columns[0].Name = "Nome";
            dgvAtividades.Columns[1].Name = "Descricao";
            dgvAtividades.Columns[2].Name = "Inicio";
            dgvAtividades.Columns[3].Name = "Fim";
            dgvAtividades.Columns[4].Name = "Previsao";
            dgvAtividades.Columns[5].Name = "Status";

            dgvAtividades.Columns["Nome"].HeaderText = "Nome";
            dgvAtividades.Columns["Descricao"].HeaderText = "Descrição";
            dgvAtividades.Columns["Inicio"].HeaderText = "Início";
            dgvAtividades.Columns["Fim"].HeaderText = "Fim";
            dgvAtividades.Columns["Previsao"].HeaderText = "Previsão";
            dgvAtividades.Columns["Status"].HeaderText = "Status";

            dgvAtividades.Columns["Status"].Visible = false;
        }

        private void aplicaMes(String mes, String ano)
        {
            dgvPontos.Rows.Clear();
            for (int dia = 1; dia <= DateTime.DaysInMonth(Convert.ToInt32(ano), Convert.ToInt32(mes)); dia++)
            {
                dgvPontos.Rows.Add(dia.ToString("d02"));
            }
            dgvPontos.Refresh();
        }

        private void atualizaGridPontos(DateTime DataSelecionada)
        {
            foreach (DataGridViewRow row in dgvPontos.Rows)
            {
                for (int coluna = 0; coluna < dgvPontos.Columns.Count; coluna++)
                {
                    row.Cells[coluna].Style.BackColor = Color.LightPink;

                    if (coluna != 0)
                        row.Cells[coluna].Value = "-";

                    row.Cells[coluna].Style.Font = new Font(Font, FontStyle.Bold);
                }


                DateTime data = DateTime.Parse(row.Cells["Dia"].Value.ToString() + "-" + this.mes + "-" + this.ano).Date;
                if (listaPontos.Exists(x => Util.StringToDatetime(x.Expediente.inicio).Date == data))
                {
                    Ponto ponto = listaPontos.Find(x => Util.StringToDatetime(x.Expediente.inicio).Date == data);

                    row.Cells["Entrada"].Value = Util.StringToDatetime(ponto.Expediente.inicio).TimeOfDay.ToString();

                    if (ponto.Almoco.fim != "")
                    {
                        row.Cells["Almoco_Ini"].Value = Util.StringToDatetime(ponto.Almoco.inicio).TimeOfDay.ToString();
                        row.Cells["Almoco_Fim"].Value = Util.StringToDatetime(ponto.Almoco.fim).TimeOfDay.ToString();
                    }

                    if (ponto.Janta.fim != "")
                    {
                        row.Cells["Janta_Ini"].Value = Util.StringToDatetime(ponto.Janta.inicio).TimeOfDay.ToString();
                        row.Cells["Janta_Fim"].Value = Util.StringToDatetime(ponto.Janta.fim).TimeOfDay.ToString();
                    }

                    row.Cells["Saida"].Value = Util.StringToDatetime(ponto.Expediente.fim).TimeOfDay.ToString();
                    row.Cells["Saldo_Horas"].Value = ponto.SaldoHoras;
                    row.Cells["Horas_Extras"].Value = ponto.HorasExtras;

                    if (ponto.HorasExtras != "00:00:00")
                        for (int coluna = 0; coluna < dgvPontos.Columns.Count; coluna++)
                            row.Cells[coluna].Style.BackColor = Color.LightGreen;
                    else if (ponto.HorasExtras == "00:00:00")
                        for (int coluna = 0; coluna < dgvPontos.Columns.Count; coluna++)
                            row.Cells[coluna].Style.BackColor = Color.LightGoldenrodYellow;
                }
            }
        }

        private void posicionaDia(DateTime DataSelecionada)
        {
            foreach (DataGridViewRow row in dgvPontos.Rows)
            {
                row.Selected = false;
                if (row.Cells["Dia"].Value.ToString() == DataSelecionada.Day.ToString())
                {
                    row.Selected = true;
                    dgvPontos.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void preencheAtividades(String DataSelecionada)
        {
            Ponto pontoAtual = listaPontos.Find(x => Util.StringToDatetime(x.Expediente.inicio).Date.ToString() == DataSelecionada);
            if (pontoAtual != null)
            {
                foreach (Atividades atividade in pontoAtual.Atividades)
                {
                    dgvAtividades.Rows.Add
                    (
                        atividade.Nome,
                        atividade.Descricao,
                        atividade.Atuacao.inicio,
                        atividade.status ? atividade.Atuacao.fim : "",
                        atividade.previsao,
                        atividade.status.ToString().ToLower()
                    );
                }
            }

            // Aplica as cores de legenda
            foreach (DataGridViewRow row in dgvAtividades.Rows)
            {
                bool status = row.Cells["Status"].Value.ToString().ToLower() == "true";
                DateTime? inicio = null;
                DateTime? fim = null;
                DateTime? previsao = null;

                if (row.Cells["Fim"].Value.ToString() != "")
                    fim = Util.StringToDatetime(row.Cells["Fim"].Value.ToString());

                if (row.Cells["Previsao"].Value != null && row.Cells["Previsao"].Value.ToString() != "")
                    previsao = Util.StringToDatetime(row.Cells["Previsao"].Value.ToString());

                if (row.Cells["Inicio"].Value != null && row.Cells["Inicio"].Value.ToString() != "")
                {
                    inicio = Util.StringToDatetime(row.Cells["Inicio"].Value.ToString());
                }
                    
                //Pendente
                row.Cells[0].Style.BackColor = Color.LightSteelBlue;
                row.Cells[0].Style.SelectionBackColor = Color.LightSteelBlue;
                row.Cells[0].Style.SelectionForeColor = Color.Black;


                if (inicio == null)
                {
                    // Atividade não iniciada
                    row.Cells[0].Style.BackColor = Color.PaleGoldenrod;
                    row.Cells[0].Style.SelectionBackColor = Color.PaleGoldenrod;
                    row.Cells[0].Style.SelectionForeColor = Color.Black;
                }

                if (status)
                {
                    // Atividade encerrada
                    row.Cells[0].Style.BackColor = Color.Lime;
                    row.Cells[0].Style.SelectionBackColor = Color.Lime;
                    row.Cells[0].Style.SelectionForeColor = Color.Black;
                }
                else if (previsao != null)
                {
                    if (previsao < dtHrAtual)
                    {
                        // Vencida
                        row.Cells[0].Style.BackColor = Color.Crimson;
                        row.Cells[0].Style.SelectionBackColor = Color.Crimson;
                        row.Cells[0].Style.SelectionForeColor = Color.White;
                    }
                    else if (Util.StringToDatetime(previsao.ToString()).Date == dtHrAtual.Date)
                    {
                        // Para vencer (ou seja, vence no dia atual)
                        row.Cells[0].Style.BackColor = Color.Pink;
                        row.Cells[0].Style.SelectionBackColor = Color.Pink;
                        row.Cells[0].Style.SelectionForeColor = Color.Black;
                    }
                }
            }

            dgvAtividades.Refresh();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPontos = new System.Windows.Forms.DataGridView();
            this.txtDataSelecionada = new System.Windows.Forms.TextBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.dgvAtividades = new System.Windows.Forms.DataGridView();
            this.pnlLegendaAtividades = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorLegendaVencida = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).BeginInit();
            this.pnlLegendaAtividades.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPontos
            // 
            this.dgvPontos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPontos.Location = new System.Drawing.Point(18, 42);
            this.dgvPontos.MultiSelect = false;
            this.dgvPontos.Name = "dgvPontos";
            this.dgvPontos.ReadOnly = true;
            this.dgvPontos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPontos.Size = new System.Drawing.Size(770, 192);
            this.dgvPontos.TabIndex = 1;
            this.dgvPontos.SelectionChanged += new System.EventHandler(this.dgvPontos_SelectionChanged);
            // 
            // txtDataSelecionada
            // 
            this.txtDataSelecionada.Location = new System.Drawing.Point(18, 15);
            this.txtDataSelecionada.Name = "txtDataSelecionada";
            this.txtDataSelecionada.ReadOnly = true;
            this.txtDataSelecionada.Size = new System.Drawing.Size(138, 20);
            this.txtDataSelecionada.TabIndex = 2;
            this.txtDataSelecionada.TabStop = false;
            this.txtDataSelecionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Location = new System.Drawing.Point(162, 13);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(33, 23);
            this.btnCalendario.TabIndex = 3;
            this.btnCalendario.Text = "...";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalendario_MouseClick);
            // 
            // dgvAtividades
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAtividades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAtividades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtividades.Location = new System.Drawing.Point(18, 240);
            this.dgvAtividades.MultiSelect = false;
            this.dgvAtividades.Name = "dgvAtividades";
            this.dgvAtividades.ReadOnly = true;
            this.dgvAtividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtividades.Size = new System.Drawing.Size(770, 192);
            this.dgvAtividades.TabIndex = 4;
            // 
            // pnlLegendaAtividades
            // 
            this.pnlLegendaAtividades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLegendaAtividades.Controls.Add(this.label8);
            this.pnlLegendaAtividades.Controls.Add(this.label9);
            this.pnlLegendaAtividades.Controls.Add(this.label7);
            this.pnlLegendaAtividades.Controls.Add(this.label5);
            this.pnlLegendaAtividades.Controls.Add(this.label4);
            this.pnlLegendaAtividades.Controls.Add(this.label6);
            this.pnlLegendaAtividades.Controls.Add(this.label3);
            this.pnlLegendaAtividades.Controls.Add(this.label2);
            this.pnlLegendaAtividades.Controls.Add(this.label1);
            this.pnlLegendaAtividades.Controls.Add(this.lblCorLegendaVencida);
            this.pnlLegendaAtividades.Location = new System.Drawing.Point(18, 438);
            this.pnlLegendaAtividades.Name = "pnlLegendaAtividades";
            this.pnlLegendaAtividades.Size = new System.Drawing.Size(770, 30);
            this.pnlLegendaAtividades.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pendente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Encerrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vencida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Para vencer";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(453, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 21);
            this.label3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(322, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(168, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 1;
            // 
            // lblCorLegendaVencida
            // 
            this.lblCorLegendaVencida.BackColor = System.Drawing.Color.Pink;
            this.lblCorLegendaVencida.Location = new System.Drawing.Point(9, 5);
            this.lblCorLegendaVencida.Name = "lblCorLegendaVencida";
            this.lblCorLegendaVencida.Size = new System.Drawing.Size(22, 21);
            this.lblCorLegendaVencida.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Não iniciada";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label9.Location = new System.Drawing.Point(564, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 21);
            this.label9.TabIndex = 10;
            // 
            // frm_ListaPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.pnlLegendaAtividades);
            this.Controls.Add(this.dgvAtividades);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.txtDataSelecionada);
            this.Controls.Add(this.dgvPontos);
            this.Name = "frm_ListaPonto";
            this.Text = "Lista de Batidas e Atividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPontos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).EndInit();
            this.pnlLegendaAtividades.ResumeLayout(false);
            this.pnlLegendaAtividades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPontos;
        private System.Windows.Forms.TextBox txtDataSelecionada;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.DataGridView dgvAtividades;
        private System.Windows.Forms.Panel pnlLegendaAtividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorLegendaVencida;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label9;
    }
}