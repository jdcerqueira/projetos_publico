using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using ibpjconfiguracaodadospost;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString retornaCampos(String vrPost)
    {
        return new Arquivo().retornaCampos(vrPost);
    }
}
