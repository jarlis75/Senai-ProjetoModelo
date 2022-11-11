CREATE TABLE funcionarios (
id INT NOT NULL AUTO_INCREMENT,
nome  VARCHAR(75)  NOT NULL,
data_de_nascimento  DATE NULL,
sexo bool NOT NULL,
cpf VARCHAR(15) NOT NULL,
id_nacionalidade INT NOT NULL,
id_naturalidade INT NOT NULL,
email VARCHAR(40) NOT NULL,
telefone VARCHAR (15) NOT NULL,
telefone_contato VARCHAR (15) NOT NULL,
cep VARCHAR (9) NOT NULL,
logradouro VARCHAR (200) NOT NULL,
numero int (5) NOT NULL,
complemento VARCHAR (30) NULL,
bairro VARCHAR (25) NOT NULL,
municipio VARCHAR (25) NOT NULL,
uf VARCHAR (2) NOT NULL,
CONSTRAINT pk_funcionarios_id PRIMARY KEY(id)
);