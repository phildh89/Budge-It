CREATE TABLE [dbo].[AccountInfo]
(
	[userId] INT NOT NULL
	,[accountId] INT NOT NULL IDENTITY (1,1) PRIMARY KEY
	,[accountType] INT NOT NULL
	,[accountDescription] NVARCHAR(50) NOT NULL
	,[apr] DECIMAL NULL
	,[initialBal] MONEY NULL

	,CONSTRAINT [FK_dbo.AccountInfo_dbo.UserInfo_userId] FOREIGN KEY ([userId]) 
        REFERENCES [dbo].[UserInfo] ([userId]) ON DELETE CASCADE
)
