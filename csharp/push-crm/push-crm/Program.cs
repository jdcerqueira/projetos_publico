using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Data;

namespace push_crm
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // recebe no parametro o total de usuários que deverão ser inseridos
            int totalUsuariosCarga = Int32.Parse(args[0]);

            // identifica as conexões no arquivo JSON
            Conexao conexao = JsonConvert.DeserializeObject<Conexao>(File.ReadAllText("conexao.json"));

            // realiza o input na base MBPJD000 através da procedure mesmo
            new Queries().insereDadoPush(new Queries().retornaDadosClienteOrigem(conexao.origem, totalUsuariosCarga), conexao.destino);
        }
    }
}
