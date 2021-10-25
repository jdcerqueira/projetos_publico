USE DBCONTROLE
GO

IF OBJECT_ID('dbo.fFormataTexto','FN') IS NOT NULL
	DROP FUNCTION dbo.fFormataTexto
GO

/*
FUNCTION : dbo.fFormataTexto
PROPOSITO : Formata o texto conforme mascara informada.
			Valido somente para valores numericos.
			Para identificar o numerico na mascara, devera ser 
			informado o caractere "#".
			Por exemplo:
				Texto: 123456789000100
				Mascara: ###.###.###/####-##
				Retorno: 123.456.789/0001-00
AUTOR : JOAO DANIEL
DATA : 13-12-2017
PARAMETRO :
	@Texto		VARCHAR(50),
	@Mascara	VARCHAR(50)
RETORNO :
	VARCHAR(100)
REGISTROS DE MANUTENCAO :
	NAO HA
*/
CREATE FUNCTION dbo.fFormataTexto
(
	@Texto		VARCHAR(50),
	@Mascara	VARCHAR(50)
)
RETURNS VARCHAR(100)
AS
BEGIN
	DECLARE @Retorno			VARCHAR(20) = ''
	DECLARE @TamanhoTexto		INT = LEN(RTRIM(@Texto))
	DECLARE @TamanhoMascara		INT = LEN(RTRIM(@Mascara))
	DECLARE @contadorMascara	INT = 0
	DECLARE @contadorTexto		INT = 0
	DECLARE @caractere			INT = 1

	-- VALIDA A MASCARA
	WHILE @caractere <= @TamanhoMascara
	BEGIN
		SELECT @contadorMascara += CASE WHEN SUBSTRING(@Mascara,@caractere,1) = '#' THEN 1 ELSE 0 END
		SELECT @caractere += 1
	END

	IF @TamanhoMascara < @TamanhoTexto
	BEGIN
		RETURN 'Mascara invalida'
	END

	-- IGUALA OS VALORES NUMERICOS CASO FALTE NO TEXTO
	SELECT @Texto = REPLICATE('0',@contadorMascara - @TamanhoTexto) + @Texto

	-- Inicia o vetor com o tamanho do texto para aplicar a mascara de trás para frente
	SET @caractere = @TamanhoMascara
	SET @contadorTexto = LEN(RTRIM(@Texto))

	WHILE @caractere > 0
	BEGIN
		IF SUBSTRING(@Mascara,@caractere,1) = '#'
		BEGIN
			SET @Retorno = SUBSTRING(@Texto,@contadorTexto,1) + @Retorno
			SET @contadorTexto -= 1
		END
		ELSE
		BEGIN
			SET @Retorno = SUBSTRING(@Mascara,@caractere,1) + @Retorno
		END

		SET @caractere -= 1
	END
	
	RETURN @Retorno
END
GO