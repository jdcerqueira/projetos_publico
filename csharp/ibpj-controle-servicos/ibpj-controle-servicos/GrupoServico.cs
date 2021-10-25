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
    public class GrupoServico
    {
        public int cdGrupo { get; set; }
        public String dsGrupo { get; set; }
        public List<Servico> servicos { get; set; }

        private const String arquivoServicos = "Controle_codigos_servicos.json";

        public static List<GrupoServico> carregaArquivoJson()
        {
            try
            {
                return JsonConvert.DeserializeObject<List<GrupoServico>>(File.ReadAllText(arquivoServicos));
            }
            catch (FileLoadException ex)
            {
                MessageBox.Show("ERR: " + ex.Message, "Erro ao carregar o arquivo de menu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR: " + ex.Message, "Erro ao carregar o arquivo de menu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return null;
        }

        public class Grupo
        {
            public int cdGrupo { get; }
            public String dsGrupo { get; }
            public String dsApresentaCombo { get; }

            public Grupo(int _codigo, String _descricao)
            {
                this.cdGrupo = _codigo;
                this.dsGrupo = _descricao;
                this.dsApresentaCombo = (_codigo == 0 ? "" : _codigo + " - ") + _descricao;
            }

            public static List<Grupo> grupos(List<GrupoServico> grupoServicos)
            {
                List<Grupo> grupos = new List<Grupo>();
                grupos.Add(new Grupo(0, Util.TodosItens));

                foreach (GrupoServico grupoServico in grupoServicos)
                    grupos.Add(new Grupo(grupoServico.cdGrupo, grupoServico.dsGrupo));

                return grupos;
            }
        }
    }
}
