USE [Giaibong]
GO
/****** Object:  Table [dbo].[Cauthu]    Script Date: 11/7/2021 12:53:21 AM ******/
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
/****** Object:  Table [dbo].[Doibong]    Script Date: 11/7/2021 12:53:21 AM ******/
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
/****** Object:  Table [dbo].[Doibong_Trandau]    Script Date: 11/7/2021 12:53:21 AM ******/
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
/****** Object:  Table [dbo].[DSCauthuTrandau]    Script Date: 11/7/2021 12:53:21 AM ******/
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
/****** Object:  Table [dbo].[Giaidau]    Script Date: 11/7/2021 12:53:21 AM ******/
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
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 11/7/2021 12:53:21 AM ******/
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
/****** Object:  Table [dbo].[Trandau]    Script Date: 11/7/2021 12:53:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trandau](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Ngaythidau] [datetime] NOT NULL,
	[Giaban] [bigint] NULL,
	[VongdauID] [int] NOT NULL,
 CONSTRAINT [PK_Trandau] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vongdau]    Script Date: 11/7/2021 12:53:21 AM ******/
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
