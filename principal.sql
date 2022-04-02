
/*BASE DE DATOS*/
CREATE DATABASE ROSSE

/*TABLA*/
USE ROSSE

CREATE TABLE Vestuario(
Id varchar (10) primary key,
Nombre_prenda varchar (50),
Talla varchar (10),
Color varchar (10),
Precio varchar (30),
Stock int,
activo bit)

CREATE TABLE Calzado(
Id varchar (10) primary key,
Nombre_calzado varchar (50),
Talla varchar (10),
Color varchar (10),
Precio varchar (30),
Stock int,
activo bit)

CREATE TABLE Articulos(
Id varchar (10) primary key,
Nombre_articulo varchar (50),
Precio varchar (30),
Stock int,
activo bit)