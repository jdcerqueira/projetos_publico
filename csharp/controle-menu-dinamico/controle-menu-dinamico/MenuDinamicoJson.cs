using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controle_menu_dinamico
{
    class MenuDinamicoJson
    {
        public Menus novosMenusDisponiveis(Menus menuCompleto, Menus menuManutencao)
        {
            List<MenuDinamico> novoMenu = new List<MenuDinamico>();
            try
            {
                foreach (var menu in menuCompleto.menus)
                {
                    if (menu.cNvelHierqMenuDnamc == 2 && menuManutencao.menus.Exists(x => x.cMenuDnamicPai == menu.cMenuDnamc))
                    {
                        for (int codigoMenuLivre = menu.cMenuDnamc; codigoMenuLivre <= (menu.cMenuDnamc + 99); codigoMenuLivre++)
                        {
                            if (!menuCompleto.menus.Exists(x => x.cMenuDnamc == codigoMenuLivre))
                                novoMenu.Add(new MenuDinamico
                                {
                                    cMenuDnamc = codigoMenuLivre,
                                    cMenuDnamicPai = menu.cMenuDnamc
                                });

                            if (menuManutencao.menus.FindAll(x => x.cMenuDnamicPai == menu.cMenuDnamc).Count ==
                                novoMenu.FindAll(x => x.cMenuDnamicPai == menu.cMenuDnamc).Count)
                                break;
                        }
                    }

                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return new Menus { menus = novoMenu } ;
        }

        public string cabecalhoScript()
        {
            string retorno = "USE OFPJD000\n";
            retorno += "GO\n";
            retorno += "\n";
            retorno += "SET TRANSACTION ISOLATION LEVEL\n";
            retorno += "SET NOCOUNT ON\n";
            return retorno;
        }

        public string toJson(object menuDinamico)
        {
            return JsonConvert.SerializeObject(menuDinamico);
        }

        public string geraScriptAlteracaoMenu(MenuDinamico menuManutencao, MenuDinamico menuCompleto)
        {
            string retorno = "";

            if (this.toJson(menuCompleto) != this.toJson(menuManutencao) )
            {

                retorno = "UPDATE dbo.tMenuDnamc SET cMenuDnamc = cMenuDnamc ";
                if (menuManutencao.iMenuDnamc != menuCompleto.iMenuDnamc)
                    retorno += ", iMenuDnamc = '" + menuManutencao.iMenuDnamc + "'";
                if (menuManutencao.rMenuDnamc != menuCompleto.rMenuDnamc)
                    retorno += ", rMenuDnamc = '" + menuManutencao.rMenuDnamc + "'";
                if (menuManutencao.eUrlMenuDnamc != menuCompleto.eUrlMenuDnamc)
                    retorno += ", eUrlMenuDnamc = '" + menuManutencao.eUrlMenuDnamc + "'";
                if (menuManutencao.cNvelHierqMenuDnamc != menuCompleto.cNvelHierqMenuDnamc)
                    retorno += ", cNvelHierqMenuDnamc = " + menuManutencao.cNvelHierqMenuDnamc;
                if (menuManutencao.cOrdSeqMenuDnamc != menuCompleto.cOrdSeqMenuDnamc)
                    retorno += ", cOrdSeqMenuDnamc = '" + menuManutencao.cOrdSeqMenuDnamc + "'";
                if (menuManutencao.cIdtfdPosicItemMenuDnamc != menuCompleto.cIdtfdPosicItemMenuDnamc)
                    retorno += ", cIdtfdPosicItemMenuDnamc = " + menuManutencao.cIdtfdPosicItemMenuDnamc;
                if (menuManutencao.cTpoPrmssAcsso != menuCompleto.cTpoPrmssAcsso)
                    retorno += ", cTpoPrmssAcsso = '" + menuManutencao.cTpoPrmssAcsso + "'";
                if (menuManutencao.cIndcdRestMenu != menuCompleto.cIndcdRestMenu)
                    retorno += ", cIndcdRestMenu = " + menuManutencao.cIndcdRestMenu;
                if (menuManutencao.cEstilEspecMenuDnamc != menuCompleto.cEstilEspecMenuDnamc)
                    retorno += ", cEstilEspecMenuDnamc = " + menuManutencao.cEstilEspecMenuDnamc;
                if (menuManutencao.cAcssoDirtoMenuDnamc != menuCompleto.cAcssoDirtoMenuDnamc)
                    retorno += ", cAcssoDirtoMenuDnamc = " + (menuManutencao.cAcssoDirtoMenuDnamc == "" ? "NULL" : "'" + menuManutencao.cAcssoDirtoMenuDnamc + "'");

                retorno += " WHERE cMenuDnamc = " + menuManutencao.cMenuDnamc + "\n";

                if(!menuCompleto.cTpoContrNe.SequenceEqual(menuManutencao.cTpoContrNe))
                {
                    retorno += "DELETE FROM dbo.tMenuDnamcTpoContr WHERE cMenuDnamc = " + menuManutencao.cMenuDnamc + "\n";
                    retorno += "INSERT INTO dbo.tMenuDnamcTpoContr (cMenuDnamc, cTpoContrNe)\nVALUES";
                    for (int ivc = 0; ivc < menuManutencao.cTpoContrNe.Length; ivc++)
                        retorno += (menuManutencao.cTpoContrNe[ivc] != null ? "(" + menuManutencao.cMenuDnamc + "," + menuManutencao.cTpoContrNe[ivc] + ")," : "");

                    retorno = retorno.Substring(0, retorno.Length - 1) + "\n";
                }

                if (menuManutencao.cGrpServcNe != menuCompleto.cGrpServcNe)
                {
                    retorno += "DELETE FROM dbo.tMenuDnamcServc WHERE cMenuDnamc = " + menuManutencao.cMenuDnamc + "\n";

                    if(menuManutencao.cGrpServcNe != null)
                        retorno += "INSERT INTO dbo.tMenuDnamcServc (cMenuDnamc, cGrpServcNe, cServcNe, cOperServcNe)\n" +
                            "VALUES(" + menuManutencao.cMenuDnamc + "," +
                            menuManutencao.cGrpServcNe + "," +
                            (menuManutencao.cServcNe == null ? "NULL" : menuManutencao.cServcNe.ToString()) + "," +
                            (menuManutencao.cOperServcNe == null ? "NULL" : menuManutencao.cOperServcNe.ToString()) + ")\n";
                }
            }

            return retorno;
        }

        public Menus geraNovoMenuCompleto(Menus parm_menuCompleto, Menus parm_menuManutencao, Menus parm_novoMenu)
        {
            Menus novoMenuCompleto = new Menus();
            novoMenuCompleto.menus = new List<MenuDinamico>();

            foreach(MenuDinamico menuCompleto in parm_menuCompleto.menus)
            {
                MenuDinamico menuManutencao =
                parm_menuManutencao.menus.Find(x =>
                {
                    return 
                        x.cMenuDnamicPai == menuCompleto.cMenuDnamicPai &&
                        String.Compare(x.cOrdSeqMenuDnamc,menuCompleto.cOrdSeqMenuDnamc) == 1 &&
                        !(menuCompleto.cOrdSeqMenuDnamc.IndexOf(x.cOrdSeqMenuDnamc.Substring(0,x.cOrdSeqMenuDnamc.Length - 2),0) == 0)
                    ;
                });

                if(menuManutencao != null)
                    Console.WriteLine(menuCompleto.ToString(), menuManutencao);

                //novoMenuCompleto.menus.Add(menuManutencao);
            }

            return novoMenuCompleto;
        }
    }
}