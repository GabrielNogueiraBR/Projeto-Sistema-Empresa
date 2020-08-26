USE SistemaCadastroEmpresa

CREATE TABLE Empresas
(
	CNPJ VARCHAR(14) NOT NULL,
	RAZAOSOCIAL VARCHAR(200) NOT NULL,
	ATIVIDADEPRINCIPAL VARCHAR(500) NOT NULL,
	LOGRADOURO VARCHAR(200),
	NUMERO VARCHAR(5),
	MUNICIPIO VARCHAR(60),
	UF VARCHAR(60)

	CONSTRAINT PK_CNPJ PRIMARY KEY (CNPJ)
	
)

insert into Empresas
values(	'12345678912345',
		'Primeira Empresa cadastrada', 
		'Realizar testes de programa��o', 
		'Rua S�o Paulo', 
		'115', 
		'Bairro S�o Paulo', 
		'S�o Paulo')
