use db_vremenska_prognoza;

insert into nalog values(1,'m', 'm', 'm', 1, 1);
select * from nalog;
select * from zaposleni;
insert into nalog values(2,'a','a', 'a', 1, 1);

insert into drzava values(1, 'Bosna i Hercegovina');
insert into drzava values(2, 'Srbija');

select * from drzava;
select * from grad;
delete from grad where id=11;

insert into grad values(1, 'Bijeljina', 1);
insert into grad values(2, 'Prijedor', 1);
insert into grad values(3, 'Beograd', 2);
insert into grad values(4, 'Banja Luka', 1);

insert into adresa values(1, 'Stepe Stepanovic', 25, 4);
insert into adresa values(2, 'Karadjordjeva', 15, 4);

insert into meteoroloska_stanica values(1, 1);
insert into meteoroloska_stanica values(2,2);

insert into lokacija_instrumenata values(1,1,1);
insert into zaposleni values(1, 'Marko', 'Markovic', 1, 1);
insert into zaposleni values(2, 'Janko', 'Jankovic', 2, 2);

insert into mjerenje values(1, '2024-01-18 12:34:56', 1, 1, 1 );
insert into mjerenje values(2, '2024-01-20 12:34:56', 1, 2, 1 );

insert into temperatura(mjerenje_id, vrijednost) VALUES (1, 14);
insert into temperatura(mjerenje_id, vrijednost) VALUES (2, 24);

insert into vjetar values(1, 'Kosava');
insert into vjetar values(2, 'Bura');
insert into vjetar values(3, 'Jugo');

insert into padavine values(1, 'Kisa');
insert into padavine values(2, 'Snijeg');

insert into vjetar_mjerenje(mjerenje_id, jacina_udara, pravac, opis, vjetar_id) values (1, 24, 'Jugozapad', 'Bez opasnosti', 1);
insert into vjetar_mjerenje(mjerenje_id, jacina_udara, pravac, opis, vjetar_id) values (2, 74, 'Sjever', 'Oprez', 2);

insert into padavine_mjerenje(mjerenje_id, padavine_id, opis, vjerovatnoca, kolicina) values (2, 1, 'Vece kolicine', 95, 10);




