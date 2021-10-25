using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controle_atividades_negocio;

namespace controle_atividades
{
    public partial class frm_Ponto : Form
    {
        String Entrada                      = "";
        String Almoco_Ini                   = "";
        String Almoco_Fim                   = "";
        String Janta_Ini                    = "";
        String Janta_Fim                    = "";
        String Saida                        = "";
        String TerminoExpedientePrevisto    = "";
        String SaldoHoras                   = "";
        frm_Relogio _ApresentaData_UC = new frm_Relogio();
        DateTime HorasExpediente = DateTime.ParseExact("08:00:00","HH:mm:ss",System.Globalization.CultureInfo.InvariantCulture);

        public frm_Ponto()
        {
            InitializeComponent();
            preparaVisualizacaoDadosPonto();
            preparaVisualizacaoDadosAtividades();

            _ApresentaData_UC.Dock = DockStyle.Fill;
            pnlDataHora.Controls.Add(_ApresentaData_UC);

            carregaAtividadesPendentes();
            //carregaAtividadesEncerradas();
            carregaDadosPontoDia();
            regraBotoesPonto();

            this.Text += " - " + Util.Constantes.versaoProduto;
        }


        private void btnEntrada_Click(object sender, EventArgs e)
        {
            registraEntrada();
            regraBotoesPonto();
        }


        private void btnIntervaloInicio_Click(object sender, EventArgs e)
        {
            registraIntervaloInicio();
            regraBotoesPonto();
        }


        private void btnIntervaloVolta_Click(object sender, EventArgs e)
        {
            registraIntervaloVolta();
            regraBotoesPonto();
        }

        
        private void btnSaida_Click(object sender, EventArgs e)
        {
            registraSaida();
            regraBotoesPonto();
            defineHoraExtra_SaldoHoras();
            encerraAtividadesSemDataFinal();
        }

        private void btnIniciarTarefa_Click(object sender, EventArgs e)
        {
            frm_Atividades _frm_Atividades = new frm_Atividades(Util.Constantes.ModoTela.Escrita, null);
            _frm_Atividades.ShowDialog();

            if (_frm_Atividades.DialogResult == DialogResult.OK)
            {
                if (_frm_Atividades.Atividades.Atuacao.fim != "")
                    incluiLinhaAtividadeEncerrada(_frm_Atividades.Atividades);
                else
                    incluiLinhaAtividade(_frm_Atividades.Atividades);
            }
                
            dgvAtividades.Refresh();
            regraBotoesPonto();
        }

        private void btnEncerrarTarefa_Click(object sender, EventArgs e)
        {

            if(dgvAtividades.Rows[dgvAtividades.CurrentRow.Index].Cells[2].Value.ToString() == "")
            {
                MessageBox.Show("Para encerrar uma atividade, deve-se informar o início dela.",
                    "Atividade Inconsistente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else 
            {
                DateTime? previsao = null;
                if (dgvAtividades.Rows[dgvAtividades.CurrentRow.Index].Cells["Previsao"].Value.ToString() != "")
                    previsao = Util.StringToDatetime(dgvAtividades.Rows[dgvAtividades.CurrentRow.Index].Cells["Previsao"].Value.ToString());

                incluiLinhaAtividadeEncerrada(new Atividades()
                {
                    Nome = dgvAtividades.Rows[dgvAtividades.CurrentRow.Index].Cells[0].Value.ToString(),
                    Descricao = dgvAtividades.Rows[dgvAtividades.CurrentRow.Index].Cells[1].Value.ToString(),
                    Atuacao = new Intervalo()
                    {
                        inicio = dgvAtividades.Rows[dgvAtividades.CurrentRow.Index].Cells[2].Value.ToString(),
                        fim = new frm_Relogio().DataHora()
                    },
                    status = true,
                    previsao = previsao
                });

                dgvAtividades.Rows.RemoveAt(dgvAtividades.CurrentRow.Index);
                dgvAtividades.Refresh();
                regraBotoesPonto();
            }
        }

        private void btnExcluirTarefa_Click(object sender, EventArgs e)
        {

            // MessageBox.Show(dgvAtividades.Rows.Count.ToString());
            if (dgvAtividades.CurrentRow.Index == 0)
                dgvAtividades.Rows.RemoveAt(0);
            else
                dgvAtividades.Rows.Remove(dgvAtividades.CurrentRow);

            dgvAtividades.Refresh();
            regraBotoesPonto();
        }

        private void dgvAtividades_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int i = dgvAtividades.CurrentRow.Index;
                DateTime? previsao = null;

                if (dgvAtividades.Rows[i].Cells["Previsao"].Value != null && dgvAtividades.Rows[i].Cells["Previsao"].Value.ToString() != "")
                    previsao = Util.StringToDatetime(dgvAtividades.Rows[i].Cells["Previsao"].Value.ToString());

                frm_Atividades _Atividades = new frm_Atividades
                (Util.Constantes.ModoTela.Leitura,
                   new Atividades()
                   {
                       Nome = dgvAtividades.Rows[i].Cells[0].Value.ToString(),
                       Descricao = dgvAtividades.Rows[i].Cells[1].Value.ToString(),
                       Atuacao = new Intervalo()
                       {
                           inicio = dgvAtividades.Rows[i].Cells[2].Value.ToString(),
                           fim = dgvAtividades.Rows[i].Cells[3].Value.ToString()
                       },
                       previsao = previsao
                   });

                _Atividades.ShowDialog();

                if (_Atividades.DialogResult == DialogResult.OK)
                {
                    if (_Atividades.Atividades.Atuacao.fim != "")
                    {
                        dgvAtividadesEncerradas.Rows.Add(
                            _Atividades.Atividades.Nome,
                            _Atividades.Atividades.Descricao,
                            _Atividades.Atividades.Atuacao.inicio,
                            _Atividades.Atividades.Atuacao.fim,
                            _Atividades.Atividades.status.ToString().ToLower(),
                            _Atividades.Atividades.previsao.ToString()
                            );

                        dgvAtividades.Rows.RemoveAt(i);
                    }
                    else
                    {
                        dgvAtividades.Rows[i].Cells["Nome"].Value = _Atividades.Atividades.Nome;
                        dgvAtividades.Rows[i].Cells["Descricao"].Value = _Atividades.Atividades.Descricao;
                        dgvAtividades.Rows[i].Cells["Inicio"].Value = _Atividades.Atividades.Atuacao.inicio;
                        dgvAtividades.Rows[i].Cells["Fim"].Value = _Atividades.Atividades.Atuacao.fim;
                        dgvAtividades.Rows[i].Cells["Previsao"].Value = _Atividades.Atividades.previsao.ToString();
                        dgvAtividades.Rows[i].Cells["Status"].Value = _Atividades.Atividades.status.ToString().ToLower();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERR: Ocorreu uma exceção.\n" + ex.Message);
            }

            dgvAtividades.Refresh();
        }

        private void btnFinalizarDia_Click(object sender, EventArgs e)
        {
            finalizaDia();
            Application.Exit();
        }

        private void dgvAtividades_SelectionChanged(object sender, EventArgs e)
        {
            regraBotoesPonto();
        }

        private void btnListaPonto_Click(object sender, EventArgs e)
        {
            frm_ListaPonto _ListaPonto = new frm_ListaPonto();
            _ListaPonto.ShowDialog();
        }
    }
}
