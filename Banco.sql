create database 3C1GUSTAVO15;
use 3C1GUSTAVO15;

create table tbl_usuarios(
	id int not null primary key auto_increment,
    email varchar(100) not null,
    senha varchar(100) not null
)ENGINE = InnoDB;
insert into tbl_usuarios (id, email, senha) values(null,'gut.n.pontes@gmail.com', '123');
create table tbl_Produtos(
	id 	int not null primary key auto_increment,
    nome varchar(100) not null,
    categoria varchar(100) not null,
    preco varchar(100) not null
)ENGINE = InnoDB;