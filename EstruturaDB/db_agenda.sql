CREATE DATABASE dbagenda;
USE dbagenda;


CREATE TABLE Tbusuaios(
nome varchar(85) not null,
usuario varchar(45) primary KEY	,
telefone varchar(15),
senha varchar(20) not null
);


select*from cadastro;