using System.Data.SqlTypes;
using ibpj_tratamento_dadospost_funcoes;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString vrPostJson(string jsonChaves, string vrDadosPost)
    {
        return new Tratamentos().retornaJsonDadosPost(jsonChaves, vrDadosPost);
    }
}
