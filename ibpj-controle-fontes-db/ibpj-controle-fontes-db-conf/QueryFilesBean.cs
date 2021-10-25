using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_fontes_db_conf
{
    public class QueryFilesBean
    {
        public static String queryFile_FiltroImplantacaoIda()
        {
            String ret = "USE OFPJD000" + "\n" +
            "GO" + "\n\n" +

            "DECLARE @cdServicoImplt INT = < codigo_filtro,int,>" + "\n" +
            "DECLARE @dsServicoImplt VARCHAR(50) = < nome_filtro,varchar(50),>" + "\n\n" +

            "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED" + "\n" +
            "SET NOCOUNT ON" + "\n" +

            "BEGIN TRAN" + "\n\n" +

            "BEGIN TRY" + "\n\n" +

                "\t" + "IF EXISTS(SELECT TOP 1 1 FROM dbo.TbServicoImplt WHERE cdServicoImplt = @cdServicoImplt)" + "\n" +
                "\t" + "BEGIN" + "\n" +
                    "\t\t" + "DELETE FROM dbo.TbFiltroEmpresaImplt WHERE idFiltroImpltServico IN(SELECT idFiltroImpltServico FROM dbo.TbFiltroServicoImplt WHERE cdServicoImplt = @cdServicoImplt)" + "\n" +
                    "\t\t" + "SELECT @@ROWCOUNT[Excluído - dbo.TbFiltroEmpresaImplt - Ok]" + "\n" +
                    "\t\t" + "DELETE FROM dbo.TbFiltroServicoImplt WHERE cdServicoImplt = @cdServicoImplt" + "\n" +
                    "\t\t" + "SELECT @@ROWCOUNT[Excluído - dbo.TbFiltroServicoImplt - Ok]" + "\n" +
                    "\t\t" + "DELETE FROM dbo.tEmpresaExcluidaServico WHERE cdServicoImplt = @cdServicoImplt" + "\n" +
                    "\t\t" + "SELECT @@ROWCOUNT[Excluído - dbo.tEmpresaExcluidaServico - Ok]" + "\n" +
                    "\t\t" + "DELETE FROM dbo.tFiltrMenuDnamc WHERE cServcImpltNe = @cdServicoImplt" + "\n" +
                    "\t\t" + "SELECT @@ROWCOUNT[Excluído - dbo.tFiltrMenuDnamc - Ok]" + "\n" +
                    "\t\t" + "DELETE FROM dbo.TbServicoImplt WHERE cdServicoImplt = @cdServicoImplt" + "\n" +
                    "\t\t" + "SELECT @@ROWCOUNT[Excluído - dbo.TbServicoImplt - Ok]" + "\n" +
                "\t" + "END" + "\n\n" +

                "\t" + "INSERT INTO dbo.TbServicoImplt" + "\n" +
                    "\t\t" + "(cdServicoImplt, dsServicoImplt, stServicoImplt, dtImpltServico, flPaginaAviso, flApresentaAviso, dtLimiteAviso, cIndcdDispnFiltrImplt,cIndcdDispnFiltrExcec, cIndcdServcSuspe, iArqInstaObrig)" + "\n" +
                "\t" + "VALUES" + "\n" +
                    "\t\t" + "(@cdServicoImplt, @dsServicoImplt, 'H', GETDATE(), 'N', 'N', NULL, 'S', 'S', 'N', NULL)" + "\n\n" +

                "\t" + "SELECT @@ROWCOUNT[Inserido - dbo.TbServicoImplt - Ok]" + "\n\n" +

                "\t" + "COMMIT" + "\n" +
                "\t" + "SELECT 'IDA - SCRIPT EXECUTADO COM SUCESSO.'" + "\n" +
            "END TRY" + "\n" +
            "BEGIN CATCH" + "\n" +
                "\t" + "ROLLBACK" + "\n" +
                "\t" + "SELECT 'IDA - ERRO NA EXECUCAO DO SCRIPT.', ERROR_MESSAGE()[ERROR_MESSAGE], ERROR_LINE()[ERROR_LINE]" + "\n" +
            "END CATCH" + "\n" +
            "GO" + "\n";

            return ret;
        }
    }
}
