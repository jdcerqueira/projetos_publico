using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace AplicaScript
{
    class Config
    {
        public Parametros parametros { get; set; }

        public Config(Parametros parametros)
        {
            this.parametros = parametros;
        }

        public void imprimeCaminho()
        {
            Console.WriteLine("Diretório percorrido: " + this.parametros.caminhoConfig);
        }

        public String arquivoConfigApply()
        {
            String retorno = this.parametros.caminhoConfig.Replace("file:\\","") + @"\config.apply";
            return retorno;
        }

        public ConfigApply configApply()
        {
            if (this.parametros.argumentoInvalido)
                return null;

            ConfigApply configApply = JsonConvert.DeserializeObject<ConfigApply>(File.ReadAllText(arquivoConfigApply()));
            return configApply;
        }

        public StringBuilder arquivoSql(string caminho_arquivo)
        {
            StringBuilder retorno = new StringBuilder("");
            StreamReader streamReader = new StreamReader(caminho_arquivo);
            while(streamReader.ReadLine() != null)
            {
                retorno.Append(streamReader.ReadLine());
            }

            streamReader.Close();

            //retorno.AppendLine(caminho_arquivo);
            return retorno;
        }

        public void aplicarScripts(Ambientes ambientes)
        {
            try
            {
                for (int i = 0; i < ambientes.scripts.Length; i++)
                {
                    string argumento = @" -S """ + ambientes.servidor +
                                        "\" -d \"" + ambientes.baseDados +
                                        "\" -i \"" + ambientes.caminhoScripts + ambientes.scripts[i] + "\"" +
                                        " -I ";
                
                    if (!ambientes.autenticado)
                    {
                        argumento += " -U \"" + ambientes.usuario + "\"" +
                                     " -P \"" + ambientes.senha + "\"";
                    }
                    else
                    {
                        argumento += " -E ";
                    }

                    Process process = new Process();
                    process.StartInfo.FileName = "sqlcmd.exe";
                    process.StartInfo.Arguments = argumento;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.UseShellExecute = false;
                    process.Start();
                    string erro = process.StandardError.ReadToEnd();

                    if (!erro.Equals(""))
                    {
                        Console.WriteLine("Erro na execução do script: " + ambientes.scripts[i]);
                        Console.WriteLine("Erro: " + erro);
                    }
                    else
                    {
                        Console.WriteLine("Aplicado script: " + ambientes.scripts[i]);
                        Console.WriteLine("Output: " + process.StandardOutput.ReadToEnd());
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}