create database PER_work

use PER_work

create table TBJogadores(
	id_jogador int identity primary key,
	nome varchar(30) not null,
	sobrenome varchar(30),
	email varchar(50) not null)

create table TBPerguntas(
	id_pergunta int identity primary key,
	id_jogador int,
	pergunta varchar(max),
	r_correta varchar(max),
	nivel varchar(40),
	pontos int	)
	
select * from TBPerguntas where id_jogador = 3
select * from TBJogadores where id_jogador = 7

drop table TBJogadores
drop table TBPerguntas

truncate table TBJogadores
truncate table TBPerguntas

Select pontos from TBJogadores where id_jogador = 1 join TBPerguntas on TBJogadores.id_jogador = TBPerguntas.id_jogador

Select pontos from TBJogadores where id_jogador = 1 join TBPerguntas on TBJogadores.id_jogador = TBPerguntas.id_jogador

Select SUM(pontos) from TBPerguntas where id_jogador = 3