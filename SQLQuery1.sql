create database db_banque;
use db_banque;
create table clients(cin varchar (10) primary key ,nom varchar (20),prenom varchar (20),
telephone varchar (15));

create table comptes (code int primary key identity(1,1),
solde float ,
datecreation date default getdate(),
cin varchar(10) foreign key references clients(cin));
create table operations (num int primary key identity(1,1),
dateoperation datetime  default current_timestamp,typeoperation varchar (1),
montant float ,code int foreign key references comptes(code));

select count(*) as nombre from clients where cin='M0002'
select *from clients;


select cin ,nom + ' ' + prenom  as nomC from clients