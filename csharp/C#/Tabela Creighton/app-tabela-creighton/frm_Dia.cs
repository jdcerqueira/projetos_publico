using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_tabela_creighton
{
    public partial class frm_Dia : Form
    {

        //Menstruacao
        Boolean _Menstruacao = false;
        Boolean flFluxoIntenso = false;
        Boolean flFluxoModerado = false;
        Boolean flFluxoLeve = false;
        Boolean flFluxoMuitoLeve = false;

        //Secrecao
        Boolean _Secrecao = false;
        Boolean flSeco = false;
        Boolean flUmido = false;
        Boolean flMolhado = false;
        Boolean flBrilhante = false;

        //Muco
        Boolean _Muco = false;
        Boolean flSeis = false;
        Boolean flOito = false;
        Boolean flDez = false;

        //Consistencia
        Boolean _Consistencia = false;
        Boolean flPostosa = false;
        Boolean flGrudento = false;

        //Cor
        Boolean _Cor = false;
        Boolean flMarrom = false;
        Boolean flVermelho = false;
        Boolean flAmarelo = false;
        Boolean flBranco = false;
        Boolean flBrancoTransparente = false;
        Boolean flTransparente = false;

        //Lubrificacao
        Boolean _Lubrificacao = false;

        public frm_Dia()
        {
            InitializeComponent();
            aberturaTela();
            controlaTela();
            carregaDataGridTabela();
        }

        private void carregaDataGridTabela()
        {
            dgvTabela.ColumnCount = 5;
            dgvTabela.AllowUserToAddRows = false;
            dgvTabela.ReadOnly = true;
            dgvTabela.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvTabela.Rows.Add();
            dgvTabela.Refresh();
        }

        private String geraCodigoTexto()
        {
            if(_Menstruacao)
            {
                if (flFluxoIntenso)
                    return "H";
                if (flFluxoModerado)
                    return "M";
                if (flFluxoLeve)
                    return "L";
                if (flFluxoMuitoLeve)
                    return "VL";
            }

            return "";
        }

        private void controlaTela()
        {
            // verifica menstruacao
            if (_Menstruacao)
            {
                desabilitaMenstruacao();

                if (flFluxoIntenso || flFluxoModerado)
                {
                    desabilitaSecrecao();
                    desabilitaLubrificacao();
                    desabilitaCores();
                    desabilitaMuco();
                }
            }

            txtCodigo.Text = geraCodigoTexto();
        }

        private void desabilitaMuco()
        {
            btnMucoSeis.Enabled = false;
            btnMucoOito.Enabled = false;
            btnMucoDez.Enabled = false;
        }

        private void desabilitaCores()
        {
            btnCorMarromPreto.Enabled = false;
            btnCorVermelho.Enabled = false;
            btnCorAmarelo.Enabled = false;
            btnCorBranco.Enabled = false;
            btnCorBrancoTransparente.Enabled = false;
            btnCorTransparente.Enabled = false;
        }

        private void desabilitaLubrificacao()
        {
            btnLubrificacao.Enabled = false;
        }

        private void desabilitaSecrecao()
        {
            btnSecrecaoSeco.Enabled = false;
            btnSecrecaoUmido.Enabled = false;
            btnSecrecaoMolhado.Enabled = false;
            btnSecrecaoBrilhante.Enabled = false;
        }

        private void desabilitaMenstruacao()
        {
            btnFluxoIntenso.Enabled = false;
            btnFluxoModerado.Enabled = false;
            btnFluxoLeve.Enabled = false;
            btnFluxoMuitoLeve.Enabled = false;
        }

        public void aberturaTela()
        {
            btnConsistenciaPastosa.Enabled = false;
            btnConsistenciaGrudento.Enabled = false;
            btnCorVermelho.Enabled = false;
            btnCorBranco.Enabled = false;
            btnCorBrancoTransparente.Enabled = false;
            btnCorAmarelo.Enabled = false;
            btnCorTransparente.Enabled = false;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            // Menstruação
            if(txtCodigo.Text.ToUpper() == "H")
            {
                //MessageBox.Show("Adesivo vermelho, menstruação - Fluxo intenso", "Título", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
            }
            else if(txtCodigo.Text.ToUpper() == "M")
            {
                //MessageBox.Show("Adesivo vermelho, menstruação - Fluxo moderado", "Título", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
            }
            else if (txtCodigo.Text.ToUpper() == "L")
            {
                //MessageBox.Show("Adesivo vermelho, menstruação - Fluxo leve", "Título", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
            }
            else if (txtCodigo.Text.ToUpper() == "VL")
            {
                //MessageBox.Show("Adesivo vermelho, menstruação - Fluxo muito leve", "Título", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
            }
            else if (txtCodigo.Text.ToUpper() == "B")
            {
                //MessageBox.Show("Adesivo vermelho, menstruação - Marrom ou preto", "Título", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
            }
           
            // Secreção infértil
            else if (txtCodigo.Text.ToUpper() == "0")
            {
                //MessageBox.Show("Adesivo verde seco.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Green;
            }
            else if (txtCodigo.Text.ToUpper() == "2")
            {
                //MessageBox.Show("Adesivo verde úmido sem lubrificação.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Green;
            }
            else if (txtCodigo.Text.ToUpper() == "4")
            {
                //MessageBox.Show("Adesivo verde brilhante sem lubrificação.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Green;
            }
            else if (txtCodigo.Text.ToUpper() == "2W")
            {
                //MessageBox.Show("Adesivo verde molhado sem lubrificação.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Green;
            }
                
            // Secreção fértil
            else if (txtCodigo.Text.ToUpper().Substring(0,1) == "6")
            {
                // Consistência
                if (txtCodigo.Text.ToUpper().Substring(1, 1) == "P" || txtCodigo.Text.ToUpper().Substring(1, 1) == "G")
                {

                    //Cor
                    if (txtCodigo.Text.ToUpper().Substring(2, 1) == "B" || txtCodigo.Text.ToUpper().Substring(2, 1) == "R")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Baixa elasticidade, com consistência, adesivo vermelho e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            //MessageBox.Show("Baixa elasticidade, com consistência, adesivo vermelho sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                    }
                    else if (txtCodigo.Text.ToUpper().Substring(2, 1) == "C" ||
                             txtCodigo.Text.ToUpper().Substring(2, 1) == "K" ||
                             txtCodigo.Text.ToUpper().Substring(2, 1) == "Y" ||
                             txtCodigo.Text.ToUpper().Substring(2, 2) == "CK")
                    {
                        //Sensação
                        if(txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1,1) == "L")
                        {
                            //MessageBox.Show("Baixa elasticidade, com consistência, adesivo branco com bebê e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                        else
                        {
                            //MessageBox.Show("Baixa elasticidade, com consistência, adesivo branco com bebê sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                    }
                }
                else
                {
                    //Cor
                    if (txtCodigo.Text.ToUpper().Substring(1, 1) == "B" || txtCodigo.Text.ToUpper().Substring(1, 1) == "R")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Baixa elasticidade, sem consistência, adesivo vermelho e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            //MessageBox.Show("Baixa elasticidade, sem consistência, adesivo vermelho sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                    }
                    else if (txtCodigo.Text.ToUpper().Substring(1, 1) == "C" ||
                             txtCodigo.Text.ToUpper().Substring(1, 1) == "K" ||
                             txtCodigo.Text.ToUpper().Substring(1, 1) == "Y" ||
                             txtCodigo.Text.ToUpper().Substring(1, 2) == "CK")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Baixa elasticidade, sem consistência, adesivo branco com bebê e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                        else
                        {
                            //MessageBox.Show("Baixa elasticidade, sem consistência, adesivo branco com bebê sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                    }
                }
            }

            else if (txtCodigo.Text.ToUpper().Substring(0, 1) == "8")
            {
                // Consistência
                if (txtCodigo.Text.ToUpper().Substring(1, 1) == "P" || txtCodigo.Text.ToUpper().Substring(1, 1) == "G")
                {
                    //Cor
                    if (txtCodigo.Text.ToUpper().Substring(2, 1) == "B" || txtCodigo.Text.ToUpper().Substring(2, 1) == "R")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Média elasticidade, com consistência, adesivo vermelho e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            //MessageBox.Show("Média elasticidade, com consistência, adesivo vermelho sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                    }
                    else if (txtCodigo.Text.ToUpper().Substring(2, 1) == "C" ||
                             txtCodigo.Text.ToUpper().Substring(2, 1) == "K" ||
                             txtCodigo.Text.ToUpper().Substring(2, 1) == "Y" ||
                             txtCodigo.Text.ToUpper().Substring(2, 2) == "CK")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Média elasticidade, com consistência, adesivo branco com bebê e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                        else
                        {
                            //MessageBox.Show("Média elasticidade, com consistência, adesivo branco com bebê sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                    }
                }
                else
                {
                    //Cor
                    if (txtCodigo.Text.ToUpper().Substring(1, 1) == "B" || txtCodigo.Text.ToUpper().Substring(1, 1) == "R")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Média elasticidade, sem consistência, adesivo vermelho e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            //MessageBox.Show("Média elasticidade, sem consistência, adesivo vermelho sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                    }
                    else if (txtCodigo.Text.ToUpper().Substring(1, 1) == "C" ||
                             txtCodigo.Text.ToUpper().Substring(1, 1) == "K" ||
                             txtCodigo.Text.ToUpper().Substring(1, 1) == "Y" ||
                             txtCodigo.Text.ToUpper().Substring(1, 2) == "CK")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Média elasticidade, sem consistência, adesivo branco com bebê e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                        else
                        {
                            //MessageBox.Show("Média elasticidade, sem consistência, adesivo branco com bebê sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                    }
                }
            }
            else if (txtCodigo.Text.ToUpper().Substring(0, 2) == "10")
            {
                // Consistência
                if (txtCodigo.Text.ToUpper().Substring(2, 1) == "P" || txtCodigo.Text.ToUpper().Substring(2, 1) == "G")
                {
                    //Cor
                    if (txtCodigo.Text.ToUpper().Substring(3, 1) == "B" || txtCodigo.Text.ToUpper().Substring(3, 1) == "R")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Alta elasticidade, com consistência, adesivo vermelho e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            //MessageBox.Show("Alta elasticidade, com consistência, adesivo vermelho sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                    }
                    else if (txtCodigo.Text.ToUpper().Substring(3, 1) == "C" ||
                             txtCodigo.Text.ToUpper().Substring(3, 1) == "K" ||
                             txtCodigo.Text.ToUpper().Substring(3, 1) == "Y" ||
                             txtCodigo.Text.ToUpper().Substring(3, 2) == "CK")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Alta elasticidade, com consistência, adesivo branco com bebê e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                        else
                        {
                            //MessageBox.Show("Alta elasticidade, com consistência, adesivo branco com bebê sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                    }
                }
                else if(txtCodigo.Text.ToUpper().Substring(2,2) == "DL")
                {
                    //MessageBox.Show("Alta elasticidade, sem consistência, sem cor, úmido, adesivo branco com bebê e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                    dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                }
                else if (txtCodigo.Text.ToUpper().Substring(2,2) == "SL")
                {
                    //MessageBox.Show("Alta elasticidade, sem consistência, sem cor, brilhante, adesivo branco com bebê e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                    dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                }
                else if (txtCodigo.Text.ToUpper().Substring(2,2) == "WL")
                {
                    //MessageBox.Show("Alta elasticidade, sem consistência, sem cor, molhado, adesivo branco com bebê e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                    dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                }
                else
                {
                    //Cor
                    if (txtCodigo.Text.ToUpper().Substring(2, 1) == "B" || txtCodigo.Text.ToUpper().Substring(2, 1) == "R")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Alta elasticidade, sem consistência, adesivo vermelho e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                        else
                        {
                            //MessageBox.Show("Alta elasticidade, sem consistência, adesivo vermelho sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        }
                    }
                    else if (txtCodigo.Text.ToUpper().Substring(2, 1) == "C" ||
                             txtCodigo.Text.ToUpper().Substring(2, 1) == "K" ||
                             txtCodigo.Text.ToUpper().Substring(2, 1) == "Y" ||
                             txtCodigo.Text.ToUpper().Substring(2, 2) == "CK")
                    {
                        //Sensação
                        if (txtCodigo.Text.ToUpper().Substring(txtCodigo.Text.Length - 1, 1) == "L")
                        {
                            //MessageBox.Show("Alta elasticidade, sem consistência, adesivo branco com bebê e lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                        else
                        {
                            //MessageBox.Show("Alta elasticidade, sem consistência, adesivo branco com bebê sem lubrificante.", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            dgvTabela.Rows[0].Cells[0].Style.BackColor = Color.WhiteSmoke;
                            dgvTabela.Rows[0].Cells[0].Value = "Bebê";
                        }
                    }
                }
            }
        }

        private void btnMenstruacaoIntenso_Click(object sender, EventArgs e)
        {
            _Menstruacao = true;
            flFluxoIntenso = true;
            controlaTela();
        }

        private void btnMenstruacaoModerado_Click(object sender, EventArgs e)
        {
            _Menstruacao = true;
            flFluxoModerado = true;
            controlaTela();
        }

        private void btnMenstruacaoLeve_Click(object sender, EventArgs e)
        {
            _Menstruacao = true;
            flFluxoLeve = true;
            controlaTela();
        }

        private void btnMenstruacaoMuitoLeve_Click(object sender, EventArgs e)
        {
            _Menstruacao = true;
            flFluxoMuitoLeve = true;
            controlaTela();
        }

        private void btnMenstruacaoMarromPreto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInfertilSeco_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\n0";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = false;
            grpSecrecao.Enabled = false;
        }

        private void btnInfertilUmido_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\n2";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = false;
            grpSecrecao.Enabled = false;
        }

        private void btnInfertilMolhado_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\n2W";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = false;
            grpSecrecao.Enabled = false;
        }

        private void btnInfertilBrilhante_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\n4";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = false;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilSeis_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\n6";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
            btnMucoOito.Enabled = false;
            btnMucoDez.Enabled = false;
            btnMucoSeis.Enabled = false;
        }

        private void btnFertilOito_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\n8";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
            btnMucoOito.Enabled = false;
            btnMucoDez.Enabled = false;
            btnMucoSeis.Enabled = false;
        }

        private void btnFertilDez_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\n10";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
            btnMucoOito.Enabled = false;
            btnMucoDez.Enabled = false;
            btnMucoSeis.Enabled = false;
        }

        private void btnFertilPastosa_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nP";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
            btnConsistenciaPastosa.Enabled = false;
            btnConsistenciaGrudento.Enabled = false;
        }

        private void btnFertilGrudento_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nG";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
            btnConsistenciaPastosa.Enabled = false;
            btnConsistenciaGrudento.Enabled = false;
        }

        private void btnFertilMarromPreto_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nB";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilVermelho_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nR";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilBranco_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nC";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilBrancoTransparente_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nCW";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilTransparente_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nK";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilAmarelo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nY";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilLubrificacao_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nL";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilUmido_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nDL";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilBrilhante_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nSL";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }

        private void btnFertilMolhado_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += "\nWL";
            grpMenstruacao.Enabled = false;
            grpMuco.Enabled = true;
            grpSecrecao.Enabled = false;
        }
    }
}
