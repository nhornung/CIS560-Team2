-- USE nhornung

--CREATE SCHEMA WorldCupSchema;
--GO
--USE master;


CREATE TABLE WorldCupSchema.[Locations] (
	LocationID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Country NVARCHAR(32) NOT NULL
)

CREATE TABLE WorldCupSchema.Teams (
	TeamID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nation NVARCHAR(32) NOT NULL UNIQUE
)


CREATE TABLE WorldCupSchema.Managers (
	ManagerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Nationality NVARCHAR(32),
	[Name] NVARCHAR(48)
)

CREATE TABLE WorldCupSchema.Stadiums (
	StadiumID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(64) NOT NULL,
	Capacity INT NOT NULL
)
CREATE TABLE WorldCupSchema.Tournaments (
	TournamentID INT NOT NULL IDENTITY(0,4) PRIMARY KEY,
	LocationID INT NOT NULL,
	StartDate DATE NOT NULL UNIQUE,
	EndDate DATE NOT NULL UNIQUE,

	FOREIGN KEY(LocationID) REFERENCES WorldCupSchema.[Locations](LocationID),
)
CREATE TABLE WorldCupSchema.Games (
	GameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	StadiumID INT NOT NULL,
	TournamentID INT NOT NULL,
	TeamA INT NOT NULL,
	TeamB INT NOT NULL,
	GameDate DATE,
	Attendance INT NOT NULL,
	TournamentStage NVARCHAR(32) NOT NULL

	FOREIGN KEY(StadiumID) REFERENCES WorldCupSchema.Stadiums(StadiumID),
	FOREIGN KEY(TournamentID) REFERENCES WorldCupSchema.Tournaments(TournamentID),
	FOREIGN KEY(TeamA) REFERENCES WorldCupSchema.Teams(TeamID),
	FOREIGN KEY(TeamB) REFERENCES WorldCupSchema.Teams(TeamID),
)

CREATE TABLE WorldCupSchema.[Stats] (
	StatID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Stat NVARCHAR(24) NOT NULL
)
CREATE TABLE WorldCupSchema.Networks (
	NetworkID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	GameID INT NOT NULL,
	Viewers INT NOT NULL

	FOREIGN KEY(GameID) REFERENCES WorldCupSchema.Games(GameID)
)
GO
CREATE TABLE WorldCupSchema.Players (
	PlayerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(48) NOT NULL,
	Age DATE NOT NULL,
	Position NVARCHAR(12) NOT NULL,
	Height INT,
	[Weight] INT
);
CREATE TABLE WorldCupSchema.PlayerGameStat (
	GameID INT NOT NULL,
	PlayerID INT NOT NULL,
	StatID Int NOT NULL,
	GameTime INT NOT NULL

	PRIMARY KEY(GameId, PlayerId, StatId, GameTime),
	FOREIGN KEY(GameID) REFERENCES WorldCupSchema.Games(GameID),
	FOREIGN KEY(PlayerID) REFERENCES WorldCupSchema.Players(PlayerID),
	FOREIGN KEY(StatId) REFERENCES WorldCupSchema.[Stats](StatId)
)
CREATE TABLE WorldCupSchema.TeamPlayer (
	TeamID INT NOT NULL,
	PlayerID INT NOT NULL,
	StartDate DATE,
	EndDate DATE

	PRIMARY KEY(TeamID, PlayerID),
	FOREIGN KEY(TeamID) REFERENCES WorldCupSchema.Teams(TeamID),
	FOREIGN KEY(PlayerID) REFERENCES WorldCupSchema.Players(PlayerID)
)
GO
CREATE TABLE WorldCupSchema.TeamManager (
	TeamID INT NOT NULL,
	ManagerID INT NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL

	PRIMARY KEY(TeamID, ManagerID),
	FOREIGN KEY(TeamID) REFERENCES WorldCupSchema.Teams(TeamID),
	FOREIGN KEY(ManagerID) REFERENCES WorldCupSchema.Managers(ManagerID)
)
GO