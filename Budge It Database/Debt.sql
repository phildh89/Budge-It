CREATE TABLE [dbo].[Debt]
(
	[accountID] INT NOT NULL
	,[custId]	INT		NOT NULL
	,[transactionId]		INT		NOT NULL PRIMARY KEY
	,[date]		DATE	NULL
	,[description]		NVARCHAR(50)	NOT NULL
	,[category]		NVARCHAR(50)	NOT NULL
	,[amount]		MONEY	NOT NULL
	,CONSTRAINT [FK_dbo.Debt_dbo.UserInfo_custID] FOREIGN KEY ([custID]) 
        REFERENCES [dbo].[UserInfo] ([custID]) ON DELETE CASCADE
	,CONSTRAINT [FK_dbo.Debt_dbo.AccountInfo_accountID] FOREIGN KEY ([accountID]) 
        REFERENCES [dbo].[AccountInfo] ([accountID]) ON DELETE CASCADE
)
