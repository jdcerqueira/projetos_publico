using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace controle_menu_dinamico
{
    class Parametros
    {
        public string caminhoMenuCompleto { get; set; }
        public string caminhoMenuManutencao { get; set; }
        const string versao = "Versão: 1.0 - Controle de Cadastro Geral para Base de Dados";

        public void helper()
        {
            StringBuilder helper = new StringBuilder("");
            helper.Append(versao + "\n");
            helper.Append("Utilitário para controle de cadastros gerais para base de dados.\n");
            helper.Append("\n");
            helper.Append("controle-menu-dinamico -m [diretório\\controle.json] -M [diretório\\manutencao.json] -V [M|S|F]u [Solicitante]\n");
            helper.Append("\n");
            helper.Append("-m Diretório + nome do arquivo JSON que contém o arquivo completo a ser controlado.\n");
            helper.Append("-M Diretório + nome do arquivo JSON que contém o arquivo de manutenção.\n");
            helper.Append("-V Tipo da alteração a ser realizada.\n");
            helper.Append("     atributos    M - Menu Dinâmico\n");
            helper.Append("                  S - Controle de Serviços\n");
            helper.Append("                  F - Filtro de Implantação\n");
            helper.Append("                  atributos <u> - Usuário solicitante da alteração.\n");
            helper.Append("-v Versão do produto.\n");
            helper.Append("\n");
            Console.WriteLine(helper);
        }

        public void getVersao()
        {
            Console.WriteLine(versao);
        }
        

        public Parametros validaParametros(string[] args)
        {
            if (args.Length == 0)
            {
                this.helper();
                return null;
            }
            else
            {
                for (int ivc = 0; ivc < args.Length; ivc++)
                {

                    switch (args[ivc])
                    {
                        case "-v":
                            this.getVersao();
                            return null;
                        case "/?":
                            this.helper();
                            return null;
                        case "-m":
                            this.caminhoMenuCompleto = args[ivc + 1];
                            break;
                        case "-M":
                            this.caminhoMenuManutencao = args[ivc + 1];
                            break;
                    }
                }

                return this;
            }
        }

        public override string ToString()
        {
            return "Caminho Completo:" +
                    this.caminhoMenuCompleto +
                    " - Caminho Manutenção:" +
                    this.caminhoMenuManutencao;
        }
    }
}