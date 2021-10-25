USE DBCONTROLE
GO

/****** Object:  Table [dbo].[TbCertificados]    Script Date: 02/05/2019 11:22:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbCertificados](
	[NuCertificado] [int] NULL,
	[NuCPF] [char](15) NULL,
	[DtCriacao] [smalldatetime] NULL,
	[DtRevogacao] [smalldatetime] NULL,
	[StCertificado] [char](1) NULL,
	[CdMidia] [char](1) NULL,
	[DtRetirada] [smalldatetime] NULL,
	[NmPessoaFisica] [varchar](50) NULL,
	[NuSenhaInvalida] [smallint] NULL,
	[cEmprPdrao] [int] NULL,
	[cAutrzRecebEmail] [bit] NULL,
	[cIndcdBloq] [bit] NULL,
	[dExpirCertf] [datetime] NULL,
	[nChaveAcssoCliNe] [decimal](9, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbChaveVsAplicado]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbChaveVsAplicado](
	[nChaveAcssoCliNeEvidencia] [decimal](9, 0) NULL,
	[nChaveAcssoCliNeAplicado] [decimal](9, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbConta]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbConta](
	[cdEmpresa] [int] NULL,
	[cdConta] [int] NULL,
	[cdAgencia] [int] NULL,
	[nuConta] [int] NULL,
	[dtRemocao] [datetime] NULL,
	[ctpoCtaBcriaCli] [tinyint] NULL,
	[cRzCta] [char](4) NULL,
	[cIndcdOrigeSistExter] [decimal](1, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbContaCobranca]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbContaCobranca](
	[CdEmpresa] [int] NULL,
	[CdConta] [int] NULL,
	[NuAgenciaCobranca] [int] NULL,
	[NuContaCobranca] [int] NULL,
	[IdProduto] [int] NULL,
	[NuRazao] [int] NULL,
	[DtCriaçao] [datetime] NULL,
	[TpConta] [char](1) NULL,
	[StCobranca] [char](1) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbContasEmpresa]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbContasEmpresa](
	[CdEmpresa] [int] NULL,
	[CdConta] [int] NULL,
	[CdSistema] [char](10) NULL,
	[NmTitular] [varchar](50) NULL,
	[ObOutros] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbContratoConta]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbContratoConta](
	[NuContratoEmpresa] [int] NULL,
	[NuAgencia] [int] NULL,
	[NuCC] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbContratoEmpresa]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbContratoEmpresa](
	[NuContratoEmpresa] [int] NULL,
	[NuAgPrincipal] [int] NULL,
	[NuCCPrincipal] [int] NULL,
	[NuCNPJ] [varchar](20) NULL,
	[NmRazaoSocial] [varchar](50) NULL,
	[NmLogradouro] [varchar](50) NULL,
	[NuNum] [char](10) NULL,
	[DsComplemento] [varchar](50) NULL,
	[NmCidade] [varchar](50) NULL,
	[SgUF] [varchar](4) NULL,
	[NuCep] [varchar](9) NULL,
	[NuTelefone] [varchar](50) NULL,
	[TeEmailEmpresa] [varchar](50) NULL,
	[DtCriacao] [smalldatetime] NULL,
	[DtAprovacao] [smalldatetime] NULL,
	[DtRevogacao] [smalldatetime] NULL,
	[StContrato] [char](1) NULL,
	[CdTipoContrato] [smallint] NULL,
	[cRecebEmailEmpr] [bit] NULL,
	[cIndcdContrPertcVisaoAgrup] [bit] NULL,
	[nLoteContrVisaoAgrup] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbContratoMaster]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbContratoMaster](
	[NuContratoEmpresa] [int] NULL,
	[NuCPF] [char](15) NULL,
	[NmMaster] [varchar](50) NULL,
	[NuTelefone] [varchar](50) NULL,
	[TeEmail] [varchar](50) NULL,
	[TeFraseSecreta] [varchar](50) NULL,
	[StMaster] [char](1) NULL,
	[cAutrzRecebEmail] [bit] NULL,
	[nCertf] [int] NULL,
	[cIndcdUtilzChavePblicBrasi] [decimal](1, 0) NULL,
	[nUsuarNe] [decimal](9, 0) NULL,
	[cIndcdExcvdAdm] [decimal](1, 0) NULL,
	[cIndcdAssDgtalContr] [decimal](1, 0) NULL,
	[dAssDgtalContr] [datetime] NULL,
	[nChaveAcssoCliNe] [decimal](9, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbContratoVsAplicado]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbContratoVsAplicado](
	[NuContratoEmpresaEvidencia] [int] NULL,
	[NuContratoEmpresaAplicado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbEmpresas]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbEmpresas](
	[CdEmpresa] [int] NULL,
	[NuCGC] [varchar](20) NULL,
	[NmEmpresa] [varchar](50) NULL,
	[DtCriacao] [smalldatetime] NULL,
	[DtRemocao] [smalldatetime] NULL,
	[NuDiasExpiracao] [smallint] NULL,
	[CdTipoContrato] [smallint] NULL,
	[DtAtualizacaoDadosEmpresa] [datetime] NULL,
	[DtAtualizacaoDadosProcuradores] [datetime] NULL,
	[cIndcdAcssoNeap] [bit] NULL,
	[cIdtfdTpoPoltcEmpr] [decimal](1, 0) NULL,
	[cIdtfdMgracEmpr] [tinyint] NULL,
	[cIndcdOrigeSistExter] [decimal](1, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEmpresaVsAplicado]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmpresaVsAplicado](
	[cdEmpresaEvidencia] [int] NULL,
	[cdEmpresaAplicado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbPoltcAssServcOper]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbPoltcAssServcOper](
	[cdEmpresa] [int] NULL,
	[cdServico] [smallint] NULL,
	[cdOperacao] [smallint] NULL,
	[cdGrupo] [smallint] NULL,
	[stIsoladaDependeAlcada] [char](1) NULL,
	[stConjuntaDependeAlcada] [char](1) NULL,
	[qtAssinatura] [smallint] NULL,
	[pzExpiracao] [smallint] NULL,
	[DtAtualizacaoDadosPolitica] [datetime] NULL,
	[cIndcdCompsAlcad] [char](1) NULL,
	[vAlcad] [decimal](18, 2) NULL,
	[cIndcdTpoPoltcObrig] [decimal](1, 0) NULL,
	[cIndcdCompsAlcadCjta] [decimal](1, 0) NULL,
	[cIdtfdTpoAssCombd] [decimal](1, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbProcuradores]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbProcuradores](
	[CdEmpresa] [int] NULL,
	[CdProcurador] [int] NULL,
	[NmApelido] [varchar](20) NULL,
	[DvMestre] [char](1) NULL,
	[DvAdministrador] [char](1) NULL,
	[DvNivel] [char](1) NULL,
	[CdAgencia] [smallint] NULL,
	[NuConta] [int] NULL,
	[CdResponsavel] [int] NULL,
	[DtCriacao] [smalldatetime] NULL,
	[DtRemocao] [smalldatetime] NULL,
	[StProcurador] [char](1) NULL,
	[dtUltAcesso] [smalldatetime] NULL,
	[NuAcessos] [int] NULL,
	[CdAutorizado] [varchar](7) NULL,
	[VrAlcada] [float] NULL,
	[NuCertificado] [int] NULL,
	[dtTrocaCertfProcurador] [smalldatetime] NULL,
	[cClulrHablt] [decimal](1, 0) NULL,
	[dAltAcssoMovel] [smalldatetime] NULL,
	[cPrfilAcssoNe] [decimal](5, 0) NULL,
	[dInicBloqProcd] [datetime] NULL,
	[dFimBloqProcd] [datetime] NULL,
	[nNvelHierqAprovTrans] [decimal](5, 0) NULL,
	[cIndcdReablProcd] [bit] NULL,
	[cIndcdPrmssTrocaChave] [bit] NULL,
	[cIndcdOrigeSistExter] [decimal](1, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUsuarioVsAplicado]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuarioVsAplicado](
	[nUsuarNeEvidencia] [decimal](9, 0) NULL,
	[nUsuarNeAplicado] [decimal](9, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChaveAcssoCliNe]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChaveAcssoCliNe](
	[nChaveAcssoCliNe] [decimal](9, 0) NULL,
	[cIndcdSitChaveAcsso] [decimal](1, 0) NULL,
	[cIndcdTpoAcssoCli] [decimal](1, 0) NULL,
	[dInclChaveAcssoCli] [datetime] NULL,
	[dExclChaveAcssoCli] [datetime] NULL,
	[dUltAcssoCli] [datetime] NULL,
	[qTentvSenhaInvld] [decimal](1, 0) NULL,
	[nCpfCliNe] [decimal](9, 0) NULL,
	[nCtrlCpfCliNe] [decimal](2, 0) NULL,
	[iChaveAcssoCli] [varchar](60) NULL,
	[cEmprPdrao] [int] NULL,
	[cIndcdAdsaoVisaoAgrup] [bit] NULL,
	[hAdsaoVisaoAgrup] [datetime] NULL,
	[cIndcdManutVisaoAgrup] [decimal](1, 0) NULL,
	[nMotvoCanclChaveAcssoNe] [smallint] NULL,
	[cEmprRespCanctAcsso] [int] NULL,
	[cProcdRespCanctAcsso] [int] NULL,
	[cIndcdOrigeSistExter] [decimal](1, 0) NULL,
	[cIndcdDoctoFictc] [decimal](1, 0) NULL,
	[cIndcdReiniSenhaChaveAcsso] [decimal](1, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChaveAcssoEmprProcd]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChaveAcssoEmprProcd](
	[cEmpr] [int] NULL,
	[cProcd] [int] NULL,
	[nChaveAcssoCliNe] [decimal](9, 0) NULL,
	[cSerieDspvoSegrcNe] [char](20) NULL,
	[cIndcdDspvoVip] [bit] NULL,
	[nTpoDspvoSegrcNe] [decimal](2, 0) NULL,
	[dExpirDspvoVip] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChavePblicBrasiCliNe]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChavePblicBrasiCliNe](
	[nChavePblicBrasi] [decimal](9, 0) NULL,
	[cChavePblicBrasi] [varchar](40) NULL,
	[nCnpjCliNe] [decimal](9, 0) NULL,
	[nFlialCnpjCliNe] [decimal](5, 0) NULL,
	[nCtrlCnpjCliNe] [decimal](2, 0) NULL,
	[nChaveAcssoCliNe] [decimal](9, 0) NULL,
	[cSerieChavePblicBrasi] [varchar](40) NULL,
	[dEmisChavePblic] [datetime] NULL,
	[dExpirChavePblic] [datetime] NULL,
	[iEmprEmisrChave] [varchar](70) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tGrpVisaoPerso]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tGrpVisaoPerso](
	[nGrpVisaoPerso] [int] NULL,
	[iGrpVisaoPerso] [varchar](70) NULL,
	[qAcssoCliNe] [int] NULL,
	[cIndcdGrpVisaoPersoPdrao] [decimal](1, 0) NULL,
	[dUltAcssoCli] [datetime] NULL,
	[cIndcdVisaoOrigeSist] [bit] NULL,
	[hExclVisaoAgrup] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tGrpVisaoPersoVsAplicado]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tGrpVisaoPersoVsAplicado](
	[nGrpVisaoPersoEvidencia] [int] NULL,
	[nGrpVisaoPersoAplicado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPersonalizacao]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPersonalizacao](
	[cdEmpresa] [int] NULL,
	[cdProcurador] [int] NULL,
	[flLeitorCodigoBarras] [char](1) NULL,
	[cdContaPadrao] [int] NULL,
	[cdContaCobrancaPadrao] [int] NULL,
	[qtMinutosExpiraSessao] [smallint] NULL,
	[cOrdGrpEconm] [decimal](1, 0) NULL,
	[cCorImpre] [decimal](1, 0) NULL,
	[cExibeVlrsTelaInic] [decimal](1, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPrfilAcssoNe]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPrfilAcssoNe](
	[cEmpr] [int] NULL,
	[cPrfilAcssoNe] [decimal](5, 0) NULL,
	[cIndcdTpoPrmssPrfil] [decimal](1, 0) NULL,
	[cIndcdTrnsmArqNe] [char](1) NULL,
	[iPrfilAcssoNe] [char](32) NULL,
	[rPrfilAcssoNe] [varchar](100) NULL,
	[cIndcdObrigProcrLegal] [decimal](1, 0) NULL,
	[cIndcdSitPrfil] [bit] NULL,
	[nPrfilCorpVisaoAgrup] [int] NULL,
	[cIndcdOrigeSistExter] [decimal](1, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPrfilCorpVisaoAgrup]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPrfilCorpVisaoAgrup](
	[nPrfilCorpVisaoAgrup] [int] NULL,
	[iPrfilCorpVisaoAgrup] [varchar](70) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPrfilCorpVisaoAgrupVsAplicado]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPrfilCorpVisaoAgrupVsAplicado](
	[nPrfilCorpVisaoAgrupEvidencia] [int] NULL,
	[nPrfilCorpVisaoAgrupAplicado] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPrfilServcOper]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPrfilServcOper](
	[cEmpr] [int] NULL,
	[cPrfilAcssoNe] [decimal](5, 0) NULL,
	[cGrpServcNe] [smallint] NULL,
	[cServcNe] [smallint] NULL,
	[cOperServcNe] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPrfilServcOperCta]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPrfilServcOperCta](
	[cEmpr] [int] NULL,
	[cPrfilAcssoNe] [decimal](5, 0) NULL,
	[cGrpServcNe] [smallint] NULL,
	[cServcNe] [smallint] NULL,
	[cOperServcNe] [smallint] NULL,
	[cCtaCliNe] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPrzaoCtaPdraoAcssoDirto]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPrzaoCtaPdraoAcssoDirto](
	[cEmpr] [int] NULL,
	[cProcd] [int] NULL,
	[cCtaCliNe] [int] NULL,
	[cAcssoDirtoMenuDnamc] [char](3) NULL,
	[cRzCtaPerso] [decimal](5, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPrzaoExibcSdoTelaInic]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPrzaoExibcSdoTelaInic](
	[cEmpr] [int] NULL,
	[cProcd] [int] NULL,
	[cCtaCliNe] [int] NULL,
	[cOrdSeqExibcSdoTelaInic] [decimal](2, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPrzaoMenuServcPrefc]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPrzaoMenuServcPrefc](
	[cEmpr] [int] NULL,
	[cProcd] [int] NULL,
	[cMenuDnamc] [decimal](5, 0) NULL,
	[cOrdSeqMenuServcPrefc] [decimal](2, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tPrzaoVisaoAgrupServcCta]    Script Date: 02/05/2019 11:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tPrzaoVisaoAgrupServcCta](
	[nGrpVisaoPerso] [int] NULL,
	[cEmpr] [int] NULL,
	[cCtaCliNe] [int] NULL,
	[cAcssoDirtoMenuDnamc] [char](3) NULL,
	[cRzCtaPerso] [decimal](5, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tUsuarNe]    Script Date: 02/05/2019 11:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tUsuarNe](
	[nUsuarNe] [decimal](9, 0) NULL,
	[wLoginUsuarNe] [char](10) NULL,
	[wSenhaAcssoUsuarNe] [char](80) NULL,
	[nTpoDoctoIdtfdUsuar] [decimal](5, 0) NULL,
	[cIdtfdDoctoUsuar] [char](20) NULL,
	[iDoctoAltrnUsuar] [varchar](60) NULL,
	[nChaveAcssoCliNe] [decimal](9, 0) NULL,
	[eEmailUsuarNe] [varchar](100) NULL,
	[cIndcdAutrzRecebEmail] [decimal](1, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tVisaoAgrupDspvoPerso]    Script Date: 02/05/2019 11:23:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tVisaoAgrupDspvoPerso](
	[cEmpr] [int] NULL,
	[cProcd] [int] NULL,
	[nGrpVisaoPerso] [int] NULL,
	[cIndcdVisaoAgrupPdrao] [bit] NULL
) ON [PRIMARY]
GO
