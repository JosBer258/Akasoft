USE [ALBATROS]
GO

/****** Object:  View [dbo].[RP_Factura_resumen]    Script Date: 7/3/2022 5:47:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[RP_Factura_resumen]
AS
select b.NOMBRE CLIENTE, b.RTN AS RTN
				, A.ID_FACTURA as NUMERO_FACTURA
			 , A.TOTAL_FACTURA AS TOTAL
			, A.TOTAL_IMPUESTO AS IMPUESTO , A.FECHA_CREACION as FECHA_EMISION   
from [ALBATROS].DBO.[FACTURA_HEADER] A 
inner join ALBATROS.DBO.CLIENTES B on A.ID_CLIENTE=B.ID_CLIENTE and b.status='A'

GO


