using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financeiro
{
    public class Util
    {
        public class Constantes
        {
            public const String arquivoFontes = @"Fontes\Cadastro.json";
            public const String diretorioFontes = "Fontes";
            public const String diretorioLancamentos = "Lancamentos";
            public const int totalParcelas = 36;
            public const String motivoDespesaAutomaticaCartaoCredito = "Despesa automática gerada pela fatura de cartão de crédito";

            public static String nomeDespesaAutomaticaCartaoCredito(String NomeFonte)
            {
                return "Fatura do " + NomeFonte;
            }

            public enum ModoTela
            {
                Insercao = 1,
                Alteracao = 2
            }
        }
    }
}
