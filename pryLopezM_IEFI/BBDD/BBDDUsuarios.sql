CREATE DATABASE BBDDUsuarios;

USE BBDDUsuarios;

CREATE TABLE Usuarios (
    idUsuario INT PRIMARY KEY IDENTITY NOT NULL,
    usuario VARCHAR(50) NOT NULL,
    contraseña VARCHAR(50) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    edad INT NOT NULL,
    DNI VARCHAR(11) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    email VARCHAR(30) NOT NULL,
    fechaDeNacimiento DATE NOT NULL,
    fechaDeAlta DATE NOT NULL DEFAULT GETDATE(), -- Fecha actual por defecto
    horaDeAlta TIME(0) NOT NULL DEFAULT CAST(GETDATE() AS TIME), -- Hora actual por defecto
    permisos VARCHAR(20) NOT NULL
);

CREATE TABLE sesionUsuario	(
	idSesion INT PRIMARY KEY NOT NULL IDENTITY,
	fechaUltConeccion DATE NOT NULL,
	horaUltConeccion TIME(0) NOT NULL DEFAULT CAST(GETDATE() AS TIME), 
    fechaActual DATE NOT NULL DEFAULT GETDATE(),
	horaActual TIME(0) NOT NULL DEFAULT CAST(GETDATE() AS TIME),
    tiempoSesion TIME(0) NOT NULL,
    tiempoTotal TIME(0) NOT NULL,
	idUsuarioSesion INT,
	FOREIGN KEY (idUsuarioSesion) REFERENCES Usuarios(idUsuario)
);

CREATE TABLE accionRealizada(
idAccionRealizada INT PRIMARY KEY IDENTITY NOT NULL,
evento VARCHAR (50) NOT NULL,
descripcion VARCHAR (100) NOT NULL,
fechaDeAccion DATE NOT NULL DEFAULT GETDATE(),
horaDeAccion TIME(0) NOT NULL DEFAULT CAST(GETDATE() AS TIME),
idUsuarioAccion INT NOT NULL,
FOREIGN KEY (idUsuarioAccion) REFERENCES Usuarios(idUsuario)
);


CREATE TABLE registrarTarea (
    idTarea INT NOT NULL IDENTITY PRIMARY KEY,
	fechaTarea DATE NOT NULL,
	tareaPrincipal VARCHAR (50) NOT NULL,
	lugarTarea VARCHAR (50) NOT NULL,
	detalle VARCHAR(255) NOT NULL, -- Asumiendo que vas a guardar los checks como texto concatenado
    comentario VARCHAR(255) NOT NULL,
	fechaRegistro DATE NOT NULL, -- Para saber cuándo se registró
	horaTareaRegistrada TIME(0) NOT NULL,
    idUsuarioTarea INT NOT NULL
    --estado VARCHAR(50), -- Ej: "Pendiente", "En Proceso", "Completada"
    --prioridad VARCHAR(20), -- Ej: "Alta", "Media", "Baja"
    FOREIGN KEY (idUsuarioTarea) REFERENCES Usuarios(IdUsuario)
);


INSERT INTO registrarTarea 
(fechaTarea, tareaPrincipal, lugarTarea, detalle, comentario, fechaRegistro, horaTareaRegistrada, idUsuarioTarea)
VALUES
('2025-06-1', 'Auditoría', 'Empresa', 'Estudio, Recibo', 'Revisión de contratos del personal.', '2025-06-2', '08:30:00', 1),
('2025-06-1', 'Consultas', 'Oficina', 'Salario, Vacacion', 'Consulta por nuevo sistema de vacaciones.', '2025-06-2', '10:15:00', 2),
('2025-06-2', 'Inspección', 'Empresa', 'Estudio, Vacacion', 'Inspección de seguridad en taller.', '2025-06-3', '11:45:00', 3),
('2025-06-2', 'Reclamos', 'Servicio', 'Insumo, Recibo', 'Reclamos por insumos defectuosos.', '2025-06-3', '14:10:00', 4),
('2025-06-3', 'Visitas', 'Oficina', 'Salario', 'Visita de evaluación de ambiente laboral.', '2025-06-4', '09:20:00', 5),
('2025-06-3', 'Auditoría', 'Empresa', 'Salario, Estudio', 'Auditoría interna mensual.', '2025-06-4', '13:50:00', 6),
('2025-06-4', 'Consultas', 'Servicio', 'Recibo', 'Consulta sobre pago de horas extra.', '2025-06-5', '10:05:00', 7),
('2025-06-4', 'Inspección', 'Empresa', 'Estudio, Insumo', 'Inspección técnica de herramientas.', '2025-06-5', '15:30:00', 8),
('2025-06-5', 'Reclamos', 'Oficina', 'Recibo, Salario', 'Reclamos múltiples por descuentos.', '2025-06-6', '09:40:00', 9),
('2025-06-5', 'Visitas', 'Servicio', 'Vacacion, Estudio', 'Visita de coordinación con otros sectores.', '2025-06-6', '16:10:00', 10);



INSERT INTO Usuarios 
(Usuario, Contraseña, Nombre, Apellido, Edad, DNI, Direccion, Telefono, Email, FechaDeNacimiento, FechaDeAlta, Permisos)
VALUES
('admin', 'admin123', 'Admin', 'Principal', 35, '12345678', 'Calle 1', '1234567890', 'admin@empresa.com', CONVERT(date, '1989/01/01', 111), CONVERT(date, GETDATE()), 'Administrador'),
('jdoe', 'pass1234', 'John', 'Doe', 28, '23456789', 'Calle 2', '1234567891', 'jdoe@mail.com', CONVERT(date, '1997/05/15', 111), CONVERT(date, '2023/03/01', 111), 'Operador'),
('mgarcia', 'secure456', 'María', 'García', 31, '34567890', 'Avenida Siempreviva 742', '1234567892', 'mgarcia@mail.com', CONVERT(date, '1993/08/10', 111), CONVERT(date, GETDATE()), 'Administrador'),
('lmendez', 'clave789', 'Luis', 'Méndez', 40, '45678901', 'Pasaje Los Andes 55', '1234567893', 'lmendez@mail.com', CONVERT(date, '1985/03/20', 111), CONVERT(date, '2023/04/15', 111), 'Operador'),
('srodriguez', 'rodrig123', 'Sofía', 'Rodríguez', 25, '56789012', 'Ruta 3 KM 45', '1234567894', 'srodriguez@mail.com', CONVERT(date, '1999/12/02', 111), CONVERT(date, GETDATE()), 'Administrador'),
('cfernandez', 'contraseña1', 'Carlos', 'Fernández', 38, '67890123', 'Boulevard San Martín 1200', '1234567895', 'cfernandez@mail.com', CONVERT(date, '1986/07/07', 111), CONVERT(date, '2023/02/28', 111), 'Operador'),
('nlopez', 'lopez2024', 'Natalia', 'López', 29, '78901234', 'Callejón del Sol 9', '1234567896', 'nlopez@mail.com', CONVERT(date, '1995/02/14', 111), CONVERT(date, GETDATE()), 'Administrador'),
('rhernandez', 'passRicky8', 'Ricardo', 'Hernández', 33, '89012345', 'Diagonal Norte 400', '1234567897', 'rhernandez@mail.com', CONVERT(date, '1991/11/23', 111), CONVERT(date, '2023/01/10', 111), 'Operador'),
('emartinez', 'martiZ21', 'Elena', 'Martínez', 27, '90123456', 'Av. Libertad 110', '1234567898', 'emartinez@mail.com', CONVERT(date, '1997/06/30', 111), CONVERT(date, GETDATE()), 'Administrador'),
('jperez', 'jperez2025', 'Javier', 'Pérez', 36, '11223344', 'Calle Falsa 123', '1234567899', 'jperez@mail.com', CONVERT(date, '1988/10/05', 111), CONVERT(date, '2023/05/20', 111), 'Operador'),
('mruiz', 'ruizclave', 'Manuel', 'Ruiz', 41, '99887766', 'Calle Sur 55', '1234567800', 'mruiz@mail.com', CONVERT(date, '1983/09/18', 111), CONVERT(date, GETDATE()), 'Administrador');


INSERT INTO accionRealizada (evento, descripcion, fechaDeAccion, idUsuarioAccion)
VALUES 
('Login', 'Inicio de sesión exitoso', '2025-06-01', 1),
('Logout', 'Cierre de sesión por inactividad', '2025-06-01', 2),
('Creacion', 'Se creó un nuevo usuario con permisos de operador', '2025-06-02', 3),
('Busqueda', 'Se consultaron datos de la tabla usuarios', '2025-06-03', 4),
('Actualizacion', 'Actualización de correo electrónico del usuario', '2025-06-03', 5),
('Eliminacion', 'Se eliminó un usuario inactivo', '2025-06-04', 6),
('Login', 'Inicio de sesión desde IP desconocida', '2025-06-05', 7),
('Busqueda', 'Consulta de sesiones activas recientes', '2025-06-05', 8),
('Actualizacion', 'Se cambió la contraseña del usuario', '2025-06-06', 9),
('Logout', 'Cierre de sesión manual', '2025-06-06', 10);


INSERT INTO sesionUsuario (fechaUltConeccion, fechaActual, tiempoSesion, tiempoTotal, idUsuarioSesion)
VALUES 
('2025-06-01', '2025-06-01', 3600, 7200, 1),
('2025-06-01', '2025-06-01', 1800, 3600, 2),
('2025-06-02', '2025-06-02', 2700, 2700, 3),
('2025-06-03', '2025-06-03', 4500, 9000, 4),
('2025-06-03', '2025-06-03', 1200, 3600, 5),
('2025-06-04', '2025-06-04', 3000, 3000, 6),
('2025-06-05', '2025-06-05', 2400, 4800, 7),
('2025-06-05', '2025-06-05', 600, 1800, 8),
('2025-06-06', '2025-06-06', 3600, 10800, 9),
('2025-06-06', '2025-06-06', 900, 1800, 10);

INSERT INTO sesionUsuario (fechaUltConeccion, fechaActual, tiempoSesion, tiempoTotal, idUsuarioSesion)
VALUES 
('2025-06-01', '2025-06-01', '01:00:00', '01:00:00', 1),
('2025-06-01', '2025-06-01', '00:30:00', '00:0:00', 2),
('2025-06-02', '2025-06-02', '00:45:00', '00:45:00', 3),
('2025-06-03', '2025-06-03', '01:15:00', '01:15:00', 4),
('2025-06-03', '2025-06-03', '00:20:00', '00:20:00', 5),
('2025-06-04', '2025-06-04', '00:50:00', '00:50:00', 6),
('2025-06-05', '2025-06-05', '00:40:00', '00:40:00', 7),
('2025-06-05', '2025-06-05', '00:10:00', '00:10:00', 8),
('2025-06-06', '2025-06-06', '01:00:00', '01:00:00', 9),
('2025-06-06', '2025-06-06', '00:15:00', '00:15:00', 10);


Select * from sesionUsuario;

Select * from Usuarios;

Select * from accionRealizada;

Select * from registrarTarea;


DROP TABLE sesionUsuario;

DROP TABLE Usuarios;

DROP TABLE accionRealizada;

DROP TABLE registrarTarea;

SELECT idUsuario, fechaDeAlta FROM Usuarios;

set format 'dd:MM:yyyy';

set DATEFORMAT dmy;