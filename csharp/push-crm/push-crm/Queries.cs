using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace push_crm
{
    class Queries
    {
        public DataTable retornaDadosClienteOrigem(DadosConexao dadosConexao, int totalRegistros)
        {
            string statement = "SELECT TOP ("+ totalRegistros +") " +
								" REPLICATE(NEWID(), 10) cHash, " + 
								" LEFT(LTRIM(E.NuCGC), 9) cnpj, " +
								" RIGHT(LEFT(LTRIM(E.NuCGC), 13), 4) filial, " +
								" CA.nCpfCliNe cpf, " + 
								" CASE WHEN(nCpfCliNe % 18) > 2 THEN 'G' ELSE 'A' END plataforma, " +
								" '{App Version:3.18.04}' propriedade, " +
								" CA.nChaveAcssoCliNe chaveAcesso " +
								" FROM dbo.tChaveAcssoCliNe CA " +
								" INNER JOIN dbo.tChaveAcssoEmprProcd CE " +
								" ON CE.nChaveAcssoCliNe = CA.nChaveAcssoCliNe " +
								" INNER JOIN dbo.TbProcuradores P " +
								" ON P.CdEmpresa = CE.cEmpr " +
								" AND P.CdProcurador = CE.cProcd " +
								" INNER JOIN dbo.TbEmpresas E " +
								" ON E.CdEmpresa = P.CdEmpresa " +
								" WHERE " +
								" E.DtRemocao IS NULL " +
								" AND P.DtRemocao IS NULL " +
								" AND CA.cIndcdSitChaveAcsso = 2 " +
								" AND ISNULL(CA.nCpfCliNe,0) > 0 " +
								" AND LEN(CA.nCpfCliNe) = 9 " +
								" ORDER BY NEWID()";
            return new Conexao().retornaResultSet(statement, dadosConexao);
        }

		public void insereDadoPush(DataTable dadosOrigem, DadosConexao dadosConexao)
		{
			try
			{
				for (int i = 0; i < dadosOrigem.Rows.Count; i++)
				{
					string statement = "exec push.pMlttDspvoMovelCli01 " +
						"'" + dadosOrigem.Rows[i][0] + "'," +
						"" + dadosOrigem.Rows[i][1] + "," +
						"" + dadosOrigem.Rows[i][2] + "," +
						"" + dadosOrigem.Rows[i][3] + "," +
						"'" + dadosOrigem.Rows[i][4] + "'," +
						"'" + dadosOrigem.Rows[i][5] + "'," +
						"" + dadosOrigem.Rows[i][6] + "";

					DataTable execPush = new Conexao().retornaResultSet(statement, dadosConexao);

					if (execPush.Rows[0][0].ToString() == "0")
						Console.WriteLine((i+1) + " - Executado com sucesso!");
					else
						Console.WriteLine((i+1) + " - Erro na execução do script!");
				}
			}
			catch
			{
				throw;
			}
		}
    }
}
