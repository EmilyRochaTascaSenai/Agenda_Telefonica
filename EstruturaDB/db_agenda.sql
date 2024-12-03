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
            CONCAT('A CATEGORIA ', OLD.categoria, ' Foi excluída'));
END;
$$
DELIMITER ;

select usuario,senha,nome,telefone  from tbusuario;

drop table tbContato;

CREATE TABLE tbContato (
    cod_contato int auto_increment PRIMARY KEY,        -- Código único para identificar o contato
    contato VARCHAR(100) NOT NULL,     -- Nome do contato (máximo de 100 caracteres)
    telefone VARCHAR(50),              -- Número de telefone (suporta símbolos como +, -)
    categoria VARCHAR(50) NOT NULL     -- Categoria do contato (ex.: Familia, Amigos)
);

-- Inserir um registro de exemplo
INSERT INTO tbContato (cod_contato, contato, telefone, categoria)
VALUES 
(3, 'Emily', '(16)9977100179',  'Familia'
);
 


DELIMITER $$

CREATE TRIGGER log_insercao_contato
AFTER INSERT ON contatos
FOR EACH ROW
BEGIN
    INSERT INTO logs (acao, tabela, data, descricao)
    VALUES ('INSERÇÃO', 'contatos', NOW(), CONCAT('Contato inserido: ', NEW.id, ' - ', NEW.nome));
END;
DELIMITER ;

DELIMITER $$
CREATE TRIGGER log_alteracao_contato
AFTER UPDATE ON contatos
FOR EACH ROW
BEGIN
    INSERT INTO logs (acao, tabela, data, descricao)
    VALUES ('ALTERAÇÃO', 'contatos', NOW(), CONCAT('Contato alterado: ', OLD.id, ' - ', OLD.nome, ' para ', NEW.nome));
END;
DELIMITER ;

DELIMITER $$
CREATE TRIGGER log_exclusao_contato
AFTER DELETE ON contatos
FOR EACH ROW
BEGIN
    INSERT INTO logs (acao, tabela, data, descricao)
    VALUES ('EXCLUSÃO', 'contatos', NOW(), CONCAT('Contato excluído: ', OLD.id, ' - ', OLD.nome));
END;
DELIMITER ;



