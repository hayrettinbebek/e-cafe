
ALTER TABLE RENDELES_FEJ ADD
	AKTIV int NULL
GO
ALTER TABLE RENDELES_FEJ ADD CONSTRAINT
	DF_RENDELES_FEJ_AKTIV DEFAULT 1 FOR AKTIV
	
GO
ALTER TABLE SZAMLA_FEJ ADD
	EV int NOT NULL,
	HO int NOT NULL,
	NAP int NOT NULL

GO

ALTER TABLE SZAMLA_TETEL ADD
	SZAMLA_FEJ_ID int NOT NULL

GO
ALTER TABLE RENDELES_SOR ADD
	CANCELED int NULL
GO
ALTER TABLE RENDELES_SOR ADD CONSTRAINT
	DF_RENDELES_SOR_CANCELED DEFAULT 0 FOR CANCELED

GO


UPDATE VERSION  SET DB_VER = '007'

GO





