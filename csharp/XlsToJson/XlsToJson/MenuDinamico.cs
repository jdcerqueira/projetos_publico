using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace XlsToJson
{
    class MenuDinamico
    {
        public int cMenuDnamc { get; set; }
        public int cNvelHierqMenuDnamc { get; set; }
        public string cOrdSeqMenuDnamc { get; set; }
        public string iMenuDnamc { get; set; }
        public string rMenuDnamc { get; set; }
        public int? cMenuDnamicPai { get; set; }
        public string cTpoPrmssAcsso { get; set; }
        public string cAcssoDirtoMenuDnamc { get; set; }
        public string wPlvraChaveMenuDnamc { get; set; }
        public string rAcssoDirtoMenuDnamc { get; set; }
        public string eUrlMenuDnamc { get; set; }
        public int? cEstilEspecMenuDnamc { get; set; }
        public int?[] cTpoContrNe { get; set; }
        public int? cGrpServcNe { get; set; }
        public int? cServcNe { get; set; }
        public int? cOperServcNe { get; set; }
        public int cIndcdRestMenu { get; set; }
        public int cIdtfdPosicItemMenuDnamc { get; set; }

    }
}

/*
 * [

  {
    "cMenuDnamc": 1,
    "cNvelHierqMenuDnamc": 1,
    "cOrdSeqMenuDnamc": "010101",
    "iMenuDnamc": "Menu do Suricato",
    "rMenuDnamc": "Menu do Suricato Asiático",
    "cMenuDnamicPai": 1,
    "tpPermissao": "C",
    "cAcssoDirtoMenuDnamc": "PPP",
    "wPlvraChaveMenuDnamc": "aaa;eee;bbb",
    "rAcssoDirtoMenuDnamc": "Menu do Suricato Asiático",
    "eUrlMenuDnamc": "http:\\www.uol.com.br",
    "cEstilEspecMenuDnamc": 17,
    "cTpoContrNe": [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 ],
    "cGrpServcNe": 1,
    "cServcNe": 1,
    "cOperServcNe": 1,
    "cIndcdRestMenu": 0,
    "cIdtfdPosicItemMenuDnamc": 1
  }
]
 */
