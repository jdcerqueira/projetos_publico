using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace ibpj_tratamento_dadospost_funcoes
{
    public class Tratamentos
    {
        public SqlString retornaJsonDadosPost(string legendaChaves, string vrDadosPost)
        {
            SqlString retorno = new SqlString(string.Empty);
            Dictionary<string, string> camposDadosPost = new Regras().organizaDadosPost(vrDadosPost);

            // monta o json de acordo com as chaves informadas
            List<Chaves> chaves = new Chaves().deserializadorChaves(legendaChaves);

            foreach(Chaves chave in chaves)
            {
                String valor;
                string substituicao = "";
                camposDadosPost.TryGetValue(chave.chave.Trim(), out valor);

                if (valor != null)
                    substituicao = new Regras().adequaTextoDadosPost(valor, chave.substituicao);

                retorno += "\"" + chave.chaveAmigavel.Trim() + "\":\"" + substituicao + "\",";
            }

            retorno = "{" + retorno.ToString().Substring(0, retorno.ToString().Length - 1) + "}";
            return retorno;
        }
    }
}
