using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace controle_atividades_negocio
{
    public class Conexao
    {

        public class Diretorio
        {
            public bool status = true;
            public String[] arquivos;
            public String mensagem = "";

            String diretorio = "";

            public Diretorio(String _diretorio, Util.Constantes.ModoDiretorio _modoDiretorio)
            {
                diretorio = _diretorio;

                if (_modoDiretorio == Util.Constantes.ModoDiretorio.Criacao)
                    criaDiretorio();
                else if (_modoDiretorio == Util.Constantes.ModoDiretorio.ListaArquivos)
                    arquivos = listaArquivos();
            }

            private String[] listaArquivos()
            {
                if (!Directory.Exists(diretorio))
                {
                    return new String[] { };
                }
                return Directory.GetFiles(diretorio);
            }

            //Cria o diretório para o arquivo de ponto
            private void criaDiretorio()
            {
                try
                {
                    mensagem = "Diretório atualizado com sucesso.";

                    if (!Directory.Exists(diretorio))
                    {
                        Directory.CreateDirectory(diretorio);
                        mensagem = "Diretório criado com sucesso.";
                    }

                    status = true;
                }
                catch (Exception ex)
                {
                    status = false;
                    mensagem = ex.Message;
                }
            }
        }

        public class Arquivo
        {

            public bool status = true;
            public String mensagem = "";

            String conteudo = "";
            String arquivo = "";

            public Arquivo(String _arquivo, String _conteudo)
            {
                arquivo = _arquivo;
                conteudo = _conteudo;
                gravaArquivo();
            }

            public void gravaArquivo()
            {
                try
                {
                    if (File.Exists(arquivo))
                        File.Delete(arquivo);
                    
                    File.WriteAllText(arquivo, conteudo);
                    status = true;
                    mensagem = "Arquivo atualizado com sucesso.";
                }
                catch (Exception ex)
                {
                    status = false;
                    mensagem = ex.Message;
                }
            }

            public static String leArquivo(String caminhoArquivo)
            {
                if (File.Exists(caminhoArquivo))
                {
                    return File.ReadAllText(caminhoArquivo);
                }

                return "";
            }
        }
    }
}
