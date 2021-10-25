using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace ibpj_teste_unitario
{
    class Program
    {
        const String fileName = @"D:\SQLServer\ArquivosTexto\2018\01\TbSessoesEst_hist.xml";
        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(fileName);
            XmlNode xmlNode = xmlDocument.DocumentElement;
            XmlNodeList xmlNodeList;

            xmlNodeList = xmlNode.SelectNodes("descendant::RECORD");
            foreach (var item in xmlNodeList)
            {
                Console.WriteLine(item);
            }




            //XPathNavigator nav = new XPathDocument(fileName).CreateNavigator();

            //nav.MoveToRoot();

            ////Move to the first child node (comment field).
            //nav.MoveToFirstChild();
            //nav.MoveToFirstChild();

            //do
            //{
            //    //Find the first element.
            //    if (nav.NodeType == XPathNodeType.Element)
            //    {
            //        //Determine whether children exist.
            //        if (nav.HasChildren == true)
            //        {
            //            //Move to the first child.
            //            nav.MoveToFirstChild();
            //            //Loop through all of the children.
            //            do
            //            {
            //                //Display the data.
            //                Console.Write("The XML string for this child ");
            //                Console.WriteLine("is '{0}'", nav.Name);
            //                //Check for attributes.
            //                if (nav.HasAttributes == true)
            //                {
            //                    Console.WriteLine("This node has attributes");
            //                }
            //            } while (nav.MoveToNext());
            //        }
            //    }
            //} while (nav.MoveToNext());
            ////Pause.
            ////Console.ReadLine();
        }
        
    }

    public class LineData
    {
        public Record record { get; set; }
        public Row row { get; set; }
    }

    public class Record
    {
        public int id { get; set; }
        public int max_length { get; set; }
        public String collation { get; set; }
    }

    public class Row
    {
        public int source { get; set; }
        public String name { get; set; }

    }
}
