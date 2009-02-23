

CREATE TABLE [dbo].[_USER](
	[USR_ID] [int] IDENTITY(1,1) NOT NULL,
	[USR_NAME] [varchar](100) NULL,
	[USR_LOGIN_NAME] [varchar](50) NULL,
	[USR_PW] [varchar](500) NULL,
	[USR_SUPERVISOR] [int] NOT NULL CONSTRAINT [DF__USER_USR_SUPERVISOR]  DEFAULT ((0)),
	[USR_LOCKED] [varchar](1) NOT NULL CONSTRAINT [DF___USER__USR_LOCKE__1E3A7A34]  DEFAULT ('N'),
	[USR_LOCKED_DATE] [datetime] NULL,
	[USR_AKTIV] [int]  NOT NULL DEFAULT (1),
	
 CONSTRAINT [PK__USER] PRIMARY KEY CLUSTERED 
(
	[USR_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


GO

CREATE TABLE dbo._JOG
	(
	JOG_ID varchar(20) NOT NULL,
	JOG_NEV varchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo._JOG ADD CONSTRAINT
	PK__JOG PRIMARY KEY CLUSTERED 
	(
	JOG_ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE TABLE dbo._USER_JOG
	(
	_USER_ID int NOT NULL,
	_JOG_ID varchar(20) NOT NULL
	)  ON [PRIMARY]
GO
create function CheckVersion(@pVer varchar(10))
returns integer
as begin

declare @aktVersion integer;
declare @ret integer;

set @ret = 0;

select @aktVersion = cast(DB_VER as integer) from version

if @aktVersion >= @pVer begin
set @ret = 0;
end else begin
set @ret = 1;
end

return @ret

end

GO


UPDATE VERSION  SET DB_VER = '004'

GO



