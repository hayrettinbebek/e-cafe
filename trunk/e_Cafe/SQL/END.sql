-- =============================================
-- Author:		<László Ernõ>
-- Create date: <2009.01.23>
-- Description:	<Készletkarton létrehozása nyitott napra>
-- =============================================
CREATE PROCEDURE [dbo].[openDay]
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
-- =============================================
-- Author:		<László Ernõ>
-- Create date: <2009.01.23>
-- Description:	<Készletkarton létrehozása nyitott napra>
-- =============================================
CREATE PROCEDURE [dbo].[createNapok]
(
-- Melyik napra szeretném megnyitni a készleteket. 
	@db int 
)
AS
BEGIN
 -- rekord beszúrása a nyitott napba
declare @i int
declare @lastDate datetime
set @lastDate = '2009.01.01'
set @i = 1
select top 1 @lastDate = CAST( CAST(EV as varchar(2))+'.'+ CAST(HO as varchar(2))+'.'+CAST(NAP as varchar(2)) as datetime) from NAPOK order by SRSZ desc


    while (@i < @db) begin
    set @lastDate = dateadd(day,1,@lastDate)
        INSERT INTO NAPOK
           ([EV]
           ,[HO]
           ,[NAP])
        VALUES
           (year(@lastDate),	month(@lastDate),	day(@lastDate))
    set @i = @i +1
    end

	


	

END

GO

-- =============================================
-- Author:		<László Ernõ>
-- Create date: <2009.01.23>
-- Description:	<Nyitott nap meglétének vizsgálata>
-- =============================================
CREATE PROCEDURE [dbo].[getNyitottNap]
(
	@EV int output,
	@HO int output,
	@NAP int output
)
AS
BEGIN
	declare @cntNyitnap int
	set @cntNyitnap = 0
	select @cntNyitnap = count(*) from NAP_NYITAS where LEZART = 0
	
    if @cntNyitnap = 0  begin
	--Nincs nyitott nap így létre kell hozni.
	set @EV = year(getdate())
	set @HO = month(getdate())
	set @NAP = day(getdate())
	exec openDay @EV, @HO, @NAP
	
    end else begin
    -- Meg kell vizsgálni hogy mennyi van ha egynél több akkor hiba!!!
        if @cntNyitNap > 1 begin
            RAISERROR('Hibás nyitott napok!',16,1)
        end else begin 
            select @EV = EV, @HO = HO, @NAP = NAP from nap_nyitas where LEZART = 0
        end
    end

	

END

GO


-- =============================================
-- Author:		<László Ernõ>
-- Create date: <2009.01.23>
-- Description:	<Készletkarton létrehozása nyitott napra>
-- =============================================
CREATE PROCEDURE [dbo].[setNyitoSor]
(
-- Melyik napra szeretném megnyitni a készleteket. 
	@cikk_id int ,
	@mennyiseg float,
    @akt_besz_ar float,
    @raktar_id int
)
AS
BEGIN

if not exists(SELECT '' from KESZLET_SOR where CIKK_ID = @cikk_id and raktar_id = @raktar_id and mozgas_tipus = 'NY')
begin
declare @a_ev int,
        @a_ho int,
        @a_nap int

execute getnyitottNap @a_ev out, @a_ho out, @a_nap out
    



insert into KESZLET_SOR (ev, ho, nap, cikk_id, raktar_id, datum, mennyiseg, irany, egysegar, netto_ertek, afa_ertek, afa_kod, brutto_ertek, mozgas_tipus)
    select @a_ev, @a_ho, @a_nap, CIKK_ID,@raktar_id, getdate(), @mennyiseg, 1, @akt_besz_ar, @akt_besz_ar*@mennyiseg,  @akt_besz_ar*@mennyiseg* (a.AFA_ERTEK/100), a.AFA_KOD, @akt_besz_ar*@mennyiseg+  @akt_besz_ar*@mennyiseg* (a.AFA_ERTEK/100),'NY'  
    from CIKK c
    inner join CIKKCSOPORT cs on cs.cikkcsoport_id = c.cikkcsoport_id
    inner join AFA a on cs.AFA_KOD = a.AFA_KOD
    where  c.cikk_id = @cikk_id
	
end else begin

raiserror ('Egy cikknek nem lehet több nyitó könyvelése!',16,1)
end
/*
exec setNyitoSor 3,77,98.5,1

exec setNyitoSor 3,100,98.5,2

exec setNyitoSor 4,30,78.5,1

exec setNyitoSor 5,12,102.5,1

exec setNyitoSor 6,44,155.5,1

exec setNyitoSor 7,70,202,1

exec setNyitoSor 8,44,197,1

exec setNyitoSor 8,5,197,2

*/
END

GO


CREATE FUNCTION [dbo].[GetKeszlet]
	(@EV int, @HO int , @NAP int, @cikk_id int, @raktar_id int)
RETURNS @ret TABLE 
	(RAKTAR_ID int, RAKTAR_NEV Varchar(50), KESZLET float, KESZLET_ERTEK float, ATLAGAR float)
AS
BEGIN


if @raktar_id = -1 begin

	INSERT @ret
        SELECT f.RAKTAR_ID, r.RAKTAR_KOD, Round(isnull(f.KESZLET_NYITO,0) + isnull(f.KESZLET_NAPI,0),2), Round(isnull(f.KESZLET_ERTEK_NYITO,0)+ (isnull(f.KESZLET_NAPI,0)*dbo.fn_get_Atlagar(f.cikk_id,r.RAKTAR_ID,@EV,@HO,@NAP)),2), dbo.fn_get_Atlagar(f.cikk_id,r.RAKTAR_ID,@EV,@HO,@NAP)
            FROM KESZLET_FEJ f inner join RAKTAR r on f.RAKTAR_ID = r.RAKTAR_ID
            where f.cikk_id = @cikk_id and f.EV = @EV and f.nap = @NAP and f.ho = @HO

end else begin

	INSERT @ret
        SELECT f.RAKTAR_ID, r.RAKTAR_KOD, Round(isnull(f.KESZLET_NYITO,0) + isnull(f.KESZLET_NAPI,0),2), Round(isnull(f.KESZLET_ERTEK_NYITO,0)+ (isnull(f.KESZLET_NAPI,0)*dbo.fn_get_Atlagar(f.cikk_id,r.RAKTAR_ID,@EV,@HO,@NAP)),2), dbo.fn_get_Atlagar(f.cikk_id,r.RAKTAR_ID,@EV,@HO,@NAP)
            FROM KESZLET_FEJ f inner join RAKTAR r on f.RAKTAR_ID = r.RAKTAR_ID
            where f.cikk_id = @cikk_id and f.raktar_id = @raktar_id 
                and f.EV = @EV and f.nap = @NAP and f.ho = @HO

end

	RETURN 
END

GO

CREATE FUNCTION [dbo].[getNyitoKeszlet]
	(@EV int, @HO int , @NAP int, @cikk_id int, @raktar_id int)
RETURNS @ret TABLE 
	(KESZLET_NYITO float, KESZLET_ERTEK_NYITO float, ELOZO_NAPI_ATLAGAR float, BESZERZESI_AR float)
AS
BEGIN

declare @tmp_c int

	INSERT @ret
		select null,null,null,null
union
        SELECT f.KESZLET_NYITO, f.KESZLET_ERTEK_NYITO, f.ELOZO_NAPI_ATLAGAR, f.BESZERZESI_AR  
            FROM KESZLET_FEJ f
            inner join getTegnap(@ev, @ho, @nap) t on f.EV = t.EV and f.nap = t.nap and f.ho = t.ho
            where cikk_id = @cikk_id and raktar_id = @raktar_id


select @tmp_c= count(*) from @ret
if @tmp_c > 1 begin
delete from @ret where KESZLET_NYITO is null
end


	RETURN 
END


GO

CREATE FUNCTION [dbo].[getTegnap] 
	(-- Melyik napra szeretném megnyitni a készleteket. 
	@EV int ,
	@HO int ,
	@NAP int)
RETURNS @i_date TABLE 
	(EV int, HO int, NAP int) 
	 
AS
BEGIN
declare @i int
SELECT @i=SRSZ  FROM  NAPOK  WHERE EV = @EV and HO = @HO and NAP = @NAP

	INSERT @i_date
        SELECT top 1 EV,HO,NAP FROM  NAPOK  WHERE SRSZ <@i order by SRSZ desc
	RETURN 
END


GO
create function [dbo].[fn_get_Atlagar](@cikk_id int,@raktar_id int, @EV int, @HO int, @NAP int)
returns float
as 
begin

declare @ret float 
set @ret = 0
if ((@cikk_id >0) and (@raktar_id > 0)) begin
	select @ret = isnull(AKT_ATLAGAR,0) from KESZLET_FEJ f
	where f.CIKK_ID = @cikk_id and f.RAKTAR_ID = @raktar_id
			and f.EV = @EV and f.HO = @HO and f.NAP = @NAP


end

return Round(@ret,2)

end

GO



-- =============================================
-- Author:		László Ernõ
-- Create date: 2009.01.26
-- Description:	Bevételezés készlet vezetése
-- =============================================
CREATE TRIGGER [dbo].[tr_BevSor_insert_update_keszlet]
   ON  [dbo].[BEVETEL_SOR]
   AFTER INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	declare @EV int, @HO int, @NAP int, @Feladva int, @sor_id int, @vane int


	exec getNyitottNap @EV out, @HO out, @NAP out

	select @Feladva = FELADVA, @sor_id = SOR_ID from inserted
	set @vane = 0
	select @vane=count(*) from KESZLET_SOR where BIZONYLAT_ID = @sor_id
--print @feladva
--print @vane
	if (@feladva = 1) and (@vane = 0) begin

		INSERT INTO KESZLET_SOR
			   (EV ,HO ,NAP
			   ,RAKTAR_ID,CIKK_ID ,DATUM
			   ,RENDELES_ID ,BIZONYLAT_ID
			   ,MENNYISEG ,IRANY ,EGYSEGAR
			   ,NETTO_ERTEK
			   ,AFA_ERTEK
			   ,AFA_KOD
			   ,BRUTTO_ERTEK
			   ,MOZGAS_TIPUS
				,KESZLET_EGYS_AR)
		 SELECT @EV,@HO,@NAP,
				i.RAKTAR_ID, i.CIKK_ID, f.DATUM,
				i.BEVETEL_FEJ_ID,i.SOR_ID,
				MENNY,1,BESZ_AR,
				MENNY*BESZ_AR,
				(MENNY*BESZ_AR)*(a.AFA_ERTEK/100),
				cs.AFA_KOD,
				(MENNY*BESZ_AR)*(1+(a.AFA_ERTEK/100)),
				'B',BESZ_AR
		FROM INSERTED i 
		inner join BEVETEL_FEJ f on i.BEVETEL_FEJ_ID = f.BEVETEL_FEJ_ID
		inner join CIKK c on i.CIKK_ID = c.CIKK_ID
		inner join CIKKCSOPORT cs on c.CIKKCSOPORT_ID = cs.CIKKCSOPORT_ID
		inner join AFA a on cs.AFA_KOD = a.AFA_KOD
		where not exists (select '' from KESZLET_SOR where BIZONYLAT_ID = i.SOR_ID)


	end

END


GO

-- =============================================
-- Author:		<László Ernõ>
-- Create date: <2009.01.23>
-- Description:	<Készletkarton létrehozása sor beszúrása esetén a nyitott napra>
-- =============================================
CREATE TRIGGER [dbo].[tr_Fej_vizsgalat_Soron]
   ON  [dbo].[KESZLET_SOR]
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for trigger here
	declare @s_ev int,
			@s_ho int,
			@s_nap int,
			@s_cikk_id int,
			@s_raktar_id int
	
    SELECT top 1 @s_ev=I.EV, @s_ho=I.HO, @s_nap=I.NAP, @s_cikk_id=I.CIKK_ID, @s_raktar_id=I.RAKTAR_ID from inserted I


	if not exists(SELECT '' FROM KESZLET_FEJ f where f.EV = @s_ev and 
						f.HO = @s_ho and
						f.NAP = @s_nap and
						f.CIKK_ID = @s_cikk_id and
						f.RAKTAR_ID = @s_raktar_id
		) 
	begin

		insert into KESZLET_FEJ (EV,HO, NAP, CIKK_ID, RAKTAR_ID, KESZLET_NYITO, KESZLET_ERTEK_NYITO, ELOZO_NAPI_ATLAGAR, BESZERZESI_AR)
			SELECT @s_ev, @s_ho, @s_nap, @s_cikk_id, @s_raktar_id, isnull(n.KESZLET_NYITO,0), isnull(n.KESZLET_ERTEK_NYITO,0), isnull(n.ELOZO_NAPI_ATLAGAR,0), isnull(n.BESZERZESI_AR,0) 
				FROM getNyitoKeszlet( @s_ev, @s_ho, @s_nap, @s_cikk_id, @s_raktar_id ) n 

	end

END


GO
-- =============================================
-- Author:		<László Ernõ>
-- Create date: <2009.01.23>
-- Description:	<Készletkarton létrehozása nyitott napra>
-- =============================================
CREATE TRIGGER [dbo].[tr_KeszletSor_update_keszlet]
   ON  [dbo].[KESZLET_SOR]
   AFTER  INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for trigger here

	update KESZLET_FEJ SET KESZLET_NAPI = (select SUM(s.MENNYISEG*s.IRANY) from 
								KESZLET_SOR s 
								inner join inserted i on s.EV = i.EV 
														and s.HO = i.HO 
														and s.NAP = i.NAP 
														and i.CIKK_ID = s.CIKK_ID 
														and s.RAKTAR_ID = i.RAKTAR_ID),
					AKT_ATLAGAR = (KESZLET_ERTEK_NYITO + (select SUM(s.MENNYISEG*s.IRANY*isnull(s.KESZLET_EGYS_AR,0)) from 
												KESZLET_SOR s 
												inner join inserted i on s.EV = i.EV 
														and s.HO = i.HO 
														and s.NAP = i.NAP 
														and i.CIKK_ID = s.CIKK_ID 
														and s.RAKTAR_ID = i.RAKTAR_ID)
									)
								/ (KESZLET_NYITO + (select SUM(s.MENNYISEG*s.IRANY) from 
												KESZLET_SOR s 
												inner join inserted i on s.EV = i.EV 
														and s.HO = i.HO 
														and s.NAP = i.NAP 
														and i.CIKK_ID = s.CIKK_ID 
														and s.RAKTAR_ID = i.RAKTAR_ID)
									)
    from KESZLET_FEJ f inner join inserted i on f.EV = i.EV and f.HO = i.HO and f.NAP = i.NAP and f.CIKK_ID = i.CIKK_ID and f.RAKTAR_ID = i.RAKTAR_ID



		
END

GO

-- =============================================
-- Author:		László Ernõ
-- Create date: 2009.01.25
-- Description:	Rendelések készletmozgását végzi el.
-- =============================================
CREATE TRIGGER [dbo].[tr_RendelSor_Keszletupdate] 
   ON  [dbo].[RENDELES_SOR]
   AFTER  UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for trigger here

	declare @EV int, @HO int, @NAP int, @new_DELETE int, @old_DELETE int, @old_Fizetve int, @new_Fizetve int

	select @new_DELETE = DELETED, @new_Fizetve = FIZETVE from inserted
	select @old_DELETE = DELETED, @old_Fizetve = FIZETVE from deleted 

	exec getNyitottNap @EV out, @HO out, @NAP out


	if ((@new_DELETE = 1) and (@old_DELETE = 0)) begin
	
	-- storno
	INSERT INTO KESZLET_SOR
			   (EV ,HO ,NAP
			   ,RAKTAR_ID,CIKK_ID ,DATUM
			   ,RENDELES_ID ,BIZONYLAT_ID
			   ,MENNYISEG ,IRANY ,EGYSEGAR
			   ,NETTO_ERTEK
			   ,AFA_ERTEK
			   ,AFA_KOD
			   ,BRUTTO_ERTEK
			   ,MOZGAS_TIPUS
				,KESZLET_EGYS_AR)
		 SELECT @EV,@HO,@NAP,
				RAKTAR_ID, i.CIKK_ID, DATUM,
				SOR_ID,RENDELES_ID,
				DB,1,ERTEK,
				ERTEK,
				ERTEK*(a.AFA_ERTEK/100),
				cs.AFA_KOD,
				ERTEK*(1+(a.AFA_ERTEK/100)),
				'FS',
				dbo.fn_get_Atlagar(i.CIKK_ID,i.RAKTAR_ID, @EV, @HO, @NAP)
		FROM INSERTED i 
		inner join CIKK c on i.CIKK_ID = c.CIKK_ID
		inner join CIKKCSOPORT cs on c.CIKKCSOPORT_ID = cs.CIKKCSOPORT_ID
		inner join AFA a on cs.AFA_KOD = a.AFA_KOD			
	end

	if ((@new_Fizetve = 1) and (@old_Fizetve = 0)) begin
	
		if not exists(SELECT '' FROM RENDELES_SOR s inner join inserted i on s.RENDELES_ID = i.RENDELES_ID where isnull(s.DELETED,0) = 0 and isnull(s.FIZETVE,0) = 0) begin

			update RENDELES_FEJ SET FIZETVE = 1 FROM RENDELES_FEJ f inner join inserted i on f.RENDELES_ID = i.RENDELES_ID

		end
	

	end
	
	update RENDELES_FEJ SET AKTIV = 0
	from rendeles_fej f
	left join rendeles_sor s on f.rendeles_id = s.rendeles_id and isnull(s.DELETED,0) = 0
	where s.sor_id is null


END

GO

-- =============================================
-- Author:		Author,,Name>
-- Create date: Create Date,,>
-- Description:	Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_KESZLET_ATVEZET]
	-- Add the parameters for the stored procedure here
	@from_raktar int,
	@to_raktar int,
	@cikk_id int,
	@menny float
	
AS
BEGIN
	
	SET NOCOUNT ON;

declare @a_ev int,
        @a_ho int,
        @a_nap int,
		@afasz float,
		@afa_kod varchar(2)

execute getnyitottNap @a_ev out, @a_ho out, @a_nap out
   
select @afa_kod = a.AFA_KOD, @afasz = a.AFA_ERTEK from aFA a inner join CIKKCSOPORT cs on cs.AFA_KOD = a.AFA_KOD
inner join CIKK c on c.CIKKCSOPORT_ID = cs.CIKKCSOPORT_ID
where c.CIKK_ID = @cikk_id

-- csökkentõ tétel
INSERT INTO KESZLET_SOR
           (EV,HO,NAP,RAKTAR_ID,CIKK_ID,DATUM,RENDELES_ID,BEVETEL_ID
			,BIZONYLAT_ID,MENNYISEG,IRANY,EGYSEGAR,NETTO_ERTEK,AFA_ERTEK
			,AFA_KOD,BRUTTO_ERTEK,MOZGAS_TIPUS,KESZLET_EGYS_AR)
     VALUES
           (@a_ev,@a_ho,@a_nap,@from_raktar,@cikk_id,getdate(),null,null
			,null,@menny,-1,dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap),dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap)*@menny, (dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap)*@menny)*(@afasz/100)
			,@afa_kod,(dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap)*@menny)*(1+(@afasz/100)),'R-',dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap))

-- növelõ tétel tétel
INSERT INTO KESZLET_SOR
           (EV,HO,NAP,RAKTAR_ID,CIKK_ID,DATUM,RENDELES_ID,BEVETEL_ID
			,BIZONYLAT_ID,MENNYISEG,IRANY,EGYSEGAR,NETTO_ERTEK,AFA_ERTEK
			,AFA_KOD,BRUTTO_ERTEK,MOZGAS_TIPUS,KESZLET_EGYS_AR)
     VALUES
           (@a_ev,@a_ho,@a_nap,@to_raktar,@cikk_id,getdate(),null,null
			,null,@menny,1,dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap),dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap)*@menny, (dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap)*@menny)*(@afasz/100)
			,@afa_kod,(dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap)*@menny)*(1+(@afasz/100)),'R+',dbo.fn_get_Atlagar(@cikk_id,@from_raktar,@a_ev,@a_ho,@a_nap))

    
END


GO

-- =============================================
-- Author:		László Ernõ
-- Create date: 2009.03.01
-- Description:	Hitelre könyveli a rendelés sorokat
-- =============================================
CREATE PROCEDURE sp_addRendeles_to_Hitel 
	-- Add the parameters for the stored procedure here
	@p_partner_id int,
	@rendel_sor_id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO HITEL_SOR (PARTNER_ID,RENDELES_SOR_ID,FIZETVE)
	VALUES (@p_partner_id,@rendel_sor_id,0)

	update RENDELES_SOR  SET FIZETVE = 1 WHERE SOR_ID = @rendel_sor_id


END
GO


CREATE TRIGGER [dbo].[tr_RendelSor_KeszletInsert] 
   ON  [dbo].[RENDELES_SOR]
   AFTER  INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for trigger here

	declare @EV int, @HO int, @NAP int, @DELETE int

	select @DELETE = DELETED from inserted

	exec getNyitottNap @EV out, @HO out, @NAP out

    INSERT INTO KESZLET_SOR
			   (EV ,HO ,NAP
			   ,RAKTAR_ID,CIKK_ID ,DATUM
			   ,RENDELES_ID ,BIZONYLAT_ID
			   ,MENNYISEG ,IRANY ,EGYSEGAR
			   ,NETTO_ERTEK
			   ,AFA_ERTEK
			   ,AFA_KOD
			   ,BRUTTO_ERTEK
			   ,MOZGAS_TIPUS
				,KESZLET_EGYS_AR)
		 SELECT @EV,@HO,@NAP,
				i.RAKTAR_ID, i.CIKK_ID, DATUM,
				SOR_ID,RENDELES_ID,
				DB,-1,ERTEK,
				DB*ERTEK,
				ERTEK*(a.AFA_ERTEK/100),
				cs.AFA_KOD,
				ERTEK*(1+(a.AFA_ERTEK/100)),
				'F',
				dbo.fn_get_Atlagar(i.CIKK_ID,i.RAKTAR_ID, @EV, @HO, @NAP)
		FROM INSERTED i 
		inner join CIKK c on i.CIKK_ID = c.CIKK_ID
		inner join CIKKCSOPORT cs on c.CIKKCSOPORT_ID = cs.CIKKCSOPORT_ID
		inner join AFA a on cs.AFA_KOD = a.AFA_KOD	
		

END