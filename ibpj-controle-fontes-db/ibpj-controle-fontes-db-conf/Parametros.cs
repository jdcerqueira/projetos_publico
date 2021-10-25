using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_fontes_db_conf
{
    public class Parametros
    {
        public Boolean help { get; set; }
        public String Path { get; set; }
        public String Solution { get; set; }
        public String Branch { get; set; }
        public String Projects { get; set; }

        public static Parametros initializeDefaultValues()
        {
            Parametros parametros = new Parametros();
            parametros.Path = "";
            parametros.Solution = "";
            parametros.Branch = "";
            parametros.Projects = "";
            parametros.help = false;
            return parametros;
        }

        public static Boolean getValidadeParameters(Parametros parametros)
        {
            // Verifica as opções de parametros
            if (!(parametros.Path == "" ||
                parametros.Solution == "" ||
                parametros.Branch == ""))
                return true;
            else
                Utilitarios.logExibeParametros(new string[] { "Para criação do projeto de base de dados, os paramêtros -Path, -Solution e -Branch são obrigatórios" });

            return false;
        }
    }
}
