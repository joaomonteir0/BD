-- DONO
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('João Silva', 'Rua A, Lisboa', 923456789, 111111111);
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('Maria Santos', 'Rua B, Porto', 987654321, 222222222);
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('António Pereira', 'Rua C, Coimbra', 955555555, 333333333);
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('Ana Rodrigues', 'Avenida X, Lisboa', 911111111, 444444444);
INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES ('Pedro Sousa', 'Rua Y, Porto', 922222222, 555555555);

-- ANIMAL
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Bobby', '2018-05-10', 1, 'Bulldog', 'Cão', 1001);
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Luna', '2019-03-15', 0, 'Siamês', 'Gato', 1002);
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Max', '2017-11-20', 1, 'Labrador', 'Cão', 1003);
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Kiko', '2020-02-28', 1, 'Golden Retriever', 'Cão', 1004);
INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) VALUES ('Mia', '2019-09-10', 0, 'Persa', 'Gato', 1005);

-- FICHA_CLINICA
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (1, 'Registo médico 1', 111111111, 1001);
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (2, 'Registo médico 2', 222222222, 1002);
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (3, 'Registo médico 3', 333333333, 1003);
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (4, 'Registo médico 4', 444444444, 1004);
INSERT INTO FICHA_CLINICA (numFichaUnica, registoMedico, numCC, numPaciente) VALUES (5, 'Registo médico 5', 555555555, 1005);

-- MEDICO_VET
INSERT INTO MEDICO_VET (nome, contato, email, morada) VALUES ('Dr. João Silva', 987654321, 'joao.silva@example.com', 'Rua das Flores, 123');
INSERT INTO MEDICO_VET (nome, contato, email, morada) VALUES ('Dra. Maria Santos', 123456789, 'maria.santos@example.com', 'Avenida Central, 456');
INSERT INTO MEDICO_VET (nome, contato, email, morada) VALUES ('Dr. Pedro Oliveira', 456789123, 'pedro.oliveira@example.com', 'Praça da Liberdade, 789');
INSERT INTO MEDICO_VET (numProfissional, nome, contato, email, morada) VALUES (4, 'Dr. Antônio Silva', 999888777, 'antonio.silva@example.com', 'Rua dos Médicos, 456');
INSERT INTO MEDICO_VET (numProfissional, nome, contato, email, morada) VALUES (5, 'Dra. Sofia Almeida', 111222333, 'sofia.almeida@example.com', 'Avenida dos Animais, 789');
INSERT INTO MEDICO_VET (numProfissional, nome, contato, email, morada) VALUES (6, 'Dr. Ricardo Santos', 444555666, 'ricardo.santos@example.com', 'Praça dos Bichos, 123');

-- Consultas
INSERT INTO CONSULTA (idConsulta, numMedicoVet, numPaciente, dataConsulta) VALUES (1, 4, 1004, '2023-06-01');
INSERT INTO CONSULTA (idConsulta, numMedicoVet, numPaciente, dataConsulta) VALUES (2, 4, 1005, '2023-06-05');
INSERT INTO CONSULTA (idConsulta, numMedicoVet, numPaciente, dataConsulta) VALUES (3, 5, 1004, '2023-06-08');
INSERT INTO CONSULTA (idConsulta, numMedicoVet, numPaciente, dataConsulta) VALUES (4, 6, 1004, '2023-05-28');
INSERT INTO CONSULTA (idConsulta, numMedicoVet, numPaciente, dataConsulta) VALUES (5, 5, 1005, '2023-05-15');
INSERT INTO CONSULTA (idConsulta, numMedicoVet, numPaciente, dataConsulta) VALUES (6, 6, 1004, '2023-05-20');
INSERT INTO CONSULTA (idConsulta, numMedicoVet, numPaciente, dataConsulta) VALUES (7, 6, 1004, '2023-05-25');
INSERT INTO CONSULTA (idConsulta, numMedicoVet, numPaciente, dataConsulta) VALUES (8, 6, 1004, '2023-05-29');


-- PRESCRICAO
INSERT INTO PRESCRICAO (numPrescricao, idConsulta, numProfissional, dataConsulta) VALUES (212, 6, 1178243, '2023-05-20');
INSERT INTO PRESCRICAO (numPrescricao, idConsulta, numProfissional, dataConsulta) VALUES (311, 6, 5731686, '2023-05-25');
INSERT INTO PRESCRICAO (numPrescricao, idConsulta, numProfissional, dataConsulta) VALUES (454, 4, 5731686, '2023-06-01');


-- CIRURGIA
INSERT INTO CIRURGIA (numCirurgia, procedimento, numPaciente, numProfissional) VALUES (5, 'Catnip Surgery', 1003, 4);
INSERT INTO CIRURGIA (numCirurgia, procedimento, numPaciente, numProfissional) VALUES (6, 'Canine Care', 1004, 5);
INSERT INTO CIRURGIA (numCirurgia, procedimento, numPaciente, numProfissional) VALUES (7, 'Feline Dental', 1005, 6);



