ALTER TABLE PARTNER ADD
	AKTIV int NULL
GO
ALTER TABLE PARTNER ADD CONSTRAINT
	DF_PARTNER_AKTIV DEFAULT 1 FOR AKTIV
	
GO

UPDATE PARTNER SET AKTIV = 1
GO

ALTER TABLE ASZTAL ADD
	AKTIV int NULL
GO
ALTER TABLE ASZTAL ADD CONSTRAINT
	DF_ASZTAL_AKTIV DEFAULT 1 FOR AKTIV

GO
UPDATE ASZTAL SET AKTIV = 1

GO
	

UPDATE VERSION  SET DB_VER = '020'

GO




