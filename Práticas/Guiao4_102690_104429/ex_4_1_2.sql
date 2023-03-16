CREATE TABLE AIRPORT(
	Codigo INT NOT NULL,
	Cidade VARCHAR(15) NOT NULL,
	Estado VARCHAR(15) NOT NULL,
	Nome VARCHAR(15) NOT NULL,

	PRIMARY KEY(Codigo),

);


CREATE TABLE AIRPLANE_TYPE(
	Tipo VARCHAR(15) NOT NULL,
	Companhia VARCHAR(15) NOT NULL,
	MAX_Lugares INT NOT NULL,

	PRIMARY KEY (Tipo),
);

CREATE TABLE CAN_LAND(
	Codigo_Aeroporto INT NOT NULL,
	Tipo_Aviao VARCHAR(15) NOT NULL,

	PRIMARY KEY (Codigo_Aeroporto, Tipo_Aviao),
	FOREIGN KEY (Codigo_Aeroporto) REFERENCES AIRPORT(Codigo),
	FOREIGN KEY (Tipo_Aviao) REFERENCES AIRPLANE_TYPE(Tipo),

);

CREATE TABLE AIRPLANE(
	ID INT NOT NULL,
	Numero_Lugares INT NOT NULL,
	Tipo_Aviao VARCHAR(15) NOT NULL,

	PRIMARY KEY (ID),
	FOREIGN KEY (Tipo_Aviao) REFERENCES AIRPLANE_TYPE(Tipo),
);

CREATE TABLE FLIGHT(
	Numero_Voo INT NOT NULL,
	Airline VARCHAR(15) NOT NULL,
	Dia_semana VARCHAR(15) NOT NULL,

	PRIMARY KEY(Numero_Voo),

);

CREATE TABLE FARE(
	Codigo INT NOT NULL,
	Quantidade INT NOT NULL,
	Restricoes VARCHAR(40) NOT NULL,
	Numero_Voo INT NOT NULL,

	PRIMARY KEY (Codigo),
	FOREIGN KEY (Numero_Voo) REFERENCES FLIGHT(Numero_Voo),

);

CREATE TABLE FLIGHT_LEG(
	Numero_Leg INT NOT NULL,
	Numero_Voo INT NOT NULL,
	Tempo_Partida_Agendado VARCHAR(5) NOT NULL,
	Tempo_Chegada_Agendado VARCHAR(5) NOT NULL,
	Codigo1 INT NOT NULL,
	Codigo2 INT NOT NULL,

	PRIMARY KEY (Numero_Leg),
	FOREIGN KEY (Numero_Voo) REFERENCES FLIGHT(Numero_Voo),
	FOREIGN KEY (Codigo1) REFERENCES AIRPORT(Codigo),
	FOREIGN KEY (Codigo2) REFERENCES AIRPORT(Codigo),

);

CREATE TABLE LEG_INSTANCE(
	Data_InstanciaLeg VARCHAR(10) NOT NULL,
	Numero_LugaresDisponiveis INT NOT NULL,
	Tempo_Partida VARCHAR(5) NOT NULL,
	Tempo_Chegada VARCHAR(5) NOT NULL,
	Codigo1 INT NOT NULL,
	Codigo2 INT NOT NULL,
	Numero_Voo INT NOT NULL,
	Numero_Leg INT NOT NULL,
	ID_Aviao INT NOT NULL,

	PRIMARY KEY (Data_InstanciaLeg),
	FOREIGN KEY (Codigo1) REFERENCES AIRPORT(Codigo),
	FOREIGN KEY (Codigo2) REFERENCES AIRPORT(Codigo),
	FOREIGN KEY (Numero_Voo) REFERENCES FLIGHT(Numero_Voo),
	FOREIGN KEY (Numero_Leg) REFERENCES FLIGHT_leg(Numero_Leg),
	FOREIGN KEY (ID_Aviao) REFERENCES AIRPLANE(ID),

);

CREATE TABLE SEAT(
	Numero_Lugar INT NOT NULL,
	Nome_Cliente VARCHAR(20) NOT NULL,
	Telefone_Cliente INT NOT NULL
	CHECK (Telefone_Cliente = 9),
	Numero_Voo INT NOT NULL,
	Numero_Leg INT NOT NULL,
	ID_Aviao INT NOT NULL,
	Data_InstanciaLeg VARCHAR(10) NOT NULL,

	PRIMARY KEY (Numero_Lugar),
	FOREIGN KEY (Numero_Voo) REFERENCES FLIGHT(Numero_Voo),
	FOREIGN KEY (Numero_Leg) REFERENCES FLIGHT_leg(Numero_Leg),
	FOREIGN KEY (ID_Aviao) REFERENCES AIRPLANE(ID),
	FOREIGN KEY (Data_InstanciaLeg) REFERENCES LEG_iNSTANCE(Data_InstanciaLeg),

);

