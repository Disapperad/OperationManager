USE [master]
GO
/****** Object:  Database [SeaphonServer]    Script Date: 23.05.2022 15:54:39 ******/
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
/****** Object:  Table [dbo].[Accounts]    Script Date: 23.05.2022 15:54:39 ******/
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
/****** Object:  Table [dbo].[Operations]    Script Date: 23.05.2022 15:54:39 ******/
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
	[OperationTime] [time](0) NOT NULL,
	[Cash] [money] NOT NULL,
	[Status] [bit] NOT NULL,
	[Reason] [int] NULL,
 CONSTRAINT [PK_Operations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TemporalyOperations]    Script Date: 23.05.2022 15:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TemporalyOperations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountFrom] [int] NULL,
	[AccountTo] [int] NULL,
	[OperationType] [int] NOT NULL,
	[OperationDate] [date] NOT NULL,
	[OperationTime] [time](0) NOT NULL,
	[Cash] [money] NOT NULL,
	[Status] [bit] NOT NULL,
	[Reason] [int] NULL,
 CONSTRAINT [PK_TemporalyOperations] PRIMARY KEY CLUSTERED 
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
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD FOREIGN KEY([AccountFrom])
REFERENCES [dbo].[Accounts] ([ID])
GO
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD FOREIGN KEY([AccountTo])
REFERENCES [dbo].[Accounts] ([ID])
GO
ALTER TABLE [dbo].[TemporalyOperations]  WITH CHECK ADD FOREIGN KEY([AccountFrom])
REFERENCES [dbo].[Accounts] ([ID])
GO
ALTER TABLE [dbo].[TemporalyOperations]  WITH CHECK ADD FOREIGN KEY([AccountTo])
REFERENCES [dbo].[Accounts] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[AddAccount]    Script Date: 23.05.2022 15:54:39 ******/
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
/****** Object:  StoredProcedure [dbo].[ExecuteOperation]    Script Date: 23.05.2022 15:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ExecuteOperation]
@AccountTo nvarchar(17) = NULL,
@AccountFrom nvarchar(17) = NULL,
@Cash money = NULL
AS

DECLARE @AccountFromID int
DECLARE @AccountToID int
DECLARE @FromCash Money
DECLARE @ToCash Money

DECLARE @FullNameFrom NVARCHAR = NULL
DECLARE @FullNameTo NVARCHAR = NULL

BEGIN TRANSACTION

SELECT @AccountFromID = ID, @FromCash = Cash, @FullNameFrom = FullName
FROM Accounts WHERE AccountID = @AccountFrom

IF (@AccountFromID IS NULL)
	BEGIN 
		ROLLBACK TRANSACTION
		RETURN
	END


SELECT @AccountToID = ID, @ToCash = Cash, @FullNameTo = FullName
FROM Accounts WHERE AccountID = @AccountTo

IF (@AccountFromID IS NULL)
	BEGIN 
		ROLLBACK TRANSACTION
		RETURN
	END

PRINT(@FullNameFrom)
PRINT(@FullNameTo)

-- Если это перевод денежных средств, то 
IF (@FullNameFrom IS NOT NULL AND @FullNameTo IS NOT NULL)
	BEGIN
	-- Проверяем хватает ли денег у отправителя.
		IF (@FromCash >= @Cash)
			BEGIN
				-- Cнимаем денежные средства у отправителя.
				UPDATE Accounts SET Cash = @FromCash - @Cash WHERE ID = @AccountFromID;
				-- Отдаём их получателю.
				UPDATE Accounts SET Cash = @ToCash + @Cash WHERE ID = @AccountToID;
				-- Добавляем запись, что транзакция прошла успешно, а ёё тип - перевод.
				INSERT INTO dbo.Operations(AccountFrom, AccountTo, OperationType, OperationDate, OperationTime, Cash, [Status], Reason)
				VALUES (@AccountFromID, @AccountToID, 1, CONVERT(date, CURRENT_TIMESTAMP), CONVERT(time(7), CURRENT_TIMESTAMP), @Cash, 1, NULL)
				-- Выполняем транзакцию
				COMMIT TRANSACTION
				-- Делаем возврат, чтобы не выполнять следующие шаги.
				RETURN 999
			END
		ELSE
			BEGIN
			-- Если денег не хватает, то делаем запись о том, что транзакция была отклонена, так как денежных средств не хватило.
				INSERT INTO dbo.Operations(AccountFrom, AccountTo, OperationType, OperationDate, OperationTime, Cash, [Status], Reason)
				VALUES (@AccountFromID, @AccountToID, 1, CONVERT(date, CURRENT_TIMESTAMP), CONVERT(time(7), CURRENT_TIMESTAMP), @Cash, 0, 1)
				-- Выполняем транзакцию.
				COMMIT TRANSACTION
				-- Выход из функции.
				RETURN 998
			END
	END
ELSE 
	BEGIN
		-- Если операция - это снятие наличных
		IF (@FullNameFrom IS NULL AND @FullNameTo IS NOT NULL)
			BEGIN
			-- И денег больше, чем нужно выдать
				IF (@FromCash >= @Cash)
					BEGIN
						-- Вычитаем деньги и у банкомата и со счёта пользователя.
						UPDATE Accounts SET Cash = Cash - @Cash WHERE ID = @AccountFromID OR ID = @AccountToID;
						-- Добавляем запись, что транзакция прошла успешно, а ёё тип - снятие.
						INSERT INTO dbo.Operations(AccountFrom, AccountTo, OperationType, OperationDate, OperationTime, Cash, [Status], Reason)
						VALUES (@AccountFromID, @AccountToID, 2, CONVERT(date, CURRENT_TIMESTAMP), CONVERT(time(7), CURRENT_TIMESTAMP), @Cash, 1, NULL)
						-- Выполняем транзакцию.
						COMMIT TRANSACTION
						-- Выходим из функции.
						RETURN 997
					END
				ELSE
					BEGIN
						-- Добавляем запись, что транзакция прошла неудачно, а причина - это нехватка денег в банкомате.
						INSERT INTO dbo.Operations(AccountFrom, AccountTo, OperationType, OperationDate, OperationTime, Cash, [Status], Reason)
						VALUES (@AccountFromID, @AccountToID, 2, CONVERT(date, CURRENT_TIMESTAMP), CONVERT(time(7), CURRENT_TIMESTAMP), @Cash, 0, 2)
						-- Выполняем транзакцию.
						COMMIT TRANSACTION
						-- Выходим из функции.
						RETURN 996
					END
			END
		-- Если операция - это пополнение счёта
		IF (@FullNameFrom IS NOT NULL AND @FullNameTo IS NULL)
			BEGIN
				-- Добавляем деньги и банкомату и счёту
				UPDATE Accounts SET Cash = Cash + @Cash WHERE ID = @AccountFromID OR ID = @AccountToID;
				-- Добавляем запись об успешном пополнении
				INSERT INTO dbo.Operations(AccountFrom, AccountTo, OperationType, OperationDate, OperationTime, Cash, [Status], Reason)
				VALUES (@AccountFromID, @AccountToID, 3, CONVERT(date, CURRENT_TIMESTAMP), CONVERT(time(7), CURRENT_TIMESTAMP), @Cash, 1, NULL)
				-- Выполняем транзакцию.
				COMMIT TRANSACTION
				-- Выходим из функции.
				RETURN 995
			END
	END
GO
/****** Object:  StoredProcedure [dbo].[RemoveAccount]    Script Date: 23.05.2022 15:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoveAccount]
@ID int
AS
DELETE FROM Accounts WHERE ID = @ID;
GO
/****** Object:  StoredProcedure [dbo].[SearchAccounts]    Script Date: 23.05.2022 15:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchAccounts]
@ID int = NULL,
@AccountID nvarchar(17) = NULL,
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
/****** Object:  StoredProcedure [dbo].[SearchOperations]    Script Date: 23.05.2022 15:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchOperations]
@ID int = NULL,
@AccountTo Nvarchar(max) = NULL,
@AccountFrom Nvarchar(max) = NULL,
@OperationType int = NULL,
@OperationDate date = NULL,
@OperationDate2 date = NULL,
@OperationTime time(7) = NULL,
@Cash money = NULL,
@Cash2 money = NULL
AS
DECLARE @From int = (SELECT ID FROM Accounts WHERE AccountID = @AccountFrom)
DECLARE @To int = (SELECT ID FROM Accounts WHERE AccountID = @AccountTo)

SELECT TOP 25 ID, (SELECT CASE WHEN OperationType = 1 THEN 'Перевод' WHEN OperationType = 2 THEN 'Снятие наличных' WHEN OperationType = 3 THEN 'Пополнение счёта' END),
AccountFrom = (SELECT AccountID FROM Accounts WHERE AccountFrom = ID),
AccountTo = (SELECT AccountID FROM Accounts WHERE AccountTo = ID), 
[Date] = CONVERT(nvarchar, OperationDate),
OperationTime, Cash = ROUND(Cash, 2),
[Status] = IIF([Status] = 1, 'Выполнена', 'Отлонена'),
(SELECT CASE WHEN Reason = 1 THEN 'На счёте не хватает денег!' WHEN Reason = 2 THEN 'Не хватает денег в банкомате' END) FROM Operations WHERE
(@ID IS NULL OR ID = @ID)
AND
(@AccountTo IS NULL OR AccountTo = (SELECT ID FROM Accounts WHERE ID = @To))
AND
(@AccountFrom IS NULL OR AccountFrom = (SELECT ID FROM Accounts WHERE ID = @From))
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
