create database dbpractica;

use dbpractica

/*if object_id('usuaros') is not null
	drop table usuarios;*/

create table usuarios
(	
	codigo int identity,
	nombre varchar(30),
	apellido varchar(30),
	usuario varchar(30),
	contrasena varchar(30),
	primary key(codigo)
);

--Vaciar tabla
--truncate table usuarios;

select * from usuarios;