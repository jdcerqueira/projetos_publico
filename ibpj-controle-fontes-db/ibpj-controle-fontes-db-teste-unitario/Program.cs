using ibpj_controle_fontes_git;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ibpj_controle_fontes_db_ssmsproject;

namespace ibpj_controle_fontes_db_teste_unitario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CompareFiltros filtros = new CompareFiltros();
            filtros.antes = FiltroImplantacao.carregaFiltroImplantacao("Controle_Filtro_Implantacao.json","GIT");
            filtros.depois = FiltroImplantacao.carregaFiltroImplantacao(@"GIT\Controle_Filtro_Implantacao.json");
            Dictionary<char, List<FiltroImplantacao>> diff = FiltroImplantacao.exibeDiferencas(filtros);
            */

            SolutionBean.solutionDefault("SolucaoTeste","D:","Ramo_B");
        }
    }
}
