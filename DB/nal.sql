USE [HackathonTampa]
GO

/****** Object:  Table [dbo].[nal]    Script Date: 04/14/2013 15:58:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[nal](
	[nalId] [int] IDENTITY(1,1) NOT NULL,
	[strap] [char](25) NULL,
	[folio] [varchar](50) NULL,
	[dor_cd] [varchar](50) NULL,
	[val_method] [varchar](50) NULL,
	[mill_cd] [varchar](50) NULL,
	[nh_cd] [varchar](50) NULL,
	[vac_impr_flg] [varchar](50) NULL,
	[yr_impr] [varchar](50) NULL,
	[yr_annexed] [varchar](50) NULL,
	[splt_dt] [varchar](50) NULL,
	[dsc_cd] [varchar](50) NULL,
	[base_yr] [varchar](50) NULL,
	[mkt_ar1] [varchar](50) NULL,
	[mkt_ar2] [varchar](50) NULL,
	[pr_strap] [varchar](50) NULL,
	[prob_deed] [varchar](50) NULL,
	[tenancy] [varchar](50) NULL,
	[hx_val] [varchar](50) NULL,
	[wid_val] [varchar](50) NULL,
	[wdr_val] [varchar](50) NULL,
	[dis_val] [varchar](50) NULL,
	[wx_val] [varchar](50) NULL,
	[jst_val] [varchar](50) NULL,
	[cls_val] [varchar](50) NULL,
	[asd_val] [varchar](50) NULL,
	[soh_val] [varchar](50) NULL,
	[tax_val] [varchar](50) NULL,
	[cur_base] [varchar](50) NULL,
	[pct_soh] [varchar](50) NULL,
	[mkt_soh] [varchar](50) NULL,
	[mkt_mkt] [varchar](50) NULL,
	[ag_x_val] [varchar](50) NULL,
	[tot_bld_val] [varchar](50) NULL,
	[cost_bld_val] [varchar](50) NULL,
	[tot_xf_val] [varchar](50) NULL,
	[tot_lnd_val] [varchar](50) NULL,
	[cls_lnd_val] [varchar](50) NULL,
	[ag_lnd_val] [varchar](50) NULL,
	[asd_lnd_val] [varchar](50) NULL,
	[ncon_val] [varchar](50) NULL,
	[demo_val] [varchar](50) NULL,
	[comb_val] [varchar](50) NULL,
	[split_val] [varchar](50) NULL,
	[px_val] [varchar](50) NULL,
	[pr_val] [varchar](50) NULL,
	[ag_x_flg] [varchar](50) NULL,
	[yr_created] [varchar](50) NULL,
	[pr_dor_cd] [varchar](50) NULL,
	[map_id] [varchar](50) NULL,
	[own_dt] [varchar](50) NULL,
	[life_est] [varchar](50) NULL,
	[jt_flg] [varchar](50) NULL,
	[inc_flg] [varchar](50) NULL,
	[mh_flg] [varchar](50) NULL,
	[lnd_sale_flg] [varchar](50) NULL,
	[conf_flg] [varchar](50) NULL,
	[mortage_cd] [varchar](50) NULL,
	[owner1] [varchar](50) NULL,
	[owner2] [varchar](50) NULL,
	[m_state] [varchar](50) NULL,
	[m_addr_1] [varchar](50) NULL,
	[m_addr_2] [varchar](50) NULL,
	[m_city] [varchar](50) NULL,
	[m_zip] [varchar](50) NULL,
	[m_country] [varchar](50) NULL,
	[carr_rt] [varchar](50) NULL,
	[mailto] [varchar](50) NULL,
	[str] [char](30) NULL,
	[str_pfx] [char](2) NULL,
	[str_num] [varchar](50) NULL,
	[str_sfx] [varchar](50) NULL,
	[str_unit] [varchar](50) NULL,
	[s_zip] [varchar](50) NULL,
	[s_city] [varchar](50) NULL,
	[plat_bk] [varchar](50) NULL,
	[plat_pg] [varchar](50) NULL,
 CONSTRAINT [PK_nal] PRIMARY KEY CLUSTERED 
(
	[nalId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


