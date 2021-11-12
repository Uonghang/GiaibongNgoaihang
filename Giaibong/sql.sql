USE [Giaibong]
GO
/****** Object:  Table [dbo].[Cauthu]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cauthu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenCauthu] [nchar](255) NULL,
	[Ngaysinh] [date] NULL,
	[VT] [nchar](255) NOT NULL,
	[DoibongID] [int] NOT NULL,
	[Chanthuan] [nchar](255) NULL,
	[Chieucao] [nchar](10) NULL,
	[Cannang] [nchar](10) NULL,
	[Dacdiem] [nchar](255) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Cauthu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doibong]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doibong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nchar](255) NOT NULL,
	[Diachi] [nchar](255) NOT NULL,
	[Trangphuc] [nchar](255) NULL,
	[Mota] [nchar](255) NULL,
 CONSTRAINT [PK_Doibong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doibong_Trandau]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doibong_Trandau](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TrandauID] [int] NOT NULL,
	[DoibongID] [int] NULL,
 CONSTRAINT [PK_Doibong_Trandau] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doitac]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doitac](
	[ID] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Doitac] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DSCauthuTrandau]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSCauthuTrandau](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TrandauID] [int] NOT NULL,
	[CauthuID] [int] NOT NULL,
	[Ten] [nchar](255) NULL,
	[VT] [nchar](10) NULL,
 CONSTRAINT [PK_Cauthu_Trandau] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giaidau]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giaidau](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Nam] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Giaidau] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoadonBanquyen]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoadonBanquyen](
	[ID] [int] NOT NULL,
	[DoibongID] [int] NOT NULL,
	[Tien] [bigint] NOT NULL,
 CONSTRAINT [PK_HoadonBanquyen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoadonBanquyenChitiet]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoadonBanquyenChitiet](
	[ID] [int] NOT NULL,
	[HopdongchitietID] [int] NOT NULL,
	[HoadonBanquyenID] [int] NOT NULL,
	[Tientra] [bigint] NULL,
 CONSTRAINT [PK_HoadonBanquyenChitiet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hopdong]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hopdong](
	[ID] [int] NOT NULL,
	[DoitacID] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Thoigian] [date] NOT NULL,
	[Tien] [bigint] NOT NULL,
 CONSTRAINT [PK_Hopdong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopdongChitiet]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopdongChitiet](
	[ID] [int] NOT NULL,
	[TrandauID] [int] NOT NULL,
	[HopdongID] [int] NOT NULL,
	[Giamua] [bigint] NOT NULL,
 CONSTRAINT [PK_HopdongChitiet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSukien]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSukien](
	[ID] [int] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiSukien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuongTrongTai]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuongTrongTai](
	[ID] [int] NOT NULL,
	[TrongTaiID] [int] NOT NULL,
	[TongLuong] [bigint] NOT NULL,
 CONSTRAINT [PK_LuongTrongTai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuongTrongTaiChitiet]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuongTrongTaiChitiet](
	[ID] [int] NOT NULL,
	[LuongTrongTaiID] [int] NOT NULL,
	[Luong] [bigint] NOT NULL,
	[TrandauID] [int] NOT NULL,
 CONSTRAINT [PK_LuongTrongTaiChitiet] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Sdt] [nvarchar](50) NOT NULL,
	[Vitri] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[San]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[San](
	[ID] [int] NOT NULL,
	[DoibongID] [int] NOT NULL,
	[TongSLkhangia] [int] NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_San] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sukien]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sukien](
	[ID] [int] NOT NULL,
	[TrandauID] [int] NOT NULL,
	[CauthuID] [int] NOT NULL,
	[LoaiSukienID] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Thoigian] [time](7) NOT NULL,
 CONSTRAINT [PK_Sukien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ToTrongTai]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ToTrongTai](
	[ID] [int] NOT NULL,
	[TrandauID] [int] NOT NULL,
	[TrongTaiID] [int] NOT NULL,
 CONSTRAINT [PK_ToTrongTai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trandau]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trandau](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Ngaythidau] [datetime] NULL,
	[Giaban] [bigint] NULL,
	[VongdauID] [int] NOT NULL,
 CONSTRAINT [PK_Trandau] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrongTai]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrongTai](
	[ID] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Stk] [int] NOT NULL,
	[Namsinh] [date] NULL,
 CONSTRAINT [PK_TrongTai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vongdau]    Script Date: 11/13/2021 12:06:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vongdau](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenVongdau] [nvarchar](50) NOT NULL,
	[GiaidauID] [int] NULL,
 CONSTRAINT [PK_Vongdau] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cauthu] ADD  CONSTRAINT [DF_Cauthu_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Cauthu]  WITH CHECK ADD  CONSTRAINT [fk_cauthu] FOREIGN KEY([DoibongID])
REFERENCES [dbo].[Doibong] ([ID])
GO
ALTER TABLE [dbo].[Cauthu] CHECK CONSTRAINT [fk_cauthu]
GO
ALTER TABLE [dbo].[Doibong_Trandau]  WITH CHECK ADD  CONSTRAINT [fk_doibongtrandau] FOREIGN KEY([DoibongID])
REFERENCES [dbo].[Doibong] ([ID])
GO
ALTER TABLE [dbo].[Doibong_Trandau] CHECK CONSTRAINT [fk_doibongtrandau]
GO
ALTER TABLE [dbo].[Doibong_Trandau]  WITH CHECK ADD  CONSTRAINT [fk_trandaudoibong] FOREIGN KEY([TrandauID])
REFERENCES [dbo].[Trandau] ([ID])
GO
ALTER TABLE [dbo].[Doibong_Trandau] CHECK CONSTRAINT [fk_trandaudoibong]
GO
ALTER TABLE [dbo].[DSCauthuTrandau]  WITH CHECK ADD  CONSTRAINT [fk_dangky_Cauthu] FOREIGN KEY([CauthuID])
REFERENCES [dbo].[Cauthu] ([ID])
GO
ALTER TABLE [dbo].[DSCauthuTrandau] CHECK CONSTRAINT [fk_dangky_Cauthu]
GO
ALTER TABLE [dbo].[DSCauthuTrandau]  WITH CHECK ADD  CONSTRAINT [fk_trandau] FOREIGN KEY([TrandauID])
REFERENCES [dbo].[Trandau] ([ID])
GO
ALTER TABLE [dbo].[DSCauthuTrandau] CHECK CONSTRAINT [fk_trandau]
GO
ALTER TABLE [dbo].[HoadonBanquyen]  WITH CHECK ADD  CONSTRAINT [fk_hdondbong] FOREIGN KEY([DoibongID])
REFERENCES [dbo].[Doibong] ([ID])
GO
ALTER TABLE [dbo].[HoadonBanquyen] CHECK CONSTRAINT [fk_hdondbong]
GO
ALTER TABLE [dbo].[HoadonBanquyenChitiet]  WITH CHECK ADD  CONSTRAINT [fk_hdonbanquyen] FOREIGN KEY([HoadonBanquyenID])
REFERENCES [dbo].[HoadonBanquyen] ([ID])
GO
ALTER TABLE [dbo].[HoadonBanquyenChitiet] CHECK CONSTRAINT [fk_hdonbanquyen]
GO
ALTER TABLE [dbo].[HoadonBanquyenChitiet]  WITH CHECK ADD  CONSTRAINT [fk_hdonchitiet] FOREIGN KEY([HopdongchitietID])
REFERENCES [dbo].[HopdongChitiet] ([ID])
GO
ALTER TABLE [dbo].[HoadonBanquyenChitiet] CHECK CONSTRAINT [fk_hdonchitiet]
GO
ALTER TABLE [dbo].[Hopdong]  WITH CHECK ADD  CONSTRAINT [fk_doitac] FOREIGN KEY([DoitacID])
REFERENCES [dbo].[Doitac] ([ID])
GO
ALTER TABLE [dbo].[Hopdong] CHECK CONSTRAINT [fk_doitac]
GO
ALTER TABLE [dbo].[HopdongChitiet]  WITH CHECK ADD  CONSTRAINT [fk_hdong] FOREIGN KEY([HopdongID])
REFERENCES [dbo].[Hopdong] ([ID])
GO
ALTER TABLE [dbo].[HopdongChitiet] CHECK CONSTRAINT [fk_hdong]
GO
ALTER TABLE [dbo].[HopdongChitiet]  WITH CHECK ADD  CONSTRAINT [fk_hptdau] FOREIGN KEY([TrandauID])
REFERENCES [dbo].[Trandau] ([ID])
GO
ALTER TABLE [dbo].[HopdongChitiet] CHECK CONSTRAINT [fk_hptdau]
GO
ALTER TABLE [dbo].[LuongTrongTai]  WITH CHECK ADD  CONSTRAINT [fk_trongtai] FOREIGN KEY([TrongTaiID])
REFERENCES [dbo].[TrongTai] ([ID])
GO
ALTER TABLE [dbo].[LuongTrongTai] CHECK CONSTRAINT [fk_trongtai]
GO
ALTER TABLE [dbo].[LuongTrongTaiChitiet]  WITH CHECK ADD  CONSTRAINT [fk_luongTT] FOREIGN KEY([TrandauID])
REFERENCES [dbo].[Trandau] ([ID])
GO
ALTER TABLE [dbo].[LuongTrongTaiChitiet] CHECK CONSTRAINT [fk_luongTT]
GO
ALTER TABLE [dbo].[San]  WITH CHECK ADD  CONSTRAINT [fk_san] FOREIGN KEY([DoibongID])
REFERENCES [dbo].[Doibong] ([ID])
GO
ALTER TABLE [dbo].[San] CHECK CONSTRAINT [fk_san]
GO
ALTER TABLE [dbo].[Sukien]  WITH CHECK ADD  CONSTRAINT [fk_loaiSk] FOREIGN KEY([LoaiSukienID])
REFERENCES [dbo].[LoaiSukien] ([ID])
GO
ALTER TABLE [dbo].[Sukien] CHECK CONSTRAINT [fk_loaiSk]
GO
ALTER TABLE [dbo].[Sukien]  WITH CHECK ADD  CONSTRAINT [fk_skcauthu] FOREIGN KEY([CauthuID])
REFERENCES [dbo].[Cauthu] ([ID])
GO
ALTER TABLE [dbo].[Sukien] CHECK CONSTRAINT [fk_skcauthu]
GO
ALTER TABLE [dbo].[Sukien]  WITH CHECK ADD  CONSTRAINT [fk_sktdau] FOREIGN KEY([TrandauID])
REFERENCES [dbo].[Trandau] ([ID])
GO
ALTER TABLE [dbo].[Sukien] CHECK CONSTRAINT [fk_sktdau]
GO
ALTER TABLE [dbo].[ToTrongTai]  WITH CHECK ADD  CONSTRAINT [fk_cdau] FOREIGN KEY([TrongTaiID])
REFERENCES [dbo].[TrongTai] ([ID])
GO
ALTER TABLE [dbo].[ToTrongTai] CHECK CONSTRAINT [fk_cdau]
GO
ALTER TABLE [dbo].[ToTrongTai]  WITH CHECK ADD  CONSTRAINT [fk_tdau] FOREIGN KEY([TrandauID])
REFERENCES [dbo].[Trandau] ([ID])
GO
ALTER TABLE [dbo].[ToTrongTai] CHECK CONSTRAINT [fk_tdau]
GO
ALTER TABLE [dbo].[Trandau]  WITH CHECK ADD  CONSTRAINT [fk_Vongdau] FOREIGN KEY([VongdauID])
REFERENCES [dbo].[Vongdau] ([ID])
GO
ALTER TABLE [dbo].[Trandau] CHECK CONSTRAINT [fk_Vongdau]
GO
ALTER TABLE [dbo].[Vongdau]  WITH CHECK ADD  CONSTRAINT [fk_Giaidau] FOREIGN KEY([GiaidauID])
REFERENCES [dbo].[Giaidau] ([ID])
GO
ALTER TABLE [dbo].[Vongdau] CHECK CONSTRAINT [fk_Giaidau]
GO
