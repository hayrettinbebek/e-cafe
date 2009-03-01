

ALTER TABLE CIKK ADD
	RECEPT_TEXT text NULL
	
GO
DROP TABLE FOGLALAS
GO
CREATE TABLE FOGLALAS
	(
	FOGLALAS_ID int NOT NULL IDENTITY (1, 1),
	ASZTAL_ID int NOT NULL,
	FOGLAL_FROM datetime NULL,
	FOGLAL_TO datetime NULL,
	PARTNER_ID int NULL,
	MEGJEGYZES varchar(200) NULL,
	NEV varchar(50) NULL,
	TELEFON varchar(50) NULL
	)  ON [PRIMARY]

GO
ALTER TABLE RENDELES_SOR ADD
	FIZETVE int NULL
GO
ALTER TABLE RENDELES_SOR ADD CONSTRAINT
	DF_RENDELES_SOR_FIZETVE DEFAULT 0 FOR FIZETVE

GO

CREATE TABLE HITEL_SOR
	(
	SOR_ID int NOT NULL IDENTITY (1, 1),
	PARTNER_ID int NOT NULL,
	RENDELES_SOR_ID int NOT NULL,
	FIZETVE int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE HITEL_SOR ADD CONSTRAINT
	DF_HITEL_SOR_FIZETVE DEFAULT 0 FOR FIZETVE
GO
ALTER TABLE HITEL_SOR ADD CONSTRAINT
	PK_HITEL_SOR PRIMARY KEY CLUSTERED 
	(
	SOR_ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

CREATE TABLE SZAMLA_FEJ
	(
	SZAMLA_FEJ_ID int NOT NULL IDENTITY (1, 1),
	SZAMLA_SORSZAM varchar(50) NULL,
	PARTNER_ID int NULL,
	RENDELES_ID int NULL,
	OSSZESEN_NETTO float(53) NULL,
	OSSZESEN_BRUTTO float(53) NULL,
	OSSZESEN_AFA float(53) NULL,
	KEDVEZMENY float(53) NULL,
	FIZETETT_OSSZEG float(53) NULL,
	FIZETESI_MOD int NULL,
	SZAMLA_DATUMA datetime NULL
	)  ON [PRIMARY]
GO
ALTER TABLE SZAMLA_FEJ ADD CONSTRAINT
	PK_SZAMLA_FEJ PRIMARY KEY CLUSTERED 
	(
	SZAMLA_FEJ_ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE TABLE SZAMLA_TETEL
	(
	TETEL_ID int NOT NULL IDENTITY (1, 1),
	RENDELES_SOR_ID int NOT NULL,
	CIKK_ID int NULL,
	MENNYISEG float(53) NULL,
	EGYSEGAR float(53) NULL,
	NETTO float(53) NULL,
	AFA float(53) NULL,
	BRUTTO float(53) NULL,
	AFA_KOD varchar(2) NULL,
	MEGJEGYZES varchar(50) NULL,
	CIKK_MEGNEVEZES varchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE SZAMLA_TETEL ADD CONSTRAINT
	PK_SZAMLA_TETEL PRIMARY KEY CLUSTERED 
	(
	TETEL_ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

UPDATE VERSION  SET DB_VER = '006'

GO





