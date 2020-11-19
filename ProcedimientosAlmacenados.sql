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

exec CargarOrden 'Preventivo'

go

Create proc RegistrarOrden
@ID_FalloEqMto int, @Costo float, 
@FechaRegistro date, @Duracion time, @Descripcion varchar(100)
as
insert into OrdenMantenimiento values(@ID_FalloEqMto, @Costo, @FechaRegistro, @Duracion, @Descripcion);

go

Create proc CargarPieza
@Pieza varchar(25)
as
Select p.Nombre from Pieza p
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
Where m.Nombre = @Pieza
group by p.Nombre

go

Create proc CargarFallo
@Fallo varchar(30)
as
Select f.Nombre from Fallo f
inner join FalloEquipo fe
on fe.ID_Fallo = f.ID_Fallo
inner join FalloEquipoMto fem
on fem.ID_FalloEquipo = fe.ID_FalloEquipo
inner join Mantenimiento m 
on m.ID_Mantenimiento = fem.ID_Mantenimiento
Where m.Nombre = @Fallo
group by f.Nombre