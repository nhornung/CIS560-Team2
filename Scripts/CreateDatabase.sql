-- USE nhornung

CREATE SCHEMA WorldCupSchema;
GO


DROP TABLE IF EXISTS WorldCupSchema.Player;
CREATE TABLE WorldCupSchema.Player (
	PlayerID INT NOT NULL PRIMARY KEY,
	Name NVARCHAR(48) NOT NULL,
	Age TINYINT NOT NULL,
	Position NVARCHAR(12) NOT NULL,
	Height INT NOT NULL,
	Weight INT NOT NULL
);


DROP TABLE IF EXISTS WorldCupSchema.Team;
CREATE TABLE WorldCupSchema.Team (
	TeamID INT NOT NULL PRIMARY KEY,
	Nation NVARCHAR(32) NOT NULL UNIQUE
)


DROP TABLE IF EXISTS WorldCupSchema.TeamPlayer;
CREATE TABLE WorldCupSchema.TeamPlayer (
	TeamID INT NOT NULL,
	PlayerID INT NOT NULL,
	StartDate DATETIME,
	EndDate DATETIME

	PRIMARY KEY(TeamID, PlayerID),
	FOREIGN KEY(TeamID) REFERENCES WorldCupSchema.Team(TeamID),
	FOREIGN KEY(PlayerID) REFERENCES WorldCupSchema.Player(PlayerID)
)


DROP TABLE IF EXISTS WorldCupSchema.Manager;
CREATE TABLE WorldCupSchema.Manager (
	ManagerID INT NOT NULL PRIMARY KEY,
	Nationality NVARCHAR(32),
	Name NVARCHAR(48)
)


DROP TABLE IF EXISTS WorldCupSchema.TeamManager;
CREATE TABLE WorldCupSchema.TeamManager (
	TeamID INT NOT NULL,
	ManagerID INT NOT NULL,
	StartDate DATETIME NOT NULL,
	EndDate DATETIME NOT NULL

	PRIMARY KEY(TeamID, ManagerID),
	FOREIGN KEY(TeamID) REFERENCES WorldCupSchema.Team(TeamID),
	FOREIGN KEY(ManagerID) REFERENCES WorldCupSchema.Manager(ManagerID)
)


DROP TABLE IF EXISTS WorldCupSchema.Stadium;
CREATE TABLE WorldCupSchema.Stadium (
	StadiumID INT NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(64) NOT NULL,
	Capacity SMALLINT NOT NULL
)


DROP TABLE IF EXISTS WorldCupSchema.[Location];
CREATE TABLE WorldCupSchema.[Location] (
	LocationID INT NOT NULL PRIMARY KEY,
	Country NVARCHAR(32) NOT NULL
)


DROP TABLE IF EXISTS WorldCupSchema.Tournament;
CREATE TABLE WorldCupSchema.Tournament (
	TournamentID INT NOT NULL PRIMARY KEY,
	LocationID INT NOT NULL,
	StartDate DATETIME NOT NULL UNIQUE,
	EndDate DATETIME NOT NULL UNIQUE,
	Winner INT NOT NULL

	FOREIGN KEY(LocationID) REFERENCES WorldCupSchema.[Location](LocationID),
	FOREIGN KEY(Winner) REFERENCES WorldCupSchema.Team(TeamID)
)


DROP TABLE IF EXISTS WorldCupSchema.Game;
CREATE TABLE WorldCupSchema.Game (
	GameID INT NOT NULL PRIMARY KEY,
	StadiumID INT NOT NULL,
	TournamentID INT NOT NULL,
	TeamA INT NOT NULL,
	TeamB INT NOT NULL,
	GameDate DATETIME NOT NULL,
	Attendance INT NOT NULL,
	TournamentStage INT NOT NULL

	FOREIGN KEY(StadiumID) REFERENCES WorldCupSchema.Stadium(StadiumID),
	FOREIGN KEY(TournamentID) REFERENCES WorldCupSchema.Tournament(TournamentID),
	FOREIGN KEY(TeamA) REFERENCES WorldCupSchema.Team(TeamID),
	FOREIGN KEY(TeamB) REFERENCES WorldCupSchema.Team(TeamID),
)


DROP TABLE IF EXISTS WorldCupSchema.[Stat];
CREATE TABLE WorldCupSchema.[Stat] (
	StatID INT NOT NULL PRIMARY KEY,
	Stat NVARCHAR(24) NOT NULL
)

DROP TABLE IF EXISTS WorldCupSchema.PlayerGameStat;
CREATE TABLE WorldCupSchema.PlayerGameStat (
	GameId INT NOT NULL,
	PlayerId INT NOT NULL,
	StatId Int NOT NULL,
	CurrMinute INT NOT NULL,

	PRIMARY KEY(GameId, PlayerId, StatId),
	FOREIGN KEY(GameID) REFERENCES WorldCupSchema.Game(GameID),
	FOREIGN KEY(PlayerID) REFERENCES WorldCupSchema.Player(PlayerID),
	FOREIGN KEY(StatId) REFERENCES WorldCupSchema.[Stat](StatId)
)

DROP TABLE IF EXISTS WorldCupSchema.Network;
CREATE TABLE WorldCupSchema.Network (
	NetworkID INT NOT NULL PRIMARY KEY,
	GameID INT NOT NULL,
	NetWorkName NVARCHAR(32) NOT NULL UNIQUE,
	Channel INT NOT NULL UNIQUE,
	Viewers INT NOT NULL

	FOREIGN KEY(GameID) REFERENCES WorldCupSchema.Game(GameID)
)