Create database db_mantenimiento;

go

use db_mantenimiento;

sp_addlogin 'usuario', '01234567'
sp_addsrvrolemember 'usuario', 'sysadmin'

sp_adduser 'usuario', 'usuario'
sp_addrolemember 'db_accessadmin', 'usuario'

Create table Empleado(
ID_Empleado int not null primary key identity(0, 1),
Primer_Nombre varchar(20) not null,
Segundo_Nombre varchar(20) not null,
Primer_Apellido varchar(20) not null,
Segundo_Apellido varchar(20) not null,
Cedula varchar(20) not null unique
);

go

CREATE PROCEDURE VerEmpleados
As
SELECT * from Empleado

Create table Equipo(
ID_Equipo int not null primary key identity(0, 1),
Nombre varchar(15) not null,
Descripcion varchar(100)
);

go

Create table EmpleadoEquipo(
ID_EmpEquipo int not null primary key identity(0, 1),
ID_Empleado int not null,
ID_Equipo int not null,
Foreign Key (ID_Empleado) References Empleado(ID_Empleado),
Foreign Key (ID_Equipo) References Equipo(ID_Equipo)
);

go

Create table Cargo(
ID_Cargo int not null primary key identity(0, 1),
Nombre varchar(30) not null,
Descripcion varchar(100)
);

go

Create table EmpleadoCargo(
ID_EmpCargo int not null primary key identity(0, 1),
ID_Empleado int not null,
ID_Cargo int not null,
Foreign Key (ID_Empleado) References Empleado(ID_Empleado),
Foreign Key (ID_Cargo) References Cargo(ID_Cargo)
);

go

Create table Fallo(
ID_Fallo int not null primary key identity(0, 1),
Nombre varchar(30)
);

go

Create table FalloEquipo(
ID_FalloEquipo int not null primary key identity(0, 1),
ID_Fallo int not null,
ID_Equipo int not null,
Costo float not null,
Descripcion varchar(100),
Foreign Key (ID_Fallo) References Fallo(ID_Fallo),
Foreign Key (ID_Equipo) References Equipo(ID_Equipo)
);

go

Create table Pieza(
ID_Pieza int not null primary key identity(0, 1),
Nombre varchar(25) not null,
Costo float not null,
Descripcion varchar(100)
);

go

Create table PiezaFalloEq(
ID_PiezaFalloEq int not null primary key identity(0, 1),
ID_Pieza int not null,
ID_FalloEquipo int not null,
Foreign Key (ID_Pieza) References Pieza(ID_Pieza),
Foreign Key (ID_FalloEquipo) References FalloEquipo(ID_FalloEquipo)
);

go

Create table Mantenimiento(
ID_Mantenimiento int not null primary key identity(0, 1),
Nombre varchar(80) not null,
Descripcion varchar(100)
);

go

Create table OrdenMantenimiento(
ID_OrdenMto int not null primary key identity(0, 1),
ID_Mantenimiento int not null,
ID_FalloEquipo int not null,
Costo float not null,
FechaRegistro date not null,
Duracion time not null,
Descripcion varchar(100),
Foreign Key (ID_Mantenimiento) References Mantenimiento(ID_Mantenimiento),
Foreign Key (ID_FalloEquipo) References FalloEquipo(ID_FalloEquipo)
);

go

insert into Empleado values('Fernando', 'Jose', 'Medina', 'Arana', '000-000000-00AB')
go
insert into Cargo values('Cocinero', '-');
go
insert into EmpleadoCargo values(0, 0);
go
insert into Equipo values('Cocina', 'Cocina de 8 quemadores');
go
insert into EmpleadoEquipo values(0, 0);
go
insert into Fallo values('Fuga en la válula de gas');
go
insert into FalloEquipo values(0, 0, 750.00, 'Fuga');
go
insert into Pieza values('Válvula de gas', 450.00, 'VÁLVULA DE CONEXIÓN PARA CILINDROS DE GAS PROPANO A ESTUFA O COCINA.');
go 
insert into PiezaFalloEq values(0, 0);
go
insert into Mantenimiento values('Preventivo', 'Revisión y limpieza de los equipos para garantizar su buen funcionamiento.');
go
insert into Mantenimiento values('Correctivo', 'Corrección de los defectos observados en los equipos e instalaciones.');
go
insert into Mantenimiento values('Predictivo', 'Detección de posibles fallas cada cierto tiempo.');
go
insert into OrdenMantenimiento values(0, 0, 1200.00, '2020-11-17', '01:00:00.0000000', 'Se cambió la válvula de gas de la cocina.');
