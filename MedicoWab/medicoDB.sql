USE [MedicoDB]
GO
ALTER TABLE [dbo].[Horaire] DROP CONSTRAINT [chkDay]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 7/11/2016 16:19:55 ******/
DROP TABLE [dbo].[Patient]
GO
/****** Object:  Table [dbo].[Horaire]    Script Date: 7/11/2016 16:19:55 ******/
DROP TABLE [dbo].[Horaire]
GO
USE [master]
GO
/****** Object:  Database [MedicoDB]    Script Date: 7/11/2016 16:19:55 ******/
DROP DATABASE [MedicoDB]
GO
/****** Object:  Database [MedicoDB]    Script Date: 7/11/2016 16:19:55 ******/
CREATE DATABASE [MedicoDB];

USE [MedicoDB]
GO
/****** Object:  Table [dbo].[Horaire]    Script Date: 7/11/2016 16:19:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horaire](
	[IdHoraire] [int] IDENTITY(1,1) NOT NULL,
	[Jour] [nvarchar](8) NOT NULL,
	[DebMat] [time](7) NOT NULL,
	[FinMat] [time](7) NOT NULL,
	[DebAprem] [time](7) NOT NULL,
	[FinAprem] [time](7) NOT NULL,
	[DebDate] [date] NOT NULL,
	[FinDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHoraire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 7/11/2016 16:19:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pseudo] [varchar](30) NOT NULL,
	[pwd] [varchar](20) NOT NULL,
	[nom] [varchar](100) NOT NULL,
	[prenom] [varchar](50) NOT NULL,
	[sexe] [bit] NULL,
	[dateNaissance] [date] NOT NULL,
	[num] [int] NULL,
	[rue] [varchar](50) NULL,
	[cp] [int] NULL,
	[localite] [varchar](50) NULL,
	[pays] [varchar](50) NULL,
	[tel1] [varchar](50) NOT NULL,
	[tel2] [varchar](50) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_IDpatient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
SET IDENTITY_INSERT [dbo].[Horaire] ON 

GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (1, N'Lundi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (7, N'Mardi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (25, N'Mercredi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (26, N'Jeudi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (27, N'Vendredi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
INSERT [dbo].[Horaire] ([IdHoraire], [Jour], [DebMat], [FinMat], [DebAprem], [FinAprem], [DebDate], [FinDate]) VALUES (28, N'Samedi', CAST(0x070040230E430000 AS Time), CAST(0x0700AC5264600000 AS Time), CAST(0x070048F9F66C0000 AS Time), CAST(0x07004C64EB810000 AS Time), CAST(0x083C0B00 AS Date), CAST(0x423C0B00 AS Date))
GO
SET IDENTITY_INSERT [dbo].[Horaire] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

GO
INSERT [dbo].[Patient] ([id], [pseudo], [pwd], [nom], [prenom], [sexe], [dateNaissance], [num], [rue], [cp], [localite], [pays], [tel1], [tel2], [email]) VALUES (1, N'minivio', N'richaricha', N'Nys', N'Violette', 0, CAST(0x270D0B00 AS Date), 186, N'rue de la Victoire', 1060, N'Saint-Gilles', N'Belgique', N'0486710695', N'', N'violette.nys@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
ALTER TABLE [dbo].[Horaire]  WITH CHECK ADD  CONSTRAINT [chkDay] CHECK  (([Jour]='Samedi' OR [Jour]='Vendredi' OR [Jour]='Jeudi' OR [Jour]='Mercredi' OR [Jour]='Mardi' OR [Jour]='Lundi'))
GO
ALTER TABLE [dbo].[Horaire] CHECK CONSTRAINT [chkDay]
GO
USE [master]
GO
ALTER DATABASE [MedicoDB] SET  READ_WRITE 
GO
