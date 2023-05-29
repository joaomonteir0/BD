-- Remover os stored procedures:
DROP PROCEDURE IF EXISTS dbo.RemoverAnimal;
DROP PROCEDURE IF EXISTS dbo.RemoverFichaClinica;
DROP PROCEDURE IF EXISTS dbo.AdicionarFichaClinica;
DROP PROCEDURE IF EXISTS dbo.AtualizarDadosFichaClinica;
GO

CREATE PROCEDURE dbo.RemoverAnimal
    @numPaciente INT
AS
BEGIN
    BEGIN TRANSACTION;

    DELETE FROM CONSULTA WHERE numPaciente = @numPaciente;

    DELETE FROM FICHA_CLINICA WHERE numPaciente = @numPaciente;

    DELETE FROM ANIMAL WHERE numPaciente = @numPaciente;

    COMMIT;
END;
GO

CREATE PROCEDURE dbo.RemoverFichaClinica
    @numFichaClinica INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @numPaciente INT;
    DECLARE @numCC INT;

    SELECT @numPaciente = numPaciente, @numCC = numCC
    FROM FICHA_CLINICA
    WHERE numFichaUnica = @numFichaClinica;

    IF (@numPaciente IS NOT NULL)
    BEGIN
        DELETE FROM FICHA_CLINICA
        WHERE numFichaUnica = @numFichaClinica;

        DELETE FROM Animal
        WHERE numPaciente = @numPaciente;

        DELETE FROM Dono
        WHERE numCC = @numCC;
    END;
END;
GO


CREATE PROCEDURE dbo.AdicionarFichaClinica
    @numFichaClinica INT,
    @registoMedico VARCHAR(200),
    @numCC INT,
    @numPaciente INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM ANIMAL WHERE numPaciente = @numPaciente) AND EXISTS (SELECT 1 FROM DONO WHERE numCC = @numCC)
    BEGIN
        INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente)
        VALUES (@numFichaClinica, @registoMedico, @numCC, @numPaciente);
    END;
END;
GO

CREATE PROCEDURE dbo.AtualizarDadosFichaClinica
    @numFichaUnica INT,
    @novoNomeDono VARCHAR(100),
    @novoNomeAnimal VARCHAR(100),
    @novaMoradaDono VARCHAR(100),
    @novoContato INT
AS
BEGIN
    UPDATE DONO
    SET
        nomeDono = @novoNomeDono,
        moradaDono = @novaMoradaDono,
        contato = @novoContato
    WHERE
        numCC = (SELECT numCC FROM FICHA_CLINICA WHERE numFichaUnica = @numFichaUnica);

    UPDATE ANIMAL
    SET
        nomeAnimal = @novoNomeAnimal
    WHERE
        numPaciente = (SELECT numPaciente FROM FICHA_CLINICA WHERE numFichaUnica = @numFichaUnica);
END
