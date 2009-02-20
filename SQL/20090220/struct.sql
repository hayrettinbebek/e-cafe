ALTER TABLE KESZLET_SOR ADD
	KESZLET_EGYS_AR float(53) NULL
GO



-- =============================================
-- Author:		László Ernõ
-- Create date: 2009.01.26
-- Description:	Bevételezés készlet vezetése
-- =============================================
ALTER TRIGGER [dbo].[tr_BevSor_insert_update_keszlet]
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
create function fn_get_Atlagar(@cikk_id int,@raktar_id int)
returns float
as 
begin

	declare @EV int, @HO int, @NAP int, @DELETE int, @ret float
	exec getNyitottNap @EV out, @HO out, @NAP out

set @ret = 0
if ((@cikk_id >1) and (@raktar_id > 1)) begin
	select @ret = isnull(AKT_ATLAGAR,0) from KESZLET_FEJ f
	where f.CIKK_ID = @cikk_id and f.RAKTAR_ID = @raktar_id
			and f.EV = @EV and f.HO = @HO and f.NAP = @NAP


end

return @ret

end

GO
-- =============================================
-- Author:		László Ernõ
-- Create date: 2009.01.25
-- Description:	Rendelések készletmozgását végzi el.
-- =============================================
ALTER TRIGGER [dbo].[tr_RendelSor_Keszletupdate] 
   ON  [dbo].[RENDELES_SOR]
   AFTER  INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for trigger here

	declare @EV int, @HO int, @NAP int, @DELETE int

	select @DELETE = DELETED from inserted

	exec getNyitottNap @EV out, @HO out, @NAP out


	if not(@DELETE = 1) begin
	-- készlet csökkenést kell beszúrni
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
				dbo.fn_get_Atlagar(i.CIKK_ID,i.RAKTAR_ID)
		FROM INSERTED i 
		inner join CIKK c on i.CIKK_ID = c.CIKK_ID
		inner join CIKKCSOPORT cs on c.CIKKCSOPORT_ID = cs.CIKKCSOPORT_ID
		inner join AFA a on cs.AFA_KOD = a.AFA_KOD
	
	end
	else begin
	-- törölt rendelés sor, ami kivét stornója
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
				dbo.fn_get_Atlagar(i.CIKK_ID,i.RAKTAR_ID)
		FROM INSERTED i 
		inner join CIKK c on i.CIKK_ID = c.CIKK_ID
		inner join CIKKCSOPORT cs on c.CIKKCSOPORT_ID = cs.CIKKCSOPORT_ID
		inner join AFA a on cs.AFA_KOD = a.AFA_KOD
	end

END

GO
-- =============================================
-- Author:		<László Ernõ>
-- Create date: <2009.01.23>
-- Description:	<Készletkarton létrehozása nyitott napra>
-- =============================================
ALTER TRIGGER [dbo].[tr_KeszletSor_update_keszlet]
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


