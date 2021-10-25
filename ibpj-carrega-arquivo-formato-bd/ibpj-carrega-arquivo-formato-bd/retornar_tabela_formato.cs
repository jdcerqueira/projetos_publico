using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Collections.Generic;
using System.Xml;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString retornar_tabela_formato(String ano, String mes, String tabela, String caminho)
    {
        // Put your code here
        SqlString retorno = "";
        String caminho_tratado = caminho + @"\" + ano + @"\" + mes + @"\" + tabela + @".fmt";
        String[] arquivo_formato = File.ReadAllLines(caminho_tratado);
        retorno += arquivo_formato[2];

        return retorno;
    }
}

public class ROW
{
    
}

public class FIELD
{
    [System.Xml.Serialization.XmlAttribute]
    public int ID { get; set; }
    public int LENGTH { get; set; }
    public int PREFIX_LENGTH { get; set; }
    public int MAX_LENGTH { get; set; }
    public String COLLATION { get; set; }
    public char TERMINATOR { get; set; }
}

public class RECORD
{
    public List<FIELD> FIELD { get; set; }

}

public class BCPFORMAT
{
    public List<RECORD> RECORD { get; set; }
}
