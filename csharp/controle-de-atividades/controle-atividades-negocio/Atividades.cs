using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_atividades_negocio
{
    public class Atividades
    {
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public Intervalo Atuacao { get; set; }
        public bool status { get; set; }
        public DateTime? previsao { get; set; }


        public static List<Atividades> atividadesPendentes()
        {
            Ponto ponto = new Ponto().arquivoPonto(Util.Configuracoes.ultimoArquivoGerado());
            if(ponto == null)
            {
                return new List<Atividades>();
            }

            return ponto.Atividades.FindAll(x => x.status == false) == null ? new List<Atividades>() : ponto.Atividades.FindAll(x => x.status == false);
        }

        public static List<Atividades> atividadesEncerradas()
        {
            Ponto ponto = new Ponto().arquivoPonto(Util.Configuracoes.ultimoArquivoGerado());
            if (ponto == null)
            {
                return new List<Atividades>();
            }

            return ponto.Atividades.FindAll(x => x.status == true) == null ? new List<Atividades>() : ponto.Atividades.FindAll(x => x.status == true);
        }
    }
}
