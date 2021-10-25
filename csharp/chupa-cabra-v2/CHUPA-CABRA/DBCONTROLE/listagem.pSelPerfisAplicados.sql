USE DBCONTROLE
GO

IF OBJECT_ID('listagem.pSelPerfisAplicados','P') IS NOT NULL
	DROP PROCEDURE listagem.pSelPerfisAplicados
GO

/*
PROCEDURE: listagem.pSelPerfisAplicados
PROPOSITO: LISTAR OS PERFIS APLICADOS
AUTOR: JOAO DANIEL
DATA: 09/05/2019
PARAMETROS: - 
RETORNO: -
REGISTROS DE MANUTENCAO: -
*/
CREATE PROCEDURE listagem.pSelPerfisAplicados
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL SNAPSHOT
	SET NOCOUNT ON

	SELECT
		PP.cEmpr evidencia,
		PP.cPrfilAcssoNe,
		PP.iPrfilAcssoNe,
		COUNT(DISTINCT P.CdProcurador) TotalProcuradores,
 		COUNT(DISTINCT PSC.cCtaCliNe) TotalContas,
		PP.cIndcdObrigProcrLegal,
		PP.cIndcdSitPrfil,
		ISNULL(PCorp.iPrfilCorpVisaoAgrup,'-') iPrfilCorpVisaoAgrup
	FROM dbo.tPrfilAcssoNe PP
		LEFT JOIN dbo.TbProcuradores P
			ON P.CdEmpresa = PP.cEmpr
			AND P.cPrfilAcssoNe = PP.cPrfilAcssoNe
		LEFT JOIN dbo.tPrfilServcOperCta PSC
			ON PSC.cEmpr = PP.cEmpr
			AND PSC.cPrfilAcssoNe = PP.cPrfilAcssoNe
		LEFT JOIN dbo.tPrfilCorpVisaoAgrup PCorp
			ON PCorp.nPrfilCorpVisaoAgrup = PP.nPrfilCorpVisaoAgrup
	GROUP BY
		PP.cEmpr,PP.cPrfilAcssoNe,PP.iPrfilAcssoNe,
		PP.cIndcdObrigProcrLegal,PP.cIndcdSitPrfil,
		ISNULL(PCorp.iPrfilCorpVisaoAgrup,'-')
	SET NOCOUNT OFF
END
GO