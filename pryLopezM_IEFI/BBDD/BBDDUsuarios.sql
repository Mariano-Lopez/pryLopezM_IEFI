CREATE DATABASE BBDDUsuarios;

USE BBDDUusarios;

CREATE TABLE Usuarios(
id int primary key not null,
nombre varchar(50),
permisos int not null,
fechaUltConex DATETIME2 not null,
fechaActual DATETIME2 not null,
tiempoSesion BIGINT not null,
tiempoTotal BIGINT not null
);