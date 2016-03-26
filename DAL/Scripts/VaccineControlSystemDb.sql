create database VaccineControlSystem;
use VaccineControlSystem;

create table TiposUsuarios(TipoUsuarioId int primary key identity(1,1),
Descripcion varchar(20)
);
go
Create table Ciudades(CiudadId int primary key identity(1,1),
Descripcion varchar(100)
);
go
create table Usuarios(UsuarioId int primary key identity(1,1),
NombresUsuarios varchar(30),
Nombres varchar(30),
Apellidos varchar(30),
Direccion varchar(100),
Telefono Varchar(15),
Email varchar(50),
Contrasena varchar(30),
TipoUsuarioId int,
CiudadId int,
Fecha datetime,
Imagen varchar(300)
);
go
create table Pacientes(PacienteId int primary key identity(1,1),
Nombres varchar(30),
Apellidos varchar(30),
Edad int,
Sexo bit,
Direccion varchar(100),
Telefono varchar(15),
EsUnica bit,
VacunaId int references Vacunas(VacunaId)
);
go
create table Vacunas(VacunaId int primary key identity(1,1),
NombresVacunas varchar(50),

);
go
create table PacientesVacunas(PacienteVacunaId int primary key identity(1,1),
PacienteId int,
VacunaId int,
Nombres varchar(50)
);
go
create table HistorialVacunas(HistorialVacunaId int primary key identity(1,1),
CentroSalud varchar(50),
Provincia varchar(50),
Municipio varchar(50),
PacienteId int,
PrimeraDosis date,
SegundaDosis date,
TerceraDosis date,
PrimerRefuerzo date,
SegundoRefuerzo date
);