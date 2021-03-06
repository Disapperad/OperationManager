USE [master]
GO
/****** Object:  Database [SeaphonServer]    Script Date: 20.05.2022 15:19:08 ******/
CREATE DATABASE [SeaphonServer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SeaphonServer', FILENAME = N'C:\Users\Student\SeaphonServer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SeaphonServer_log', FILENAME = N'C:\Users\Student\SeaphonServer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SeaphonServer] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SeaphonServer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SeaphonServer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SeaphonServer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SeaphonServer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SeaphonServer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SeaphonServer] SET ARITHABORT OFF 
GO
ALTER DATABASE [SeaphonServer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SeaphonServer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SeaphonServer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SeaphonServer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SeaphonServer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SeaphonServer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SeaphonServer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SeaphonServer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SeaphonServer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SeaphonServer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SeaphonServer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SeaphonServer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SeaphonServer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SeaphonServer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SeaphonServer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SeaphonServer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SeaphonServer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SeaphonServer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SeaphonServer] SET  MULTI_USER 
GO
ALTER DATABASE [SeaphonServer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SeaphonServer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SeaphonServer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SeaphonServer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SeaphonServer] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SeaphonServer] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SeaphonServer] SET QUERY_STORE = OFF
GO
USE [SeaphonServer]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 20.05.2022 15:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [nvarchar](17) NOT NULL,
	[FullName] [nvarchar](100) NULL,
	[Cash] [money] NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operations]    Script Date: 20.05.2022 15:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountFrom] [int] NULL,
	[AccountTo] [int] NULL,
	[OperationType] [int] NOT NULL,
	[OperationDate] [date] NOT NULL,
	[OperationTime] [time](7) NOT NULL,
	[Cash] [money] NOT NULL,
 CONSTRAINT [PK_Operations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD FOREIGN KEY([AccountFrom])
REFERENCES [dbo].[Accounts] ([ID])
GO
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD FOREIGN KEY([AccountTo])
REFERENCES [dbo].[Accounts] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[AddAccount]    Script Date: 20.05.2022 15:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddAccount]
@AccountID NVARCHAR(17) = NULL,
@FullName NVARCHAR(17) = NULL
AS
INSERT INTO dbo.Accounts(AccountID, FullName, Cash)
VALUES (@AccountID, @FullName, 0)
GO
/****** Object:  StoredProcedure [dbo].[ExecuteOperation]    Script Date: 20.05.2022 15:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExecuteOperation]
@AccountTo nvarchar(17) = NULL,
@AccountFrom nvarchar(17) = NULL,
@OperationType int = NULL,
@Cash money = NULL,
@ActionID int = NULL
AS
DECLARE @AccountFromID int
DECLARE @AccountToID int
DECLARE @FromCash Money
DECLARE @ToCash Money

DECLARE @FF NVARCHAR
BEGIN TRANSACTION

SET @AccountFromID = (SELECT dbo.Accounts.ID
FROM dbo.Accounts INNER JOIN dbo.Operations ON dbo.Accounts.AccountID = dbo.Operations.AccountFrom)

SET @AccountToID = (SELECT dbo.Accounts.ID
FROM dbo.Accounts INNER JOIN dbo.Operations ON dbo.Accounts.AccountID = dbo.Operations.AccountTo)

SET @FromCash = (SELECT dbo.Accounts.Cash
FROM dbo.Accounts INNER JOIN dbo.Operations ON dbo.Accounts.AccountID = dbo.Operations.AccountFrom)

SET @ToCash = (SELECT dbo.Accounts.Cash
FROM dbo.Accounts INNER JOIN dbo.Operations ON dbo.Accounts.AccountID = dbo.Operations.AccountTo)

SET @FF = (SELECT FullName
FROM dbo.Accounts INNER JOIN dbo.Operations ON dbo.Accounts.AccountID = dbo.Operations.ID)

IF (@FF IS NOT NULL)
	BEGIN
		IF (@AccountTo is NOT NULL AND @AccountFrom is NOT NULL) AND (@FromCash >= @ToCash)
			BEGIN
				UPDATE Accounts SET Cash = @FromCash - @ToCash WHERE ID = @AccountFromID;
				UPDATE Accounts SET Cash = @ToCash + @FromCash WHERE ID = @AccountToID;
			END
		ELSE
			BEGIN
				ROLLBACK TRANSACTION
			END
	 END
ELSE
	BEGIN
		IF (@ActionID = 1) AND (@FromCash >= @Cash) AND (@ToCash >= @Cash)
			BEGIN
				UPDATE Accounts SET Cash = @FromCash - @Cash WHERE ID = @AccountFromID;
				UPDATE Accounts SET Cash = @ToCash - @Cash WHERE ID = @AccountToID;
			END
			ELSE
				BEGIN
					ROLLBACK TRANSACTION
				END
		IF (@ActionID = 2)
			BEGIN
				UPDATE Accounts SET Cash = @FromCash + @Cash WHERE ID = @AccountFromID;
				UPDATE Accounts SET Cash = @FromCash + @Cash WHERE ID = @AccountToID;
			END
	END
COMMIT TRANSACTION

INSERT INTO Operations(AccountFrom, AccountTo, OperationType, OperationDate, OperationTime, Cash)
VALUES (@AccountFromID, @AccountToID, @OperationType, CONVERT(date, CURRENT_TIMESTAMP), CONVERT(time, CURRENT_TIMESTAMP), @Cash)
GO
/****** Object:  StoredProcedure [dbo].[RemoveAccount]    Script Date: 20.05.2022 15:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoveAccount]
@ID int
AS
DELETE FROM Accounts WHERE ID = @ID;
GO
/****** Object:  StoredProcedure [dbo].[SearchAccounts]    Script Date: 20.05.2022 15:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchAccounts]
@ID int = NULL,
@AccountID int = NULL,
@FullName nvarchar(100) = NULL,
@Cash money = NULL,
@Cash2 money = NULL 
AS
SELECT TOP 25 * FROM Accounts WHERE 
(@ID IS NULL OR ID = @ID)
AND
(@AccountID IS NULL OR AccountID = @AccountID)
AND
(@FullName IS NULL OR FullName = @FullName)
AND
(@Cash IS NULL OR Cash <= @Cash)
AND
(@Cash2 IS NULL OR Cash >= @Cash2)
GO
/****** Object:  StoredProcedure [dbo].[SearchOperations]    Script Date: 20.05.2022 15:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchOperations]
@ID int = NULL,
@AccountTo int = NULL,
@AccountFrom int = NULL,
@OperationType int = NULL,
@OperationDate date = NULL,
@OperationDate2 date = NULL,
@OperationTime time(7) = NULL,
@Cash money = NULL,
@Cash2 money = NULL
AS
SELECT TOP 25 * FROM Operations WHERE
(@ID IS NULL OR ID = @ID)
AND
(@AccountTo IS NULL OR AccountTo = @AccountTo)
AND
(@AccountFrom IS NULL OR AccountFrom = @AccountFrom)
AND
(@OperationType IS NULL OR OperationDate = @OperationDate)
AND
(@OperationDate IS NULL OR OperationDate BETWEEN @OperationDate AND @OperationDate2)
AND
(@Cash IS NULL OR Cash <= @Cash)
AND
(@Cash2 IS NULL OR Cash >= @Cash2)
GO
USE [master]
GO
ALTER DATABASE [SeaphonServer] SET  READ_WRITE 
GO
