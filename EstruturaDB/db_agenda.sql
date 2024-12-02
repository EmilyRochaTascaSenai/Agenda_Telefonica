CREATE DATABASE dbagenda;
USE dbagenda;


create database dbAgenda;

use dbAgenda;

create table tbUsuario(
nome varchar(60) not null,
usuario varchar (20) primary key,
telefone varchar(15),
senha varchar(20) not null
);


create table tbCategoria(
	cod_categoria INT AUTO_INCREMENT PRIMARY KEY,
    categoria VARCHAR(80) NOT NULL,
    usuario varchar (20) 
);

CREATE USER 'Ana_Maria'@'%' IDENTIFIED BY 'amominhafamilia';


select *from mysql.user;

GRANT SELECT ON sys.sys_config TO 'Ana_Maria'@'%';

FLUSH PRIVILEGES;

DELIMITER $$
create trigger trinsertcategoria
before
insert
on tbcategoria
for each row 
begin
	set new.usuario = current_user();
end;
$$


DELIMITER ;
		
select * from tbcategoria;
CREATE TABLE tb_log (
	cod_log int auto_increment primary key,
   usuario varchar(25),
   data_alterada datetime,
   descricao varchar(50)
);


DELIMITER $$

CREATE TRIGGER trlog_categoria_delete
AFTER DELETE ON tbCategoria
FOR EACH ROW
BEGIN
    INSERT INTO tb_log (usuario, data_alterada, descricao)
    VALUES (USER(), CURRENT_TIMESTAMP(), 
            CONCAT('A CATEGORIA ', OLD.categoria, ' Foi exclu�da'));
END;
$$
DELIMITER ;

select usuario,senha,nome,telefone  from tbusuario;



CREATE TABLE tbContato (
    cod_contato INT PRIMARY KEY,        -- C�digo �nico para identificar o contato
    contato VARCHAR(100) NOT NULL,     -- Nome do contato (m�ximo de 100 caracteres)
    telefone VARCHAR(50),              -- N�mero de telefone (suporta s�mbolos como +, -)
    categoria VARCHAR(50) NOT NULL     -- Categoria do contato (ex.: Familia, Amigos)
);

-- Inserir um registro de exemplo
INSERT INTO tbContato (cod_contato, contato, telefone, categoria)
VALUES 
(3, 'Emily', '(16)9977100179',  'Familia'
);
 




