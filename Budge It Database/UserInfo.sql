CREATE TABLE [dbo].[UserInfo]
(
	[userId]			INT				NOT NULL IDENTITY(1,1) PRIMARY KEY
	,[firstName]		NVARCHAR(20)	NOT NULL
	,[lastName]		NVARCHAR(20)	NOT NULL
	,[email]			NVARCHAR(255)	NOT NULL
	,[password]		NVARCHAR(30)	NOT NULL
)
