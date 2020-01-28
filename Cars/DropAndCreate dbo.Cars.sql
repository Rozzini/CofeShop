USE [CarDb]
GO

/****** Object: Table [dbo].[Cars] Script Date: 28.01.2020 13:54:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Cars];


GO
CREATE TABLE [dbo].[Cars] (
    [CarId]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (MAX) NULL,
    [ShortDescription] NVARCHAR (MAX) NULL,
    [LongDescription]  NVARCHAR (MAX) NULL,
    [Image]            NVARCHAR (MAX) NULL,
    [IsFavorite]       BIT            NOT NULL,
    [Available]        BIT            NOT NULL,
    [CategoryId]       INT            NOT NULL,
    [Price] DECIMAL(16, 2) NOT NULL
);
GO
ALTER TABLE [dbo].[Cars]
   ADD CONSTRAINT PK_Primary_CarId PRIMARY KEY CLUSTERED (CarId);
GO
ALTER TABLE [dbo].[Cars]
   ADD CONSTRAINT FK_Carss_Categories FOREIGN KEY (CategoryId)
      REFERENCES dbo.Categories (CategoryId)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;

