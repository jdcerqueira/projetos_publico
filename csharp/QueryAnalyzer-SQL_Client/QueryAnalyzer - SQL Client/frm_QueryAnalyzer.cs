using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace QueryAnalyzer___SQL_Client
{
    public partial class frm_QueryAnalyzer : Form
    {
        String mensagem = "";
        Boolean erro = false;

        public frm_QueryAnalyzer()
        {
            InitializeComponent();
            cmbBaseDados.SelectedIndex = 0;
            dgvResultSet.ReadOnly = true;
            dgvResultSet.AllowUserToAddRows = false;
        }

        public String retornaResultadoDaQuery(String _json)
        {
            //erro = false;
            //mensagem = "";

            try
            {
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("localhost:8080/teste");
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/teste");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";


                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(JsonConvert.SerializeObject(new EnviaQuery() { query = _json}));
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            catch(Exception ex)
            {
                //erro = true;
                //mensagem = ex.Message;
                throw new Exception(ex.Message);
                //MessageBox.Show(ex.Message);
                //return mensagem;
            }
        }

        private void executaQuery()
        {
            dgvResultSet.Rows.Clear();
            dgvResultSet.MultiSelect = false;
            dgvResultSet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                RetornoQuery retorno = JsonConvert.DeserializeObject<RetornoQuery>(retornaResultadoDaQuery(txtQuery.Text));

                // Gera a grid de resultado
                dgvResultSet.ColumnCount = retorno.colunas.Count;

                for (int coluna = 0; coluna < retorno.colunas.Count; coluna++)
                {
                    dgvResultSet.Columns[coluna].Name = retorno.colunas[coluna];
                    dgvResultSet.Columns[coluna].HeaderText = retorno.colunas[coluna];
                }

                // Aplica linhas do resultado da pesquisa
                foreach (String linha in retorno.dados)
                {
                    dgvResultSet.Rows.Add(linha.Split(';'));
                }

                foreach(DataGridViewRow row in dgvResultSet.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
                    row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            

            /*
            const String connectionString = @"Server=labs178\hm1120a;Database=OFPJD000;User Id=sa;Password=n3tB@se862488;";
            DataTable result = new DataTable();

            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(txtQuery.Text, sqlConnection);
                sqlCommand.CommandTimeout = 0;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                result.Load(sqlDataReader);

                dgvResultSet.Rows.Clear();
                dgvResultSet.ColumnCount = result.Columns.Count;
                for (int coluna = 0; coluna < result.Columns.Count; coluna++)
                {
                    dgvResultSet.Columns[coluna].Name = result.Columns[coluna].ColumnName;
                    dgvResultSet.Columns[coluna].HeaderText = result.Columns[coluna].ColumnName;
                }

                foreach (DataRow linha in result.Rows)
                {
                    String[] registro = new String[dgvResultSet.ColumnCount];

                    for (int coluna = 0; coluna < dgvResultSet.ColumnCount; coluna++)
                    {
                        registro[coluna] = linha.ItemArray[coluna].ToString();
                    }

                    dgvResultSet.Rows.Add(registro);
                }

                dgvResultSet.Refresh();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */

        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                executaQuery();
        }

        private void txtQuery_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                int pontoInicial = txtQuery.SelectionStart;

                txtQuery.Text = txtQuery.Text.Substring(0, pontoInicial) + "    " + txtQuery.Text.Substring(pontoInicial, (txtQuery.Text.Length - pontoInicial));
                txtQuery.Select(pontoInicial + 4,0); 
            }
                
        }
    }
}
