using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ibpj_controle_fontes_db_conf
{
    public class Utilitarios
    {
        public static string generateUniqueIdProject()
        {
            string newId = Guid.NewGuid().ToString("N").ToUpper();
            string idReturn = "";
            for (int ivc = 0; ivc < newId.Length; ivc++)
            {
                idReturn += newId[ivc];
                if (ivc == 7 || ivc == 11 || ivc == 15 || ivc == 19)
                    idReturn += "-";
            }

            // exemplo de retorno {4F2E2C19-372F-40D8-9FA7-9D2138C6997A}
            return idReturn;
        }

        public static void createDirectory(String path, String name)
        {
            try
            {
                Console.WriteLine("Diretório criado: " + path + @"\" + name);
                System.IO.Directory.CreateDirectory(path + @"\" + name);
                //OpcoesUtilitario.logExibeParametros(new string[] { "Diretório criado com sucesso.", caminho });
            }
            catch (Exception)
            {
                throw;
                //OpcoesUtilitario.logExibeParametros(new string[] { "Erro na criação do diretório.", caminho });
                //OpcoesUtilitario.logExibeParametros(new string[] { e.StackTrace });
            }
        }

        public static void createDirectory(String path)
        {
            Console.WriteLine("Diretório criado: " + path);
            System.IO.Directory.CreateDirectory(path);
        }

        public static void createFile(String path, String file, String content)
        {
            System.IO.File.WriteAllLines(path + @"\" + file, content.Split('\n'));
        }


        public static FileStream createFile(String path, String file)
        {
            return System.IO.File.Create(path + @"\" + file);
        }

        public static String queryFile(String file)
        {

            //"01-IDA_SCR_FiltroImplantacao.sql",
            //"02-IDA_SCR_CriaServico.sql",
            //"03-IDA_SCR_CriaPolitica.sql",
            //"04-IDA_SCR_MenuDinamico.sql",
            //"05-IDA_SCR_TipoServico.sql",
            //"06-IDA_SCR_EstatisticaOperador.sql"

            if (file == "01-IDA_SCR_FiltroImplantacao.sql")
                return QueryFilesBean.queryFile_FiltroImplantacaoIda();
            else
                return "SELECT 'Queryzinha Marota'";
        }

        public static void Sobre()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("\tSobre o Programa - Controle de Fontes para Base de Dados           ");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("\tInformações sobre o utilitário de controle para projetos de carga na base de dados - OFPJ e MBPJ.");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("\t[-Path          <caminho_solucao>       ]    Caminho do diretório da solução do SQL Server Management Studio");
            stringBuilder.AppendLine("\t[-Solution      <nome_solucao>          ]    Cria uma solução para o SQL Server Management Studio");
            stringBuilder.AppendLine("\t[-Branch        <nome_branch>           ]    Cria estrutura do Branch ou Ramo na solução");
            stringBuilder.AppendLine("\t[-Projects      <projeto_1,projeto_2...>]    Cria o projeto na solução do SQL Server Management Studio");
            stringBuilder.AppendLine("");
            Console.WriteLine(stringBuilder);
        }

        public static Parametros validaParametros(string[] args)
        {
            Parametros parametros = Parametros.initializeDefaultValues();

            if (args.Length == 0)
            {
                Utilitarios.mensagemErroInesperado();
            }
            else
            {
                

                for (int indexOfArray = 0; indexOfArray < args.Length; indexOfArray++)
                {
                    if (args[indexOfArray].ToLower() == "/?" ||
                        args[indexOfArray].ToLower() == "-help" ||
                        args[indexOfArray].ToLower() == "help" ||
                        args[indexOfArray].ToLower() == "?" ||
                        args[indexOfArray].ToLower() == "/help")
                    {
                        Utilitarios.Sobre();
                        parametros.help = true;
                        break;
                    }
                    else
                    {

                        if (args[indexOfArray] == "-Branch")
                        {
                            indexOfArray++;
                            parametros.Branch = args[indexOfArray];
                            Utilitarios.logExibeParametros(new string[] { "Identificado opção -Branch", args[indexOfArray] });
                        }

                        if (args[indexOfArray] == "-Solution")
                        {
                            indexOfArray++;
                            parametros.Solution = args[indexOfArray];
                            Utilitarios.logExibeParametros(new string[] { "Identificado opção -Solution", args[indexOfArray] });
                        }

                        if (args[indexOfArray] == "-Path")
                        {
                            indexOfArray++;
                            parametros.Path = args[indexOfArray];
                            Utilitarios.logExibeParametros(new string[] { "Identificado opção -Path", args[indexOfArray] });
                        }

                        if (args[indexOfArray] == "-Projects")
                        {
                            indexOfArray++;
                            parametros.Projects = args[indexOfArray];
                            Utilitarios.logExibeParametros(new string[] { "Identificado opção -Projects", args[indexOfArray] });
                        }
                    }
                }
            }

            return parametros;
        }

        public static void mensagemErroInesperado()
        {
            Utilitarios.logExibeParametros(new string[] { "Erro inesperado" });
            Utilitarios.logExibeParametros(new string[] { "É necessário informar uma instrução. Para maiores informações sobre os parametros, digite HELP" });

            //Console.WriteLine("Erro inesperado.");
            //Console.WriteLine("É necessário informar uma instrução, para maiores detalhes, \"help\"");
        }

        public static void mensagemParametroInvalido()
        {
            Utilitarios.logExibeParametros(new string[] { "Os parâmetros informados são inválidos." });
            Utilitarios.mensagemErroInesperado();
        }

        public static void logExibeParametros(string[] parametros)
        {
            string log = DateTime.Now.ToString() + " - ";
            for (int parametro = 0; parametro < parametros.Length; parametro++)
            {
                log += parametros[parametro] + ",";
            }
            log = log.Substring(0, log.Length - 1);
            //log += "}";
            Console.WriteLine(log);
        }
    }

    
}
