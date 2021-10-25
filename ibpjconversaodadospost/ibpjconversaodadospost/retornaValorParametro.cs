using System.Data.SqlTypes;
using ibpjconfiguracaodadospost;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString retornaValorParametro(string chave, string substituicoes, string vrDadosPost)
    {
        return new Arquivo().retornaValorParametro(chave, new Arquivo().retornaRegrasSubstituicoes(substituicoes), vrDadosPost);
    }
        
}
