USE DBCONTROLE
GO

IF OBJECT_ID('listagem.pSelProcuradoresAplicados','P') IS NOT NULL
	DROP PROCEDURE listagem.pSelProcuradoresAplicados
GO

/*
PROCEDURE: listagem.pSelProcuradoresAplicados
PROPOSITO: LISTAR OS PROCURADORES CARREGADOS E APLICADOS
AUTOR: JOAO DANIEL
DATA: 08/05/2019
PARAMETROS:
RETORNO:
REGISTROS DE MANUTENCAO:
*/
CREATE PROCEDURE listagem.pSelProcuradoresAplicados
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL SNAPSHOT
	SET NOCOUNT ON

	SELECT
		P.cdEmpresa evidencia,
		ISNULL(dbo.fFormataTexto(CONVERT(CHAR(11),REPLACE(STR(CA.nCpfCliNe,9) + STR(CA.nCtrlCpfCliNe,2),' ','0')),'###.###.###-##'),'-') NuCPF,
		ISNULL(CA.iChaveAcssoCli,'-') iChaveAcssoCli,
		ISNULL(CA.cIndcdTpoAcssoCli,0) cIndcdTpoAcssoCli,
		ISNULL(U.wLoginUsuarNe,'-') wLoginUsuarNe,
		ISNULL(ICP.cSerieChavePblicBrasi,0) cSerieChavePblicBrasi,
		ISNULL(CER.NuCertificado,0) NuCertificado,
		ISNULL(PP.cPrfilAcssoNe,0) cPrfilAcssoNe,
		ISNULL(PP.iPrfilAcssoNe,'-') iPrfilAcssoNe,
		P.StProcurador
	FROM dbo.TbProcuradores P
		LEFT JOIN dbo.tChaveAcssoEmprProcd CE
			ON CE.cEmpr = P.CdEmpresa
			AND CE.cProcd = P.CdProcurador
		LEFT JOIN dbo.tChaveAcssoCliNe CA
			ON CA.nChaveAcssoCliNe = CE.nChaveAcssoCliNe
		LEFT JOIN dbo.tUsuarNe U
			ON U.nChaveAcssoCliNe = CA.nChaveAcssoCliNe
		LEFT JOIN dbo.tChavePblicBrasiCliNe ICP
			ON ICP.nChaveAcssoCliNe = CA.nChaveAcssoCliNe
		LEFT JOIN dbo.TbCertificados CER
			ON CER.nChaveAcssoCliNe = CA.nChaveAcssoCliNe
		LEFT JOIN dbo.tPrfilAcssoNe PP
			ON PP.cEmpr = P.cdEmpresa
			AND PP.cPrfilAcssoNe = P.cPrfilAcssoNe

	SET NOCOUNT OFF
END
GO