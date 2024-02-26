drop database if exists voluntarios;

create database voluntarios;
	use voluntarios; 

create table contactos (
	nome Varchar(20) Primary Key,
	email Varchar(30),
	telef Varchar(9),
	pais Varchar(30)
);

Insert into  contactos Values ('Zau', 'zau@gmail.com', '918745125', 'Portugal');
Insert into contactos Values ('Lara', 'lara@gmail.com', '912348521', 'Reino Unido');
Insert into contactos Values ('David', 'david@gmail.com', '912854754', 'França');

select * From contactos;