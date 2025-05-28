CREATE DATABASE BBDDUsuarios;

USE BBDDUsuarios;

CREATE TABLE Usuarios (
    id INT PRIMARY KEY NOT NULL IDENTITY,
    usuario VARCHAR(50),
	contraseña VARCHAR(50),
    permisos VARCHAR(20) NOT NULL,
    
);

CREATE TABLE sesionUs(
	idSesion INT PRIMARY KEY NOT NULL IDENTITY,
	fechaUltConex DATETIME NOT NULL,
    fechaActual DATETIME NOT NULL,
    tiempoSesion BIGINT NOT NULL,
    tiempoTotal BIGINT NOT NULL,
	idUs INT,
	FOREIGN KEY (idUs) REFERENCES Usuarios(id)
);

INSERT INTO Usuarios (usuario, contraseña, permisos)
VALUES
('admin', 'admin123', 'Administrador'),
('usuario1', 'clave1', 'Operador'),
('usuario2', 'clave2', 'Operador'),
('soporte1', 'soporte123', 'Soporte'),
('maria', 'maria2024', 'Operador'),
('juan', 'juanpass', 'Operador'),
('lucas', 'lucas456', 'Administrador'),
('ana', 'ana321', 'Soporte'),
('testuser', 'testpass', 'Operador'),
('supervisor1', 'super2024', 'Administrador');

Select * from sesionUs;

Select * from Usuarios;

DROP TABLE sesionUs;

DROP TABLE Usuarios;