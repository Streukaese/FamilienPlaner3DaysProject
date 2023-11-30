create database Planer;

	create table Planungen (
	id int not null auto_increment primary key,
	name varchar(30) not null,
	ueberschrift varchar(55) not null,
	notizen varchar(1000) not null,
	endDate date,
	wichtigkeit enum('hat zeit.', 'Zeitnahe erledigen.', 'Run Forrest, RUN!')
);