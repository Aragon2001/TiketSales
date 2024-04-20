

create database vuelos 
use vuelos 


-- Crear la tabla Aerolineas
CREATE TABLE Aerolineas (
    ID_aerolinea INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Pais_origen NVARCHAR(100) NOT NULL
);
GO

-- Crear la tabla Avion
CREATE TABLE Avion (
    ID_avion INT PRIMARY KEY IDENTITY(1,1),
    Marca_avion NVARCHAR(100) NOT NULL,
    ID_aerolinea INT NOT NULL,
    Capacidad INT NOT NULL,
    Nombre_piloto NVARCHAR(100) NOT NULL,
    Ciudad_origen NVARCHAR(100) NOT NULL,
    Ciudad_destino NVARCHAR(100) NOT NULL,
    Hora_salida DATETIME NOT NULL,
    Hora_llegada DATETIME NOT NULL,
    Escala BIT NOT NULL,
    Ciudades_escala NVARCHAR(MAX),
    CONSTRAINT FK_Avion_Aerolineas FOREIGN KEY (ID_aerolinea) REFERENCES Aerolineas(ID_aerolinea)
);


-- Crear la tabla Asiento
CREATE TABLE Asiento (
    ID_asiento INT PRIMARY KEY IDENTITY(1,1),
    Num_asiento NVARCHAR(10) NOT NULL,
    ID_avion INT NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
    FOREIGN KEY (ID_avion) REFERENCES Avion(ID_avion)
);
GO

-- Crear la tabla Persona
CREATE TABLE Persona (
    ID_persona INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Num_identificacion INT NOT NULL,
    tipo BIT NOT NULL, -- 0 empleado, 1 pasajero
    Apellido1 NVARCHAR(50) NOT NULL,
    Apellido2 NVARCHAR(50) NOT NULL,
    CONSTRAINT UK_NumIdentificacion UNIQUE (Num_identificacion)
);
GO

-- Crear la tabla Empleado
CREATE TABLE Empleado (
    ID_empleado INT PRIMARY KEY IDENTITY(1,1),
    ID_persona INT NOT NULL,
    Linea_aerea NVARCHAR(100) NOT NULL,
    Contraseña NVARCHAR(100) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    tipo INT NOT NULL, -- 0 admin, 1 vendedor
    Identificacion INT NOT NULL, -- Clave foránea
    FOREIGN KEY (ID_persona) REFERENCES Persona(ID_persona),
    FOREIGN KEY (Identificacion) REFERENCES Persona(Num_identificacion) -- Clave foránea
);
GO

-- Crear la tabla Pasajero
CREATE TABLE Pasajero (
    ID_pasajero INT PRIMARY KEY IDENTITY(1,1),
    Destino NVARCHAR(100) NOT NULL,
    Num_tiquete NVARCHAR(50) NOT NULL,
    Precio_tiquete DECIMAL(10, 2) NOT NULL, 
    Hora_atencion DATETIME NOT NULL,
    Fecha_salida DATE NOT NULL,
    Presente BIT NOT NULL,
    ID_persona INT NOT NULL,
    Nacionalidad NVARCHAR(50) NOT NULL,
    pasaporte INT NOT NULL, -- Clave foránea
    FOREIGN KEY (ID_persona) REFERENCES Persona(ID_persona),
    FOREIGN KEY (pasaporte) REFERENCES Persona(Num_identificacion) -- Clave foránea
);
GO

-- Crear la tabla Venta
CREATE TABLE Venta (
    ID_venta INT PRIMARY KEY IDENTITY(1,1),
    ID_pasajero INT NOT NULL,
    ID_avion INT NOT NULL,
    Hora_venta DATETIME NOT NULL,
    Monto_total DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (ID_pasajero) REFERENCES Pasajero(ID_pasajero),
    FOREIGN KEY (ID_avion) REFERENCES Avion(ID_avion)
);
GO

-- Crear la tabla Ventanilla
CREATE TABLE Ventanilla (
    ID_ventanilla INT PRIMARY KEY IDENTITY(1,1),
    Nombre_empleado NVARCHAR(100) NOT NULL,
    Numero_cedula NVARCHAR(50) NOT NULL,
    Hora_apertura TIME NOT NULL,
    Linea_aerea NVARCHAR(100) NOT NULL,
    Destino_vuelo NVARCHAR(100) NOT NULL,
    Numero_vuelo NVARCHAR(50) NOT NULL
);
GO



-- Crear la tabla Vuelos
CREATE TABLE Vuelos (
    ID_vuelo INT PRIMARY KEY IDENTITY(1,1),
    ID_avion INT NOT NULL,
    ID_aerolinea INT NOT NULL,
    Destino NVARCHAR(100) NOT NULL,
    Hora_salida DATETIME NOT NULL,
    Hora_llegada DATETIME NOT NULL,
    precio DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (ID_avion) REFERENCES Avion(ID_avion),
    FOREIGN KEY (ID_aerolinea) REFERENCES Aerolineas(ID_aerolinea)
);
GO

-- Insertar datos en la tabla Aerolineas
INSERT INTO Aerolineas (Nombre, Pais_origen) VALUES
    ('American Airlines', 'Estados Unidos'),
    ('British Airways', 'Reino Unido'),
    ('Lufthansa', 'Alemania'),
    ('Emirates', 'Emiratos Árabes Unidos');
    
-- Insertar datos en la tabla Avion
INSERT INTO Avion (Marca_avion, ID_aerolinea, Capacidad, Nombre_piloto, Ciudad_origen, Ciudad_destino, Hora_salida, Hora_llegada, Escala, Ciudades_escala) VALUES
    ('Boeing 777', 1, 300, 'John Smith', 'Nueva York', 'Londres', '2024-04-15 08:00:00', '2024-04-15 15:00:00', 0, NULL),
    ('Airbus A380', 2, 500, 'Emma Johnson', 'Londres', 'Nueva York', '2024-04-15 10:00:00', '2024-04-15 18:00:00', 0, NULL),
    ('Boeing 737', 3, 150, 'Michael Brown', 'Fráncfort', 'Dubái', '2024-04-16 09:00:00', '2024-04-16 15:00:00', 1, 'Estambul'),
    ('Airbus A320', 4, 200, 'Sophia Wilson', 'Dubái', 'Fráncfort', '2024-04-16 11:00:00', '2024-04-16 17:00:00', 0, NULL);

-- Insertar datos en la tabla Asiento
INSERT INTO Asiento (Num_asiento, ID_avion, Estado) VALUES
    ('1A', 1, 'Disponible'),
    ('1B', 1, 'Reservado'),
    ('2A', 1, 'Disponible'),
    ('2B', 1, 'Disponible'),
    ('1A', 2, 'Disponible'),
    ('1B', 2, 'Disponible'),
    ('2A', 2, 'Reservado'),
    ('2B', 2, 'Disponible'),
    ('1A', 3, 'Disponible'),
    ('1B', 3, 'Disponible'),
    ('2A', 3, 'Disponible'),
    ('2B', 3, 'Disponible'),
    ('1A', 4, 'Disponible'),
    ('1B', 4, 'Reservado'),
    ('2A', 4, 'Disponible'),
    ('2B', 4, 'Disponible');

-- Insertar datos en la tabla Persona
INSERT INTO Persona (Nombre, Num_identificacion, tipo, Apellido1, Apellido2) VALUES
    ('John', 123456789, 0, 'Doe', 'Smith'),
    ('Emma', 234567890, 1, 'Johnson', 'Brown'),
    ('Michael', 345678901, 0, 'Williams', 'Taylor'),
    ('Sophia', 456789012, 1, 'Wilson', 'Martinez');

-- Insertar datos en la tabla Empleado
INSERT INTO Empleado (ID_persona, Linea_aerea, Contraseña, Email, tipo, Identificacion) VALUES
    (1, 'American Airlines', '1234', 'john.doe@example.com', 0, 123456789),
    (3, 'Lufthansa', '1234', 'michael.williams@example.com', 1, 345678901);

-- Insertar datos en la tabla Pasajero
INSERT INTO Pasajero (Destino, Num_tiquete, Precio_tiquete, Hora_atencion, Fecha_salida, Presente, ID_persona, Nacionalidad, pasaporte) VALUES
    ('Londres', 'AA1234', 500.00, '2024-04-15 07:30:00', '2024-04-15', 1, 2, 'Estadounidense', 234567890),
    ('Nueva York', 'LH5678', 600.00, '2024-04-16 08:00:00', '2024-04-16', 1, 4, 'Británica', 456789012);

-- Insertar datos en la tabla Venta
INSERT INTO Venta (ID_pasajero, ID_avion, Hora_venta, Monto_total) VALUES
    (1, 1, '2024-04-15 06:30:00', 500.00),
    (2, 2, '2024-04-16 07:00:00', 600.00);

-- Insertar datos en la tabla Ventanilla
INSERT INTO Ventanilla (Nombre_empleado, Numero_cedula, Hora_apertura, Linea_aerea, Destino_vuelo, Numero_vuelo) VALUES
    ('Elena Rodriguez', 'ABC123', '08:00:00', 'American Airlines', 'Londres', 'AA1234'),
    ('Carlos Martinez', 'DEF456', '09:00:00', 'Lufthansa', 'Nueva York', 'LH5678');

-- Insertar datos en la tabla Vuelos
INSERT INTO Vuelos (ID_avion, ID_aerolinea, Destino, Hora_salida, Hora_llegada, precio) VALUES
    (1, 1, 'Londres', '2024-04-15 08:00:00', '2024-04-15 15:00:00', 500.00),
    (2, 2, 'Nueva York', '2024-04-16 10:00:00', '2024-04-16 18:00:00', 600.00);


----------- modificaciones el 20/04/24
ALTER TABLE Pasajero DROP COLUMN precio_tiquete;
