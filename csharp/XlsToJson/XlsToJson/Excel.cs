using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace XlsToJson
{
    class Excel
    {
        public DataSet retornarSheet(string fileName)
        {
            FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelDataReader;
            excelDataReader = ExcelReaderFactory.CreateBinaryReader(fileStream);
            DataSet dataSet = excelDataReader.AsDataSet();
            fileStream.Close();
            return dataSet;
        }

        public List<MenuDinamico> lerArquivoMenuDinamico(string fileName)
        {

            List<MenuDinamico> listMenu = new List<MenuDinamico>();
            try
            {
                DataSet menuDinamicoDs = this.retornarSheet(fileName);
                for(int linhaMenu = 3; linhaMenu < menuDinamicoDs.Tables["Visão Menu"].Rows.Count; linhaMenu++)
                {
                    MenuDinamico menuDinamico = new MenuDinamico();
                    
                    // inicia alguns campos do bean
                    menuDinamico.iMenuDnamc = "";
                    menuDinamico.rMenuDnamc = "";
                    menuDinamico.cAcssoDirtoMenuDnamc = null;
                    menuDinamico.wPlvraChaveMenuDnamc = null;
                    menuDinamico.rAcssoDirtoMenuDnamc = null;
                    menuDinamico.eUrlMenuDnamc = "";
                    menuDinamico.cIndcdRestMenu = 0;
                    menuDinamico.cTpoContrNe = new int?[12];
                    menuDinamico.cTpoPrmssAcsso = null;

                    menuDinamico.cMenuDnamc = Int32.Parse(menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][0].ToString());
                    menuDinamico.cNvelHierqMenuDnamc = Int32.Parse(menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][1].ToString());
                    menuDinamico.cOrdSeqMenuDnamc = menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][2].ToString();
                    menuDinamico.iMenuDnamc = menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][6].ToString();
                    menuDinamico.rMenuDnamc = menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][7].ToString();

                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][8].ToString() != "" &&
                        menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][8].ToString().ToUpper() != "NULL")
                        menuDinamico.cMenuDnamicPai = Int32.Parse(menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][8].ToString());

                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][9].ToString().ToUpper() == "SERVIÇO")
                        menuDinamico.cTpoPrmssAcsso = "S";
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][9].ToString().ToUpper() == "CONTA")
                        menuDinamico.cTpoPrmssAcsso = "C";
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][9].ToString().ToUpper() == "CONTA COBRANÇA")
                        menuDinamico.cTpoPrmssAcsso = "B";
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][9].ToString().ToUpper() == "MASTER")
                        menuDinamico.cTpoPrmssAcsso = "M";


                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][10].ToString() != "")
                        menuDinamico.cAcssoDirtoMenuDnamc = menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][10].ToString();

                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][11].ToString() != "")
                        menuDinamico.wPlvraChaveMenuDnamc = menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][11].ToString();

                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][12].ToString() != "")
                        menuDinamico.rAcssoDirtoMenuDnamc = menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][12].ToString();

                    menuDinamico.eUrlMenuDnamc = menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][13].ToString();
                    
                    if(menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][14].ToString() != "")
                        menuDinamico.cEstilEspecMenuDnamc = Int32.Parse(menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][14].ToString());

                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][26].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[0] = 0;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][15].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[1] = 1;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][16].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[2] = 2;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][17].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[3] = 3;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][18].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[4] = 4;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][19].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[5] = 5;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][20].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[6] = 6;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][21].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[7] = 7;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][22].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[8] = 8;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][23].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[9] = 9;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][24].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[10] = 10;
                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][25].ToString().ToUpper() == "X")
                        menuDinamico.cTpoContrNe[11] = 11;


                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][27].ToString() != "")
                        menuDinamico.cGrpServcNe = Int32.Parse(menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][27].ToString());

                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][28].ToString() != "")
                        menuDinamico.cServcNe = Int32.Parse(menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][28].ToString());

                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][29].ToString() != "")
                        menuDinamico.cOperServcNe = Int32.Parse(menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][29].ToString());

                    if (menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][30].ToString().ToUpper() == "X")
                        menuDinamico.cIndcdRestMenu = 1;

                    menuDinamico.cIdtfdPosicItemMenuDnamc = Int32.Parse(menuDinamicoDs.Tables["Visão Menu"].Rows[linhaMenu][31].ToString());

                    listMenu.Add(menuDinamico);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return listMenu;
            
        }

        public List<GrupoServicos> lerArquivoServicosNe(string fileName)
        {

            List<GrupoServicos> grupos = new List<GrupoServicos>();

            try{

                // Declara os DataSets para retornar as listas de cada aba
                DataSet grupoDs = this.retornarSheet(fileName);
                DataSet servicoDs = this.retornarSheet(fileName);
                DataSet tipoServicoDs = this.retornarSheet(fileName);


                // encontra os grupos de servico
                for(int linhaGrupo = 1; linhaGrupo < grupoDs.Tables["tbGrupoServico"].Rows.Count; linhaGrupo++)
                {
                    GrupoServicos grupo = new GrupoServicos();
                    if(grupoDs.Tables["tbGrupoServico"].Rows[linhaGrupo][0].ToString() == "")
                    {
                        grupo.cdGrupo = 0;
                    }
                    else
                    {
                        grupo.cdGrupo = Int32.Parse(grupoDs.Tables["tbGrupoServico"].Rows[linhaGrupo][0].ToString());
                    }
                    grupo.dsGrupo = grupoDs.Tables["tbGrupoServico"].Rows[linhaGrupo][1].ToString();

                    // encontra os servicos
                    List<Servicos> servicos = new List<Servicos>();
                    for (int linhaServico = 1; linhaServico < servicoDs.Tables["tbServico"].Rows.Count; linhaServico++)
                    {
                        int cdGrupoServico = Int32.Parse(servicoDs.Tables["tbServico"].Rows[linhaServico][0].ToString());
                        if(cdGrupoServico == grupo.cdGrupo)
                        {
                            
                            Servicos servico = new Servicos();
                            if(servicoDs.Tables["tbServico"].Rows[linhaServico][1].ToString() == "")
                            {
                                servico.cdServico = 0;
                            }
                            else
                            {
                                servico.cdServico = Int32.Parse(servicoDs.Tables["tbServico"].Rows[linhaServico][1].ToString());
                            }
                            servico.dsServico = servicoDs.Tables["tbServico"].Rows[linhaServico][2].ToString();


                            List<TipoServicos> tipoServicos = new List<TipoServicos>();
                            for (int linhaTipoServico = 1; linhaTipoServico < tipoServicoDs.Tables["tTipoServico"].Rows.Count; linhaTipoServico++)
                            {
                                int cdGrupoTipoServico;
                                if(tipoServicoDs.Tables["tTipoServico"].Rows[linhaTipoServico][0].ToString() == "")
                                {
                                    cdGrupoTipoServico = 0;
                                }
                                else
                                {
                                    cdGrupoTipoServico = Int32.Parse(tipoServicoDs.Tables["tTipoServico"].Rows[linhaTipoServico][0].ToString());
                                }
                                int cdServicoTipoServico;
                                if (tipoServicoDs.Tables["tTipoServico"].Rows[linhaTipoServico][1].ToString() == "")
                                {
                                    cdServicoTipoServico = 0;
                                }
                                else
                                {
                                    cdServicoTipoServico = Int32.Parse(tipoServicoDs.Tables["tTipoServico"].Rows[linhaTipoServico][1].ToString());
                                }

                                if (cdGrupoTipoServico == grupo.cdGrupo && cdServicoTipoServico == servico.cdServico)
                                {
                                    TipoServicos tipo = new TipoServicos();
                                    if(tipoServicoDs.Tables["tTipoServico"].Rows[linhaTipoServico][2].ToString() == "")
                                    {
                                        tipo.tpServico = 0;
                                    }
                                    else
                                    {
                                        tipo.tpServico = Int32.Parse(tipoServicoDs.Tables["tTipoServico"].Rows[linhaTipoServico][2].ToString());
                                    }
                                    tipo.dsTipoServico = tipoServicoDs.Tables["tTipoServico"].Rows[linhaTipoServico][3].ToString();
                                    tipoServicos.Add(tipo);
                                }
                            }

                            servico.tipoServicos = tipoServicos;
                            servicos.Add(servico);
                        }
                    }

                    grupo.servicos = servicos;
                    grupos.Add(grupo);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return grupos;
        }
    }
}