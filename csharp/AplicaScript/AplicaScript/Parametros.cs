using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AplicaScript
{
    class Parametros
    {

        public string caminhoConfig { get; set; }
        public bool umProcVsMuitosServidores { get; set; }
        public bool argumentoInvalido { get; set; }
        public bool executaFolderCompleta { get; set; }

        public Parametros verificarParametros(string[] parametros)
        {
            this.argumentoInvalido = false;

            if (parametros.Length == 0 || parametros == null)
                this.argumentoInvalido = true;
            else
            {
                for(int ivc=0; ivc < parametros.Length; ivc++)
                {
                    switch (parametros[ivc])
                    {
                        case ("-m"):
                            this.caminhoConfig = parametros[ivc + 1];
                            break;
                        case ("-f"):
                            this.executaFolderCompleta = true;
                            break;
                    }
                }
            }

            // verifica os parametros obrigatorios
            if (caminhoConfig == null || caminhoConfig == "")
                this.argumentoInvalido = true;

            return this;
        }

    }
}