CREATE PROCEDURE RemoverAnimal
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
END
