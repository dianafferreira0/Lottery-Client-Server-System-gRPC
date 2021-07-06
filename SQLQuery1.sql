create table ModelUtilizador(
	Id int identity primary key,
	nome nvarchar(300) not null
)

create table ModelAposta(
	Id int identity primary key,
	chave nvarchar(300) not null,
	data nvarchar(300) not null,
	registada bit,
	utilizadorId int references ModelUtilizador(Id)
)