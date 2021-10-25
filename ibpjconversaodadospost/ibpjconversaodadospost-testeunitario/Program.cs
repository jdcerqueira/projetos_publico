using System;


namespace ibpjconversaodadospost_testeunitario
{
    class Program
    {
        static void Main(string[] args)
        {
            //string legenda = "nSess=numero_Sessao&" +
            //        "conta_0 = conta &"+
            //        "numeroContasCredito = numeroContasCredito &" +
            //        "TIPO_DISPOSITIVO = TIPO_DISPOSITIVO &" +
            //        "COD_MOTIVO_RECUSA = COD_MOTIVO_RECUSA &" +
            //        "tipoConta = tipoConta &" +
            //        "banco_0 = banco &" +
            //        "agencia_0 = agencia &" +
            //        "TTM = TTM &" +
            //        "cpfCnpj_0 = cpfCnpj &" +
            //        "nomeTitular_0 = nomeTitular &" +
            //        "limiteDesejado = limiteDesejado";
            //string vrDadosPost = "nSess=3176708&conta%5f0=3673650&numeroContasCredito=1&TIPO%5fDISPOSITIVO=0&COD%5fMOTIVO%5fRECUSA=1&tipoConta=C&banco%5f0=1&agencia%5f0=9&TTM=&cpfCnpj%5f0=096538829000088&nomeTitular%5f0=asdasdasd+++++++++++++++++++++++&limiteDesejado=0&";

            //Console.WriteLine(UserDefinedFunctions.vrPostJson(legenda,vrDadosPost));
            Console.WriteLine(UserDefinedFunctions.json_value("{\"nome\":\"João Daniel\",\"graus\": [28,27,26,25],\"Filhos\":[{\"total\":[1,2,3]},{\"abc\":1}],\"Salario\":25.0}","filhos"));

        }
    }
}
