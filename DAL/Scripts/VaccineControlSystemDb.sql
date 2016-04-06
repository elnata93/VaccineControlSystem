create database VaccineControlSystem;
use VaccineControlSystem;
select * from PacientesVacunas
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
Sexo int,
Direccion varchar(100),
Telefono varchar(15),
EsUnica int
);
go
create table Vacunas(VacunaId int primary key identity(1,1),
NombresVacunas varchar(40),
);
go
create table PacientesVacunas(PacienteVacunaId int primary key identity(1,1),
PacienteId int,
NombrePaciente varchar(30),
VacunaId int references Vacunas(VacunaId),
NombresVacunas varchar(40)
);
go
create table HistorialVacunas(HistorialVacunaId int primary key identity(1,1),
CentroSalud varchar(50),
Provincia varchar(50),
Municipio varchar(50),
FechaHistorial datetime
);

create table HistorialVacunasFecha(HistorialFechaId int primary key identity(1,1),
Paciente varchar(30),
HistorialVacunaId int references HistorialVacunas(HistorialVacunaId),
NombresVacunas varchar(40),
FechaVacuna datetime,
Dosis varchar(20)
);