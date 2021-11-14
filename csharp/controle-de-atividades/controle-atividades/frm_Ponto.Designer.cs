
using controle_atividades_negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace controle_atividades
{
    partial class frm_Ponto
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

        private bool trataBotaoEntrada()
        {
            if (Entrada == "")
            {
                btnEntrada.Enabled = true;
                btnIntervaloInicio.Enabled = btnIntervaloVolta.Enabled = btnSaida.Enabled = false;
                return true;
            }
            return false;
        }

        private bool trataBotaoSaida()
        {
            if (Saida == "")
            {
                btnSaida.Enabled = true;
                btnIntervaloInicio.Enabled = btnIntervaloVolta.Enabled = btnEntrada.Enabled = false;
                return true;
            }
            return false;
        }

        private bool trataBotaoIntervalo()
        {
            if (Almoco_Ini == "" && Saida == "")
            {
                btnIntervaloInicio.Enabled = true;
                btnSaida.Enabled = true;
                btnEntrada.Enabled = btnIntervaloVolta.Enabled = false;
                return true;
            }
            else if (Almoco_Fim == "" && Saida == "")
            {
                btnIntervaloVolta.Enabled = true;
                btnEntrada.Enabled = btnIntervaloInicio.Enabled = btnSaida.Enabled = false;
                return true;
            }
            else if (Janta_Ini == "" && Saida == "")
            {
                btnIntervaloInicio.Enabled = true;
                btnSaida.Enabled = true;
                btnEntrada.Enabled = btnIntervaloVolta.Enabled = false;
                return true;
            }
            else if (Janta_Fim == "" && Saida == "")
            {
                btnIntervaloVolta.Enabled = true;
                btnEntrada.Enabled = btnIntervaloInicio.Enabled = btnSaida.Enabled = false;
                return true;
            }
            return false;
        }

        private void trataBotoesAtividades()
        {

            btnEncerrarTarefa.Enabled = false;
            btnExcluirTarefa.Enabled = false;
            btnIniciarTarefa.Enabled = false;

            btnIniciarTarefa.Enabled = !btnEntrada.Enabled;

            if (dgvAtividades.Rows.Count > 0)
            {
                btnEncerrarTarefa.Enabled = dgvAtividades.CurrentRow == null || dgvAtividades.CurrentRow.Cells[3].Value.ToString() == "";
                btnExcluirTarefa.Enabled = true;
            }
        }

        private void regraBotoesPonto()
        {
            if (!trataBotaoEntrada())
                if (!trataBotaoIntervalo())
                    if (!trataBotaoSaida())
                        btnSaida.Enabled = btnIntervaloInicio.Enabled = btnIntervaloVolta.Enabled = btnEntrada.Enabled = false;

            btnFinalizarDia.Enabled = (!btnSaida.Enabled && Saida != ""); 
            trataBotoesAtividades();
        }

        private void encerraAtividadesSemDataFinal()
        {
            for (int i = 0; i < dgvAtividades.Rows.Count; i++)
                if (dgvAtividades.Rows[i].Cells[3].Value.ToString() == "")
                    dgvAtividades.Rows[i].Cells[3].Value = Saida;
        }


        private List<Atividades> atividadesDoDia()
        {
            List<Atividades> atividades = new List<Atividades>();
            foreach (DataGridViewRow row in dgvAtividades.Rows)
            {

                bool status = true;
                if (row.Cells[4].Value == null || row.Cells[4].Value.ToString().ToLower() == "false")
                    status = false;

                DateTime? previsao = null;
                if (row.Cells["Previsao"].Value != null && row.Cells["Previsao"].Value.ToString() != "")
                    previsao = Util.StringToDatetime(row.Cells["Previsao"].Value.ToString());

                atividades.Add(new Atividades()
                {
                    Nome = row.Cells[0].Value.ToString(),
                    Descricao = row.Cells[1].Value.ToString(),
                    Atuacao = new Intervalo()
                    {
                        inicio = row.Cells[2].Value.ToString(),
                        fim = row.Cells[3].Value.ToString()
                    },

                    status = status,
                    previsao = previsao
                });
            }

            foreach (DataGridViewRow row in dgvAtividadesEncerradas.Rows)
            {
                DateTime? previsao = null;
                if (row.Cells["Previsao"].Value != null && row.Cells["Previsao"].Value.ToString() != "")
                    previsao = Util.StringToDatetime(row.Cells["Previsao"].Value.ToString());

                atividades.Add(new Atividades()
                {
                    Nome = row.Cells[0].Value.ToString(),
                    Descricao = row.Cells[1].Value.ToString(),
                    Atuacao = new Intervalo()
                    {
                        inicio = row.Cells[2].Value.ToString(),
                        fim = row.Cells[3].Value.ToString()
                    },

                    status = true,
                    previsao = previsao
                });
            }
            return atividades;
        }

        private Ponto criaPonto(List<Atividades> atividades)
        {
            Ponto ponto = new Ponto()
            {
                Expediente = new Intervalo()
                {
                    inicio = Entrada,
                    fim = Saida
                },
                Almoco = new Intervalo()
                {
                    inicio = Almoco_Ini,
                    fim = Almoco_Fim
                },
                Janta = new Intervalo()
                {
                    inicio = Janta_Ini,
                    fim = Janta_Fim
                },
                SaldoHoras = SaldoHoras,
                HorasExtras = dgvPonto.Rows[0].Cells[7].Value == null || dgvPonto.Rows[0].Cells[7].Value.ToString() == "" ? "" : dgvPonto.Rows[0].Cells[7].Value.ToString(),
                Atividades = atividades
            };

            return ponto;
        }

        private void finalizaDia()
        {

            List<Atividades> atividades = atividadesDoDia();
            Ponto ponto = criaPonto(atividades);
            ponto.criaArquivo(ponto, _ApresentaData_UC.DataDiaAberturaTela());
        }

        private void incluiLinhaAtividade(Atividades atividades)
        {
            dgvAtividades.Rows.Add
                (
                    new String[]
                    {
                        atividades.Nome,
                        atividades.Descricao,
                        atividades.Atuacao.inicio,
                        "",
                        atividades.status.ToString().ToLower(),
                        atividades.previsao.ToString()
                    }
                );
        }

        private void incluiLinhaAtividadeEncerrada(Atividades atividades)
        {
            dgvAtividadesEncerradas.Rows.Add
                (
                    new String[]
                    {
                        atividades.Nome,
                        atividades.Descricao,
                        atividades.Atuacao.inicio,
                        atividades.Atuacao.fim,
                        atividades.status.ToString().ToLower(),
                        atividades.previsao.ToString()
                    }
                );
        }

        private void carregaAtividadesPendentes()
        {
            foreach (Atividades atv in Atividades.atividadesPendentes())
            {
                incluiLinhaAtividade(atv);
            }
        }

        private void carregaAtividadesEncerradas()
        {
            foreach (Atividades atv in Atividades.atividadesEncerradas())
            {
                incluiLinhaAtividadeEncerrada(atv);
            }
        }

        private void criaArquivoInicial()
        {
            if(MessageBox.Show("Deseja criar o arquivo inicial do dia de hoje?","Persiste arquivo de ponto",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                atualizaArquivo();
                flcriaArquivoInicial = true;
            }
            
        }

        private void atualizaArquivo()
        {
            Ponto ponto = criaPonto(atividadesDoDia());
            ponto.criaArquivo(ponto, _ApresentaData_UC.DataDiaAberturaTela());
        }

        private void carregaDadosPontoDia()
        {
            Ponto ponto = new Ponto().arquivoPonto
                (HorasExpediente.Year.ToString("d4") +
                @"\" + HorasExpediente.Month.ToString("d2") +
                @"\" + HorasExpediente.Day.ToString("d2") + ".json");

            if (MessageBox.Show("Horário previsto de trabalho é de 8h?", "Previsão de Expediente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                HorasExpediente = DateTime.Now.Date;

            if (!(ponto == null))
            {
                frm_CarregaPontoExistente _CarregaPontoExistente = new frm_CarregaPontoExistente();
                _CarregaPontoExistente.ShowDialog();

                if (!(_CarregaPontoExistente.DialogResult == DialogResult.Cancel && _CarregaPontoExistente.restaurarPontoDia == Util.Constantes.RestaurarPontoDia.NovoPonto))
                {
                    if (_CarregaPontoExistente.restaurarPontoDia == Util.Constantes.RestaurarPontoDia.Entrada)
                    {
                        Entrada = ponto.Expediente.inicio;
                        TerminoExpedientePrevisto = Util.StringToDatetime(Entrada).Add(HorasExpediente.TimeOfDay).ToString();
                        SaldoHoras = Util.StringToDatetime(Entrada).Subtract(Util.StringToDatetime(TerminoExpedientePrevisto)).ToString();
                    }
                    else if (_CarregaPontoExistente.restaurarPontoDia == Util.Constantes.RestaurarPontoDia.Almoco)
                    {
                        Entrada = ponto.Expediente.inicio;
                        Almoco_Ini = ponto.Almoco.inicio;
                        Almoco_Fim = ponto.Almoco.fim;

                        TerminoExpedientePrevisto = Util.StringToDatetime(Entrada).Add(HorasExpediente.TimeOfDay).ToString();
                        SaldoHoras = Util.StringToDatetime(Entrada).Subtract(Util.StringToDatetime(TerminoExpedientePrevisto)).ToString();
                    }
                    else if (_CarregaPontoExistente.restaurarPontoDia == Util.Constantes.RestaurarPontoDia.Janta)
                    {
                        Entrada = ponto.Expediente.inicio;
                        Almoco_Ini = ponto.Almoco.inicio;
                        Almoco_Fim = ponto.Almoco.fim;
                        Janta_Ini = ponto.Janta.inicio;
                        Janta_Fim = ponto.Janta.fim;

                        TerminoExpedientePrevisto = Util.StringToDatetime(Entrada).Add(HorasExpediente.TimeOfDay).ToString();
                        SaldoHoras = Util.StringToDatetime(Entrada).Subtract(Util.StringToDatetime(TerminoExpedientePrevisto)).ToString();
                    }
                    else if (_CarregaPontoExistente.restaurarPontoDia == Util.Constantes.RestaurarPontoDia.Saida)
                    {
                        Entrada = ponto.Expediente.inicio;
                        Almoco_Ini = ponto.Almoco.inicio;
                        Almoco_Fim = ponto.Almoco.fim;
                        Janta_Ini = ponto.Janta.inicio;
                        Janta_Fim = ponto.Janta.fim;
                        Saida = ponto.Expediente.fim;
                        SaldoHoras = ponto.SaldoHoras;
                        dgvPonto.Rows[0].Cells["Horas_Extras"].Value = ponto.HorasExtras;
                        encerraAtividadesSemDataFinal();
                    }

                    dgvPonto.Rows[0].Cells["Entrada"].Value = Util.Hora(Entrada);
                    dgvPonto.Rows[0].Cells["Almoco_Ini"].Value = Util.Hora(Almoco_Ini);
                    dgvPonto.Rows[0].Cells["Almoco_Fim"].Value = Util.Hora(Almoco_Fim);
                    dgvPonto.Rows[0].Cells["Janta_Ini"].Value = Util.Hora(Janta_Ini);
                    dgvPonto.Rows[0].Cells["Janta_Fim"].Value = Util.Hora(Janta_Fim);
                    dgvPonto.Rows[0].Cells["Saida"].Value = Util.Hora(Saida);
                    dgvPonto.Rows[0].Cells["Saldo_Horas"].Value = SaldoHoras;

                    dgvAtividades.Rows.Clear();
                    dgvAtividadesEncerradas.Rows.Clear();

                    foreach(Atividades atividades in ponto.Atividades)
                    {
                        if (atividades.status)
                            dgvAtividadesEncerradas.Rows.Add
                            (
                                atividades.Nome,
                                atividades.Descricao,
                                atividades.Atuacao.inicio,
                                atividades.Atuacao.fim,
                                atividades.status,
                                atividades.previsao
                            );
                        else
                            dgvAtividades.Rows.Add
                            (
                                atividades.Nome,
                                atividades.Descricao,
                                atividades.Atuacao.inicio,
                                Saida != "" ? atividades.Atuacao.fim : "",
                                atividades.status,
                                atividades.previsao
                            );
                    }
                    dgvAtividades.Refresh();
                }
            }
        }

        private void defineHoraExtra_SaldoHoras()
        {
            String Intervalos = "";

            if (Almoco_Fim != "")
                Intervalos = Util.StringToDatetime(Almoco_Fim).Subtract(Util.StringToDatetime(Almoco_Ini)).ToString();

            if (Janta_Fim != "")
                Intervalos = Util.StringToTimesPan(Intervalos).Add((Util.StringToDatetime(Janta_Fim).Subtract(Util.StringToDatetime(Janta_Ini)))).ToString();

            SaldoHoras = Util.StringToDatetime(Saida).Subtract(Util.StringToDatetime(Entrada)).ToString();
            SaldoHoras = Util.StringToTimesPan(SaldoHoras).Subtract(Util.StringToTimesPan(Intervalos)).ToString();

            String HoraExtra = Util.StringToDatetime(Saida).Subtract(Util.StringToDatetime(TerminoExpedientePrevisto)).ToString();
            HoraExtra = Util.StringToTimesPan(HoraExtra).Subtract(Util.StringToTimesPan(Intervalos)).ToString();

            dgvPonto.Rows[0].Cells[6].Value = SaldoHoras;
            dgvPonto.Rows[0].Cells[7].Value = TimeSpan.Parse(HoraExtra) > TimeSpan.Parse("00:00:00") ? HoraExtra : "00:00:00";

            if (HorasExpediente.TimeOfDay.ToString() != "00:00:00")
            {
                if (Util.StringToTimesPan(SaldoHoras).Subtract(HorasExpediente.TimeOfDay).TotalSeconds < HorasExpediente.TimeOfDay.TotalSeconds)
                    dgvPonto.Rows[0].Cells["Saldo_Horas"].Style.ForeColor = Color.Red;
                else
                    dgvPonto.Rows[0].Cells["Saldo_Horas"].Style.ForeColor = Color.Green;
            }
            else
                dgvPonto.Rows[0].Cells["Saldo_Horas"].Style.ForeColor = Color.Green;
        }

        private void registraEntrada()
        {
            Entrada = Entrada == "" ? new frm_Relogio().DataHora(true) : Entrada;
            if (dgvPonto.Rows.Count > 0)
            {
                dgvPonto.Rows[0].Cells[0].Value = Util.Hora(Entrada);
                _ApresentaData_UC.atualizaRelogio(Entrada, HorasExpediente.ToString());
            }

            TerminoExpedientePrevisto = Util.StringToDatetime(Entrada).Add(HorasExpediente.TimeOfDay).ToString();
            SaldoHoras = Util.StringToDatetime(Entrada).Subtract(Util.StringToDatetime(TerminoExpedientePrevisto)).ToString();
            dgvPonto.Rows[0].Cells[6].Value = SaldoHoras;

            if (flcriaArquivoInicial)
                atualizaArquivo();
        }

        private void registraIntervaloInicio()
        {
            if (Almoco_Ini != "")
            {
                Janta_Ini = Janta_Ini == "" ? new frm_Relogio().DataHora(true) : Janta_Ini;
                if (dgvPonto.Rows.Count > 0)
                {
                    dgvPonto.Rows[0].Cells[3].Value = Util.Hora(Janta_Ini);
                }
            }
            else
            {
                Almoco_Ini = Almoco_Ini == "" ? new frm_Relogio().DataHora(true) : Almoco_Ini;
                if (dgvPonto.Rows.Count > 0)
                {
                    dgvPonto.Rows[0].Cells[1].Value = Util.Hora(Almoco_Ini);
                }
            }

            if (MessageBox.Show("Deseja exibir o intervalo de 1h?", "Intervalo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                new frm_RelogioCongelaTela(3600).ShowDialog();

            if (flcriaArquivoInicial)
                atualizaArquivo();
        }


        private void registraIntervaloVolta()
        {
            String Intervalo = "";

            if (Almoco_Fim != "")
            {
                Janta_Fim = Janta_Fim == "" ? new frm_Relogio().DataHora(true) : Janta_Fim;
                if (dgvPonto.Rows.Count > 0)
                {
                    dgvPonto.Rows[0].Cells[4].Value = Util.Hora(Janta_Fim);
                    Intervalo = Util.StringToDatetime(Almoco_Fim).Subtract(Util.StringToDatetime(Almoco_Ini)).ToString();
                    Intervalo = Util.StringToTimesPan(Intervalo).Add(Util.StringToDatetime(Janta_Fim).Subtract(Util.StringToDatetime(Janta_Ini))).ToString();
                }
            }
            else
            {
                Almoco_Fim = Almoco_Fim == "" ? new frm_Relogio().DataHora(true) : Almoco_Fim;
                if (dgvPonto.Rows.Count > 0)
                {
                    dgvPonto.Rows[0].Cells[2].Value = Util.Hora(Almoco_Fim);
                    Intervalo = Util.StringToDatetime(Almoco_Fim).Subtract(Util.StringToDatetime(Almoco_Ini)).ToString();
                }
            }

            Intervalo = Util.StringToDatetime(Entrada).Add(Util.StringToTimesPan(Intervalo)).ToString();

            _ApresentaData_UC.atualizaRelogio(Intervalo, HorasExpediente.ToString());

            if (flcriaArquivoInicial)
                atualizaArquivo();
        }

        private void registraSaida()
        {
            Saida = Saida == "" ? new frm_Relogio().DataHora(true) : Saida;
            if (dgvPonto.Rows.Count > 0)
            {
                dgvPonto.Rows[0].Cells[5].Value = Util.Hora(Saida);
            }
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.grpBotoes = new System.Windows.Forms.GroupBox();
            this.btnFinalizarDia = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnIntervaloVolta = new System.Windows.Forms.Button();
            this.btnIntervaloInicio = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.grpPonto = new System.Windows.Forms.GroupBox();
            this.btnListaPonto = new System.Windows.Forms.Button();
            this.dgvAtividadesEncerradas = new System.Windows.Forms.DataGridView();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.dgvAtividades = new System.Windows.Forms.DataGridView();
            this.dgvPonto = new System.Windows.Forms.DataGridView();
            this.btnEncerrarTarefa = new System.Windows.Forms.Button();
            this.btnIniciarTarefa = new System.Windows.Forms.Button();
            this.pnlDataHora = new System.Windows.Forms.Panel();
            this.grpBotoes.SuspendLayout();
            this.grpPonto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividadesEncerradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBotoes
            // 
            this.grpBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBotoes.Controls.Add(this.btnFinalizarDia);
            this.grpBotoes.Controls.Add(this.btnSaida);
            this.grpBotoes.Controls.Add(this.btnIntervaloVolta);
            this.grpBotoes.Controls.Add(this.btnIntervaloInicio);
            this.grpBotoes.Controls.Add(this.btnEntrada);
            this.grpBotoes.Location = new System.Drawing.Point(12, 46);
            this.grpBotoes.Name = "grpBotoes";
            this.grpBotoes.Size = new System.Drawing.Size(536, 100);
            this.grpBotoes.TabIndex = 0;
            this.grpBotoes.TabStop = false;
            // 
            // btnFinalizarDia
            // 
            this.btnFinalizarDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarDia.Location = new System.Drawing.Point(430, 19);
            this.btnFinalizarDia.Name = "btnFinalizarDia";
            this.btnFinalizarDia.Size = new System.Drawing.Size(100, 75);
            this.btnFinalizarDia.TabIndex = 6;
            this.btnFinalizarDia.Text = "Finalizar dia";
            this.btnFinalizarDia.UseVisualStyleBackColor = true;
            this.btnFinalizarDia.Click += new System.EventHandler(this.btnFinalizarDia_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Location = new System.Drawing.Point(324, 19);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(100, 75);
            this.btnSaida.TabIndex = 3;
            this.btnSaida.Text = "Saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnIntervaloVolta
            // 
            this.btnIntervaloVolta.Location = new System.Drawing.Point(218, 19);
            this.btnIntervaloVolta.Name = "btnIntervaloVolta";
            this.btnIntervaloVolta.Size = new System.Drawing.Size(100, 75);
            this.btnIntervaloVolta.TabIndex = 2;
            this.btnIntervaloVolta.Text = "Fim";
            this.btnIntervaloVolta.UseVisualStyleBackColor = true;
            this.btnIntervaloVolta.Click += new System.EventHandler(this.btnIntervaloVolta_Click);
            // 
            // btnIntervaloInicio
            // 
            this.btnIntervaloInicio.Location = new System.Drawing.Point(112, 19);
            this.btnIntervaloInicio.Name = "btnIntervaloInicio";
            this.btnIntervaloInicio.Size = new System.Drawing.Size(100, 75);
            this.btnIntervaloInicio.TabIndex = 1;
            this.btnIntervaloInicio.Text = "Inicio";
            this.btnIntervaloInicio.UseVisualStyleBackColor = true;
            this.btnIntervaloInicio.Click += new System.EventHandler(this.btnIntervaloInicio_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Location = new System.Drawing.Point(6, 19);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(100, 75);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // grpPonto
            // 
            this.grpPonto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPonto.Controls.Add(this.btnListaPonto);
            this.grpPonto.Controls.Add(this.dgvAtividadesEncerradas);
            this.grpPonto.Controls.Add(this.btnExcluirTarefa);
            this.grpPonto.Controls.Add(this.dgvAtividades);
            this.grpPonto.Controls.Add(this.dgvPonto);
            this.grpPonto.Controls.Add(this.btnEncerrarTarefa);
            this.grpPonto.Controls.Add(this.btnIniciarTarefa);
            this.grpPonto.Location = new System.Drawing.Point(12, 152);
            this.grpPonto.Name = "grpPonto";
            this.grpPonto.Size = new System.Drawing.Size(536, 323);
            this.grpPonto.TabIndex = 1;
            this.grpPonto.TabStop = false;
            // 
            // btnListaPonto
            // 
            this.btnListaPonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaPonto.Location = new System.Drawing.Point(430, 225);
            this.btnListaPonto.Name = "btnListaPonto";
            this.btnListaPonto.Size = new System.Drawing.Size(100, 88);
            this.btnListaPonto.TabIndex = 7;
            this.btnListaPonto.Text = "Listagem de Pontos";
            this.btnListaPonto.UseVisualStyleBackColor = true;
            this.btnListaPonto.Click += new System.EventHandler(this.btnListaPonto_Click);
            // 
            // dgvAtividadesEncerradas
            // 
            this.dgvAtividadesEncerradas.AllowUserToAddRows = false;
            this.dgvAtividadesEncerradas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtividadesEncerradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtividadesEncerradas.Location = new System.Drawing.Point(3, 225);
            this.dgvAtividadesEncerradas.MultiSelect = false;
            this.dgvAtividadesEncerradas.Name = "dgvAtividadesEncerradas";
            this.dgvAtividadesEncerradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtividadesEncerradas.Size = new System.Drawing.Size(421, 88);
            this.dgvAtividadesEncerradas.TabIndex = 8;
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirTarefa.Location = new System.Drawing.Point(430, 183);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(100, 20);
            this.btnExcluirTarefa.TabIndex = 7;
            this.btnExcluirTarefa.Text = "Excluir";
            this.btnExcluirTarefa.UseVisualStyleBackColor = true;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // dgvAtividades
            // 
            this.dgvAtividades.AllowUserToAddRows = false;
            this.dgvAtividades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtividades.Location = new System.Drawing.Point(3, 131);
            this.dgvAtividades.MultiSelect = false;
            this.dgvAtividades.Name = "dgvAtividades";
            this.dgvAtividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtividades.Size = new System.Drawing.Size(421, 88);
            this.dgvAtividades.TabIndex = 1;
            this.dgvAtividades.SelectionChanged += new System.EventHandler(this.dgvAtividades_SelectionChanged);
            this.dgvAtividades.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAtividades_MouseDoubleClick);
            // 
            // dgvPonto
            // 
            this.dgvPonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonto.Location = new System.Drawing.Point(3, 16);
            this.dgvPonto.Name = "dgvPonto";
            this.dgvPonto.Size = new System.Drawing.Size(527, 93);
            this.dgvPonto.TabIndex = 0;
            // 
            // btnEncerrarTarefa
            // 
            this.btnEncerrarTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrarTarefa.Location = new System.Drawing.Point(430, 157);
            this.btnEncerrarTarefa.Name = "btnEncerrarTarefa";
            this.btnEncerrarTarefa.Size = new System.Drawing.Size(100, 20);
            this.btnEncerrarTarefa.TabIndex = 5;
            this.btnEncerrarTarefa.Text = "Encerrar";
            this.btnEncerrarTarefa.UseVisualStyleBackColor = true;
            this.btnEncerrarTarefa.Click += new System.EventHandler(this.btnEncerrarTarefa_Click);
            // 
            // btnIniciarTarefa
            // 
            this.btnIniciarTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarTarefa.Location = new System.Drawing.Point(430, 131);
            this.btnIniciarTarefa.Name = "btnIniciarTarefa";
            this.btnIniciarTarefa.Size = new System.Drawing.Size(100, 20);
            this.btnIniciarTarefa.TabIndex = 4;
            this.btnIniciarTarefa.Text = "Adicionar";
            this.btnIniciarTarefa.UseVisualStyleBackColor = true;
            this.btnIniciarTarefa.Click += new System.EventHandler(this.btnIniciarTarefa_Click);
            // 
            // pnlDataHora
            // 
            this.pnlDataHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDataHora.Location = new System.Drawing.Point(12, 12);
            this.pnlDataHora.Name = "pnlDataHora";
            this.pnlDataHora.Size = new System.Drawing.Size(536, 37);
            this.pnlDataHora.TabIndex = 2;
            // 
            // frm_Ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 487);
            this.Controls.Add(this.pnlDataHora);
            this.Controls.Add(this.grpPonto);
            this.Controls.Add(this.grpBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Ponto";
            this.Text = "Ponto";
            this.grpBotoes.ResumeLayout(false);
            this.grpPonto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividadesEncerradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void preparaVisualizacaoDadosPonto()
        {
            dgvPonto.ColumnCount = 8;

            dgvPonto.Columns[0].Name = "Entrada";
            dgvPonto.Columns[1].Name = "Almoco_Ini";
            dgvPonto.Columns[2].Name = "Almoco_Fim";
            dgvPonto.Columns[3].Name = "Janta_Ini";
            dgvPonto.Columns[4].Name = "Janta_Fim";
            dgvPonto.Columns[5].Name = "Saida";
            dgvPonto.Columns[6].Name = "Saldo_Horas";
            dgvPonto.Columns[7].Name = "Horas_Extras";

            dgvPonto.Columns[0].HeaderText = "Entrada";
            dgvPonto.Columns[1].HeaderText = "Almoço Saída";
            dgvPonto.Columns[2].HeaderText = "Almoço Retorno";
            dgvPonto.Columns[3].HeaderText = "Janta Saída";
            dgvPonto.Columns[4].HeaderText = "Janta Retorno";
            dgvPonto.Columns[5].HeaderText = "Saida";
            dgvPonto.Columns[6].HeaderText = "Saldo de Horas";
            dgvPonto.Columns[7].HeaderText = "Horas Extras";

            dgvPonto.ReadOnly = true;
        }

        private void preparaVisualizacaoDadosAtividades()
        {
            dgvAtividades.ColumnCount = 6;

            dgvAtividades.Columns[0].Name = "Nome";
            dgvAtividades.Columns[1].Name = "Descricao";
            dgvAtividades.Columns[2].Name = "Inicio";
            dgvAtividades.Columns[3].Name = "Fim";
            dgvAtividades.Columns[4].Name = "Status";
            dgvAtividades.Columns[5].Name = "Previsao";

            dgvAtividades.Columns[0].HeaderText = "Nome";
            dgvAtividades.Columns[1].HeaderText = "Descrição";
            dgvAtividades.Columns[2].HeaderText = "Início";
            dgvAtividades.Columns[3].HeaderText = "Fim";
            dgvAtividades.Columns[4].HeaderText = "Status";
            dgvAtividades.Columns[5].HeaderText = "Previsão";

            dgvAtividades.Columns[4].Visible = false;
            dgvAtividades.ReadOnly = true;

            dgvAtividadesEncerradas.ColumnCount = 6;

            dgvAtividadesEncerradas.Columns[0].Name = "Nome";
            dgvAtividadesEncerradas.Columns[1].Name = "Descricao";
            dgvAtividadesEncerradas.Columns[2].Name = "Inicio";
            dgvAtividadesEncerradas.Columns[3].Name = "Fim";
            dgvAtividadesEncerradas.Columns[4].Name = "Status";
            dgvAtividadesEncerradas.Columns[5].Name = "Previsao";

            dgvAtividadesEncerradas.Columns[0].HeaderText = "Nome";
            dgvAtividadesEncerradas.Columns[1].HeaderText = "Descrição";
            dgvAtividadesEncerradas.Columns[2].HeaderText = "Início";
            dgvAtividadesEncerradas.Columns[3].HeaderText = "Fim";
            dgvAtividadesEncerradas.Columns[4].HeaderText = "Status";
            dgvAtividadesEncerradas.Columns[5].HeaderText = "Previsão";

            dgvAtividadesEncerradas.Columns[4].Visible = false;
            dgvAtividadesEncerradas.ReadOnly = true;
        }

        private System.Windows.Forms.GroupBox grpBotoes;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnIntervaloVolta;
        private System.Windows.Forms.Button btnIntervaloInicio;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.GroupBox grpPonto;
        private System.Windows.Forms.DataGridView dgvPonto;
        private System.Windows.Forms.DataGridView dgvAtividades;
        private System.Windows.Forms.Panel pnlDataHora;
        private System.Windows.Forms.Button btnIniciarTarefa;
        private System.Windows.Forms.Button btnEncerrarTarefa;
        private System.Windows.Forms.Button btnFinalizarDia;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private DataGridView dgvAtividadesEncerradas;
        private Button btnListaPonto;
    }
}

