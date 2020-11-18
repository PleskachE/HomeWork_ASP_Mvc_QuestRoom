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
	[Rating] FLOAT,
	[LevelComplexityId] INT NOT NULL,
	[TypeRoomId] INT NOT NULL,
	CONSTRAINT PK_Room PRIMARY KEY ([Id])
)
