-- USE nhornung

--CREATE SCHEMA WorldCupSchema;
--GO
--USE master;


CREATE TABLE WorldCupSchema.[Locations] (
	LOCATIONID INT NOT NULL PRIMARY KEY,
	COUNTRY NVARCHAR(32) NOT NULL
)

CREATE TABLE WorldCupSchema.Teams (
	TeamID INT NOT NULL PRIMARY KEY,
	Nation NVARCHAR(32) NOT NULL UNIQUE
)


CREATE TABLE WorldCupSchema.Managers (
	ManagerID INT NOT NULL PRIMARY KEY,
	Nationality NVARCHAR(32),
	[Name] NVARCHAR(48)
)

CREATE TABLE WorldCupSchema.Stadiums (
	StadiumID INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(64) NOT NULL,
	Capacity SMALLINT NOT NULL
)
CREATE TABLE WorldCupSchema.Tournaments (
	TournamentID INT NOT NULL PRIMARY KEY,
	LocationID INT NOT NULL,
	StartDate DATE NOT NULL UNIQUE,
	EndDate DATE NOT NULL UNIQUE,

	FOREIGN KEY(LocationID) REFERENCES WorldCupSchema.[Locations](LocationID),
)
CREATE TABLE WorldCupSchema.Games (
	GameID INT NOT NULL PRIMARY KEY,
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
	StatID INT NOT NULL PRIMARY KEY,
	Stat NVARCHAR(24) NOT NULL
)
CREATE TABLE WorldCupSchema.Networks (
	NetworkID INT NOT NULL PRIMARY KEY,
	GameID INT NOT NULL,
	Viewers INT NOT NULL

	FOREIGN KEY(GameID) REFERENCES WorldCupSchema.Games(GameID)
)
GO
CREATE TABLE WorldCupSchema.Players (
	PlayerID INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(48) NOT NULL,
	Age DATE NOT NULL,
	Position NVARCHAR(12) NOT NULL,
	Height INT,
	[Weight] INT
);
CREATE TABLE WorldCupSchema.PlayerGameStat (
	GameId INT NOT NULL,
	PlayerId INT NOT NULL,
	StatId Int NOT NULL,

	PRIMARY KEY(GameId, PlayerId, StatId),
	FOREIGN KEY(GameID) REFERENCES WorldCupSchema.Games(GameID),
	FOREIGN KEY(PlayerID) REFERENCES WorldCupSchema.Players(PlayerID),
	FOREIGN KEY(StatId) REFERENCES WorldCupSchema.[Stats](StatId)
)
GO
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