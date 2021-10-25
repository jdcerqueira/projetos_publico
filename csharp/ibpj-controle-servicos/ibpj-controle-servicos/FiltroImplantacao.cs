using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ibpj_controle_servicos
{
    public class FiltroImplantacao
    {
        public int cdServicoImplt { get; set; }
        public String dsServicoImplt { get; set; }
        public String dsApresentaCombo { get; }

        public FiltroImplantacao(int _cdServicoImplt, String _dsServicoImplt)
        {
            this.dsApresentaCombo = (_cdServicoImplt == 0 ? "" : _cdServicoImplt.ToString() + " - ") + _dsServicoImplt;
        }

        private const String arquivoFiltroImplantacao = "Controle_Filtro_Implantacao.json";

        public static List<FiltroImplantacao> carregaArquivoJson()
        {
            try
            {
                List<FiltroImplantacao> retorno = new List<FiltroImplantacao>();
                retorno.Add(new FiltroImplantacao(0, Util.TodosItens));
                foreach(FiltroImplantacao filtro in JsonConvert.DeserializeObject<List<FiltroImplantacao>>(File.ReadAllText(arquivoFiltroImplantacao)))
                {
                    retorno.Add(new FiltroImplantacao(filtro.cdServicoImplt, filtro.dsServicoImplt) { cdServicoImplt = filtro.cdServicoImplt, dsServicoImplt = filtro.dsServicoImplt });
                }
                return retorno;
            }
            catch (FileLoadException ex)
            {
                MessageBox.Show("ERR: " + ex.Message, "Erro ao carregar o arquivo de filtro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR: " + ex.Message, "Erro ao carregar o arquivo de filtro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return null;
        }
    }
}
