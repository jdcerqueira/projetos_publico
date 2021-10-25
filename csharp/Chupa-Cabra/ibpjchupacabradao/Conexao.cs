using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ibpjchupacabradao
{
    public class Conexao
    {
        public String connectionString;
        public SqlConnection sqlConnection;

        public Conexao(String _connectionString)
        {
            //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ChaveAcesso.mdf;Integrated Security=True";

            try
            {
                connectionString = _connectionString;
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
            }catch(SqlException sex)
            {
                throw new Exception(sex.Message);
            }

        }

        // executa uma instrução na base
        public String SqlCommand(String _sqlStatement)
        {
            try
            {
                SqlCommand sqlStatement = new SqlCommand(_sqlStatement, sqlConnection);
                sqlStatement.CommandTimeout = 0;
                SqlDataReader sqlDataReader = sqlStatement.ExecuteReader();
                return "OK: Executado com sucesso: " + _sqlStatement;
            }
            catch(Exception ex)
            {
                return "ERR: SQL não executado: " + ex.Message;
            }
        }

        // executa uma instrução e retorna um dataset
        public DataTable SQLQuery(String _sqlStatement)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sqlStatement = new SqlCommand(_sqlStatement,sqlConnection);
                sqlStatement.CommandTimeout = 0;
                SqlDataReader sqlDataReader = sqlStatement.ExecuteReader();
                dataTable.Load(sqlDataReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dataTable;
        }

        public void Close()
        {
            sqlConnection.Close();
        }

        public class ConnectionString
        {
            public const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\Chupa_Cabra.mdf;Integrated Security=True";
        }
    }
}
