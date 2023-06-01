CREATE TRIGGER ValidarDataNascimentoAnimal
ON ANIMAL
FOR INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE dataNascimentoAnimal > GETDATE()
    )
    BEGIN
        RAISERROR ('A data de nascimento não pode ser futura.', 16, 1)
        ROLLBACK TRANSACTION
    END
END;

CREATE TRIGGER ValidarFormatoEmailMedico
ON MEDICO_VET
FOR INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE email NOT LIKE '%@%.%'
    )
    BEGIN
        RAISERROR ('O formato do email é inválido.', 16, 1)
        ROLLBACK TRANSACTION
    END
END;

CREATE TRIGGER GerarNumeroProfissional
ON MEDICO_VET
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO MEDICO_VET (nome, numProfissional, contato, email, morada)
    SELECT nome, ABS(CHECKSUM(NEWID())) % 9000000 + 1000000, contato, email, morada
    FROM inserted;
END;

