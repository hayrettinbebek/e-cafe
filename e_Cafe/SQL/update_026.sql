
ALTER TABLE HELY ADD
	AKTIV int NULL
GO
ALTER TABLE HELY ADD CONSTRAINT
	DF_HELY_AKTIV DEFAULT 1 FOR AKTIV

GO

UPDATE HELY SET AKTIV = 1
GO

ALTER TABLE CIKCSOP_OTHER_FILTER ADD
	AKTIV int NULL
GO
ALTER TABLE CIKCSOP_OTHER_FILTER ADD CONSTRAINT
	DF_CIKCSOP_OTHER_FILTER_AKTIV DEFAULT 1 FOR AKTIV
GO

UPDATE CIKCSOP_OTHER_FILTER SET AKTIV = 1
GO

UPDATE VERSION  SET DB_VER = '026'

GO





