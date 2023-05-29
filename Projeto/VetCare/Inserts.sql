-- DONO
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('Jo�o Silva', 'Rua A, Lisboa', 923456789, 111111111);
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('Maria Santos', 'Rua B, Porto', 987654321, 222222222);
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('Ant�nio Pereira', 'Rua C, Coimbra', 955555555, 333333333);
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('Ana Rodrigues', 'Avenida X, Lisboa', 911111111, 444444444);
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('Pedro Sousa', 'Rua Y, Porto', 922222222, 555555555);

-- ANIMAL
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Bobby', '2018-05-10', 1, 'Bulldog', 'C�o', 1001);
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Luna', '2019-03-15', 0, 'Siam�s', 'Gato', 1002);
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Max', '2017-11-20', 1, 'Labrador', 'C�o', 1003);
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Kiko', '2020-02-28', 1, 'Golden Retriever', 'C�o', 1004);
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Mia', '2019-09-10', 0, 'Persa', 'Gato', 1005);

-- FICHA_CLINICA
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (1, 'Registo m�dico 1', 111111111, 1001);
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (2, 'Registo m�dico 2', 222222222, 1002);
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (3, 'Registo m�dico 3', 333333333, 1003);
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (4, 'Registo m�dico 4', 444444444, 1004);
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (5, 'Registo m�dico 5', 555555555, 1005);

-- MEDICO_VET
-- Inser��o do primeiro m�dico
INSERT INTO MEDICO_VET (nome, contato, email, morada)
VALUES ('Dr. Jo�o Silva', 987654321, 'joao.silva@example.com', 'Rua das Flores, 123');

-- Inser��o do segundo m�dico
INSERT INTO MEDICO_VET (nome, contato, email, morada)
VALUES ('Dra. Maria Santos', 123456789, 'maria.santos@example.com', 'Avenida Central, 456');

-- Inser��o do terceiro m�dico
INSERT INTO MEDICO_VET (nome, contato, email, morada)
VALUES ('Dr. Pedro Oliveira', 456789123, 'pedro.oliveira@example.com', 'Pra�a da Liberdade, 789');
