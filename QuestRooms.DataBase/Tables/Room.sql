CREATE TABLE [dbo].[Rooms]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX),
	[Duration] NVARCHAR(50),
	[GroupSize] NVARCHAR(50),
	[MinimumAge] NVARCHAR(50),
	[Address] NVARCHAR(100),
	[PhoneNumbers] NVARCHAR(50),
	[Email] NVARCHAR(50),
	[Company] NVARCHAR(50),
	[Rating] NVARCHAR(50),
	[LevelComplexity] NVARCHAR(50),
	[LevelFear] NVARCHAR(50),
	CONSTRAINT PK_Room PRIMARY KEY ([Id])
)
