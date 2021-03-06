USE [master]
GO
/****** Object:  Database [cascadingDropDownListsDB]    Script Date: 4/27/2022 3:28:34 PM ******/
CREATE DATABASE [cascadingDropDownListsDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CascadingDropDownListsDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLCATDB\MSSQL\DATA\CascadingDropDownListsDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CascadingDropDownListsDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLCATDB\MSSQL\DATA\CascadingDropDownListsDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cascadingDropDownListsDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cascadingDropDownListsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cascadingDropDownListsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET RECOVERY FULL 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET  MULTI_USER 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cascadingDropDownListsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cascadingDropDownListsDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cascadingDropDownListsDB', N'ON'
GO
ALTER DATABASE [cascadingDropDownListsDB] SET QUERY_STORE = OFF
GO
USE [cascadingDropDownListsDB]
GO
/****** Object:  Table [dbo].[citiy]    Script Date: 4/27/2022 3:28:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[citiy](
	[CityId] [int] NOT NULL,
	[StateId] [int] NOT NULL,
	[CityName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_citiy] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[country]    Script Date: 4/27/2022 3:28:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[country](
	[CountryId] [int] NOT NULL,
	[CountryName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_country] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[state]    Script Date: 4/27/2022 3:28:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[state](
	[StateId] [int] NOT NULL,
	[CountryId] [int] NOT NULL,
	[StateName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_state] PRIMARY KEY CLUSTERED 
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (1, 1, N'Abbeville')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (2, 1, N'Argo')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (3, 2, N'Buckeye')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (4, 2, N'Carefree')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (5, 3, N'Juneau')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (6, 3, N'Sitka')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (7, 4, N'Mumbai')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (8, 4, N'Pune')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (9, 5, N'Ahmedabad')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (10, 5, N'Gandhinagar')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (11, 6, N'Panjim')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (12, 6, N'Vasco')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (13, 7, N'Ottawa')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (14, 7, N'Port Hope')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (15, 8, N'Chandler')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (16, 8, N'Princeville')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (17, 9, N'Carman')
INSERT [dbo].[citiy] ([CityId], [StateId], [CityName]) VALUES (18, 9, N'Roblin')
GO
INSERT [dbo].[country] ([CountryId], [CountryName]) VALUES (1, N'USA')
INSERT [dbo].[country] ([CountryId], [CountryName]) VALUES (2, N'India')
INSERT [dbo].[country] ([CountryId], [CountryName]) VALUES (3, N'Canada')
GO
INSERT [dbo].[state] ([StateId], [CountryId], [StateName]) VALUES (1, 1, N'Alabama')
INSERT [dbo].[state] ([StateId], [CountryId], [StateName]) VALUES (2, 1, N'Arizona')
INSERT [dbo].[state] ([StateId], [CountryId], [StateName]) VALUES (3, 1, N'Alaska')
INSERT [dbo].[state] ([StateId], [CountryId], [StateName]) VALUES (4, 2, N'Maharashtra')
INSERT [dbo].[state] ([StateId], [CountryId], [StateName]) VALUES (5, 2, N'Gujarat')
INSERT [dbo].[state] ([StateId], [CountryId], [StateName]) VALUES (6, 2, N'Goa')
INSERT [dbo].[state] ([StateId], [CountryId], [StateName]) VALUES (7, 3, N'Ontario')
INSERT [dbo].[state] ([StateId], [CountryId], [StateName]) VALUES (8, 3, N'Quebec')
INSERT [dbo].[state] ([StateId], [CountryId], [StateName]) VALUES (9, 3, N'Manitoba')
GO
ALTER TABLE [dbo].[citiy]  WITH CHECK ADD  CONSTRAINT [FK_citiy_state] FOREIGN KEY([StateId])
REFERENCES [dbo].[state] ([StateId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[citiy] CHECK CONSTRAINT [FK_citiy_state]
GO
ALTER TABLE [dbo].[state]  WITH CHECK ADD  CONSTRAINT [FK_state_country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[country] ([CountryId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[state] CHECK CONSTRAINT [FK_state_country]
GO
USE [master]
GO
ALTER DATABASE [cascadingDropDownListsDB] SET  READ_WRITE 
GO
