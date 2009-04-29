INSERT INTO MOZGAS
           (MOZGAS_ID
           ,MOZGAS_MEGNEVEZES
           ,MOZGAS_IRANY
           ,MOZGAS_STORNO_PAR)
     VALUES
           ('R-'
           ,'technikai csökkentés'
           ,-1
           ,'R+')

GO

INSERT INTO MOZGAS
           (MOZGAS_ID
           ,MOZGAS_MEGNEVEZES
           ,MOZGAS_IRANY
           ,MOZGAS_STORNO_PAR)
     VALUES
           ('R+'
           ,'technikai növelés'
           ,-1
           ,'R1')

GO

INSERT INTO MOZGAS
           (MOZGAS_ID
           ,MOZGAS_MEGNEVEZES
           ,MOZGAS_IRANY
           ,MOZGAS_STORNO_PAR)
     VALUES
           ('S'
           ,'Selejtezés'
           ,-1
           ,'S')

GO


UPDATE VERSION  SET DB_VER = '027'

GO





