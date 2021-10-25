using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ibpj_controle_servicos
{
    public class Servico
    {
        public int cdServico { get; set; }
        public String dsServico { get; set; }
        public String dsApresentaCombo { get; }

        public Servico(int _codigo, String _nome)
        {
            this.cdServico = _codigo;
            this.dsServico = _nome;
            this.dsApresentaCombo = (_codigo == 0 ? "" : _codigo + " - ") + _nome;
        }

        override
        public String ToString()
        {
            return String.Format("{0} - {1} ({2})",this.cdServico, this.dsServico, this.dsApresentaCombo);
        }

        public static List<Servico> servicos(List<Servico> servicos)
        {
            List<Servico> retorno = new List<Servico>();
            retorno.Add(new Servico(0,Util.TodosItens));

            foreach (Servico servico in servicos)
                retorno.Add(new Servico(servico.cdServico, servico.dsServico));

            return retorno;
        }
    }
}
