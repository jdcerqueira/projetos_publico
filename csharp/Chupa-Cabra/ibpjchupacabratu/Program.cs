using ibpjchupacabradao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpjchupacabratu
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach(ChaveAcesso.ChaveAcessoUnit chaveAcesso in ChaveAcesso.carregaArquivoProducao(args[0]))
            {
                Console.WriteLine(chaveAcesso.ToJson());
            }
        }
    }
}
