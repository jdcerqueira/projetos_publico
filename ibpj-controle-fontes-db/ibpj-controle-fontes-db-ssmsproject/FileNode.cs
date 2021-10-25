using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_fontes_db_ssmsproject
{
    public class FileNode
    {
        [System.Xml.Serialization.XmlAttribute]
        public string Name;

        public string AssociatedConnectionMoniker;
        public string AssociatedConnSrvName;
        public string AssociatedConnUserName;
        public string FullPath;

//         
        public static FileNode[] fileNodesDefaultOfpjd000Ida()
        {
            try
            {
                string AssociatedConnectionMoniker = @"8c91a03d-f9b4-46c0-a305-b5dcc79ff907:LABS178\HM1120A:True";
                string AssociatedConnSrvName = @"LABS178\HM1120A";

                string[] arquivosPadrao = new string[]
                {
                    "01-IDA_SCR_FiltroImplantacao.sql",
                    "02-IDA_SCR_CriaServico.sql",
                    "03-IDA_SCR_CriaPolitica.sql",
                    "04-IDA_SCR_MenuDinamico.sql",
                    "05-IDA_SCR_TipoServico.sql",
                    "06-IDA_SCR_EstatisticaOperador.sql"
                };

                FileNode[] fileNodes = new FileNode[arquivosPadrao.Length];

                for (int i = 0; i < arquivosPadrao.Length; i++)
                {
                    fileNodes[i] = new FileNode()
                    {
                        Name = arquivosPadrao[i],
                        AssociatedConnectionMoniker = AssociatedConnectionMoniker,
                        AssociatedConnSrvName = AssociatedConnSrvName,
                        AssociatedConnUserName = "",
                        FullPath = arquivosPadrao[i]
                    };
                }

                return fileNodes;
            }
            catch (Exception e)
            {
                //OpcoesUtilitario.logExibeParametros(new string[] { "Erro na execução do método", "fileNodesDefault" });
                throw;
            }

        }

        public static FileNode[] fileNodesDefaultOfpjd000Volta()
        {
            try
            {
                string AssociatedConnectionMoniker = @"8c91a03d-f9b4-46c0-a305-b5dcc79ff907:LABS178\HM1120A:True";
                string AssociatedConnSrvName = @"LABS178\HM1120A";

                string[] arquivosPadrao = new string[]
                {
                    "101-VOLTA_SCR_MenuDinamico.sql",
                    "102-VOLTA_SCR_EstatisticaOperador.sql",
                    "103-VOLTA_SCR_CriaPolitica.sql",
                    "104-VOLTA_SCR_CriaServico.sql",
                    "105-VOLTA_SCR_FiltroImplantacao.sql"
                };


                FileNode[] fileNodes = new FileNode[arquivosPadrao.Length];

                for (int i = 0; i < arquivosPadrao.Length; i++)
                {
                    fileNodes[i] = new FileNode()
                    {
                        Name = arquivosPadrao[i],
                        AssociatedConnectionMoniker = AssociatedConnectionMoniker,
                        AssociatedConnSrvName = AssociatedConnSrvName,
                        AssociatedConnUserName = "",
                        FullPath = arquivosPadrao[i]
                    };
                }

                return fileNodes;
            }
            catch (Exception e)
            {
                //OpcoesUtilitario.logExibeParametros(new string[] { "Erro na execução do método", "fileNodesDefault" });
                throw;
            }

        }

        public static FileNode[] fileNodesDefaultOfpjd001Ida()
        {
            try
            {
                string AssociatedConnectionMoniker = @"8c91a03d-f9b4-46c0-a305-b5dcc79ff907:LABS178\HM1120B:True";
                string AssociatedConnSrvName = @"LABS178\HM1120B";

                string[] arquivosPadrao = new string[]
                {
                    "01-IDA_SCR_EstatisticaOperador.sql"
                };

                FileNode[] fileNodes = new FileNode[arquivosPadrao.Length];

                for (int i = 0; i < arquivosPadrao.Length; i++)
                {
                    fileNodes[i] = new FileNode()
                    {
                        Name = arquivosPadrao[i],
                        AssociatedConnectionMoniker = AssociatedConnectionMoniker,
                        AssociatedConnSrvName = AssociatedConnSrvName,
                        AssociatedConnUserName = "",
                        FullPath = arquivosPadrao[i]
                    };
                }

                return fileNodes;
            }
            catch (Exception e)
            {
                //OpcoesUtilitario.logExibeParametros(new string[] { "Erro na execução do método", "fileNodesDefault" });
                throw;
            }

        }

        public static FileNode[] fileNodesDefaultOfpjd001Volta()
        {
            try
            {
                string AssociatedConnectionMoniker = @"8c91a03d-f9b4-46c0-a305-b5dcc79ff907:LABS178\HM1120B:True";
                string AssociatedConnSrvName = @"LABS178\HM1120B";

                string[] arquivosPadrao = new string[]
                {
                    
                    "101-VOLTA_SCR_EstatisticaOperador.sql"
                    
                };


                FileNode[] fileNodes = new FileNode[arquivosPadrao.Length];

                for (int i = 0; i < arquivosPadrao.Length; i++)
                {
                    fileNodes[i] = new FileNode()
                    {
                        Name = arquivosPadrao[i],
                        AssociatedConnectionMoniker = AssociatedConnectionMoniker,
                        AssociatedConnSrvName = AssociatedConnSrvName,
                        AssociatedConnUserName = "",
                        FullPath = arquivosPadrao[i]
                    };
                }

                return fileNodes;
            }
            catch (Exception e)
            {
                //OpcoesUtilitario.logExibeParametros(new string[] { "Erro na execução do método", "fileNodesDefault" });
                throw;
            }

        }

        
    }
}
