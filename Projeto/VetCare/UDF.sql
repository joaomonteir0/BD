CREATE FUNCTION dbo.GetCCAndFichaUnicaByNumPaciente
(
    @numPaciente INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT numCC, numFichaUnica
    FROM FICHA_CLINICA
    WHERE numPaciente = @numPaciente
);

CREATE FUNCTION dbo.ObterDadosFichaClinica (
    @numFichaUnica INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT D.nomeDono, A.nomeAnimal, D.moradaDono, D.contato, FC.numCC, FC.numFichaUnica, A.especie
    FROM FICHA_CLINICA FC
    INNER JOIN ANIMAL A ON FC.numPaciente = A.numPaciente
    INNER JOIN DONO D ON FC.numCC = D.numCC
    WHERE FC.numFichaUnica = @numFichaUnica
)


CREATE FUNCTION VerificarPrescricao(@idConsulta INT)
RETURNS INT
AS
BEGIN
    DECLARE @numPrescricao INT;

    SELECT @numPrescricao = numPrescricao
    FROM PRESCRICAO
    WHERE idConsulta = @idConsulta;

    IF @numPrescricao IS NULL
        SET @numPrescricao = 0;

    RETURN @numPrescricao;
END;
