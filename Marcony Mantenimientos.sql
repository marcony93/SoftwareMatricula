Update Ocupacion set OcupNombre='Carpintero' where OcupId=1
Update Ocupacion set OcupNombre='Albañil' where OcupId=2
Update Ocupacion set OcupNombre='Ingeniero' where OcupId=3
Update Ocupacion set OcupNombre='Pintor' where OcupId=4
Update Ocupacion set OcupNombre='Mesero' where OcupId=5
update Ocupacion set EstadoOcu=1 where OcupId=4

Update Parentesco set ParenNombre='Padre' where ParenId=1
Update Parentesco set ParenNombre='Madre' where ParenId=2
Update Parentesco set ParenNombre='Abuela' where ParenId=3
Update Parentesco set ParenNombre='Abuelo' where ParenId=4
Update Parentesco set ParenNombre='Tio' where ParenId=5
update Parentesco set EstadoParent=1 where ParenId=4
update Parentesco set EstadoParent=1 where ParenId=5


select * from Dia
insert into Dia values ('Lunes')
insert into Dia values ('Martes')
insert into Dia values ('Miercoles')
insert into Dia values ('Jueves')
insert into Dia values ('Viernes')

select * from Departamento

select * from Seccion

select * from Maestro