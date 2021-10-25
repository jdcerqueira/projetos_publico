using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_fontes_git
{

    public class Arquivo
    {
        public static List<ArquivoJson> deserializerListaArquivoJson(String file)
        { 
            return JsonConvert.DeserializeObject <List<ArquivoJson>> (file);
        }
        
    }

    public class ArquivoJson
    {
        public String nome { get; set; }
        public String sobrenome { get; set; }
        public int idade { get; set; }
        public String dataNascimento { get; set; }

        override
        public String ToString()
        {
            return "Nome: " + this.nome + "," +
                "Sobrenome: " + this.sobrenome + "," +
                "Idade: " + this.idade + "," +
                "Data de Nascimento: " + this.dataNascimento;
        }
    }

    public class ListaArquivoJson
    {
        public List<ArquivoJson> arquivoJson { get; set; }
    }

    public class GitActions
    {

        public static String loadPreviousFile(String file, String directory)
        {
            return GitActions.GitComando("git show HEAD:" + file, directory);
        }

        public static String loadFileComplete(String fullPathFile)
        {
            return File.ReadAllText(fullPathFile);
        }


        public static String GitComando(String gitComando, String diretorio)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/c " + gitComando.ToString());
                processStartInfo.RedirectStandardInput = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.StandardOutputEncoding = Encoding.UTF8;
                processStartInfo.WorkingDirectory = diretorio.ToString();

                Process process = new Process();
                process.StartInfo = processStartInfo;
                process.Start();

                StringBuilder stringBuilder = new StringBuilder();
                process.OutputDataReceived += delegate (object sender, DataReceivedEventArgs e)
                {
                    stringBuilder.AppendLine(e.Data);
                };
                process.ErrorDataReceived += delegate (object sender, DataReceivedEventArgs e)
                {
                    stringBuilder.AppendLine(e.Data);
                };

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();

                return stringBuilder.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

    }
}
