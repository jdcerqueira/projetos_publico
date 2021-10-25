using System;
using System.Collections.Generic;

namespace ibpj_tratamento_dadospost_funcoes
{
    class Chaves
    {
        public string chave { get; set; }
        public string chaveAmigavel { get; set; }
        public List<Regras> substituicao { get; set; }


        public List<Chaves> deserializadorChaves(string legendaChaves)
        {
            List<Chaves> retorno = new List<Chaves>();
            

            string[] trechos = legendaChaves.Split('&');

            for (int indexOfArrayTrechos = 0; indexOfArrayTrechos < trechos.Length; indexOfArrayTrechos ++)
            {
                List<Regras> regras = new List<Regras>();
                string[] chaves_substituicoes = trechos[indexOfArrayTrechos].Split('*');
                string[] chaves = chaves_substituicoes[0].Split('=');
                

                if (chaves_substituicoes.Length == 2)
                {
                    string[] substituicoes = chaves_substituicoes[1].Split(',');
                    for (int indexArraySubs = 0; indexArraySubs < substituicoes.Length; indexArraySubs++)
                    {
                        string[] s_regras = substituicoes[indexArraySubs].Split('=');
                        regras.Add(new Regras() { antes = s_regras[0], depois = s_regras[1] });
                    }
                }

                retorno.Add(new Chaves() { chave = chaves[0], chaveAmigavel = chaves[1], substituicao = regras});
            }
            return retorno;
        }
    }
}
