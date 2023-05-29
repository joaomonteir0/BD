-- Remover os stored procedures existentes
DROP PROCEDURE IF EXISTS dbo.RemoverAnimal;
DROP PROCEDURE IF EXISTS dbo.RemoverFichaClinica;
GO

-- Criar os stored procedures novamente
CREATE PROCEDURE dbo.RemoverAnimal
    @numPaciente INT
AS
BEGIN
    BEGIN TRANSACTION;

    -- Remover todas as consultas associadas ao animal
    DELETE FROM CONSULTA WHERE numPaciente = @numPaciente;

    -- Remover a ficha clínica do animal
    DELETE FROM FICHA_CLINICA WHERE numPaciente = @numPaciente;

    -- Remover o animal da tabela ANIMAL
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

    -- Obter o número do paciente e o número do CC do dono da ficha clínica
    SELECT @numPaciente = numPaciente, @numCC = numCC
    FROM FICHA_CLINICA
    WHERE numFichaUnica = @numFichaClinica;

    IF (@numPaciente IS NOT NULL)
    BEGIN
        -- Remover ficha clínica
        DELETE FROM FICHA_CLINICA
        WHERE numFichaUnica = @numFichaClinica;

        -- Remover animal associado à ficha
        DELETE FROM Animal
        WHERE numPaciente = @numPaciente;

        -- Remover dono associado à ficha
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
    -- Verificar se o animal e o dono existem
    IF EXISTS (SELECT 1 FROM ANIMAL WHERE numPaciente = @numPaciente) AND EXISTS (SELECT 1 FROM DONO WHERE numCC = @numCC)
    BEGIN
        -- Inserir a ficha clínica
        INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente)
        VALUES (@numFichaClinica, @registoMedico, @numCC, @numPaciente);
    END;
END;
GO
