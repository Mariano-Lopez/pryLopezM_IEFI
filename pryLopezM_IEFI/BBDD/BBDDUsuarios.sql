CREATE DATABASE BBDDUsuarios;

USE BBDDUsuarios;

CREATE TABLE Usuarios (
    id INT PRIMARY KEY NOT NULL IDENTITY,
    usuario VARCHAR(50),
	contraseña VARCHAR(50),
    permisos INT NOT NULL,
    
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

INSERT INTO Usuarios (id, usuario, contraseña, permisos)
VALUES
(1, 'admin', 'admin123', 1),
(2, 'usuario1', 'clave1', 2),
(3, 'usuario2', 'clave2', 2);

Select * from sesionUs;

Select * from Usuarios;

DROP TABLE sesionUs;

DROP TABLE Usuarios;