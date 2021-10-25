using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

namespace db_devops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            XmlDocument doc = new XmlDocument();
            doc.Load(@"Menu.xml");
            var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);
            File.WriteAllText(@"MenuTeste.json",json.ToString());
            */

            new ManutencaoMenuDinamico().exibirSelecaoFamilia();
        }
    }
}
