CREATE DATABASE BBDDUsuarios;

USE BBDDUsuarios;

CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY NOT NULL,
    Usuario VARCHAR(50),
	Contraseña VARCHAR(50),
	Nombre VARCHAR(50),
	Apellido VARCHAR(50),
	Edad VARCHAR(2),
	DNI VARCHAR (11),
	Direccion VARCHAR (50),
	Telefono VARCHAR (15),
	Email VARCHAR (30),
	FechaDeNacimiento DATE NOT NULL,
	FechaDeAlta DATETIME NOT NULL,
    Permisos VARCHAR(20) NOT NULL,
    
);

CREATE TABLE sesionUs(
	IdSesion INT PRIMARY KEY NOT NULL IDENTITY,
	FechaUltConeccion DATETIME NOT NULL,
    FechaActual DATETIME NOT NULL,
    TiempoSesion BIGINT NOT NULL,
    TiempoTotal BIGINT NOT NULL,
	AccionRealizada VARCHAR (50),
	IdUsuarioSesion INT,
	FOREIGN KEY (IdUsuarioSesion) REFERENCES Usuarios(IdUsuario)
);

set DATEFORMAT mdy;

INSERT INTO Usuarios 
(IdUsuario, Usuario, Contraseña, Nombre, Apellido, Edad, DNI, Direccion, Telefono, Email, FechaDeNacimiento, FechaDeAlta, Permisos)
VALUES
(1, 'admin', 'admin123', 'Admin', 'Principal', '35', '12345678', 'Calle 1', '1234567890', 'admin@empresa.com', '1989-01-01', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Administradores'),
(2, 'jdoe', 'pass1234', 'John', 'Doe', '28', '23456789', 'Calle 2', '1234567891', 'jdoe@mail.com', '1997-05-15', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Operadores'),
(3, 'mgarcia', 'secure456', 'María', 'García', '31', '34567890', 'Avenida Siempreviva 742', '1234567892', 'mgarcia@mail.com', '1993-08-10', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Administradores'),
(4, 'lmendez', 'clave789', 'Luis', 'Méndez', '40', '45678901', 'Pasaje Los Andes 55', '1234567893', 'lmendez@mail.com', '1985-03-20', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Operadores'),
(5, 'srodriguez', 'rodrig123', 'Sofía', 'Rodríguez', '25', '56789012', 'Ruta 3 KM 45', '1234567894', 'srodriguez@mail.com', '1999-12-02', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Administradores'),
(6, 'cfernandez', 'contraseña1', 'Carlos', 'Fernández', '38', '67890123', 'Boulevard San Martín 1200', '1234567895', 'cfernandez@mail.com', '1986-07-07', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Operadores'),
(7, 'nlopez', 'lopez2024', 'Natalia', 'López', '29', '78901234', 'Callejón del Sol 9', '1234567896', 'nlopez@mail.com', '1995-02-14', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Administradores'),
(8, 'rhernandez', 'passRicky8', 'Ricardo', 'Hernández', '33', '89012345', 'Diagonal Norte 400', '1234567897', 'rhernandez@mail.com', '1991-11-23', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Operadores'),
(9, 'emartinez', 'martiZ21', 'Elena', 'Martínez', '27', '90123456', 'Av. Libertad 110', '1234567898', 'emartinez@mail.com', '1997-06-30', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Administradores'),
(10, 'jperez', 'jperez2025', 'Javier', 'Pérez', '36', '11223344', 'Calle Falsa 123', '1234567899', 'jperez@mail.com', '1988-10-05', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Operadores'),
(11, 'mruiz', 'ruizclave', 'Manuel', 'Ruiz', '41', '99887766', 'Calle Sur 55', '1234567800', 'mruiz@mail.com', '1983-09-18', CONVERT(DATETIME, CONVERT(VARCHAR(19), GETDATE(), 120)), 'Administradores');



Select * from sesionUs;

Select * from Usuarios;

DROP TABLE sesionUs;

DROP TABLE Usuarios;

SELECT
    IdUsuario, Usuario, Contraseña, Nombre, Apellido, Edad, DNI, Direccion, Telefono, Email, Format(FechaDeNacimiento, 'yyyy/MM/dd') AS [Fechita de nacimiento], FORMAT(FechaDeAlta, 'yyyy-MM-dd HH:mm:ss') AS FechaDeAltaSinMilisegundos, Permisos
FROM Usuarios;