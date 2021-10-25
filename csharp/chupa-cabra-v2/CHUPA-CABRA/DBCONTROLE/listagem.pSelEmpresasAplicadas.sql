USE DBCONTROLE
GO

IF OBJECT_ID('listagem.pSelEmpresasAplicadas','P') IS NOT NULL
	DROP PROCEDURE listagem.pSelEmpresasAplicadas
GO

/*
Procedure: listagem.pSelEmpresasAplicadas
Proposito: Listar as empresas aplicadas no ambiente
Autor: Joao Daniel
Data: 02-05-2019
Parametros: -
Retorno:
Registro de Manutencao: -
*/
CREATE PROCEDURE listagem.pSelEmpresasAplicadas
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL SNAPSHOT
	SET NOCOUNT ON

	SELECT
		E.CdEmpresa evidencia,
		ISNULL(EA.cdEmpresaAplicado,0) aplicado,
		dbo.fFormataTexto(E.NuCGC,'###.###.###/####-##') NuCGC,
		E.NmEmpresa,
		ISNULL(CONVERT(VARCHAR,E.DtCriacao,121),'-') DtCriacao,
		ISNULL(CONVERT(VARCHAR,E.DtRemocao,121),'-') DtRemocao
	FROM dbo.TbEmpresas E
		LEFT JOIN dbo.tbEmpresaVsAplicado EA
			ON E.CdEmpresa = EA.cdEmpresaEvidencia

	SET NOCOUNT OFF
END
GO