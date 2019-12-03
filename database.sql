create database gestion_etudiant_wpf;
USE gestion_etudiant_wpf

create table filiere
(
	id_filiere int primary key identity(1,1),
	nom_filiere varchar(50),
	resp varchar(50)
)


create table etudiant
(
	id_etudiant integer primary key identity(1,1),
	cne varchar(10) unique,
	nom varchar(25),
	prenom varchar(25),
	picture varchar(50),
	sexe char CHECK (sexe in ('F','M')),
	date_naissance date,
	tele varchar(15),
	id_filiere int references filiere(id_filiere)


)






