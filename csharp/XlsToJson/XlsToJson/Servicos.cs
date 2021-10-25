using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace XlsToJson
{
    class Servicos
    {
        public int cdServico { get; set; }
        public string dsServico { get; set; }
        public List<TipoServicos> tipoServicos { get; set; }

    }
}