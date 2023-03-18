CREATE TABLE MEDICO(
	ID INT NOT NULL,
	Nome VARCHAR(30) NOT NULL,
	Especialidade VARCHAR(20) NOT NULL,

	PRIMARY KEY(ID),
);

CREATE TABLE FARMACO(
	Nome VARCHAR(20) NOT NULL,
	Formula VARCHAR(100) NOT NULL,

	PRIMARY KEY (Nome),
);

CREATE TABLE FARMACEUTICA(
	Num_Registo_Nacional INT NOT NULL,
	Nome VARCHAR(20) NOT NULL,
	Telefone INT NOT NULL,
	Endereco VARCHAR(50) NOT NULL,
	Nome_Unico_Farmaco VARCHAR(20) NOT NULL,

	PRIMARY KEY(Num_Registo_Nacional),
	FOREIGN KEY(Nome_Unico_Farmaco) REFERENCES FARMACO(Nome),
);

CREATE TABLE PACIENTE(
	Num_Utente INT NOT NULL,
	Nome VARCHAR(30) NOT NULL,
	Data_Nasc DATE NOT NULL,
	Endere�o VARCHAR(50) NOT NULL,

	PRIMARY KEY(Num_Utente),
);

CREATE TABLE PRESCRICAO(
	Num_Unico INT NOT NULL,
	DataPrescricao DATE NOT NULL,
	Medico_efetua INT NOT NULL,
	Paciente INT NOT NULL,
	Farmaco VARCHAR(20) NOT NULL,

	PRIMARY KEY(Num_Unico),
	FOREIGN KEY(Medico_efetua) REFERENCES MEDICO(ID),
	FOREIGN KEY(Paciente) REFERENCES PACIENTE(Num_Utente),
	FOREIGN KEY(Farmaco) REFERENCES FARMACO(Nome),
);

CREATE TABLE FARMACIA(
	NIF INT NOT NULL,
	Nome VARCHAR(20) NOT NULL,
	Telefone INT NOT NULL,
	Endereco VARCHAR(50) NOT NULL,

	PRIMARY KEY (NIF),
);

CREATE TABLE PROCESSAR(
	Num_Prescricao INT NOT NULL,
	Num_Utente INT NOT NULL,
	NIF_Farmacia INT NOT NULL,

	PRIMARY KEY(Num_Prescricao, Num_Utente, NIF_Farmacia),
	FOREIGN KEY(Num_Prescricao) REFERENCES PRESCRICAO(Num_Unico),
	FOREIGN KEY(Num_Utente) REFERENCES PACIENTE(Num_Utente),
	FOREIGN KEY(NIF_Farmacia) REFERENCES FARMACIA(NIF),
);