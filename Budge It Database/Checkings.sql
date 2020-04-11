CREATE TABLE [dbo].[Checkings]
(
	[accountID] INT NOT NULL
	,[userId]	INT		NOT NULL
	,[transactionId]		INT		NOT NULL IDENTITY (1,1) PRIMARY KEY
	,[date]		DATE	NULL
	,[description]		NVARCHAR(50)	NOT NULL
	,[category]		NVARCHAR(50)	NOT NULL
	,[amount]		MONEY	NOT NULL
	,CONSTRAINT [FK_dbo.Checkings_dbo.UserInfo_userId] FOREIGN KEY ([userId]) 
        REFERENCES [dbo].[UserInfo] ([userId]) ON DELETE CASCADE
	,CONSTRAINT [FK_dbo.Checkings_dbo.AccountInfo_accountID] FOREIGN KEY ([accountID]) 
        REFERENCES [dbo].[AccountInfo] ([accountID]) ON DELETE CASCADE
)
