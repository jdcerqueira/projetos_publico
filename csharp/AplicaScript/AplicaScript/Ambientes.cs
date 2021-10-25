using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AplicaScript
{
    class Ambientes
    {
        public string servidor { get; set; }
        public Boolean autenticado { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string baseDados { get; set; }
        public string caminhoScripts { get; set; }
        public string[] scripts { get; set; }
    }
}