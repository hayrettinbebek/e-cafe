delete from cikk where cikkcsoport_id is null
go

ALTER TABLE KESZLET_SOR ADD
	KESZLET_EGYS_AR float(53) NULL
GO

INSERT INTO version (DB_VER) VALUES ('001')

GO

--delete from bevetel_sor
go

--delete from bevetel_fej
go

--delete from rendeles_sor
go

--delete from rendeles_fej
go

--delete from keszlet_sor
go

--delete from keszlet_fej
go
