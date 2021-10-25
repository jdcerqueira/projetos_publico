using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_fontes_db_ssmsproject
{
    public class Items
    {
        [System.Xml.Serialization.XmlElement]
        public ConnectionNode[] ConnectionNode;

        [System.Xml.Serialization.XmlElement]
        public FileNode[] FileNode;
    }
}
