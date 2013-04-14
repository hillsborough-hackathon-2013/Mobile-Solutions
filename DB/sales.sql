USE [HackathonTampa]
GO

/****** Object:  Table [dbo].[sales]    Script Date: 04/14/2013 15:59:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[sales](
	[SalesId] [int] NOT NULL,
	[strap] [char](25) NOT NULL,
	[folio] [char](10) NULL,
	[ln_num] [int] NULL,
	[trns_cd] [char](2) NULL,
	[or_bk] [char](5) NULL,
	[or_pg] [char](5) NULL,
	[grantor] [char](30) NULL,
	[grantee] [char](30) NULL,
	[dos] [date] NULL,
	[price] [int] NULL,
	[vi] [char](1) NULL,
	[qu_flg] [char](1) NULL,
	[doc_stamps] [decimal](9, 2) NULL,
	[rea_cd] [char](2) NULL,
 CONSTRAINT [PK_sales] PRIMARY KEY CLUSTERED 
(
	[SalesId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


