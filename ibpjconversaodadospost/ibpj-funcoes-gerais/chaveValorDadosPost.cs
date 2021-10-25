using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using ibpj_tratamento_dadospost_funcoes;

public partial class UserDefinedFunctions
{
    public static void retornaObjetoChaveValor(
        object obj_ChaveValor,
        out SqlString chave,
        out SqlString valor)
    {
        ChaveValor chaveValor = (ChaveValor)obj_ChaveValor;
        chave = chaveValor.chave;
        valor = chaveValor.valor;
    }

    public static ChaveValor[] adequaChaveValor(string vrDadosPost)
    {
        vrDadosPost = new Regras().adequaTextoDadosPost(vrDadosPost);
        string[] chaveValor = vrDadosPost.Split('&');
        ChaveValor[] retorno = new ChaveValor[chaveValor.Length];

        for (int indexOfArrayChaveValor = 0; indexOfArrayChaveValor < chaveValor.Length; indexOfArrayChaveValor++)
        {
            string[] campo = chaveValor[indexOfArrayChaveValor].Split('=');
            if (campo.Length == 2)
                retorno[indexOfArrayChaveValor] = new ChaveValor() { chave = campo[0], valor = campo[1] };
            else
                retorno[indexOfArrayChaveValor] = new ChaveValor() { chave = campo[0], valor = "" };
        }

        return retorno;
    }

    [Microsoft.SqlServer.Server.SqlFunction(
        DataAccess = DataAccessKind.Read, 
        FillRowMethodName = "retornaObjetoChaveValor", 
        TableDefinition = "chave nvarchar(100), valor nvarchar(100)")]
    public static IEnumerable chaveValorDadosPost(SqlString vrDadosPost)
    {
        List<ChaveValor> chaveValors = new List<ChaveValor>();
        ChaveValor[] arrayChaveValor = adequaChaveValor(vrDadosPost.ToString());
        for (int indexOfArrayChaveValor = 0; indexOfArrayChaveValor < arrayChaveValor.Length; indexOfArrayChaveValor++)
        {
            chaveValors.Add(new ChaveValor()
            {
                chave = arrayChaveValor[indexOfArrayChaveValor].chave,
                valor = arrayChaveValor[indexOfArrayChaveValor].valor
            });
        }
        
        return chaveValors;
    }
}
