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
    public class Estilo
    {

        public int codigo { get; set; }
        public String nome { get; set; }
        public String descricao { get; set; }
        public String dsApresentaCombo { get; }

        public const String arquivoEstiloJson = @"ibpj-menu-dinamico-estilos.json";

        public Estilo(int _codigo, String _nome, String _descricao)
        {
            this.codigo = _codigo;
            this.nome = _nome;
            this.descricao = _descricao;

            this.dsApresentaCombo = (_codigo == 0 ? "" : _codigo + " - ") + _nome;
        }

        public static List<Estilo> carregaArquivoJson()
        {
            try
            {
                List<Estilo> retorno = new List<Estilo>();
                retorno.Add(new Estilo(0, Util.NenhumItem,""));
                foreach (Estilo estilo in JsonConvert.DeserializeObject<List<Estilo>>(File.ReadAllText(arquivoEstiloJson)))
                {
                    retorno.Add(new Estilo(estilo.codigo, estilo.nome, estilo.descricao));
                }
                return retorno;
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

        public static List<Estilo> estilos(List<Estilo> estilos)
        {
            List<Estilo> retorno = new List<Estilo>();
            retorno.Add(new Estilo(0, Util.NenhumItem, ""));

            foreach (Estilo estilo in estilos)
                retorno.Add(new Estilo(estilo.codigo, estilo.nome, estilo.descricao));

            return retorno;
        }

        public static void persisteArquivo(List<Estilo> estilos)
        {
            try
            {
                File.WriteAllText(arquivoEstiloJson, JsonConvert.SerializeObject(estilos, Formatting.Indented));
                MessageBox.Show("Arquivo atualizado com sucesso.", "Gravação de Arquivo (Estilo)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERR: " + ex.Message, "Gravação de Arquivo (Estilo)", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
