using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_servicos
{
    public class TipoPermissao
    {
        public String descricao { get; }
        public String indice { get; }

        private TipoPermissao(String _descricao, String _indice)
        {
            this.descricao = _descricao;
            this.indice = _indice;
        }

        public static List<TipoPermissao> retornaTipoPermissoes()
        {
            List<TipoPermissao> retorno = new List<TipoPermissao>();

            retorno.Add(new TipoPermissao("[Nenhum]",""));
            retorno.Add(new TipoPermissao("Por Serviço","S"));
            retorno.Add(new TipoPermissao("Por Conta-Corrente","C"));
            retorno.Add(new TipoPermissao("Por Conta-Cobrança","B"));
            retorno.Add(new TipoPermissao("Para Másters","M"));

            return retorno;
        }
    }
}
