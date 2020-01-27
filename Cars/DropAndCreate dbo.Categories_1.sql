USE [CarDb]
GO

/****** Object: Table [dbo].[Categories] Script Date: 28.01.2020 04:03:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Categories];


GO
CREATE TABLE [dbo].[Categories] (
    [CategoryId]   INT            IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (MAX) NULL,
    [Description]  NVARCHAR (MAX) NULL
);
GO

INSERT INTO [dbo].[Categories] (CategoryName, Description)
Values ('Russian', 'Garbage')


