USE [master]
GO
/****** Object:  Database [Yonetim]    Script Date: 6.02.2019 18:17:12 ******/
CREATE DATABASE [Yonetim]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Yonetim', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.YENI\MSSQL\DATA\Yonetim.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Yonetim_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.YENI\MSSQL\DATA\Yonetim_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Yonetim] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Yonetim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Yonetim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Yonetim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Yonetim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Yonetim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Yonetim] SET ARITHABORT OFF 
GO
ALTER DATABASE [Yonetim] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Yonetim] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Yonetim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Yonetim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Yonetim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Yonetim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Yonetim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Yonetim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Yonetim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Yonetim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Yonetim] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Yonetim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Yonetim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Yonetim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Yonetim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Yonetim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Yonetim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Yonetim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Yonetim] SET RECOVERY FULL 
GO
ALTER DATABASE [Yonetim] SET  MULTI_USER 
GO
ALTER DATABASE [Yonetim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Yonetim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Yonetim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Yonetim] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Yonetim', N'ON'
GO
USE [Yonetim]
GO
/****** Object:  StoredProcedure [dbo].[sprehberkayitduzenle]    Script Date: 6.02.2019 18:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sprehberkayitduzenle]
(
@ID uniqueidentifier,
@kullaniciadi nchar(10),
@sifre nchar(10),
@adi nchar(20),
@soyadi nchar(20),
@eposta nchar(30)

)
as
begin
Update Kullanicilar Set kullaniciadi=@kullaniciadi,sifre=@sifre,adi=@adi,soyadi=@soyadi,eposta=@eposta where ID=@ID
end

GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 6.02.2019 18:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[ID] [uniqueidentifier] NOT NULL,
	[kullaniciadi] [nvarchar](10) NULL,
	[sifre] [nvarchar](10) NULL,
	[adi] [nvarchar](20) NULL,
	[soyadi] [nvarchar](20) NULL,
	[eposta] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Yetkiler]    Script Date: 6.02.2019 18:17:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetkiler](
	[ID] [uniqueidentifier] NULL,
	[kullaniciadi] [nvarchar](10) NULL,
	[sifre] [nvarchar](10) NULL,
	[kullaniciyetki] [nvarchar](15) NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [Yonetim] SET  READ_WRITE 
GO
