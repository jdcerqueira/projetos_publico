using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ibpj_controle_fontes_db
{

    public class Filtro
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ibpj_controle_fontes_db_conf.Parametros parametros = ibpj_controle_fontes_db_conf.Utilitarios.validaParametros(args);

            if (!parametros.help)
                if (!ibpj_controle_fontes_db_conf.Parametros.getValidadeParameters(parametros))                
                    ibpj_controle_fontes_db_conf.Utilitarios.mensagemParametroInvalido();
                else
                    ibpj_controle_fontes_db_ssmsproject.SolutionBean.solutionDefault(parametros.Solution, parametros.Path, parametros.Branch, parametros.Projects);
        } 
    }
}
