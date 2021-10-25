using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_atividades_negocio
{
    public class SIGS
    {
        public String controle { get; set; }
        public String tipoControle{ get; set; }
        public String nome { get; set; }
        public Intervalo atendimento { get; set; }
        public String detalhe { get; set; }
        public String situacao { get; set; }

        public static void gravaSigs(SIGS requisicao)
        {
            if (!Directory.Exists(Util.Constantes.diretorioSigs))
                Directory.CreateDirectory(Util.Constantes.diretorioSigs);

            String filename = $@"{Util.Constantes.diretorioSigs}\{requisicao.controle.ToString()}.json";
            String content = JsonConvert.SerializeObject(requisicao, Formatting.Indented);
            File.WriteAllText(filename,content);
        }
    }
}
