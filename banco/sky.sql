create database sky; 
use sky; 



create table cliente( 
id_cli int not null auto_increment primary key, 
nome_cli varchar(100) not null, 
email_cli varchar(100) not null, 
tel_cli varchar(15) not null,  
cpf_cli varchar (15) not null, 
end_cli varchar (100) not null, 
senha_cli varchar(60) not null 

); 

ALTER TABLE tipo_quarto ADD COLUMN descricao_q VARCHAR(255);

create table tipo_quarto ( 

id_tipo int not null primary key, 
nome_q varchar(100) not null, 
descrição_q varchar (250) not null, 
preco_dia decimal (10,2) not null,  
max_ocup int not null 
); 
select*from quarto;
drop table quarto;
create table quarto( 
    id_quarto int not null auto_increment primary key, 
    id_tipo int not null, 
    status varchar(20) default 'Available', 
    foreign key (id_tipo) references tipo_quarto(id_tipo) 
); 

drop table reserva;
create table reserva( 
id_reserva int not null auto_increment primary key, 
id_cli int not null, 
id_quarto int not null, 
data_checkin date not null, 
data_checkout date not null, 
total decimal(10,2), 
foreign key (id_cli) references cliente(id_cli), 
foreign key (id_quarto) references quarto(id_quarto) 
); 

create table met_pag ( 
metodo_pag varchar (45) not null primary key 
); 

drop table pagamentos;
create table pagamentos ( 
id_pag int not null auto_increment primary key, 
id_reserva int not null, 
valor decimal(10,2), 
metodo_pag varchar(50) not null, 
data_pag datetime not null, 
foreign key (id_reserva) references reserva(id_reserva), 
foreign key (metodo_pag) references met_pag (metodo_pag)  
); 
create table cargo ( 
nome_carg varchar(100) not null primary key, 
sal_base decimal(10,2) not null  
); 

create table funcionario ( 
id_func int not null auto_increment primary key, 
nome_func varchar(100) not null, 
email_func varchar(100) not null, 
tel_func varchar(15) not null,  
cpf_func varchar (15) not null, 
end_func varchar (100) not null, 
sal_func decimal(10,2) not null, 
cargo_func int not null 

);
INSERT INTO cliente (nome_cli, email_cli, tel_cli, cpf_cli, end_cli, senha_cli)
VALUES ('Nome Exemplo', 'email@exemplo.com', '123456789', '000.000.000-00', 'Endereço Exemplo', 'senha123');
