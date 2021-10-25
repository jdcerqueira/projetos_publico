
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace financeiro
{
    partial class frm_Lancamentos
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
        /// 

        private void valoresDefault()
        {
            DateTime DataSelecionada = DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            lblListagem.Text = "Listagem de " + DataSelecionada.Month.ToString("d02") + " / " + DataSelecionada.Year.ToString("d04");

            mskValor.Mask = @"$9999999.00";
            mskValor.FormatProvider = CultureInfo.CurrentCulture;

            txtDescricao.Text = "";
            txtMotivo.Text = "";
            txtResponsavel.Text = "";
            mskValor.Text = "";
            chkFixa.Checked = false;
            chkQuitado.Checked = false;
            rdbDespesa.Checked = false;
            rdbReceita.Checked = false;

            cmbParcelas.Items.Clear();
            for (int item = 1; item <= Util.Constantes.totalParcelas; item++)
            {
                cmbParcelas.Items.Add(item);
            }
            cmbParcelas.SelectedIndex = 0;
            cmbParcelas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void atualizaLancamentos(String _ano, String _mes, Fonte _fonte)
        {
            if (_fonte == null || _fonte.nome == "")
                Lancamentos = Lancamento.Lancamentos(_ano, _mes);
            else
                Lancamentos = Lancamento.Lancamentos(_ano, _mes, _fonte);
        }

        private void carregaComboFontes()
        {
            cmbFonte.Items.Clear();
            Fontes = Fonte.fontes();

            if (Fontes != null)
                foreach (Fonte fonte in Fontes)
                    cmbFonte.Items.Add(fonte.nome);
        }

        private void regrasDeControles()
        {
            txtDataLancamento.ReadOnly = true;
            txtDataLancamento.TabStop = false;
            btnCalendario.TabStop = false;
            dgvLancamentos.TabStop = false;
            chkQuitado.TabStop = false;

            txtDescricao.Select();

            txtDescricao.TabIndex = 0;
            txtMotivo.TabIndex = 1;
            txtResponsavel.TabIndex = 2;
            cmbFonte.TabIndex = 3;
            cmbParcelas.TabIndex = 4;
            mskValor.TabIndex = 5;
            chkFixa.TabIndex = 6;
            grpTipoLancamento.TabIndex = 7;
            btnSalvar.TabIndex = 8;
            btnCancelar.TabIndex = 9;

            preparaViewLancamentos();
        }

        private void preparaViewLancamentos()
        {
            dgvLancamentos.Rows.Clear();
            dgvLancamentos.ColumnCount = 11;

            dgvLancamentos.Columns[dgvIndex_dataLancamento].Name = "dataLancamento";
            dgvLancamentos.Columns[dgvIndex_fonte].Name = "fonte";
            dgvLancamentos.Columns[dgvIndex_valor].Name = "valor";
            dgvLancamentos.Columns[dgvIndex_descricao].Name = "descricao";
            dgvLancamentos.Columns[dgvIndex_responsavel].Name = "responsavel";
            dgvLancamentos.Columns[dgvIndex_motivo].Name = "motivo";
            dgvLancamentos.Columns[dgvIndex_fixa].Name = "fixa";
            dgvLancamentos.Columns[dgvIndex_quitado].Name = "quitado";
            dgvLancamentos.Columns[dgvIndex_tipoDespesa].Name = "tipoDespesa";
            dgvLancamentos.Columns[dgvIndex_parcelas].Name = "parcelas";
            dgvLancamentos.Columns[dgvIndex_parcelaAtual].Name = "parcelaAtual";

            dgvLancamentos.Columns[dgvIndex_dataLancamento].HeaderText = "Dia";
            dgvLancamentos.Columns[dgvIndex_fonte].HeaderText = "Fonte";
            dgvLancamentos.Columns[dgvIndex_valor].HeaderText = "Valor";
            dgvLancamentos.Columns[dgvIndex_descricao].HeaderText = "Descrição";
            dgvLancamentos.Columns[dgvIndex_responsavel].HeaderText = "Responsável";
            dgvLancamentos.Columns[dgvIndex_motivo].HeaderText = "Motivo";
            dgvLancamentos.Columns[dgvIndex_fixa].HeaderText = "Fixa";
            dgvLancamentos.Columns[dgvIndex_quitado].HeaderText = "Quitado";
            dgvLancamentos.Columns[dgvIndex_tipoDespesa].HeaderText = "Tipo de Despesa";
            dgvLancamentos.Columns[dgvIndex_parcelas].HeaderText = "Parcelas";
            dgvLancamentos.Columns[dgvIndex_parcelaAtual].HeaderText = "Parcela Atual";

            dgvLancamentos.Columns[dgvIndex_motivo].Visible = false;
            dgvLancamentos.Columns[dgvIndex_fixa].Visible = false;
            dgvLancamentos.Columns[dgvIndex_quitado].Visible = false;
            dgvLancamentos.Columns[dgvIndex_tipoDespesa].Visible = false;
            dgvLancamentos.Columns[dgvIndex_parcelas].Visible = false;
            dgvLancamentos.Columns[dgvIndex_parcelaAtual].Visible = false;

            dgvLancamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLancamentos.ReadOnly = true;
            dgvLancamentos.AllowUserToAddRows = false;
            dgvLancamentos.MultiSelect = false;
            dgvLancamentos.DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite;
            dgvLancamentos.DefaultCellStyle.SelectionForeColor = Color.Black;

            preencheViewLancamentos();

            //dgvLancamentos.Sort(dgvLancamentos.Columns[dgvIndex_dataLancamento],System.ComponentModel.ListSortDirection.Ascending);
            dgvLancamentos.Refresh();
        }

        private void preencheViewLancamentos()
        {
            Decimal totalDespesas = 0;
            Decimal totalReceitas = 0;
            Decimal totalGastoPrevisto = 0;
            Decimal totalGanhoPrevisto = 0;

            // Aplica os dados de lancamentos
            if (Lancamentos != null)
                foreach (Lancamento lancamento in Lancamentos)
                    insereLancamentoDataGridView(lancamento);

            // Aplica identificação de cores
            foreach(DataGridViewRow row in dgvLancamentos.Rows)
            {
                if (row.Cells[dgvIndex_tipoDespesa].Value == null)
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                else
                {
                    if (row.Cells[dgvIndex_tipoDespesa].Value.ToString() == "D")
                    {
                        row.Cells[dgvIndex_valor].Style.ForeColor = Color.Red;
                        row.Cells[dgvIndex_valor].Style.SelectionForeColor = Color.Red;
                        totalDespesas += row.Cells[dgvIndex_quitado].Value.ToString() == "true" ? retornaValor(row.Cells[dgvIndex_valor].Value.ToString()) : 0;
                        totalGastoPrevisto += row.Cells[dgvIndex_quitado].Value.ToString() == "false" ? retornaValor(row.Cells[dgvIndex_valor].Value.ToString()) : 0;
                    }
                    else
                    {
                        row.Cells[dgvIndex_valor].Style.ForeColor = Color.Blue;
                        row.Cells[dgvIndex_valor].Style.SelectionForeColor = Color.Blue;
                        totalReceitas += row.Cells[dgvIndex_quitado].Value.ToString() == "true" ? retornaValor(row.Cells[dgvIndex_valor].Value.ToString()) : 0;
                        totalGanhoPrevisto += row.Cells[dgvIndex_quitado].Value.ToString() == "false" ? retornaValor(row.Cells[dgvIndex_valor].Value.ToString()) : 0;
                    }
                        
                }

                if (row.Cells[dgvIndex_quitado].Value.ToString().ToLower() == "true")
                {
                    row.Cells[dgvIndex_descricao].Style.ForeColor = Color.Goldenrod;
                    row.Cells[dgvIndex_descricao].Style.SelectionForeColor = Color.Goldenrod;
                }
                    
            }

            lblTotalDespesas.Text = "Total de Despesas: " + String.Format("{0:C2}", totalDespesas);
            lblTotalReceitas.Text = "Total de Receitas: " + String.Format("{0:C2}", totalReceitas);
            lblTotalGastoPrevisto.Text = "Total de Gasto Previsto: " + String.Format("{0:C2}", totalGastoPrevisto);
            lblTotalGanhoPrevisto.Text = "Total de Ganho Previsto: " + String.Format("{0:C2}", totalGanhoPrevisto);

            Decimal saldoPrevisto = ((totalReceitas + totalGanhoPrevisto) - (totalDespesas + totalGastoPrevisto));
            Decimal saldoReal = (totalReceitas - totalDespesas);

            lblSaldoPrevisto.Text = "Saldo Previsto: " + String.Format("{0:C2}", saldoPrevisto);
            lblSaldoReal.Text = "Saldo Real: " + String.Format("{0:C2}", saldoReal);

            lblTotalDespesas.ForeColor = Color.Red;
            lblTotalReceitas.ForeColor = Color.Blue;
            lblTotalGastoPrevisto.ForeColor = Color.OrangeRed;
            lblTotalGanhoPrevisto.ForeColor = Color.CornflowerBlue;

            lblSaldoPrevisto.ForeColor = saldoPrevisto >= 0 ? Color.ForestGreen : Color.PaleVioletRed;
            lblSaldoPrevisto.BackColor = Color.Bisque;

            lblSaldoReal.ForeColor = saldoReal >= 0 ? Color.ForestGreen : Color.PaleVioletRed;
            lblSaldoReal.BackColor = Color.Bisque;
        }


        private Decimal retornaValor(String valor)
        {
            if (valor.Replace("R$", "").Replace(".", "").Replace(",", "").Trim() == "")
                return 0;

            return Decimal.Parse(valor, NumberStyles.Currency);
        }


        private void salvarRegistro(Boolean _Alterar, Lancamento lancamento)
        {

            try
            {
                lancamento.fixa = chkFixa.Checked;
                lancamento.quitado = chkQuitado.Checked;
                lancamento.valor = retornaValor(mskValor.Text);

                lancamento.ValidaClasse();
                lancamento.ValidacaoCadastral();
                lancamento.gravaLancamento(_Sobrescrever: true);

                valoresDefault();
                DateTime DataSelecionada = DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                atualizaLancamentos(DataSelecionada.Year.ToString("d04"), DataSelecionada.Month.ToString("d02"), Fonte.getFonteNome(cmbFonte.Text));
                regrasDeControles();
                lancamento = null;
                modoTela = Util.Constantes.ModoTela.Insercao;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvLancamentos.Refresh();
        }

        private void salvarRegistro()
        {

            Lancamento lancamento = new Lancamento()
            {
                dataLancamento = DateTime.Parse(txtDataLancamento.Text),
                descricao = txtDescricao.Text,
                motivo = txtMotivo.Text,
                responsavel = txtResponsavel.Text,
                valor = retornaValor(mskValor.Text),
                tipoDespesa = rdbDespesa.Checked ? "D" : rdbReceita.Checked ? "R" : "",
                quitado = chkQuitado.Checked,
                fixa = chkFixa.Checked,
                fonte = Fonte.getFonteNome(cmbFonte.Text),
                parcelas = Convert.ToInt32(cmbParcelas.Text),
                parcelaAtual = 1
            };

            try
            {
                lancamento.ValidaClasse();
                lancamento.ValidacaoCadastral();
                lancamento.gravaLancamento();

                valoresDefault();
                DateTime DataSelecionada = DateTime.ParseExact(txtDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                atualizaLancamentos(DataSelecionada.Year.ToString("d04"), DataSelecionada.Month.ToString("d02"), Fonte.getFonteNome(cmbFonte.Text));
                regrasDeControles();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvLancamentos.Refresh();
        }

        private void insereLancamentoDataGridView(Lancamento lancamento)
        {
            dgvLancamentos.Rows.Add
                (
                    lancamento.dataLancamento.ToString("dd/MM/yyyy"),
                    lancamento.fonte,
                    String.Format("{0:C2}", lancamento.valor),
                    lancamento.descricao,
                    lancamento.responsavel,
                    lancamento.motivo,
                    lancamento.fixa.ToString().ToLower(),
                    lancamento.quitado.ToString().ToLower(),
                    lancamento.tipoDespesa.ToString().ToUpper(),
                    lancamento.parcelas,
                    lancamento.parcelaAtual
                );
        }

        private void InitializeComponent()
        {
            this.grpFormulario = new System.Windows.Forms.GroupBox();
            this.cmbParcelas = new System.Windows.Forms.ComboBox();
            this.lblParcelas = new System.Windows.Forms.Label();
            this.cmbFonte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkQuitado = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.chkFixa = new System.Windows.Forms.CheckBox();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.grpTipoLancamento = new System.Windows.Forms.GroupBox();
            this.rdbDespesa = new System.Windows.Forms.RadioButton();
            this.rdbReceita = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtDataLancamento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpListagem = new System.Windows.Forms.GroupBox();
            this.lblSaldoReal = new System.Windows.Forms.Label();
            this.lblSaldoPrevisto = new System.Windows.Forms.Label();
            this.lblTotalGanhoPrevisto = new System.Windows.Forms.Label();
            this.lblTotalGastoPrevisto = new System.Windows.Forms.Label();
            this.lblTotalReceitas = new System.Windows.Forms.Label();
            this.lblTotalDespesas = new System.Windows.Forms.Label();
            this.lblListagem = new System.Windows.Forms.Label();
            this.dgvLancamentos = new System.Windows.Forms.DataGridView();
            this.grpFormulario.SuspendLayout();
            this.grpTipoLancamento.SuspendLayout();
            this.grpListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFormulario
            // 
            this.grpFormulario.Controls.Add(this.cmbParcelas);
            this.grpFormulario.Controls.Add(this.lblParcelas);
            this.grpFormulario.Controls.Add(this.cmbFonte);
            this.grpFormulario.Controls.Add(this.label2);
            this.grpFormulario.Controls.Add(this.chkQuitado);
            this.grpFormulario.Controls.Add(this.btnCancelar);
            this.grpFormulario.Controls.Add(this.btnSalvar);
            this.grpFormulario.Controls.Add(this.chkFixa);
            this.grpFormulario.Controls.Add(this.mskValor);
            this.grpFormulario.Controls.Add(this.grpTipoLancamento);
            this.grpFormulario.Controls.Add(this.label6);
            this.grpFormulario.Controls.Add(this.txtResponsavel);
            this.grpFormulario.Controls.Add(this.label8);
            this.grpFormulario.Controls.Add(this.label7);
            this.grpFormulario.Controls.Add(this.txtMotivo);
            this.grpFormulario.Controls.Add(this.btnCalendario);
            this.grpFormulario.Controls.Add(this.txtDescricao);
            this.grpFormulario.Controls.Add(this.txtDataLancamento);
            this.grpFormulario.Controls.Add(this.label4);
            this.grpFormulario.Controls.Add(this.label1);
            this.grpFormulario.Location = new System.Drawing.Point(12, 12);
            this.grpFormulario.Name = "grpFormulario";
            this.grpFormulario.Size = new System.Drawing.Size(776, 126);
            this.grpFormulario.TabIndex = 0;
            this.grpFormulario.TabStop = false;
            this.grpFormulario.Text = "Lançamento Financeiro";
            // 
            // cmbParcelas
            // 
            this.cmbParcelas.FormattingEnabled = true;
            this.cmbParcelas.Location = new System.Drawing.Point(385, 45);
            this.cmbParcelas.Name = "cmbParcelas";
            this.cmbParcelas.Size = new System.Drawing.Size(237, 21);
            this.cmbParcelas.TabIndex = 17;
            // 
            // lblParcelas
            // 
            this.lblParcelas.AutoSize = true;
            this.lblParcelas.Location = new System.Drawing.Point(331, 48);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(48, 13);
            this.lblParcelas.TabIndex = 16;
            this.lblParcelas.Text = "Parcelas";
            // 
            // cmbFonte
            // 
            this.cmbFonte.FormattingEnabled = true;
            this.cmbFonte.Location = new System.Drawing.Point(385, 19);
            this.cmbFonte.Name = "cmbFonte";
            this.cmbFonte.Size = new System.Drawing.Size(237, 21);
            this.cmbFonte.TabIndex = 15;
            this.cmbFonte.SelectedIndexChanged += new System.EventHandler(this.cmbFonte_SelectedIndexChanged);
            this.cmbFonte.Leave += new System.EventHandler(this.cmbFonte_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fonte";
            // 
            // chkQuitado
            // 
            this.chkQuitado.AutoSize = true;
            this.chkQuitado.Location = new System.Drawing.Point(253, 21);
            this.chkQuitado.Name = "chkQuitado";
            this.chkQuitado.Size = new System.Drawing.Size(69, 17);
            this.chkQuitado.TabIndex = 13;
            this.chkQuitado.Text = "Quitado?";
            this.chkQuitado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(693, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(59, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(628, 69);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chkFixa
            // 
            this.chkFixa.AutoSize = true;
            this.chkFixa.Location = new System.Drawing.Point(542, 73);
            this.chkFixa.Name = "chkFixa";
            this.chkFixa.Size = new System.Drawing.Size(51, 17);
            this.chkFixa.TabIndex = 1;
            this.chkFixa.Text = "Fixa?";
            this.chkFixa.UseVisualStyleBackColor = true;
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(385, 71);
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(152, 20);
            this.mskValor.TabIndex = 5;
            // 
            // grpTipoLancamento
            // 
            this.grpTipoLancamento.Controls.Add(this.rdbDespesa);
            this.grpTipoLancamento.Controls.Add(this.rdbReceita);
            this.grpTipoLancamento.Location = new System.Drawing.Point(628, 17);
            this.grpTipoLancamento.Name = "grpTipoLancamento";
            this.grpTipoLancamento.Size = new System.Drawing.Size(142, 48);
            this.grpTipoLancamento.TabIndex = 6;
            this.grpTipoLancamento.TabStop = false;
            this.grpTipoLancamento.Text = "Tipo Lançamento";
            // 
            // rdbDespesa
            // 
            this.rdbDespesa.AutoSize = true;
            this.rdbDespesa.Location = new System.Drawing.Point(69, 19);
            this.rdbDespesa.Name = "rdbDespesa";
            this.rdbDespesa.Size = new System.Drawing.Size(67, 17);
            this.rdbDespesa.TabIndex = 7;
            this.rdbDespesa.TabStop = true;
            this.rdbDespesa.Text = "Despesa";
            this.rdbDespesa.UseVisualStyleBackColor = true;
            // 
            // rdbReceita
            // 
            this.rdbReceita.AutoSize = true;
            this.rdbReceita.Location = new System.Drawing.Point(6, 19);
            this.rdbReceita.Name = "rdbReceita";
            this.rdbReceita.Size = new System.Drawing.Size(62, 17);
            this.rdbReceita.TabIndex = 6;
            this.rdbReceita.TabStop = true;
            this.rdbReceita.Text = "Receita";
            this.rdbReceita.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(84, 97);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(237, 20);
            this.txtResponsavel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Responsável";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Motivo";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(84, 71);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(237, 20);
            this.txtMotivo.TabIndex = 8;
            // 
            // btnCalendario
            // 
            this.btnCalendario.Location = new System.Drawing.Point(222, 17);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(25, 23);
            this.btnCalendario.TabIndex = 7;
            this.btnCalendario.Text = "...";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalendario_MouseClick);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(84, 45);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(237, 20);
            this.txtDescricao.TabIndex = 6;
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.Location = new System.Drawing.Point(84, 19);
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.Size = new System.Drawing.Size(132, 20);
            this.txtDataLancamento.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // grpListagem
            // 
            this.grpListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpListagem.Controls.Add(this.lblSaldoReal);
            this.grpListagem.Controls.Add(this.lblSaldoPrevisto);
            this.grpListagem.Controls.Add(this.lblTotalGanhoPrevisto);
            this.grpListagem.Controls.Add(this.lblTotalGastoPrevisto);
            this.grpListagem.Controls.Add(this.lblTotalReceitas);
            this.grpListagem.Controls.Add(this.lblTotalDespesas);
            this.grpListagem.Controls.Add(this.lblListagem);
            this.grpListagem.Controls.Add(this.dgvLancamentos);
            this.grpListagem.Location = new System.Drawing.Point(12, 144);
            this.grpListagem.Name = "grpListagem";
            this.grpListagem.Size = new System.Drawing.Size(776, 294);
            this.grpListagem.TabIndex = 1;
            this.grpListagem.TabStop = false;
            this.grpListagem.Text = "Despesas do mês atual";
            // 
            // lblSaldoReal
            // 
            this.lblSaldoReal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSaldoReal.AutoSize = true;
            this.lblSaldoReal.Location = new System.Drawing.Point(421, 275);
            this.lblSaldoReal.Name = "lblSaldoReal";
            this.lblSaldoReal.Size = new System.Drawing.Size(113, 13);
            this.lblSaldoReal.TabIndex = 21;
            this.lblSaldoReal.Text = "Saldo Real: R$ XX,XX";
            // 
            // lblSaldoPrevisto
            // 
            this.lblSaldoPrevisto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSaldoPrevisto.AutoSize = true;
            this.lblSaldoPrevisto.Location = new System.Drawing.Point(421, 254);
            this.lblSaldoPrevisto.Name = "lblSaldoPrevisto";
            this.lblSaldoPrevisto.Size = new System.Drawing.Size(129, 13);
            this.lblSaldoPrevisto.TabIndex = 20;
            this.lblSaldoPrevisto.Text = "Saldo Previsto: R$ XX,XX";
            // 
            // lblTotalGanhoPrevisto
            // 
            this.lblTotalGanhoPrevisto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalGanhoPrevisto.AutoSize = true;
            this.lblTotalGanhoPrevisto.Location = new System.Drawing.Point(191, 275);
            this.lblTotalGanhoPrevisto.Name = "lblTotalGanhoPrevisto";
            this.lblTotalGanhoPrevisto.Size = new System.Drawing.Size(176, 13);
            this.lblTotalGanhoPrevisto.TabIndex = 19;
            this.lblTotalGanhoPrevisto.Text = "Total de Ganho Previsto: R$ XX,XX";
            // 
            // lblTotalGastoPrevisto
            // 
            this.lblTotalGastoPrevisto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalGastoPrevisto.AutoSize = true;
            this.lblTotalGastoPrevisto.Location = new System.Drawing.Point(191, 254);
            this.lblTotalGastoPrevisto.Name = "lblTotalGastoPrevisto";
            this.lblTotalGastoPrevisto.Size = new System.Drawing.Size(172, 13);
            this.lblTotalGastoPrevisto.TabIndex = 17;
            this.lblTotalGastoPrevisto.Text = "Total de Gasto Previsto: R$ XX,XX";
            // 
            // lblTotalReceitas
            // 
            this.lblTotalReceitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalReceitas.AutoSize = true;
            this.lblTotalReceitas.Location = new System.Drawing.Point(6, 275);
            this.lblTotalReceitas.Name = "lblTotalReceitas";
            this.lblTotalReceitas.Size = new System.Drawing.Size(145, 13);
            this.lblTotalReceitas.TabIndex = 16;
            this.lblTotalReceitas.Text = "Total de Receitas: R$ XX,XX";
            // 
            // lblTotalDespesas
            // 
            this.lblTotalDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalDespesas.AutoSize = true;
            this.lblTotalDespesas.Location = new System.Drawing.Point(6, 254);
            this.lblTotalDespesas.Name = "lblTotalDespesas";
            this.lblTotalDespesas.Size = new System.Drawing.Size(150, 13);
            this.lblTotalDespesas.TabIndex = 15;
            this.lblTotalDespesas.Text = "Total de Despesas: R$ XX,XX";
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Location = new System.Drawing.Point(6, 16);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(124, 13);
            this.lblListagem.TabIndex = 14;
            this.lblListagem.Text = "Listagem de MM / AAAA";
            // 
            // dgvLancamentos
            // 
            this.dgvLancamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLancamentos.Location = new System.Drawing.Point(8, 32);
            this.dgvLancamentos.Name = "dgvLancamentos";
            this.dgvLancamentos.Size = new System.Drawing.Size(761, 219);
            this.dgvLancamentos.TabIndex = 0;
            this.dgvLancamentos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLancamentos_MouseDoubleClick);
            // 
            // frm_Lancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpListagem);
            this.Controls.Add(this.grpFormulario);
            this.Name = "frm_Lancamentos";
            this.Text = "Lançamentos Financeiros";
            this.grpFormulario.ResumeLayout(false);
            this.grpFormulario.PerformLayout();
            this.grpTipoLancamento.ResumeLayout(false);
            this.grpTipoLancamento.PerformLayout();
            this.grpListagem.ResumeLayout(false);
            this.grpListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLancamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFormulario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataLancamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.GroupBox grpTipoLancamento;
        private System.Windows.Forms.RadioButton rdbDespesa;
        private System.Windows.Forms.RadioButton rdbReceita;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox chkFixa;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.GroupBox grpListagem;
        private System.Windows.Forms.DataGridView dgvLancamentos;
        private System.Windows.Forms.CheckBox chkQuitado;
        private System.Windows.Forms.Label lblListagem;
        private System.Windows.Forms.ComboBox cmbFonte;
        private System.Windows.Forms.Label label2;
        private Label lblTotalReceitas;
        private Label lblTotalDespesas;
        private Label lblTotalGastoPrevisto;
        private Label lblSaldoPrevisto;
        private Label lblTotalGanhoPrevisto;
        private ComboBox cmbParcelas;
        private Label lblParcelas;
        private Label lblSaldoReal;
    }
}

