CREATE TABLE dbo.FOGLALAS
	(
	FOGLALAS_ID int NOT NULL,
	ASZTAL_ID int NOT NULL,
	FOGLAL_FROM datetime NULL,
	FOGLAL_TO datetime NULL,
	PARTNER_ID int NULL,
	MEGJEGYZES varchar(200) NULL
	)  ON [PRIMARY]
GO

ALTER TABLE dbo.FOGLALAS ADD CONSTRAINT
	PK_FOGLALAS PRIMARY KEY CLUSTERED 
	(
	FOGLALAS_ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

CREATE TABLE dbo.CEG
	(
	CEG_NEV varchar(100) NULL,
	CEG_CIM varchar(150) NULL,
	ADOSZAM varchar(15) NULL
	)  ON [PRIMARY]
	
GO

INSERT INTO CEG (CEG_NEV) VALUES ('NOTRIX')

GO



UPDATE VERSION  SET DB_VER = '005'

GO




