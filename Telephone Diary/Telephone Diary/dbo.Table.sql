CREATE TABLE [Mobiles].[Table]
(
	[Id] INT NOT NULL , 
    [First] VARCHAR(50) NULL, 
    [Last] VARCHAR(50) NULL, 
    [Mobile] VARCHAR(50) NOT NULL, 
    [Email] VARBINARY(50) NULL, 
    [Category] VARBINARY(50) NULL, 
    PRIMARY KEY ([Mobile])
)
