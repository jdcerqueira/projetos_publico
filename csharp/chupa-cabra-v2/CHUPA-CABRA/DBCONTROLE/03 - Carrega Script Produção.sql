USE CONTROLE
GO

EXEC sp_msforeachtable 'TRUNCATE TABLE ?'
GO

IF EXISTS(SELECT TOP 1 1 FROM sys.columns WHERE object_id = OBJECT_ID('validadorEvidencia.RecepcaoArquivo_TMP') AND name = 'ID')
BEGIN
	ALTER TABLE validadorEvidencia.RecepcaoArquivo_TMP DROP CONSTRAINT PKRecepcaoArquivo_TMP
	ALTER TABLE validadorEvidencia.RecepcaoArquivo_TMP DROP COLUMN ID
END
GO

SET NOCOUNT ON
SET DATEFORMAT YMD
GO

DECLARE @Arquivo VARCHAR(MAX) = 'D:\SQLServer\ArquivosTexto\ChupaCabra\SCR_MRV_GrupoEconomico.txt'
DECLARE @Formato VARCHAR(MAX) = 'D:\SQLServer\ArquivosTexto\ChupaCabra\ChupaCabra.fmt'
DECLARE @Comando VARCHAR(1024) = N'bcp '+ DB_NAME() +'.validadorEvidencia.RecepcaoArquivo_TMP IN '+ @Arquivo +' -f '+ @Formato +' -S "1acpjw008\sql17" -T -b 50000'

SELECT COUNT(1) 'Total Tabela Carregamento' FROM validadorEvidencia.RecepcaoArquivo_TMP
EXEC master..xp_cmdshell @Comando, NO_OUTPUT
SELECT COUNT(1) 'Total Tabela Carregamento' FROM validadorEvidencia.RecepcaoArquivo_TMP
GO

ALTER TABLE validadorEvidencia.RecepcaoArquivo_TMP ADD ID INT IDENTITY
ALTER TABLE validadorEvidencia.RecepcaoArquivo_TMP ADD CONSTRAINT PKRecepcaoArquivo_TMP PRIMARY KEY(ID)
GO

DECLARE @ID INT = 1
DECLARE @Comando VARCHAR(MAX) = ''

WHILE EXISTS(SELECT TOP 1 1 FROM validadorEvidencia.RecepcaoArquivo_TMP WHERE ID = @ID)
BEGIN
	SELECT @Comando = LINHA FROM validadorEvidencia.RecepcaoArquivo_TMP WHERE ID = @ID

	BEGIN TRAN
	BEGIN TRY
		EXEC(@Comando)
		DELETE FROM validadorEvidencia.RecepcaoArquivo_TMP WHERE ID = @ID
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT @Comando
	END CATCH

	SET @ID += 1
END
GO

DECLARE @Resultados TABLE(Tabela VARCHAR(MAX), Total INT)
INSERT INTO @Resultados(Tabela,Total)
EXEC sp_MSforeachtable 'SELECT ''?'', COUNT(1) FROM ?'
SELECT * FROM @Resultados ORDER BY Total DESC
GO

SET NOCOUNT OFF
GO
