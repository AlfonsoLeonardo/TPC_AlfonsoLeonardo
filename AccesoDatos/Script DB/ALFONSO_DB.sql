USE master
GO
create database ALFONSO_DB
GO
use ALFONSO_DB

go

create table TIPODEUSUARIO(
Id int not null primary key,
Descripcion varchar(50) not null,
)
go

insert into TIPODEUSUARIO values (1, 'ADMINISTRADOR')
insert into TIPODEUSUARIO values (2, 'GERENTE')
insert into TIPODEUSUARIO values (3, 'ATENCION PUBLICO')

go

create table USUARIOS(
Id int primary key identity (1,1) not null,
Nombre varchar (50) not null,
Pass varchar (50) not null,
TipoUsuario int not null foreign key references TIPODEUSUARIO(Id),
)
go

insert into USUARIOS values ('admin', 'admin', 1)
go

create table INGREDIENTES(
Id int primary key identity (1,1) not null,
Nombre varchar (50) not null,
Stockingrediente decimal (12,3) not null,
Precio decimal (12,3) not null,
MasterPack decimal (12,3) not null,
FechaCreacion SMALLDATETIME not null,
UsuarioCreacion int not null foreign key references USUARIOS(Id),
FechaModificacion SMALLDATETIME not null,
UsuarioModificacion int not null foreign key references USUARIOS(Id),
)
go
insert into INGREDIENTES values ('Papa',0,1500,15,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIENTES values ('Masa',0,17,0.435,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIENTES values ('Muzzarella',0,3500,25,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIENTES values ('Salsa',0,500,8,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIENTES values ('Aceituna',0,250,12,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIENTES values ('Oregano',0,100,500,'03/03/2018',1,'03/03/2018',1)



create table COMIDAS(
Id int primary key identity (1,1) not null,
Nombre varchar (50) not null,
Precio decimal (12,3) not null,
FechaCreacion SMALLDATETIME not null,
UsuarioCreacion int not null foreign key references USUARIOS(Id),
FechaModificacion SMALLDATETIME not null,
UsuarioModificacion int not null foreign key references USUARIOS(Id),
)
go
insert into COMIDAS values ('Pizza Mussa',175,'03/03/2018',1,'03/03/2018',1)
insert into COMIDAS values ('Porcion Papas',85,'03/03/2018',1,'03/03/2018',1)

go

create table INGREDIETESPORCOMIDAS(
IdComida int not null FOREIGN KEY REFERENCES COMIDAS(Id),
IdIngrediente int not null FOREIGN KEY REFERENCES INGREDIENTES(Id),
Cantidad decimal (12,3) not null,
FechaCreacion SMALLDATETIME not null,
UsuarioCreacion int not null foreign key references USUARIOS(Id),
FechaModificacion SMALLDATETIME not null,
UsuarioModificacion int not null foreign key references USUARIOS(Id),
primary key (IdComida,IdIngrediente),
)
go

insert into INGREDIETESPORCOMIDAS values (1,2,0.435,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIETESPORCOMIDAS values (1,3,0.200,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIETESPORCOMIDAS values (1,4,0.005,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIETESPORCOMIDAS values (1,5,0.010,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIETESPORCOMIDAS values (1,6,0.001,'03/03/2018',1,'03/03/2018',1)
insert into INGREDIETESPORCOMIDAS values (2,1,0.460,'03/03/2018',1,'03/03/2018',1)

