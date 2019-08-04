CREATE DATABASE [Invoice] COLLATE SQL_Latin1_General_CP1_CI_AS
GO
RAISERROR(N'Create Table [dbo].[Invoice]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[Invoice] (
    [Invoice_Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Date]         DATE         CONSTRAINT [DF_Invoice_Date] DEFAULT (getdate()) NULL,
    [Salesman]     VARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [CustomerName] VARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Contact]      VARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    CONSTRAINT [PK__Invoice__0DE605740AD2A005] PRIMARY KEY CLUSTERED ([Invoice_Id]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF)
)
GO
RAISERROR(N'Create Table [dbo].[Invoice_Item]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[Invoice_Item] (
    [Invoice_Id]  INT          NOT NULL,
    [Description] VARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Quantity]    INT          NOT NULL,
    [Unit_Price]  INT          NOT NULL,
    [Line_Total]  INT          NOT NULL,
    CONSTRAINT [Invoice_Item_Pk] PRIMARY KEY CLUSTERED ([Invoice_Id], [Description]) WITH (IGNORE_DUP_KEY = OFF, ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF),
    CONSTRAINT [FK__Invoice_I__Invoi__117F9D94] FOREIGN KEY ([Invoice_Id]) REFERENCES [dbo].[Invoice] ([Invoice_Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO
RAISERROR(N'Create Table [dbo].[Admin_Info]', 0, 1) WITH NOWAIT;
GO
CREATE TABLE [dbo].[Admin_Info] (
    [Name]     VARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [Password] VARCHAR (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
GO
