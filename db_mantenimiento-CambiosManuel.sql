Use master;

go

Drop database db_mantenimiento;

go

Create database db_mantenimiento;

go

use db_mantenimiento;

go

Create table Empleado(
ID_Empleado int not null primary key identity(1, 1),
Primer_Nombre varchar(20) not null,
Segundo_Nombre varchar(20) not null,
Primer_Apellido varchar(20) not null,
Segundo_Apellido varchar(20) not null,
Cedula varchar(20) not null unique
);

go

Create table Equipo(
ID_Equipo int not null primary key identity(1, 1),
Nombre varchar(30) not null,
Descripcion varchar(100)
);

go

Create table EmpleadoEquipo(
ID_EmpEquipo int not null primary key identity(1, 1),
ID_Empleado int not null,
ID_Equipo int not null,
Foreign Key (ID_Empleado) References Empleado(ID_Empleado),
Foreign Key (ID_Equipo) References Equipo(ID_Equipo)
);

go

Create table Cargo(
ID_Cargo int not null primary key identity(1, 1),
Nombre varchar(30) not null,
Descripcion varchar(100)
);

go

Create table EmpleadoCargo(
ID_EmpCargo int not null primary key identity(1, 1),
ID_Empleado int not null,
ID_Cargo int not null,
Foreign Key (ID_Empleado) References Empleado(ID_Empleado),
Foreign Key (ID_Cargo) References Cargo(ID_Cargo)
);

go

Create table Fallo(
ID_Fallo int not null primary key identity(1, 1),
Nombre varchar(30)
);

go

Create table FalloEquipo(
ID_FalloEquipo int not null primary key identity(1, 1),
ID_Fallo int not null,
ID_Equipo int not null,
Costo float not null,
Descripcion varchar(100),
Foreign Key (ID_Fallo) References Fallo(ID_Fallo),
Foreign Key (ID_Equipo) References Equipo(ID_Equipo)
);

go

Create table Pieza(
ID_Pieza int not null primary key identity(1, 1),
Nombre varchar(25) not null,
TiempoFallo int not null,
Costo float not null,
Descripcion varchar(100)
);

go

Create table PiezaFalloEq(
ID_PiezaFalloEq int not null primary key identity(1, 1),
ID_Pieza int not null,
ID_FalloEquipo int not null,
Foreign Key (ID_Pieza) References Pieza(ID_Pieza),
Foreign Key (ID_FalloEquipo) References FalloEquipo(ID_FalloEquipo)
);

go

Create table Mantenimiento(
ID_Mantenimiento int not null primary key identity(1, 1),
Nombre varchar(80) not null,
Descripcion varchar(100)
);

go

Create table FalloEquipoMto(
ID_FalloEqMto int not null primary key identity(1, 1),
ID_FalloEquipo int not null,
ID_Mantenimiento int not null,
Foreign Key (ID_FalloEquipo) References FalloEquipo(ID_FalloEquipo),
Foreign Key (ID_Mantenimiento) References Mantenimiento(ID_Mantenimiento)
);

go

Create table OrdenMantenimiento(
ID_OrdenMto int not null primary key identity(1, 1),
ID_FalloEqMto int not null,
Costo float not null,
FechaRegistro date not null,
Duracion time not null,
Descripcion varchar(100),
Foreign Key (ID_FalloEqMto) References FalloEquipoMto(ID_FalloEqMto)
);

drop table OrdenMantenimiento
drop table FalloEquipoMto
drop table Mantenimiento
drop table PiezaFalloEq
drop table Pieza
drop table FalloEquipo
drop table Fallo
drop table EmpleadoCargo
drop table Cargo
drop table EmpleadoEquipo
drop table Equipo
drop table Empleado


go

insert into Empleado values('Fernando', 'Jose', 'Medina', 'Arana', '000-000000-00AB')
go
insert into Cargo values('Técnico especializado', '-');
go
insert into EmpleadoCargo values(0, 0);
go
insert into Equipo values('Computadora', 'HP All-in-One 20-c401la AMD A4-9125, 4 GB RAM, 1TB HDD, 19.5" HD');
insert into Equipo values('Caja_registrador', 'Sharp XEA407 caja registradora avanzada')
insert into Equipo values('Televisor', 'Insignia NS-39DF510NA19 39-inch Smart HD TV')
go
insert into EmpleadoEquipo values(0, 0);
go
insert into Fallo values('Fuga en la válula de gas');
go
insert into FalloEquipo values(0, 0, 750.00, 'Fuga');
go
insert into Pieza values('Válvula de gas', 2, 450.00, 'VÁLVULA DE CONEXIÓN PARA CILINDROS DE GAS PROPANO A ESTUFA O COCINA.');
go 
insert into PiezaFalloEq values(0, 0);
go
insert into Mantenimiento values('Preventivo', 'Revisión y limpieza de los equipos para garantizar su buen funcionamiento.');
go
insert into Mantenimiento values('Correctivo', 'Corrección de los defectos observados en los equipos e instalaciones.');
go
insert into Mantenimiento values('Predictivo', 'Detección de posibles fallas cada cierto tiempo.');
go
insert into FalloEquipoMto values(0, 0);
go
insert into OrdenMantenimiento values(0, 1200.00, '2020-11-17', '01:00:00.0000000', 'Se cambió la válvula de gas de la cocina.');

go

sp_addlogin 'usuario', '01234567'
go
sp_addsrvrolemember 'usuario', 'sysadmin'
go
sp_adduser 'usuario', 'usuario'
go
sp_addrolemember 'db_accessadmin', 'usuario'
go

CREATE PROCEDURE VerEmpleados
As
SELECT * from Empleado
