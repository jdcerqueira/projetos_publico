USE DBCONTROLE
GO

IF OBJECT_ID('listagem.pSelContratosAplicados','P') IS NOT NULL
	DROP PROCEDURE listagem.pSelContratosAplicados
GO

/*
Procedure: listagem.pSelContratosAplicados
Proposito: Listar os contratos aplicados na massa de forma geral
Data: 06-05-2019
Autor: Joao Daniel
Parametros:
Retorno:
Registro de Manutencao:
*/
CREATE PROCEDURE listagem.pSelContratosAplicados
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL SNAPSHOT

	SET NOCOUNT ON

	SELECT
		CE.NuContratoEmpresa evidencia,
		CA.NuContratoEmpresaAplicado aplicado,
		CE.NuAgPrincipal,
		CE.NuCCPrincipal,
		CE.NmRazaoSocial,
		ISNULL(CONVERT(VARCHAR,CE.DtCriacao,121),'-') DtCriacao,
		ISNULL(CONVERT(VARCHAR,CE.DtRevogacao,121),'-') DtRevogacao,
		CE.StContrato,
		CE.CdTipoContrato
	FROM dbo.TbContratoEmpresa CE
		LEFT JOIN dbo.tbContratoVsAplicado CA
			ON CA.NuContratoEmpresaEvidencia = CE.NuContratoEmpresa

	SET NOCOUNT OFF
END
GO