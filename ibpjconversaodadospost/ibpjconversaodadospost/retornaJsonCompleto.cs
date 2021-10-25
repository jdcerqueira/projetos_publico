using System.Data.SqlTypes;
using ibpjconfiguracaodadospost;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString retornaJsonCompleto(string jsonChaves, string vrDadosPost)
    {
        return new Arquivo().retornaJsonDadosPost(jsonChaves, vrDadosPost);
    }
}
