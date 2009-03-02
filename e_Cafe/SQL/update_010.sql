
CREATE TABLE SYSPAR (PARAM_NAME varchar(20),
					PARAM_VALUE_S varchar(50),
					PARAM_VALUE_I int,
					PARAM_VALUE_F float
					)
					
GO

insert into SYSPAR (PARAM_NAME,PARAM_VALUE_I) VALUES ('SHOW_ORDER_BEFORE',2)

GO					
	


UPDATE VERSION  SET DB_VER = '010'

GO





