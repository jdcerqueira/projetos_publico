using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace controle_menu_dinamico
{
    class MenuDinamico : IEquatable<MenuDinamico>
    {
        public int cMenuDnamc { get; set; }
        public int? cNvelHierqMenuDnamc { get; set; }
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
        public int? cIndcdRestMenu { get; set; }
        public int? cIdtfdPosicItemMenuDnamc { get; set; }


        public override string ToString()
        {
            return "Menu: " + this.cMenuDnamc + 
                " - Ordem: " + this.cOrdSeqMenuDnamc + 
                " - Nome: " + this.iMenuDnamc +
                " - CAR: " + this.cAcssoDirtoMenuDnamc +
                " - Pai: " + this.cMenuDnamicPai;
        }

        public override int GetHashCode()
        {
            return this.cMenuDnamc;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MenuDinamico menuDinamico = obj as MenuDinamico;
            if (menuDinamico == null)
                return false;
            else
                return Equals(menuDinamico);

            //return base.Equals(obj);
        }


        public bool Equals(MenuDinamico other)
        {
            throw new NotImplementedException();
        }

        
    }
}