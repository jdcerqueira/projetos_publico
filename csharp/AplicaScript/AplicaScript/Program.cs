using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaScript
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Config config = new Config(new Parametros().verificarParametros(args));
                config.imprimeCaminho();

                for (int i=0; i < config.configApply().ambientes.Length; i++)
                {
                    Ambientes ambientes = new Ambientes();
                    ambientes.servidor = config.configApply().ambientes[i].servidor;
                    ambientes.autenticado = config.configApply().ambientes[i].autenticado;
                    ambientes.usuario = config.configApply().ambientes[i].usuario;
                    ambientes.senha = config.configApply().ambientes[i].senha;
                    ambientes.baseDados = config.configApply().ambientes[i].baseDados;
                    ambientes.caminhoScripts = config.configApply().ambientes[i].caminhoScripts;

                    if(config.parametros.executaFolderCompleta)
                    {
                        string[] arquivos = Directory.GetFiles(config.parametros.caminhoConfig, "*.sql");
                        ambientes.scripts = new string[arquivos.Length];
                        int ivc = 0;
                        foreach (string arquivo in arquivos)
                        {
                            ambientes.scripts[ivc] = arquivo.Replace(config.parametros.caminhoConfig, "");
                            ivc++;
                        }
                    }
                    else
                    {
                        ambientes.scripts = config.configApply().ambientes[i].scripts;
                    }

                    Console.WriteLine("Processo de aplicação dos scripts");
                    Console.WriteLine("Servidor:" + ambientes.servidor);
                    Console.WriteLine("Base de Dados: " + ambientes.baseDados);

                    config.aplicarScripts(ambientes);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
