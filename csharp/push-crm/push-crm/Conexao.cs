using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace push_crm
{
    class Conexao
    {
        public DadosConexao origem { get; set; }
        public DadosConexao destino { get; set; }

        override
        public string ToString()
        {
            return "origem: " + this.origem.servidor + " | " + this.origem.usuario + " | " + this.origem.senha + " | " + this.origem.baseDeDados + "\n" +
                "destino: " + this.destino.servidor + " | " + this.destino.usuario + " | " + this.destino.senha + " | " + this.destino.baseDeDados;
        }

        public DataTable retornaResultSet(string statement, DadosConexao dadosConexao)
        {
            DataTable dtRetornaResultSet = new DataTable();

            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder() 
            { 
                InitialCatalog = dadosConexao.baseDeDados,
                DataSource = dadosConexao.servidor,
                UserID = dadosConexao.usuario,
                Password = dadosConexao.senha
            };

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(statement, sqlConnection);
            sqlConnection.Open();
            using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            {
                dtRetornaResultSet.Load(sqlDataReader);
            }
            sqlConnection.Close();

            return dtRetornaResultSet;
        }
    }
}
