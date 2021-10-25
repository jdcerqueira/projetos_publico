using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_fontes_db_ssmsproject
{
    public class LogicalFolder
    {
        [System.Xml.Serialization.XmlAttribute]
        public string Name;
        [System.Xml.Serialization.XmlAttribute]
        public string Type;
        [System.Xml.Serialization.XmlAttribute]
        public bool Sorted = true;

        public Items Items;


        public static LogicalFolder[] createLogicalFolderDefault(ConnectionNode[] connectionNodes, FileNode[] fileNodes)
        {
            LogicalFolder[] logicalFolder = new LogicalFolder[]
            {
                new LogicalFolder()
                {
                    Name = "Connections",
                    Type = "2",
                    Items = new Items() { ConnectionNode = connectionNodes }
                },
                new LogicalFolder()
                {
                    Name = "Queries",
                    Type = "0",
                    Items = new Items() { FileNode = fileNodes }
                },
                new LogicalFolder()
                {
                    Name = "Miscellaneous",
                    Type = "3",
                    Items = new Items()
                }
            };

            return logicalFolder;
        }
    }
}
