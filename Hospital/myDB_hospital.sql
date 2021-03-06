﻿USE [master]
GO
/****** Object:  Database [MyDB]    Script Date: 05/02/2020 9:24:11 PM ******/
CREATE DATABASE [MyDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MyDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MyDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MyDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MyDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MyDB] SET  MULTI_USER 
GO
ALTER DATABASE [MyDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MyDB]
GO
/****** Object:  Table [dbo].[Hospital.Autentification]    Script Date: 2/9/2017 9:24:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.Autentification](
	[idPosition] [int] NOT NULL,
	[idService] [int] NOT NULL,
 CONSTRAINT [PK_Hospital.Autentification_1] PRIMARY KEY CLUSTERED 
(
	[idPosition] ASC,
	[idService] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.Doctor]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.Doctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[idSpeciality] [int] NULL,
 CONSTRAINT [PK_Hospital.Doctor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.HistoryPatientAndDoctor]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.HistoryPatientAndDoctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPatient] [int] NULL,
	[idDoctor] [int] NULL,
	[idSick] [int] NULL,
 CONSTRAINT [PK_Hospital.HistoryPatientAndDoctor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.HistoryPatientAndDoctor_Shader]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.HistoryPatientAndDoctor_Shader](
	[Shid] [int] IDENTITY(1,1) NOT NULL,
	[ShTimesTamp] [datetime2](7) NULL,
	[ShOperations] [varchar](1) NULL,
	[id] [int] NULL,
	[idPatient] [int] NULL,
	[idDoctor] [int] NULL,
	[idSick] [int] NULL,
 CONSTRAINT [PK_Hospital.HistoryPatientAndDoctor_Shader] PRIMARY KEY CLUSTERED 
(
	[Shid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.Patient]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.Patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[idCard] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[birthday] [datetime2](7) NULL,
	[number] [varchar](50) NULL,
 CONSTRAINT [PK_Hospital.Patient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.Position]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.Position](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_Hospital.Position] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.Service]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.Service](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[discription] [varchar](255) NULL,
 CONSTRAINT [PK_Hospital.Service] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.Sick]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.Sick](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[discription] [varchar](255) NULL,
 CONSTRAINT [PK_Hospital.Sick] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.Speciality]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.Speciality](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[discribe] [varchar](255) NULL,
 CONSTRAINT [PK_Hospital.Speciality] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.User]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[idPosition] [int] NULL,
 CONSTRAINT [PK_Hospital.User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospital.Visit]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospital.Visit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idDoctor] [int] NULL,
	[dateTime] [datetime] NULL,
	[idPatient] [int] NULL,
 CONSTRAINT [PK_Hospital.Visit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[DoctorView]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DoctorView]
as
SELECT D.[id]
      ,[firstName]
      ,[lastName]
	  ,S.[name] AS [Speciality]
  FROM [Hospital.Doctor] AS D JOIN [Hospital.Speciality] AS S ON [idSpeciality] = S.id
GO
/****** Object:  View [dbo].[HistoryView]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HistoryView]
AS
SELECT HistPandD.[id]
      ,HistPandD.[idPatient]
	  ,P.firstName + ' ' + P.lastName AS NamePatient
	  ,P.idCard
	  ,P.[address]
	  ,P.birthday
	  ,P.number
      ,HistPandD.[idDoctor]
	  ,D.firstName + ' ' + D.lastName AS NameDoctor
      ,HistPandD.[idSick]
	  ,S.[name]
	  ,S.discription
  FROM [Hospital.HistoryPatientAndDoctor] AS HistPandD
	JOIN [Hospital.Patient] AS P
		ON idPatient = P.id
	JOIN [Hospital.Doctor] AS D
		ON idDoctor = D.id
	JOIN [Hospital.Sick] AS S
		ON idSick = S.id;
GO
/****** Object:  View [dbo].[PatientView]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PatientView]
AS
SELECT [id]
      ,[firstName]
      ,[lastName]
      ,[idCard]
      ,[address]
      ,[birthday]
      ,[number]
  FROM [Hospital.Patient]
GO
/****** Object:  View [dbo].[SickView]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SickView]
AS
SELECT [id]
      ,[name]
      ,[discription]
  FROM [Hospital.Sick]
GO
/****** Object:  View [dbo].[SpecialityView]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SpecialityView]
AS
SELECT [id]
      ,[name]
      ,[discribe]
  FROM [Hospital.Speciality]
GO
ALTER TABLE [dbo].[Hospital.Autentification]  WITH CHECK ADD  CONSTRAINT [FK_Hospital.Autentification_Hospital.Position] FOREIGN KEY([idPosition])
REFERENCES [dbo].[Hospital.Position] ([id])
GO
ALTER TABLE [dbo].[Hospital.Autentification] CHECK CONSTRAINT [FK_Hospital.Autentification_Hospital.Position]
GO
ALTER TABLE [dbo].[Hospital.Autentification]  WITH CHECK ADD  CONSTRAINT [FK_Hospital.Autentification_Hospital.Service] FOREIGN KEY([idService])
REFERENCES [dbo].[Hospital.Service] ([id])
GO
ALTER TABLE [dbo].[Hospital.Autentification] CHECK CONSTRAINT [FK_Hospital.Autentification_Hospital.Service]
GO
ALTER TABLE [dbo].[Hospital.Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Hospital.Doctor_Hospital.Speciality] FOREIGN KEY([idSpeciality])
REFERENCES [dbo].[Hospital.Speciality] ([id])
GO
ALTER TABLE [dbo].[Hospital.Doctor] CHECK CONSTRAINT [FK_Hospital.Doctor_Hospital.Speciality]
GO
ALTER TABLE [dbo].[Hospital.HistoryPatientAndDoctor]  WITH CHECK ADD  CONSTRAINT [FK_Hospital.HistoryPatientAndDoctor_Hospital.Doctor] FOREIGN KEY([idDoctor])
REFERENCES [dbo].[Hospital.Doctor] ([id])
GO
ALTER TABLE [dbo].[Hospital.HistoryPatientAndDoctor] CHECK CONSTRAINT [FK_Hospital.HistoryPatientAndDoctor_Hospital.Doctor]
GO
ALTER TABLE [dbo].[Hospital.HistoryPatientAndDoctor]  WITH CHECK ADD  CONSTRAINT [FK_Hospital.HistoryPatientAndDoctor_Hospital.Patient] FOREIGN KEY([idPatient])
REFERENCES [dbo].[Hospital.Patient] ([id])
GO
ALTER TABLE [dbo].[Hospital.HistoryPatientAndDoctor] CHECK CONSTRAINT [FK_Hospital.HistoryPatientAndDoctor_Hospital.Patient]
GO
ALTER TABLE [dbo].[Hospital.HistoryPatientAndDoctor]  WITH CHECK ADD  CONSTRAINT [FK_Hospital.HistoryPatientAndDoctor_Hospital.Sick] FOREIGN KEY([idSick])
REFERENCES [dbo].[Hospital.Sick] ([id])
GO
ALTER TABLE [dbo].[Hospital.HistoryPatientAndDoctor] CHECK CONSTRAINT [FK_Hospital.HistoryPatientAndDoctor_Hospital.Sick]
GO
ALTER TABLE [dbo].[Hospital.User]  WITH CHECK ADD  CONSTRAINT [FK_Hospital.User_Hospital.Position] FOREIGN KEY([idPosition])
REFERENCES [dbo].[Hospital.Position] ([id])
GO
ALTER TABLE [dbo].[Hospital.User] CHECK CONSTRAINT [FK_Hospital.User_Hospital.Position]
GO
ALTER TABLE [dbo].[Hospital.Visit]  WITH CHECK ADD  CONSTRAINT [FK_Hospital.Visit_Hospital.Doctor] FOREIGN KEY([idDoctor])
REFERENCES [dbo].[Hospital.Doctor] ([id])
GO
ALTER TABLE [dbo].[Hospital.Visit] CHECK CONSTRAINT [FK_Hospital.Visit_Hospital.Doctor]
GO
ALTER TABLE [dbo].[Hospital.Visit]  WITH CHECK ADD  CONSTRAINT [FK_Hospital.Visit_Hospital.Patient] FOREIGN KEY([idPatient])
REFERENCES [dbo].[Hospital.Patient] ([id])
GO
ALTER TABLE [dbo].[Hospital.Visit] CHECK CONSTRAINT [FK_Hospital.Visit_Hospital.Patient]
GO
/****** Object:  StoredProcedure [dbo].[AutentificationList]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AutentificationList]
	 @idPosition INT
AS
BEGIN
	SELECT S.id, S.[name], S.discription
	FROM [Hospital.Autentification] AS A 
	JOIN [Hospital.Service] AS S
	ON A.idService = S.id
	WHERE @idPosition = A.idPosition
END;
GO
/****** Object:  StoredProcedure [dbo].[DoctorDelete]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DoctorDelete]
	@ID int
AS
BEGIN
	DELETE FROM [Hospital.Doctor] WHERE id=@ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DoctorInsert]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DoctorInsert]
	@firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @idSpeciality INT,
	@ID int output
AS
BEGIN
	INSERT INTO [Hospital.Doctor]([firstName], [lastName], [idSpeciality])
	VALUES (@firstName, @lastName, @idSpeciality);
	SET @ID = @@identity;
END;
GO
/****** Object:  StoredProcedure [dbo].[DoctorSelect]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DoctorSelect]
AS
BEGIN
	SELECT D.[id]
      ,[firstName]
      ,[lastName]
	  ,[firstName] + ' ' + [lastName] AS DoctorName
      ,S.[name] AS [Speciality]
	  FROM [Hospital.Doctor] AS D JOIN [Hospital.Speciality] AS S ON D.idSpeciality = S.id;
END

GO
/****** Object:  StoredProcedure [dbo].[DoctorUpdate]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DoctorUpdate]
	@firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @idSpeciality INT,
	@ID int
AS
BEGIN
	UPDATE [Hospital.Doctor]
	SET 
		[firstName] = @firstName, 
		[lastName] = @lastName, 
		[idSpeciality] = @idSpeciality
	WHERE id = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[HistoryPatientAndDoctorDelete]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HistoryPatientAndDoctorDelete]
						@id int
AS BEGIN
INSERT INTO [Hospital.HistoryPatientAndDoctor_Shader] ([ShTimesTamp], [ShOperations], [id], [idPatient], [idDoctor], [idSick])
SELECT CURRENT_TIMESTAMP, 'D', [id], [idPatient], [idDoctor], [idSick]
FROM [Hospital.HistoryPatientAndDoctor]
WHERE id = @id;
DELETE FROM [Hospital.HistoryPatientAndDoctor]
WHERE id = @id
END;
GO
/****** Object:  StoredProcedure [dbo].[HistoryPatientAndDoctorInsert]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HistoryPatientAndDoctorInsert]
	@idPatient INT,
    @idDoctor INT,
    @idSick INT,
	@ID int output
AS
BEGIN
	INSERT INTO [Hospital.HistoryPatientAndDoctor]([idPatient], [idDoctor], [idSick])
	VALUES (@idPatient, @idDoctor, @idSick);
	SET @ID = @@identity;
END;
GO
/****** Object:  StoredProcedure [dbo].[HistoryPatientAndDoctorSelect]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HistoryPatientAndDoctorSelect]
AS
BEGIN
	SELECT [id]
      ,[idPatient]
      ,[idDoctor]
      ,[idSick]
	FROM [Hospital.HistoryPatientAndDoctor];
END;
GO
/****** Object:  StoredProcedure [dbo].[HistoryPatientAndDoctorUpdate]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HistoryPatientAndDoctorUpdate]
						@id int, 
						@idPatient INT,
						@idDoctor INT,
						@idSick INT
AS BEGIN
INSERT INTO [Hospital.HistoryPatientAndDoctor_Shader] ([ShTimesTamp], [ShOperations], [id], [idPatient], [idDoctor], [idSick])
SELECT CURRENT_TIMESTAMP, 'U', [id], [idPatient], [idDoctor], [idSick]
FROM [Hospital.HistoryPatientAndDoctor]
WHERE id = @id;
UPDATE [Hospital.HistoryPatientAndDoctor]
SET
	[idPatient] = @idPatient,
	[idDoctor] = @idDoctor,
	[idSick] = @idSick
WHERE id = @id
END;
GO
/****** Object:  StoredProcedure [dbo].[PatientDelete]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PatientDelete]
@ID int
AS
BEGIN
	DELETE FROM [Hospital.Patient] WHERE id=@ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[PatientInsert]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PatientInsert]
	@firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @idCard VARCHAR(50),
	@address VARCHAR(50),
	@birthday DATETIME2(7),
	@number VARCHAR(50),
	@id int output
AS
BEGIN
	INSERT INTO [Hospital.Patient]([firstName], [lastName], [idCard], [address], [birthday], [number])
	VALUES (@firstName, @lastName, @idCard, @address, @birthday, @number);
	SET @id = @@identity;
END;
GO
/****** Object:  StoredProcedure [dbo].[PatientSelect]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PatientSelect]
AS
BEGIN
SELECT [id]
      ,[firstName]
      ,[lastName]
	  ,[firstName] + ' ' + [lastName] AS PatientName
      ,[idCard]
      ,[address]
      ,[birthday]
      ,[number]
  FROM [Hospital.Patient]
END;
GO
/****** Object:  StoredProcedure [dbo].[PatientUpdate]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PatientUpdate]
	@firstName VARCHAR(50),
    @lastName VARCHAR(50),
    @idCard VARCHAR(50),
	@address VARCHAR(50),
	@birthday DATETIME2(7),
	@number VARCHAR(50),
	@id int 
AS
BEGIN
	UPDATE [Hospital.Patient]
	SET 
		[firstName] = @firstName, 
		[lastName] = @lastName, 
		[idCard] = @idCard,
		[address] = @address,
		[birthday] = @birthday,
		[number] = @number
	WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SickDelete]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SickDelete]
@ID int
AS
BEGIN
	DELETE FROM [Hospital.Sick] WHERE id=@ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[SickInsert]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SickInsert]
	@name VARCHAR(50),
    @discription VARCHAR(255),
	@id int output
AS
BEGIN
	INSERT INTO [Hospital.Sick]([name], [discription])
	VALUES (@name, @discription);
	SET @id = @@identity;
END;
GO
/****** Object:  StoredProcedure [dbo].[SickSelect]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SickSelect]
AS
BEGIN
SELECT [id]
      ,[name]
      ,[discription]
  FROM [MyDB].[dbo].[Hospital.Sick]
END;
GO
/****** Object:  StoredProcedure [dbo].[SickUpdate]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SickUpdate]
	@name VARCHAR(50),
    @discription VARCHAR(255),
	@id int 
AS
BEGIN
	UPDATE [Hospital.Sick]
	SET 
		[name] = @name, 
		[discription] = @discription 
	WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SpecialityDelete]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpecialityDelete]
@ID int
AS
BEGIN
	DELETE FROM [Hospital.Speciality] WHERE id=@ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[SpecialityInsert]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpecialityInsert]
	@name VARCHAR(50),
    @discribe VARCHAR(255),
	@id int output
AS
BEGIN
	INSERT INTO [Hospital.Speciality]([name], [discribe])
	VALUES (@name, @discribe);
	SET @id = @@identity;
END;
GO
/****** Object:  StoredProcedure [dbo].[SpecialitySelect]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpecialitySelect]
AS
BEGIN
SELECT [id]
      ,[name]
      ,[discribe]
  FROM [MyDB].[dbo].[Hospital.Speciality]
END;
GO
/****** Object:  StoredProcedure [dbo].[SpecialityUpdate]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SpecialityUpdate]
	@name VARCHAR(50),
    @discribe VARCHAR(255),
	@id int 
AS
BEGIN
	UPDATE [Hospital.Speciality]
	SET 
		[name] = @name, 
		[discribe] = @discribe 
	WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[UserGet]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserGet]
	 @UserId int
	,@firstName VARCHAR(50) OUTPUT
	,@lastName VARCHAR(50) OUTPUT
	,@idPosition INT OUTPUT
	,@namePosition VARCHAR(50) OUTPUT
AS
BEGIN
	SELECT @firstName = firstName
		  ,@lastName = lastName
		  ,@idPosition = idPosition
		  ,@namePosition = P.[name]
	FROM [Hospital.User] AS U
	JOIN [Hospital.Position] AS P
	ON idPosition = P.id
	WHERE U.id = @UserId
END;
GO
/****** Object:  StoredProcedure [dbo].[UserLogin]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UserLogin]
	 @Login VARCHAR(50)
	,@Password VARCHAR(50)
	,@UserId int output
	,@ErrorId int output
AS
BEGIN
	SELECT @UserId = id
	FROM [Hospital.User]
	WHERE [login] = @Login and [password] = @Password
	IF (@UserId is NULL)
	BEGIN
		SET @UserId = -1;
		SET @ErrorID = 1;
	END;
	ELSE
	BEGIN
		SET @ErrorID = 0;
	END;
END;
GO
/****** Object:  StoredProcedure [dbo].[VisitDelete]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitDelete]
	@id int
AS
BEGIN
	DELETE FROM [Hospital.Visit] WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[VisitInsert]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitInsert]
	@idDoctor int,
	@dateTime datetime,
	@idPatient int,
	@id int output
AS
BEGIN
	INSERT INTO [Hospital.Visit]([idDoctor], [dateTime], [idPatient])
	VALUES (@idDoctor, @dateTime, @idPatient);
	SET @id = @@identity;
END;
GO
/****** Object:  StoredProcedure [dbo].[VisitSelect]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitSelect]
AS
BEGIN
SELECT V.[id]
      ,D.firstName + ' ' + D.lastName AS Doctor
      ,[dateTime]
      ,P.firstName + ' ' + P.lastName AS Patient
  FROM [Hospital.Visit] AS V JOIN [Hospital.Patient] AS P ON [idPatient] = P.id
							 JOIN [Hospital.Doctor] AS D ON [idDoctor] = D.id
END;
GO
/****** Object:  StoredProcedure [dbo].[VisitSelectParticular]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitSelectParticular]
	@ID INT
AS
BEGIN
SELECT V.[id]
      ,D.firstName + ' ' + D.lastName AS Doctor
      ,[dateTime]
      ,P.firstName + ' ' + P.lastName AS Patient
  FROM [Hospital.Visit] AS V JOIN [Hospital.Patient] AS P ON [idPatient] = P.id
							 JOIN [Hospital.Doctor] AS D ON [idDoctor] = D.id
		WHERE V.id = @ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[VisitUpdate]    Script Date: 2/9/2017 9:24:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitUpdate] 
	@idDoctor int,
	@dateTime datetime,
	@idPatient int,
	@id int
AS
BEGIN
UPDATE [Hospital.Visit]
	SET 
		[idDoctor] = @idDoctor, 
		[dateTime] = @dateTime, 
		[idPatient] = @idPatient
	WHERE id = @id;
END;
GO
USE [master]
GO
ALTER DATABASE [MyDB] SET  READ_WRITE 
GO
