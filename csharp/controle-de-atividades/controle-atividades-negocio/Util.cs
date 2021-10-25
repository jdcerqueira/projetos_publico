using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_atividades_negocio
{
    public class Util
    {

        public static String Hora(String DataHora)
        {
            if (DataHora == null || DataHora == "")
                return "";

            return DateTime.ParseExact(DataHora, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture).TimeOfDay.ToString();
        }

        public static DateTime StringToDatetime(String DataHora)
        {
            return DateTime.ParseExact(DataHora, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static TimeSpan StringToTimesPan(String Hora)
        {
            if (Hora == "")
                return TimeSpan.Parse("00:00:00");

            return TimeSpan.Parse(Hora);
        }

        public class Configuracoes
        {
            public static String ultimoArquivoGerado()
            {

                String ano = "";
                String mes = "";
                String dia = "";

                if (!File.Exists(@"conf"))
                {
                    var arquivoCriado = File.Create(@"conf");
                    arquivoCriado.Close();
                }
                    

                String ultimoArquivoGerado = File.ReadAllText(@"conf");
                if(!ultimoArquivoGerado.Equals(""))
                {
                    String[] conteudoArquivo = ultimoArquivoGerado.Split('|');
                    ano = conteudoArquivo[0];
                    mes = conteudoArquivo[1];
                    dia = conteudoArquivo[2];
                    return ano + @"\" + mes + @"\" + dia + ".json";
                }

                return "";
            }

            public static bool atualizaArquivoConf(String ano, String mes, String dia)
            {
                File.WriteAllText(@"conf",ano+"|"+mes+"|"+dia);
                return true;
            }
        }

        public class Constantes
        {
            public enum ModoTela
            {
                Leitura = 1,
                Escrita = 2
            }

            public enum ModoDiretorio
            {
                Listagem = 1,
                Criacao = 2,
                ListaArquivos = 3
            }

            public enum RestaurarPontoDia
            {
                Entrada = 1,
                Almoco = 2,
                Janta = 3,
                Saida = 4,
                NovoPonto = 5
            }

            public enum IntervalosDatas
            {
                InicioTarefa = 1,
                PrevisaoTarefa = 1,
                ListaPonto = 1
            }

            public static int IntervaloSelecao(Util.Constantes.IntervalosDatas intervalos)
            {
                if(intervalos == IntervalosDatas.InicioTarefa)
                    return 1;
                if (intervalos == IntervalosDatas.PrevisaoTarefa)
                    return 1;
                if (intervalos == IntervalosDatas.ListaPonto)
                    return 1;

                return 1;
            }

            public const String versaoProduto = "v.1.5.2";
            public const Double minutosDiaCheio = 1439;
        }
    }
}
