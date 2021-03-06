USE [master]
GO
/****** Object:  Database [schooldb]    Script Date: 5/26/2022 2:49:21 PM ******/
CREATE DATABASE [schooldb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'studentdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLCATDB\MSSQL\DATA\studentdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'studentdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLCATDB\MSSQL\DATA\studentdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [schooldb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [schooldb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [schooldb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [schooldb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [schooldb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [schooldb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [schooldb] SET ARITHABORT OFF 
GO
ALTER DATABASE [schooldb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [schooldb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [schooldb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [schooldb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [schooldb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [schooldb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [schooldb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [schooldb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [schooldb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [schooldb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [schooldb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [schooldb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [schooldb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [schooldb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [schooldb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [schooldb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [schooldb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [schooldb] SET RECOVERY FULL 
GO
ALTER DATABASE [schooldb] SET  MULTI_USER 
GO
ALTER DATABASE [schooldb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [schooldb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [schooldb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [schooldb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [schooldb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [schooldb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'schooldb', N'ON'
GO
ALTER DATABASE [schooldb] SET QUERY_STORE = OFF
GO
USE [schooldb]
GO
/****** Object:  Table [dbo].[coursetbl]    Script Date: 5/26/2022 2:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coursetbl](
	[id] [int] NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[credit] [nvarchar](50) NOT NULL,
	[description] [nvarchar](max) NULL,
	[price] [int] NULL,
	[level] [tinyint] NULL,
	[isactive] [bit] NOT NULL,
	[rating] [tinyint] NULL,
	[level2] [int] NULL,
 CONSTRAINT [PK_coursetbl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[funcGitCourseByTitle]    Script Date: 5/26/2022 2:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[funcGitCourseByTitle]
(
	@myTitle nvarchar(50)
)
returns table
as
return
(
	select * from coursetbl where title=@myTitle
)
GO
/****** Object:  Table [dbo].[couselevel]    Script Date: 5/26/2022 2:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[couselevel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[level] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[enrolltbl]    Script Date: 5/26/2022 2:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[enrolltbl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[courseid] [int] NOT NULL,
	[studentid] [int] NOT NULL,
	[grade] [decimal](4, 1) NULL,
 CONSTRAINT [PK_enrolltbl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studenttbl]    Script Date: 5/26/2022 2:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studenttbl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fname] [nvarchar](50) NOT NULL,
	[lname] [nvarchar](50) NOT NULL,
	[enrolldate] [date] NULL,
	[imgPath] [nvarchar](250) NULL,
 CONSTRAINT [PK_studenttbl] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (1, N'asp.net', N'15', NULL, NULL, NULL, 0, NULL, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (2, N'php', N'19', NULL, NULL, NULL, 0, NULL, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (3, N'python', N'4', NULL, NULL, NULL, 0, NULL, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (6, N'c#', N'33', N'eee', NULL, 1, 1, NULL, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (7, N'proj', N'4', NULL, NULL, 1, 0, NULL, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (8, N'p', N'5', NULL, NULL, 2, 1, 4, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (22, N'ttt', N'3', NULL, NULL, NULL, 0, 4, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (44, N'444', N'3', NULL, NULL, NULL, 0, 2, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (88, N'js', N'4', N'dsds', NULL, NULL, 0, 2, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (90, N'uu', N'9', NULL, NULL, 1, 1, NULL, NULL)
GO
INSERT [dbo].[coursetbl] ([id], [title], [credit], [description], [price], [level], [isactive], [rating], [level2]) VALUES (889, N'ppp', N'3', NULL, NULL, NULL, 0, 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[couselevel] ON 
GO
INSERT [dbo].[couselevel] ([id], [level]) VALUES (1, N'Beginner')
GO
INSERT [dbo].[couselevel] ([id], [level]) VALUES (2, N'Intermediate')
GO
INSERT [dbo].[couselevel] ([id], [level]) VALUES (3, N'Advanced')
GO
INSERT [dbo].[couselevel] ([id], [level]) VALUES (4, N'Insane')
GO
SET IDENTITY_INSERT [dbo].[couselevel] OFF
GO
SET IDENTITY_INSERT [dbo].[enrolltbl] ON 
GO
INSERT [dbo].[enrolltbl] ([id], [courseid], [studentid], [grade]) VALUES (2, 2, 9, CAST(66.0 AS Decimal(4, 1)))
GO
INSERT [dbo].[enrolltbl] ([id], [courseid], [studentid], [grade]) VALUES (3, 1, 9, CAST(80.0 AS Decimal(4, 1)))
GO
INSERT [dbo].[enrolltbl] ([id], [courseid], [studentid], [grade]) VALUES (4, 6, 9, CAST(90.0 AS Decimal(4, 1)))
GO
SET IDENTITY_INSERT [dbo].[enrolltbl] OFF
GO
SET IDENTITY_INSERT [dbo].[studenttbl] ON 
GO
INSERT [dbo].[studenttbl] ([id], [fname], [lname], [enrolldate], [imgPath]) VALUES (5, N'haitham', N'maged', NULL, NULL)
GO
INSERT [dbo].[studenttbl] ([id], [fname], [lname], [enrolldate], [imgPath]) VALUES (7, N'mazen', N'maged', NULL, N'Capture2.PNG')
GO
INSERT [dbo].[studenttbl] ([id], [fname], [lname], [enrolldate], [imgPath]) VALUES (8, N'mazen', N'maged', NULL, N'Capture.PNG')
GO
INSERT [dbo].[studenttbl] ([id], [fname], [lname], [enrolldate], [imgPath]) VALUES (9, N'asmaa', N'm', CAST(N'2022-04-05' AS Date), N'vlcsnap-2022-04-23-15h53m26s039.png')
GO
INSERT [dbo].[studenttbl] ([id], [fname], [lname], [enrolldate], [imgPath]) VALUES (10, N'khadija', N'haitham', CAST(N'2022-04-05' AS Date), N'adorable-ga782433a8_1920.jpg')
GO
INSERT [dbo].[studenttbl] ([id], [fname], [lname], [enrolldate], [imgPath]) VALUES (11, N'maged', N'haitham', CAST(N'2022-04-07' AS Date), N'dog-g7ede5af9e_1920.jpg')
GO
INSERT [dbo].[studenttbl] ([id], [fname], [lname], [enrolldate], [imgPath]) VALUES (12, N'hiam', N'maged', CAST(N'2022-04-30' AS Date), N'dog-gf256c5066_1920.jpg')
GO
INSERT [dbo].[studenttbl] ([id], [fname], [lname], [enrolldate], [imgPath]) VALUES (13, N'hamed', N'maged', CAST(N'2022-04-29' AS Date), N'touch-ga902e5483_1920.jpg')
GO
SET IDENTITY_INSERT [dbo].[studenttbl] OFF
GO
/****** Object:  Index [IX_enrolltbl]    Script Date: 5/26/2022 2:49:21 PM ******/
CREATE NONCLUSTERED INDEX [IX_enrolltbl] ON [dbo].[enrolltbl]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[coursetbl] ADD  CONSTRAINT [DF_coursetbl_isactive]  DEFAULT ((0)) FOR [isactive]
GO
ALTER TABLE [dbo].[coursetbl]  WITH CHECK ADD FOREIGN KEY([level2])
REFERENCES [dbo].[couselevel] ([id])
GO
ALTER TABLE [dbo].[enrolltbl]  WITH CHECK ADD  CONSTRAINT [FK_enrolltbl_coursetbl] FOREIGN KEY([courseid])
REFERENCES [dbo].[coursetbl] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[enrolltbl] CHECK CONSTRAINT [FK_enrolltbl_coursetbl]
GO
ALTER TABLE [dbo].[enrolltbl]  WITH CHECK ADD  CONSTRAINT [FK_enrolltbl_studenttbl] FOREIGN KEY([studentid])
REFERENCES [dbo].[studenttbl] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[enrolltbl] CHECK CONSTRAINT [FK_enrolltbl_studenttbl]
GO
/****** Object:  StoredProcedure [dbo].[getCourses]    Script Date: 5/26/2022 2:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getCourses]

as
	select * from coursetbl	
GO
/****** Object:  StoredProcedure [dbo].[insertCourse]    Script Date: 5/26/2022 2:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertCourse]
(
	@mytitle nvarchar(255),
	@mycredits int
)
as
	insert into coursetbl (title,credit)
	values (@mytitle,@mycredits)
GO
USE [master]
GO
ALTER DATABASE [schooldb] SET  READ_WRITE 
GO
