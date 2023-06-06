CREATE VIEW vw_Cirurgia AS
SELECT c.numCirurgia, c.procedimento, a.nomeAnimal AS nomePaciente, m.nome AS nomeProfissional
FROM CIRURGIA c
INNER JOIN ANIMAL a ON c.numPaciente = a.numPaciente
INNER JOIN MEDICO_VET m ON c.numProfissional = m.numProfissional;
