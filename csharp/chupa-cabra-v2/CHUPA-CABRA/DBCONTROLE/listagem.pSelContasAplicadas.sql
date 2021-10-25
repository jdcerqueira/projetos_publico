USE DBCONTROLE
GO

IF OBJECT_ID('listagem.pSelContasAplicadas','P') IS NOT NULL
	DROP PROCEDURE listagem.pSelContasAplicadas
GO

/*
Procedure: listagem.pSelContasAplicadas
Proposito: Listar as contas aplicadas dentro de cada empresa.
Autor: Joao Daniel
Data: 07/05/2019
Parametros:
Retorno:
Registro de Manutencao:
*/
CREATE PROCEDURE listagem.pSelContasAplicadas
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL SNAPSHOT

	SET NOCOUNT ON

	SELECT
		C.cdEmpresa evidencia,
		C.cdAgencia,
		C.nuConta,
		ISNULL(CE.CdEmpresa,0) contaCorrente,
		ISNULL(CB.CdEmpresa,0) contaCobranca,
		ISNULL(CB.IdProduto,0) IdProduto,
		ISNULL(CB.TpConta,'-') TpConta,
		ISNULL(CB.StCobranca,'-') StCobranca,
		ISNULL(CB.NuAgenciaCobranca,0) NuAgenciaCobranca,
		ISNULL(CB.NuContaCobranca,0) NuContaCobranca,
		ISNULL(CONVERT(VARCHAR,CB.DtCriaçao,121),'-') DtCriacao,
		ISNULL(CONVERT(VARCHAR,C.dtRemocao,121),'-') dtRemocao
	FROM dbo.TbConta C
		LEFT JOIN dbo.TbContasEmpresa CE
			ON CE.cdEmpresa = C.cdEmpresa
			AND CE.CdConta = C.cdConta
		LEFT JOIN dbo.TbContaCobranca CB
			ON CB.CdEmpresa = C.cdEmpresa
			AND CB.CdConta = C.cdConta

	SET NOCOUNT OFF
END
GO