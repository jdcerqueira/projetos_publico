using System.Collections.Generic;

namespace ibpjconfiguracaodadospost
{
    public class RegraSubstituicao
    {
        public string antes { get; set; }
        public string depois { get; set; }

        public string adequaTextoDadosPost(string vrDadosPost)
        {
            return vrDadosPost.Replace("%5f", "_").Replace("+", " ");
        }

        public string adequaTextoDadosPost(string vrDadosPost, RegraSubstituicao[] regraSubstituicao)
        {
            for (int indexOfArray = 0; indexOfArray < regraSubstituicao.Length; indexOfArray++)
            {
                vrDadosPost = vrDadosPost.Replace(regraSubstituicao[indexOfArray].antes, regraSubstituicao[indexOfArray].depois);
            }
            return vrDadosPost;
        }

        public Dictionary<string,string> organizaDadosPost(string vrDadosPost, bool dic)
        {
            //Realiza a limpeza padrão de strings no VrDadoPost.
            vrDadosPost = this.adequaTextoDadosPost(vrDadosPost);

            //Gera lista com os campos e valores do VrDadosPost.
            Dictionary<string, string> retorno = new Dictionary<string, string>();
            string[] separaCampos = vrDadosPost.Split('&');
            for (int indexOfArray = 0; indexOfArray < separaCampos.Length; indexOfArray++)
            {
                string[] campoValor = separaCampos[indexOfArray].Split('=');
                if (campoValor.Length == 2)
                    retorno.Add(campoValor[0], campoValor[1]);
                else
                    retorno.Add(campoValor[0], "");
            }

            return retorno;
        }

        public List<CamposDadosPost> organizaDadosPost(string vrDadosPost)
        {
            //Realiza a limpeza padrão de strings no VrDadoPost.
            vrDadosPost = this.adequaTextoDadosPost(vrDadosPost);

            //Gera lista com os campos e valores do VrDadosPost.
            List<CamposDadosPost> retorno = new List<CamposDadosPost>();
            string[] separaCampos = vrDadosPost.Split('&');
            for (int indexOfArray = 0; indexOfArray < separaCampos.Length; indexOfArray++)
            {
                string[] campoValor = separaCampos[indexOfArray].Split('=');
                if (campoValor.Length == 2)
                    retorno.Add(new CamposDadosPost { campo = campoValor[0], valor = campoValor[1] });
                else
                    retorno.Add(new CamposDadosPost { campo = campoValor[0], valor = "" });
            }

            return retorno;
        }
    }
}
