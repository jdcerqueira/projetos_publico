using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpjchupacabradao
{
    public class ChaveAcesso
    {
		public class ChaveAcessoUnit
        {
			public int? numeroChaveAcesso { get; set; }
			public byte? situacao { get; set; }
			public byte? tipo { get; set; }
			public DateTime? dataHoraInclusao { get; set; }
			public DateTime? dataHoraExclusao { get; set; }
			public DateTime? dataHoraUltimoAcesso { get; set; }
			public byte? qtdeTentativaSenhaInvalida { get; set; }
			public int? raizCpf { get; set; }
			public int? controleCpf { get; set; }
			public String nomePessoa { get; set; }
			public int? codigoEmpresaPadrao { get; set; }
			public bool? adesaoVisaoUnificada { get; set; }
			public DateTime? dataHoraAdesaoVisaoUnificada { get; set; }
			public byte? indicadorManutencaoVisaoUnificada { get; set; }
			public byte? motivoCancelamento { get; set; }
			public int? codigoEmpresaCancelamento { get; set; }
			public int? codigoProcuradorCancelamento { get; set; }
			public byte? origemExterna { get; set; }
			public byte? documentoFicticio { get; set; }
			public byte? indicadorReinicioSenha { get; set; }


			public String ToJson()
            {
				return JsonConvert.SerializeObject(this).ToString();
            }

			public ChaveAcessoUnit ToClass(String chaveJson)
            {
				return JsonConvert.DeserializeObject<ChaveAcessoUnit>(chaveJson);
            }
		}

		public class ChaveAcessoList
        {
			public List<ChaveAcessoUnit> chaveAcessos { get; set; }
        }

		public class ChaveAcessoJson
        {
			String chaveJson;
			public void setChaveJson(String chaveJson)
            {
				this.chaveJson = chaveJson;
            }

			public String getChaveJson()
            {
				return this.chaveJson;
            }
        }

		public void geraArquivoJson(String path)
        {
			File.WriteAllText(path,JsonConvert.SerializeObject(this,Formatting.Indented));
        }

		public static List<ChaveAcessoUnit> carregaArquivoProducao(String path)
        {
			return JsonConvert.DeserializeObject<List<ChaveAcessoUnit>>(File.ReadAllText(path, UTF8Encoding.UTF8));
        }

		public class ChaveAcessoDAO
        {

			public String mensagem;
			public bool status;
			public String tabela;
			public Conexao conexao;

			public ChaveAcessoDAO(String _tabela)
            {
				status = true;

                try
                {
					conexao = new Conexao(Conexao.ConnectionString.connectionString);
					tabela = _tabela;
					mensagem = "OK: Conexão com a tabela realizada com sucesso.";
				}
                catch (Exception ex)
                {
					status = false;
					mensagem = "ERR: Conexão com a tabela com erro (" + ex.Message + ")";
                }

            }

			public void Inserir(ChaveAcessoUnit _chaveAcesso, int Id)
            {
				String statement = "INSERT INTO "+ this.tabela +" (Id,JSON) " +
					"VALUES ("+ Id +",'"+ _chaveAcesso.ToJson() +"')";
                try
                {
					conexao.SqlCommand(statement);
					conexao.Close();
					mensagem = "OK: Dados inseridos na tabela." + statement;
				}
                catch (Exception ex)
                {
					status = false;
					mensagem = "ERR: Erro na execução da instrução SQL (" + ex.Message + ")";
				}
				
            }

			public List<ChaveAcessoUnit> SelecionarTudo()
            {
				ChaveAcessoList chaveAcessoList = new ChaveAcessoList();
				chaveAcessoList.chaveAcessos = new List<ChaveAcessoUnit>();

				String _statement = "SELECT JSON FROM " + tabela + " ORDER BY JSON";

                try
                {
					DataTable chavesDataTable = new Conexao(Conexao.ConnectionString.connectionString).SQLQuery(_statement);
					
					foreach(DataRow linhaBase in chavesDataTable.Rows)
                    {
						ChaveAcessoUnit chaveAcesso = new ChaveAcessoUnit().ToClass(linhaBase["JSON"].ToString());
						chaveAcessoList.chaveAcessos.Add(new ChaveAcessoUnit().ToClass(linhaBase["JSON"].ToString()));
                    }

					mensagem = "Segue listagem de registro.";
				}catch(Exception ex)
                {
					status = false;
					mensagem = "ERR: " + ex.Message;
                }

				return chaveAcessoList.chaveAcessos;
            }

        }
	}
}
