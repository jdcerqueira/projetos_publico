using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace XlsToJson
{
    class GrupoServicos
    {
        public int cdGrupo { get; set; }
        public string dsGrupo { get; set; }
        public List<Servicos> servicos { get; set; }

    }
}