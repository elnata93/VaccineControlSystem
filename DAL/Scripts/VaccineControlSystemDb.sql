create database VaccineControlSystemDb;
use VaccineControlSystemDb;

create table Usuarios(UsuarioId int primary key identity(1,1),
Nombres varchar(30),Apellidos varchar(30),Direccion varchar(100),
Telefono Varchar(15),Contrasena varchar(30),
TipoUsuarioId int references TiposUsuarios(TipoUsuarioId),
CiudaId int references Ciudades(CiudaId) ,Fecha datetime);
go
create table TiposUsuarios(TipoUsuarioId int primary key identity(1,1),
Descripcion varchar(20));
go
create table Pacientes(PacienteId int primary key identity(1,1),
Nombres varchar(30),Apellidos varchar(30),Direccion varchar(100),
Telefono Varchar(15),Edad int);
go
Create table Ciudades(CiudaId int primary key identity(1,1),
Descripcion varchar(100));
go
create table TiposVacunas(TipoVacunaId int primary key identity(1,1),
Descripcion varchar(30));
go
create table Vacunas(VacunaId int primary key identity(1,1),
CentroSaludId varchar(50),Provincia varchar(50),
Municipio varchar(50),PacienteId int,FechaNacimiento date);
go
create table FechasVanacion(FechaVanacionId int primary key identity(1,1),
PrimeraDosis date,SegundaDosis date,TerceraDosis date,
PrimerRefuerzo date,SegundoRefuerzo date);
go 
create table PacientesVacunas(PacienteVacunaId int primary key identity(1,1),PacienteId int,FechaVanacionId int);
