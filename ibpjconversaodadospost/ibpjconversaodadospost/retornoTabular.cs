using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class UserDefinedFunctions
{
    public class Pessoas
    {
        public int id { get; set; }
        public string nome { get; set; }
    }

    public static void BuscaPessoas(
       object obj_pessoas,
       out SqlInt32 id,
       out SqlString nome)
    {
        Pessoas pessoas = (Pessoas)obj_pessoas;

        id = pessoas.id;
        nome = pessoas.nome;
    }

    [Microsoft.SqlServer.Server.SqlFunction (DataAccess = DataAccessKind.Read, FillRowMethodName = "BuscaPessoas", TableDefinition = "id int, nome nvarchar(100)")]
    public static IEnumerable retornoTabular()
    {
        List<Pessoas> pessoas = new List<Pessoas>();
        pessoas.Add(new Pessoas() { id = 1, nome = "João" });
        pessoas.Add(new Pessoas() { id = 2, nome = "Henrique" });
        pessoas.Add(new Pessoas() { id = 3, nome = "Vladimir" });
   
        return pessoas;
    }
}
