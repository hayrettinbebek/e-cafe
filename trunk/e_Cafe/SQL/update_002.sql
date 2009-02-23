
UPDATE VERSION  SET DB_VER = '002'

GO

ALTER TABLE CIKK ADD
	GYORSKOD varchar(10) NULL

GO

insert into megys VALUES (1,'Darab')
insert into megys VALUES (2,'Üveg')
insert into megys VALUES (3,'Liter')

GO


