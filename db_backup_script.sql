USE [Otopark_ Otomasyonu]
GO
/****** Object:  Table [dbo].[arac_durumu]    Script Date: 21.12.2021 19:58:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arac_durumu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParkYeri] [nvarchar](50) NOT NULL,
	[ParkDurumu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_arac_durumu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[arac_marka_bilgileri]    Script Date: 21.12.2021 19:58:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arac_marka_bilgileri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Marka] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_arac_marka_bilgileri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[arac_otopark_kaydı]    Script Date: 21.12.2021 19:58:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arac_otopark_kaydı](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TC] [nvarchar](50) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Plaka] [nvarchar](50) NOT NULL,
	[Marka] [nvarchar](50) NOT NULL,
	[SeriNo] [nvarchar](50) NOT NULL,
	[Renk] [nvarchar](50) NOT NULL,
	[Parkyeri] [nvarchar](50) NOT NULL,
	[Tarih] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_arac_otopark_kaydı] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[arac_seri_bilgileri]    Script Date: 21.12.2021 19:58:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arac_seri_bilgileri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[A_Marka] [nvarchar](50) NOT NULL,
	[A_Seri] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_arac_seri_bilgileri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[arac_durumu] ON 
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (1, N'P-1', N'BOŞ')
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (2, N'P-2', N'BOŞ')
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (3, N'P-3', N'BOŞ')
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (4, N'P-4', N'BOŞ')
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (5, N'P-5', N'BOŞ')
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (6, N'P-6', N'BOŞ')
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (7, N'P-7', N'BOŞ')
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (8, N'P-8', N'BOŞ')
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (9, N'P-9', N'BOŞ')
GO
INSERT [dbo].[arac_durumu] ([Id], [ParkYeri], [ParkDurumu]) VALUES (10, N'P-10', N'BOŞ')
GO
SET IDENTITY_INSERT [dbo].[arac_durumu] OFF
GO
SET IDENTITY_INSERT [dbo].[arac_marka_bilgileri] ON 
GO
INSERT [dbo].[arac_marka_bilgileri] ([Id], [Marka]) VALUES (1, N'Renault')
GO
INSERT [dbo].[arac_marka_bilgileri] ([Id], [Marka]) VALUES (2, N'Ford')
GO
SET IDENTITY_INSERT [dbo].[arac_marka_bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[arac_seri_bilgileri] ON 
GO
INSERT [dbo].[arac_seri_bilgileri] ([Id], [A_Marka], [A_Seri]) VALUES (2, N'Ford', N'Focus')
GO
INSERT [dbo].[arac_seri_bilgileri] ([Id], [A_Marka], [A_Seri]) VALUES (3, N'Renault', N'Clio')
GO
SET IDENTITY_INSERT [dbo].[arac_seri_bilgileri] OFF
GO
