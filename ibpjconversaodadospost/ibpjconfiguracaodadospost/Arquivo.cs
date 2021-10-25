using Newtonsoft.Json;
using System.Data.SqlTypes;
using System.IO;
using System.Collections.Generic;
using System;

namespace ibpjconfiguracaodadospost
{
    public class Arquivo
    {
        public List<Configuracoes> carregaArquivoConfiguracao(string caminhoConfig)
        {
            return JsonConvert.DeserializeObject<List<Configuracoes>>(File.ReadAllText(@caminhoConfig + "configuracoes.json"));
        }

        public RegraSubstituicao[] retornaRegrasSubstituicoes(string jsonReplace)
        {
            if (jsonReplace == "[]")
                return new RegraSubstituicao[0];
            else
                return JsonConvert.DeserializeObject<RegraSubstituicao[]>(jsonReplace);
        }

        public Chaves[] retornaChaves(string jsonChaves)
        {
            return JsonConvert.DeserializeObject<Chaves[]>(jsonChaves);
        }

        public SqlString retornaJsonDadosPost(string caminhoConfig, string tabela, int cdGrupo, int cdServico, int tpServico, string vrDadosPost)
        {
            SqlString retorno = new SqlString(string.Empty);

            List<Configuracoes> configuracoes = new Arquivo().carregaArquivoConfiguracao(caminhoConfig);
            List<CamposDadosPost> camposDadosPost = new RegraSubstituicao().organizaDadosPost(vrDadosPost);

            // busca pelo parametro de tabela
            if(configuracoes.Exists(x=>x.tabela == tabela))
            {
                Configuracoes configMatched = configuracoes.Find(x => x.tabela == tabela);

                // busca pelos parametros de grupo, servico e tipo
                if(configMatched.parametros.Exists(x=>x.cdGrupo == cdGrupo && x.cdServico == cdServico && x.tpServico == tpServico))
                {
                    // monta o json de acordo com as chaves informadas
                    Chaves[] chaves = configMatched.parametros.Find(x => x.cdGrupo == cdGrupo && x.cdServico == cdServico && x.tpServico == tpServico).chaves;
                    for (int indexOfArray = 0; indexOfArray < chaves.Length; indexOfArray++)
                    {
                        if(camposDadosPost.Exists(x => x.campo == chaves[indexOfArray].chave))
                        {
                            retorno += "\"" + chaves[indexOfArray].chaveAmigavel + "\":\"" + 
                                new RegraSubstituicao().adequaTextoDadosPost(
                                    camposDadosPost.Find(x => x.campo == chaves[indexOfArray].chave).valor, 
                                    chaves[indexOfArray].substituicao) + 
                                "\",";
                        }
                    }
                }

                retorno = "{" + retorno.ToString().Substring(0, retorno.ToString().Length - 1) + "}";
            }

            return retorno;            
        }

        public SqlString retornaJsonDadosPost(string jsonChaves, string vrDadosPost)
        {
            SqlString retorno = new SqlString(string.Empty);
            Dictionary<string, string> camposDadosPost = new RegraSubstituicao().organizaDadosPost(vrDadosPost,true);

            // monta o json de acordo com as chaves informadas
            Chaves[] chaves = new Arquivo().retornaChaves(jsonChaves);
            for (int indexOfArray = 0; indexOfArray < chaves.Length; indexOfArray++)
            {
                String valor;
                string substituicao = "";
                camposDadosPost.TryGetValue(chaves[indexOfArray].chave, out valor);

                if (valor != null)
                    substituicao = new RegraSubstituicao().adequaTextoDadosPost(valor, chaves[indexOfArray].substituicao);
                    
                retorno += "\"" + chaves[indexOfArray].chaveAmigavel + "\":\"" + substituicao + "\",";
            }

            retorno = "{" + retorno.ToString().Substring(0, retorno.ToString().Length - 1) + "}";
            return retorno;
        }

        public SqlString retornaValorParametro(string chave, RegraSubstituicao[] substituicao, string vrDadosPost)
        {
            List<CamposDadosPost> camposDadosPost = new RegraSubstituicao().organizaDadosPost(vrDadosPost);

            // monta o json de acordo com as chaves informadas
            if (camposDadosPost.Exists(x => x.campo == chave))
                return new RegraSubstituicao().adequaTextoDadosPost(camposDadosPost.Find(x => x.campo == chave).valor, substituicao);
            else
                return "";
        }

        public SqlString retornaCampos(string vrPost)
        {
            SqlString retorno = "";
            List<CamposDadosPost> listCampos = new RegraSubstituicao().organizaDadosPost(vrPost);
            foreach (CamposDadosPost camposDadosPost in listCampos)
            {
                if(camposDadosPost.campo != "")
                    retorno += "\"" + camposDadosPost.campo + "\",";
            }
            return "[" + retorno.ToString().Substring(0,retorno.ToString().Length-1) + "]";
        }

        public SqlString retornaCampoValorDefault(string vrPost)
        {
            SqlString retorno = "";
            List<CamposDadosPost> listCampos = new RegraSubstituicao().organizaDadosPost(vrPost);
            foreach (CamposDadosPost camposDadosPost in listCampos)
            {
                if(camposDadosPost.campo != "")
                    retorno += "\"" + camposDadosPost.campo + "\":\"" + camposDadosPost.valor + "\",";
            }
            return "{" + retorno.ToString().Substring(0, retorno.ToString().Length - 1) + "}";
        }
    }
}
