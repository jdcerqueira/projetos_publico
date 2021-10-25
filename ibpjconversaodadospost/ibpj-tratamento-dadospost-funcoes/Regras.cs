using System.Collections.Generic;

namespace ibpj_tratamento_dadospost_funcoes
{
    public class Regras
    {
        public string antes { get; set; }
        public string depois { get; set; }

        public string adequaTextoDadosPost(string vrDadosPost, List<Regras> regraSubstituicao)
        {
            foreach(Regras regras in regraSubstituicao)
            {
                vrDadosPost = vrDadosPost.Replace(regras.antes, regras.depois);
            }
            return vrDadosPost;
        }

        public string adequaTextoDadosPost(string vrDadosPost)
        {
            return vrDadosPost
                .Replace("%5f","_")
                .Replace("+"," ")
                .Replace("%2e",".")
                .Replace("%2d","-")
                .Replace("%2f","/")
                .Replace("%3a",":");
        }

        public Dictionary<string, string> organizaDadosPost(string vrDadosPost)
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
                {
                    retorno.Add(campoValor[0], campoValor[1]);
                }   
                else
                {
                    retorno.Add(campoValor[0], "");
                }
            }

            return retorno;
        }
    }
}
