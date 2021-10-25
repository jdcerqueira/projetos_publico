using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XlsToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //string json = JsonConvert.SerializeObject(new Excel().lerArquivoServicosNe(@"D:\TFS\DOC_Controle_de_Codigos\Controle_codigos_servicos.xls").ToArray());
            //File.WriteAllText("teste.json", json);

            string json = JsonConvert.SerializeObject(new Excel().lerArquivoMenuDinamico(@"D:\TFS\DOC_Controle_de_Codigos\Planilha Menu_HML.xls").ToArray());
            File.WriteAllText("Controle_Menu_Dinamico.json", json);
        }
    }
}
