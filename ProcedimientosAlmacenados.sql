Create proc CargarOrden
@Tipo varchar(20)
as
Select e.Nombre as [Nombre del equipo], m.Nombre as [Tipo de Mantenimiento], 
om.FechaRegistro as [Fecha Registro], om.Costo, om.Descripcion  from 
OrdenMantenimiento om
inner join FalloEquipoMto fem
on fem.ID_FalloEqMto = om.ID_FalloEqMto
inner join Mantenimiento m
on m.ID_Mantenimiento = fem.ID_Mantenimiento
inner join FalloEquipo fe
on fe.ID_FalloEquipo = fem.ID_FalloEquipo
inner join Fallo f
on f.ID_Fallo = fe.ID_Fallo
inner join Equipo e
on e.ID_Equipo = fe.ID_Equipo
Where m.Nombre = @Tipo

go

Create proc RegistrarOrden
@ID_FalloEqMto int, @Costo float, 
@FechaRegistro date, @Duracion time, @Descripcion varchar(100)
as
insert into OrdenMantenimiento values(@ID_FalloEqMto, @Costo, @FechaRegistro, @Duracion, @Descripcion);

go

Create proc CargarPieza
@Equipo varchar(25), @Fallo varchar(25), @Mto varchar(25)
as
Select distinct(p.Nombre) from Pieza p
inner join PiezaFalloEq pfe
on pfe.ID_Pieza = p.ID_Pieza
inner join FalloEquipo fe
on fe.ID_FalloEquipo = pfe.ID_FalloEquipo
inner join Fallo f
on f.ID_Fallo = fe.ID_Fallo
inner join FalloEquipoMto fem
on fem.ID_FalloEquipo = fe.ID_FalloEquipo
inner join Mantenimiento m
on m.ID_Mantenimiento = fem.ID_Mantenimiento
inner join Equipo e
on e.ID_Equipo = fe.ID_Equipo
Where m.Nombre = @Mto and f.Nombre = @Fallo and  e.Nombre = @Equipo
group by p.Nombre

go

Create proc CargarFallo
@Pieza varchar(30)
as
Select distinct(f.Nombre) from Fallo f
inner join FalloEquipo fe
on fe.ID_Fallo = f.ID_Fallo
inner join FalloEquipoMto fem
on fem.ID_FalloEquipo = fe.ID_FalloEquipo
inner join Mantenimiento m 
on m.ID_Mantenimiento = fem.ID_Mantenimiento
inner join PiezaFalloEq pfe
on pfe.ID_FalloEquipo = fe.ID_FalloEquipo
inner join Pieza p
on p.ID_Pieza = pfe.ID_Pieza
Where p.Nombre = @Pieza
group by f.Nombre

go

Create proc CargarEquipo
as
Select e.Nombre from Equipo e
group by e.Nombre

go

Create proc CargarPiezaEquipo
@Equipo varchar(25)
as
Select distinct(p.Nombre) from Pieza p
inner join PiezaFalloEq pfe
on pfe.ID_Pieza = p.ID_Pieza
inner join FalloEquipo fe
on fe.ID_FalloEquipo = pfe.ID_FalloEquipo
inner join Fallo f
on f.ID_Fallo = fe.ID_Fallo
inner join FalloEquipoMto fem
on fem.ID_FalloEquipo = fe.ID_FalloEquipo
inner join Mantenimiento m
on m.ID_Mantenimiento = fem.ID_Mantenimiento
inner join Equipo e
on e.ID_Equipo = fe.ID_Equipo
Where e.Nombre = @Equipo
group by p.Nombre

go

Create proc IdMtoEquipo
@Fallo varchar(30), @Equipo varchar(15), @Mto varchar(80)
as
Select fem.ID_FalloEqMto as ID 
from FalloEquipoMto fem
inner join FalloEquipo fe
on fe.ID_FalloEquipo = fem.ID_FalloEquipo
inner join Fallo f
on f.ID_Fallo = fe.ID_Fallo
inner join Equipo e
on e.ID_Equipo = fe.ID_Equipo
inner join Mantenimiento m
on m.ID_Mantenimiento = fem.ID_Mantenimiento
where f.Nombre = @Fallo and e.Nombre = @Equipo and m.Nombre = @Mto
group by fem.ID_FalloEqMto

go

Create proc ObtenerCostoPieza
@Nombre varchar(25)
as
Select top 1 p.Costo from Pieza p 
where p.Nombre = @Nombre

exec ObtenerCostoPieza 'Válvula de gas'

go

Create proc ObtenerTiempoFallo
@Nombre varchar(25)
as
Select p.TiempoFallo from Pieza p 
where p.Nombre = @Nombre

go

Create proc CantidadFallosPieza
@Nombre varchar(25)
as
Select count(distinct(p.Nombre)) as Cantidad from PiezaFalloEq pfe
inner join Pieza p
on p.ID_Pieza = pfe.ID_Pieza
inner join FalloEquipo fe
on fe.ID_FalloEquipo = pfe.ID_FalloEquipo
inner join Fallo f
on f.ID_Fallo = fe.ID_Fallo
where p.Nombre = @Nombre
group by p.ID_Pieza

Exec CantidadFallosPieza 'Válvula de gas'

Select * from OrdenMantenimiento