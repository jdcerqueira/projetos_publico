using System.Data.SqlTypes;
using ibpjconfiguracaodadospost;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString retornaParametrosJson(string caminhoConfig, string tabela, int cdGrupo, int cdServico, int tpServico, string vrDadosPost)
    {
        return new Arquivo().retornaJsonDadosPost(caminhoConfig, tabela, cdGrupo, cdServico, tpServico, vrDadosPost);
    }
}
