﻿CREATE TABLE naturalidade (
	id int NOT NULL AUTO_INCREMENT,
    descricao VARCHAR(100) NOT NULL,
    dataCriacao datetime not null,
    dataAlteracao datetime not null,
    ativo boolean not null,
    CONSTRAINT pk_naturalidades_id PRIMARY KEY (id)
);