CREATE DATABASE SistemaCadastroEmpresa

CREATE TABLE Empresas
(
	CNPJ VARCHAR(14) NOT NULL,
	RAZAOSOCIAL VARCHAR(200) NOT NULL,
	ATIVIDADEPRINCIPAL VARCHAR(500) NOT NULL,
	LOGRADOURO VARCHAR(200) NOT NULL,
	NUMERO VARCHAR(5) NOT NULL,
	MUNICIPIO VARCHAR(60) NOT NULL,
	UF VARCHAR(60) NOT NULL,

	CONSTRAINT PK_CNPJ PRIMARY KEY (CNPJ),
	CONSTRAINT UNIQUE_RAZAOSOCIAL UNIQUE (RAZAOSOCIAL)
	
)