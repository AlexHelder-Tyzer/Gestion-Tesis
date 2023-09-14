use Master
go

--------------------------------------
-- CREACION DE LA BASE DE DATOS		--
--------------------------------------
if exists (select * from dbo.sysdatabases where name='DBDeTesis')
	drop database DBDeTesis
go
create database DBDeTesis
go


--------------------------------------
-- CREACION DE LAS TABLAS			--
use DBDeTesis
go
create table TDocente
( -- lista de atributos
	CodDocente varchar(5),
	Nombres varchar(80) not null,
	Apellidos varchar(80) not null,
	DNI char(8) check (DNI like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	Clase varchar(20) check(Clase in ('Nombrado','Contratado')) not null,
	Categoria varchar(50),
	Especialidad varchar(100),
	DepartamentoAcademico varchar(50),
	Email varchar (50),
	-- Especificacion de claves
	primary key (CodDocente)
)
go

---------------------------------------
create table TTesista
(-- lista de atributos
	CodTesista varchar(6),
	Nombres varchar(80) not null,
	Apellidos varchar(80) not null,
	DNI char(8) check (DNI like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	EscuelaProfesional varchar(50),
	Celular char(9),
	Email varchar(50),
	-- Especificacion de claves
	primary key (CodTesista)
)
go

---------------------------------------------
create table TTesis
(-- lista de atributos
	CodTesis varchar(10),
	Titulo varchar(50) not null,
	Especialidad varchar(30) not null,
	CodTesista varchar(6),
	CodDocente varchar(5),
	-- Especificacion de claves
	primary key (CodTesis),
	foreign key (CodTesista) references TTesista(CodTesista),
	foreign key (CodDocente) references TDocente(CodDocente)
)
go

-----------------------------------------------------

create table TExpediente_Inscripcion
(-- lista de atributos
	CodITesis varchar(6),
	Fecha date not null,
	CodTesista varchar(6) not null,
	CodTesis varchar(10) not null,
	-- Especificacion de claves
	primary key (CodITesis),
	foreign key (CodTesista) references TTesista(CodTesista),
	foreign key (CodTesis) references TTesis(CodTesis)
)
go

---------------------------------------------------------

create table TExpediente
(-- lista de atributos
	CodExpediente int identity(1,1),
	CodTesis varchar(10) not null,
	CodTramite int not null,
	-- Especificacion de claves
	primary key (CodExpediente),
	foreign key (CodTesis) references TTesis(CodTesis),
	foreign key (CodTramite) references TTramite(CodTramite)
)
go

---------------------------------------------------------
create table TExpediente_Dictamen
(-- lista de atributos
	CodDictamen int identity(1,1) not null,
	CodDictaminante varchar(5) not null,
	Condicion varchar(15) check(Condicion in ('SUFICIENCIA','INSUFICIENCIA')),
	-- Especificacion de claves
	primary key (CodDictamen,CodDictaminante),
	foreign key (CodDictamen) references TExpediente(CodExpediente),
	foreign key (CodDictaminante) references TDocente(CodDocente)
)
go

------------------------------------------------------------

create table TExpediente_Sustentacion
(-- lista de atributos
	CodSustentacion int,
	CodEvaluador varchar(5),
	Fecha date not null,
	-- Especificacion de claves
	primary key (CodSustentacion,CodEvaluador),
	foreign key (CodSustentacion) references TExpediente(CodExpediente),
	foreign key (CodEvaluador) references TDocente(CodDocente)
)
go

-----------------------------------------------------------
/*
create table TAsesor
( -- lista de atributos
	CodAsesor int identity(1,1),
	-- Especificacion de claves
	FechaAsignacion date not null,
	CodDocente varchar(5) not null,
	CodTesis varchar(10) not null,
	primary key (CodAsesor),
	foreign key (CodDocente) references TDocente(CodDocente),
	foreign key (CodTesis) references TTesis(CodTesis)
)
go

----------------------------------------------------

create table TRevisor
( -- lista de atributos
	CodRevisor int identity(1,1),
	-- Especificacion de claves
	FechaAsignacion date not null,
	CodDocente varchar(5) not null,
	CodTesis varchar(10) not null,
	primary key (CodRevisor),
	foreign key (CodDocente) references TDocente(CodDocente),
	foreign key (CodTesis) references TTesis(CodTesis)
)
go

----------------------------------------------------

create table TDictaminante
( -- lista de atributos
	CodDictaminante int identity(1,1),
	-- Especificacion de claves
	FechaAsignacion date not null,
	CodDocente varchar(5) not null,
	CodTesis varchar(10) not null,
	primary key (CodDictaminante),
	foreign key (CodDocente) references TDocente(CodDocente),
	foreign key (CodTesis) references TTesis(CodTesis)
)
go

-------------------------------------------------------
create table TEvaluador
( -- lista de atributos
	CodEvaluador int identity(1,1),
	-- Especificacion de claves
	FechaAsignacion date not null,
	CodDocente varchar(5) not null,
	CodTesis varchar(10) not null,
	primary key (CodEvaluador),
	foreign key (CodDocente) references TDocente(CodDocente),
	foreign key (CodTesis) references TTesis(CodTesis)
)
go

*/
---------------------------------------------------------

create table TRequisito
(
	-- lista de atributos
	CodRequisito int identity(1,1),
	Nombre varchar(80) not null,
	primary key (CodRequisito)
)


create table TTramite
(
	--- lista de atributos
	CodTramite int identity(1,1),
	Nombre varchar(40) not null,
	Descripcion varchar(80),
	primary key (CodTramite)
)

create table TRequisitos_Tramite
(
	CodReqTramite int identity(1,1),
	NroTramite int not null,
	NroRequisito int not null,
	primary key (CodReqTramite),
	foreign key (NroTramite) references TTramite(CodTramite),
	foreign key (NroRequisito) references TRequisito(CodRequisito)
)

