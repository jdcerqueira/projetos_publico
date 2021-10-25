USE DBCONTROLE
GO

IF OBJECT_ID('listagem.pSelMastersAplicados','P') IS NOT NULL
	DROP PROCEDURE listagem.pSelMastersAplicados
GO

/*
PROCEDURE: listagem.pSelMastersAplicados
PROPOSITO: LISTAR OS MASTERS APLICADOS
AUTOR: JOAO DANIEL
DATA: 07/05/2019
PARAMETROS:
RETORNO:
REGISTRO DE MANUTENCAO
*/
CREATE PROCEDURE listagem.pSelMastersAplicados
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL SNAPSHOT
	SET NOCOUNT ON

	SELECT
		CM.NuContratoEmpresa evidencia,
		dbo.fFormataTexto(CM.NuCPF,'###.###.###-##') NuCPF,
		CM.NmMaster,
		ISNULL(CA.cIndcdTpoAcssoCli,0) tipoAcesso,
		ISNULL(U.wLoginUsuarNe,'-') wLoginUsuarNe,
		ISNULL(CER.NuCertificado,0) NuCertificado,
		ISNULL(ICP.cSerieChavePblicBrasi,'-') cSerieChavePblicBrasi,
		CM.StMaster
	FROM dbo.TbContratoMaster CM
		LEFT JOIN dbo.tChaveAcssoCliNe CA
			ON CA.nChaveAcssoCliNe = CM.nChaveAcssoCliNe
		LEFT JOIN dbo.tUsuarNe U
			ON U.nChaveAcssoCliNe = CA.nChaveAcssoCliNe
		LEFT JOIN dbo.TbCertificados CER
			ON CER.nChaveAcssoCliNe = CA.nChaveAcssoCliNe
		LEFT JOIN dbo.tChavePblicBrasiCliNe ICP
			ON ICP.nChaveAcssoCliNe = CA.nChaveAcssoCliNe

	SET NOCOUNT OFF
END
GO