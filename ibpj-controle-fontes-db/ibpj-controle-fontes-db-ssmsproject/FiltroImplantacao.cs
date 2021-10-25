using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ibpj_controle_fontes_git;
using ibpj_controle_fontes_db_conf;

namespace ibpj_controle_fontes_db_ssmsproject
{

    public class CompareFiltros
    {
        public Dictionary<int,FiltroImplantacao> antes { get; set; }
        public Dictionary<int,FiltroImplantacao> depois { get; set; }
    }

    public class FiltroImplantacaoJson
    {
        public List<FiltroImplantacao> filtros { get; set; }
    }

    public class FiltroImplantacao
    {
        public String EmpresaDesenvolvedora { get; set; }
        public int cdServicoImplt { get; set; }
        public String dsServicoImplt { get; set; }
        public String Responsavel { get; set; }
        public String dtSolicitacao { get; set; }


        public static Dictionary<int,FiltroImplantacao> carregaFiltroImplantacao(String file, String directory)
        {
            Dictionary<int, FiltroImplantacao> ret = new Dictionary<int, FiltroImplantacao>();
            FiltroImplantacaoJson filtroImplantacaoJson = JsonConvert.DeserializeObject<FiltroImplantacaoJson>(GitActions.loadPreviousFile(file, directory));
            foreach(FiltroImplantacao filtroImplantacao in filtroImplantacaoJson.filtros)
            {
                ret.Add(filtroImplantacao.cdServicoImplt, filtroImplantacao);
            }

            Utilitarios.logExibeParametros(new string[] { "Arquivo carregado(file,directory) ", file, directory, ret.Count.ToString() });

            return ret;
        }

        public static Dictionary<int,FiltroImplantacao> carregaFiltroImplantacao(String fullPathFile)
        {
            Dictionary<int, FiltroImplantacao> ret = new Dictionary<int, FiltroImplantacao>();
            FiltroImplantacaoJson filtroImplantacaoJson = JsonConvert.DeserializeObject<FiltroImplantacaoJson>(GitActions.loadFileComplete(fullPathFile));
            foreach (FiltroImplantacao filtroImplantacao in filtroImplantacaoJson.filtros)
            {
                ret.Add(filtroImplantacao.cdServicoImplt, filtroImplantacao);
            }

            Utilitarios.logExibeParametros(new string[] { "Arquivo carregado(fullPathFile)", fullPathFile, ret.Count.ToString() });

            return ret;
        }

        override
        public String ToString()
        {
            return this.cdServicoImplt + "," + "\""+ dsServicoImplt +"\"";
        }

        public static Dictionary<char,List<FiltroImplantacao>> exibeDiferencas(CompareFiltros filtros)
        {
            Dictionary<char, List<FiltroImplantacao>> ret = new Dictionary<char, List<FiltroImplantacao>>();

            List<FiltroImplantacao> inse = new List<FiltroImplantacao>();
            List<FiltroImplantacao> dels = new List<FiltroImplantacao>();
            List<FiltroImplantacao> upds = new List<FiltroImplantacao>(); 

            // mapeia alterações e novas inclusões
            foreach (int cdServico in filtros.depois.Keys)
            {
                FiltroImplantacao[] filtroImplantacao = new FiltroImplantacao[2];
                filtros.depois.TryGetValue(cdServico, out filtroImplantacao[1]);

                if (filtros.antes.ContainsKey(cdServico))
                {
                    filtros.antes.TryGetValue(cdServico, out filtroImplantacao[0]);
                    if (filtroImplantacao[0].ToString() != filtroImplantacao[1].ToString())
                    {
                        upds.Add(filtroImplantacao[1]);
                        Utilitarios.logExibeParametros(new string[] { "Atualizado", filtroImplantacao[0].ToString(), filtroImplantacao[1].ToString() });
                    }
                        
                }
                else
                {
                    inse.Add(filtroImplantacao[1]);
                    Utilitarios.logExibeParametros(new string[] { "Novo", filtroImplantacao[1].ToString() });
                }
                    

            }

            // mapeia exclusões
            foreach (int cdServico in filtros.antes.Keys)
            {
                FiltroImplantacao filtroImplantacao = new FiltroImplantacao();
                filtros.antes.TryGetValue(cdServico, out filtroImplantacao);

                if (!filtros.depois.ContainsKey(cdServico))
                {
                    dels.Add(filtroImplantacao);
                    Utilitarios.logExibeParametros(new string[] { "Excluído", filtroImplantacao.ToString() });
                }
                    
            }

            ret.Add('I', inse);
            ret.Add('U', upds);
            ret.Add('D', dels);

            return ret;
        }

    }
}
