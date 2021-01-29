create data base testluby

use testluby

create table pessoa (
p_id int not null primary Key,
p_nome varchar(50)
);

create table evento (ev_id int Not Null,
ev_evento varchar(40),
ev_pessoaid int(30),
primary key (ev_id),
foreign key (ev_pessoaid) references pessoa(p_id));

insert into pessoa values(1,'John Doe');
insert into pessoa values(2,'Jane Doe ');
insert into pessoa values(3,'Alice Jones');
insert into pessoa values(4,'Bobby Louis');
insert into pessoa values(5,'Lisa Romero');

insert into evento values(1,'Evento A ', 2);
insert into evento values(2,'Evento B ', 3);
insert into evento values(3,' Evento C', 2);
insert into evento values(4,' Evento D ', null);

-- 2.1
SELECT Evento.*, pessoa.p_nome FROM Evento
INNER JOIN Pessoa ON Evento.ev_pessoaid = Pessoa.p_id;

-- 2.2
select * from  Pessoa
where  p_nome like '%Doe%';

-- 2.3
insert into evento values('Evento E', 5);

--2.4
UPDATE Evento
SET  ev_pessoaid = 1
WHERE ev_id = 4;

-- 2.5
delete  from Evento
WHERE ev_id = 2;

--2.6
delete  from Pessoa
WHERE p_id = 3 and p_id = 4 ;

-- 2.7
alter table pessoa
add p_idade  int(30);

-- 2.8
create table telefone (
 id int Not null,
 telefone varchar(200),
 pessoa_id int  not null,
 
 primary key(id),
 foreign key (pessoa_id) references pessoa(p_id)
);

-- 2.9
CREATE INDEX IDX_Telef
ON telefone (telefone);

-- 2.10
DROP TABLE telefone;