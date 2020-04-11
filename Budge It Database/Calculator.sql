CREATE TABLE [dbo].[Calculator]
(
	[Id] INT NOT NULL IDENTITY (1,1) PRIMARY KEY
	,[userId] INT NOT NULL
	,[isSavingsCalc] BIT NOT NULL
	,[amount] DECIMAL NOT NULL
	,[apr] DECIMAL NOT NULL
	,[monthlyPayment] DECIMAL NULL
	,[payOffTime] INT NULL
	,CONSTRAINT [FK_dbo.Calculator_dbo.UserInfo_userId] FOREIGN KEY ([userId]) 
        REFERENCES [dbo].[UserInfo] ([userId]) ON DELETE CASCADE
)
