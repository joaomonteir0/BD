-- Índice ANIMAL
CREATE INDEX idx_ANIMAL_numPaciente ON ANIMAL (numPaciente);

-- Índice DONO
CREATE INDEX idx_DONO_numCC ON DONO (numCC);

-- Índices FICHA_CLINICA
CREATE INDEX idx_FICHA_CLINICA_numFichaUnica ON FICHA_CLINICA (numFichaUnica);
CREATE INDEX idx_FICHA_CLINICA_numPaciente ON FICHA_CLINICA (numPaciente);
CREATE INDEX idx_FICHA_CLINICA_numCC ON FICHA_CLINICA (numCC);

-- Índices MEDICO_VET
CREATE INDEX idx_MEDICO_VET_numProfissional ON MEDICO_VET (numProfissional);

-- Índices CONSULTA
CREATE INDEX idx_CONSULTA_idConsulta ON CONSULTA (idConsulta);
CREATE INDEX idx_CONSULTA_numMedicoVet ON CONSULTA (numMedicoVet);
CREATE INDEX idx_CONSULTA_numPaciente ON CONSULTA (numPaciente);

-- Índices PRESCRICAO
CREATE INDEX idx_PRESCRICAO_numPrescricao ON PRESCRICAO (numPrescricao);
CREATE INDEX idx_PRESCRICAO_idConsulta ON PRESCRICAO (idConsulta);
CREATE INDEX idx_PRESCRICAO_numProfissional ON PRESCRICAO (numProfissional);

-- Índices CIRURGIA
CREATE INDEX idx_CIRURGIA_numCirurgia ON CIRURGIA (numCirurgia);
CREATE INDEX idx_CIRURGIA_numPaciente ON CIRURGIA (numPaciente);
CREATE INDEX idx_CIRURGIA_numProfissional ON CIRURGIA (numProfissional);
