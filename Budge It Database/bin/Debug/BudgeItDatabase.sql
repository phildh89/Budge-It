﻿/*
Deployment script for BudgeItDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "BudgeItDatabase"
:setvar DefaultFilePrefix "BudgeItDatabase"
:setvar DefaultDataPath "C:\Users\phild\AppData\Local\Microsoft\VisualStudio\SSDT\BudgeIt"
:setvar DefaultLogPath "C:\Users\phild\AppData\Local\Microsoft\VisualStudio\SSDT\BudgeIt"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [dbo].[Checkings]...';


GO
CREATE TABLE [dbo].[Checkings] (
    [accountID]     INT           NOT NULL,
    [custId]        INT           NOT NULL,
    [transactionId] INT           NOT NULL,
    [date]          DATE          NULL,
    [description]   NVARCHAR (50) NOT NULL,
    [category]      NVARCHAR (50) NOT NULL,
    [amount]        MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([transactionId] ASC)
);


GO
PRINT N'Creating [dbo].[Debt]...';


GO
CREATE TABLE [dbo].[Debt] (
    [accountID]     INT           NOT NULL,
    [custId]        INT           NOT NULL,
    [transactionId] INT           NOT NULL,
    [date]          DATE          NULL,
    [description]   NVARCHAR (50) NOT NULL,
    [category]      NVARCHAR (50) NOT NULL,
    [amount]        MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([transactionId] ASC)
);


GO
PRINT N'Creating [dbo].[Savings]...';


GO
CREATE TABLE [dbo].[Savings] (
    [accountID]     INT           NOT NULL,
    [custId]        INT           NOT NULL,
    [transactionId] INT           NOT NULL,
    [date]          DATE          NULL,
    [description]   NVARCHAR (50) NOT NULL,
    [category]      NVARCHAR (50) NOT NULL,
    [amount]        MONEY         NOT NULL,
    PRIMARY KEY CLUSTERED ([transactionId] ASC)
);


GO
PRINT N'Creating [dbo].[FK_dbo.Checkings_dbo.UserInfo_custID]...';


GO
ALTER TABLE [dbo].[Checkings] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Checkings_dbo.UserInfo_custID] FOREIGN KEY ([custId]) REFERENCES [dbo].[UserInfo] ([custId]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.Checkings_dbo.AccountInfo_accountID]...';


GO
ALTER TABLE [dbo].[Checkings] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Checkings_dbo.AccountInfo_accountID] FOREIGN KEY ([accountID]) REFERENCES [dbo].[AccountInfo] ([accountId]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.Debt_dbo.UserInfo_custID]...';


GO
ALTER TABLE [dbo].[Debt] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Debt_dbo.UserInfo_custID] FOREIGN KEY ([custId]) REFERENCES [dbo].[UserInfo] ([custId]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.Debt_dbo.AccountInfo_accountID]...';


GO
ALTER TABLE [dbo].[Debt] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Debt_dbo.AccountInfo_accountID] FOREIGN KEY ([accountID]) REFERENCES [dbo].[AccountInfo] ([accountId]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.Savings_dbo.UserInfo_custID]...';


GO
ALTER TABLE [dbo].[Savings] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Savings_dbo.UserInfo_custID] FOREIGN KEY ([custId]) REFERENCES [dbo].[UserInfo] ([custId]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.Savings_dbo.AccountInfo_accountID]...';


GO
ALTER TABLE [dbo].[Savings] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Savings_dbo.AccountInfo_accountID] FOREIGN KEY ([accountID]) REFERENCES [dbo].[AccountInfo] ([accountId]) ON DELETE CASCADE;


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Checkings] WITH CHECK CHECK CONSTRAINT [FK_dbo.Checkings_dbo.UserInfo_custID];

ALTER TABLE [dbo].[Checkings] WITH CHECK CHECK CONSTRAINT [FK_dbo.Checkings_dbo.AccountInfo_accountID];

ALTER TABLE [dbo].[Debt] WITH CHECK CHECK CONSTRAINT [FK_dbo.Debt_dbo.UserInfo_custID];

ALTER TABLE [dbo].[Debt] WITH CHECK CHECK CONSTRAINT [FK_dbo.Debt_dbo.AccountInfo_accountID];

ALTER TABLE [dbo].[Savings] WITH CHECK CHECK CONSTRAINT [FK_dbo.Savings_dbo.UserInfo_custID];

ALTER TABLE [dbo].[Savings] WITH CHECK CHECK CONSTRAINT [FK_dbo.Savings_dbo.AccountInfo_accountID];


GO
PRINT N'Update complete.';


GO
