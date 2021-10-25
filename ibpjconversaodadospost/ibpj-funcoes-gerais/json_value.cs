using System;
using System.Data.SqlTypes;
using System.Collections.Generic;

public class ChaveValorJson
{
    public string chave { get; set; }
    public string valor { get; set; }
}

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString json_value(SqlString documento_json, SqlString chave)
    {
        documento_json = documento_json.ToString().Substring(1, documento_json.ToString().Length - 1);
        documento_json = documento_json.ToString().Substring(0, documento_json.ToString().Length - 1);
        documento_json += ",";

        SqlString retorno = "";

        int is_lst = 0;
        int is_doc = 0;
        bool is_key = true;
        string key = "";
        string value = "";

        Dictionary<string, SqlString> chavesValorJson = new Dictionary<string, SqlString>();

        for (int i = 0; i < documento_json.ToString().Length; i++)
        {
            if (is_key)
            {
                if (documento_json.ToString()[i].Equals(':'))
                    is_key = false;
                else
                    key += documento_json.ToString()[i];
            }
            else
                value += documento_json.ToString()[i];

            if (documento_json.ToString()[i].Equals('['))
                is_lst++;

            if (documento_json.ToString()[i].Equals(']'))
                 is_lst--;

            if (documento_json.ToString()[i].Equals('{'))
                is_doc++;

            if (documento_json.ToString()[i].Equals('}'))
                is_doc--;


            if (documento_json.ToString()[i].Equals(',') && is_lst==0 && is_doc == 0 && !is_key)
            {
                value = value.Substring(0,value.Length-1);
                chavesValorJson.Add(key.Replace("\"","").Trim().ToLower(),value);
                is_key = true;
                key = "";
                value = "";
            }
        }

        
        chavesValorJson.TryGetValue(chave.ToString().ToLower(), out retorno);
            
        return retorno;
    }
}
