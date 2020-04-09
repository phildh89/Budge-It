CREATE TABLE [dbo].[AccountInfo]
(
	[custID] INT NOT NULL
	,[accountId] INT NOT NULL IDENTITY (1,1) PRIMARY KEY
	,[accountType] VARCHAR(20) NOT NULL
	,[accountName] VARCHAR(20) NOT NULL
	,[apr] DECIMAL NULL
	,[initialBal] MONEY NULL

	,CONSTRAINT [FK_dbo.AccountInfo_dbo.UserInfo_custID] FOREIGN KEY ([custID]) 
        REFERENCES [dbo].[UserInfo] ([custID]) ON DELETE CASCADE
)
