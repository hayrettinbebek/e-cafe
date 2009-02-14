ALTER TABLE dbo.KESZLET_SOR
	DROP CONSTRAINT FK_KESZLET_SOR_KESZLET_FEJ
GO

create view V_SRSZ_KESZLET_NAP as
select n.srsz, f.* from KESZLET_FEJ f
	inner join napok n on f.EV = n.EV and f.HO = n.Ho and f.NAP = n.NAP

go

-- =============================================
-- Author:		<László Ernõ>
-- Create date: <2009.01.23>
-- Description:	<Készletkarton létrehozása nyitott napra>
-- =============================================
ALTER PROCEDURE [dbo].[openDay]
(
-- Melyik napra szeretném megnyitni a készleteket. 
	@EV int ,
	@HO int ,
	@NAP int 
)
AS
BEGIN

declare
	@last_nap_srsz int,
	@open_day_srsz int
BEGIN TRAN T1

set @last_nap_srsz = 1

    select @last_nap_srsz=isnull(n.SRSZ,1) from napok n 
		where n.srsz = isnull( (SELECT max(k.SRSZ) FROM NAPOK k inner join nap_nyitas l on k.EV = l.EV and k.HO = l.HO and k.NAP = l.NAP )  ,(select min(m.SRSZ) from napok m))
 -- rekord beszúrása a nyitott napba

	SELECT @open_day_srsz=k.SRSZ FROM NAPOK k where  k.EV = @EV and k.HO = @HO and k.NAP = @NAP

	INSERT INTO NAP_NYITAS
           ([EV]
           ,[HO]
           ,[NAP]
           ,[NYITAS_DATUMA]
           ,[ZARAS_DATUMA]
           ,[LEZART])
     VALUES
           (@EV
           ,@HO
           ,@NAP
           ,getdate()
           ,null
           ,0)

-- Készletek MÁSOLÁSA ELÕZÕ NAPRÓL
insert into KESZLET_FEJ (EV,HO,NAP,CIKK_ID,RAKTAR_ID,KESZLET_NYITO,KESZLET_ERTEK_NYITO,ELOZO_NAPI_ATLAGAR,BESZERZESI_AR, KESZLET_NAPI, AKT_ATLAGAR)
	select nn.EV,nn.HO, nn.NAP, v.CIKK_ID, v.RAKTAR_ID, v.KESZLET_NYITO+v.KESZLET_NAPI, (v.KESZLET_NYITO+v.KESZLET_NAPI)*isnull(v.AKT_ATLAGAR,0), isnull(v.AKT_ATLAGAR,0),v.BESZERZESI_AR,0,isnull(v.AKT_ATLAGAR,0)
	from napok nn 
		inner join V_SRSZ_KESZLET_NAP v on v.SRSZ = @last_nap_srsz

	where nn.srsz > @last_nap_srsz and nn.srsz <= @open_day_srsz
commit tran T1
END

GO


ALTER FUNCTION [dbo].[GetKeszlet]
	(@EV int, @HO int , @NAP int, @cikk_id int, @raktar_id int)
RETURNS @ret TABLE 
	(RAKTAR_ID int, RAKTAR_NEV Varchar(50), KESZLET float, KESZLET_ERTEK float)
AS
BEGIN


if @raktar_id = -1 begin

	INSERT @ret
        SELECT f.RAKTAR_ID, r.RAKTAR_KOD, isnull(f.KESZLET_NYITO,0) + isnull(f.KESZLET_NAPI,0), isnull(f.KESZLET_ERTEK_NYITO,0)
            FROM KESZLET_FEJ f inner join RAKTAR r on f.RAKTAR_ID = r.RAKTAR_ID
            where f.cikk_id = @cikk_id and f.EV = @EV and f.nap = @NAP and f.ho = @HO

end else begin

	INSERT @ret
        SELECT f.RAKTAR_ID, r.RAKTAR_KOD, isnull(f.KESZLET_NYITO,0) + isnull(f.KESZLET_NAPI,0), isnull(f.KESZLET_ERTEK_NYITO,0)
            FROM KESZLET_FEJ f inner join RAKTAR r on f.RAKTAR_ID = r.RAKTAR_ID
            where f.cikk_id = @cikk_id and f.raktar_id = @raktar_id 
                and f.EV = @EV and f.nap = @NAP and f.ho = @HO

end

	RETURN 
END

GO

