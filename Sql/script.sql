--Non-Report Queries!



--Inserts a game into the Games Table
--used in GameCreateView.xaml
CREATE OR ALTER PROCEDURE WorldCupSchema.CreateGame
	
	@StadiumID INT,
	@TournamentID INT,
	@Home INT,
	@Away INT,
	@GameDate Date,
	@TournamentStage VARCHAR(40),
	@Attendance INT,
	@Winner INT,
	@GameID	 INT = 0 OUTPUT   
AS
BEGIN
    INSERT INTO WorldCupSchema.Games(StadiumID, TournamentID, TeamA, TeamB, GameDate , Attendance, TournamentStage, Winner)
    SELECT @StadiumID, @TournamentID, 
	(SELECT T.TeamID
	FROM WorldCupSchema.Teams T
	WHERE T.TeamID = @Home
	),
	(SELECT T.TeamID
	FROM WorldCupSchema.Teams T
	WHERE T.TeamID = @Away
	),
	@GameDate, @Attendance, @TournamentStage,
	(SELECT T.TeamID
	FROM WorldCupSchema.Teams T
	WHERE T.TeamID = @Winner
	)
	FROM [WorldCupSchema].Teams T
	WHERE T.TeamID = @Home
SET @GameID = SCOPE_IDENTITY();
END;

--Gets a player's stats by that "PlayerID"
--used in the PlayerView.xaml to get a full historical
--report of the player.
CREATE OR ALTER PROCEDURE [WorldCupSchema].[GetPlayerStatsByID]
	@PlayerID INT
AS
BEGIN	
SELECT 
	ALLG.GameID,
	ALLG.GameDate,
	(ALLG.TournamentID + 1986)
	AS 'TournamentYear',

	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	WHERE PGS.StatID = 1 AND PGS.GameID = ALLG.GameID AND PGS.PlayerID = @PlayerID
	) AS 'Goals',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	WHERE PGS.StatID = 2 AND PGS.GameID = ALLG.GameID AND PGS.PlayerID = @PlayerID
	) AS 'Saves',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	WHERE PGS.StatID = 3 AND PGS.GameID = ALLG.GameID AND PGS.PlayerID = @PlayerID
	) AS 'Assists',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	WHERE PGS.StatID = 4 AND PGS.GameID = ALLG.GameID AND PGS.PlayerID = @PlayerID
	) AS 'Tackles',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	WHERE PGS.StatID = 5 AND PGS.GameID = ALLG.GameID AND PGS.PlayerID = @PlayerID
	) AS 'YellowCard',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	WHERE PGS.StatID = 6 AND PGS.GameID = ALLG.GameID AND PGS.PlayerID = @PlayerID
	) AS 'RedCard'

FROM WorldCupSchema.Games ALLG
JOIN WorldCupSchema.Teams T ON T.TeamID = ALLG.TeamA OR T.TeamID = ALLG.TeamB
JOIN WorldCupSchema.TeamPlayer TP ON  TP.TeamID = T.TeamID
JOIN WorldCupSchema.Players P ON P.PlayerID = TP.PlayerID
WHERE P.PlayerID = @PlayerID
END;

--Gets All of the games in the database
--used when populating GameSearchView.xaml's Data Grid
CREATE OR ALTER PROCEDURE WorldCupSchema.RetrieveGames
AS

SELECT G.GameID AS GameID,
		S.Name AS [Venue],
	   (T.TournamentID + 1986) AS [TournamentYear],
		TeamA.Nation AS [HomeTeam],
		TeamB.Nation AS [AwayTeam],
		G.GameDate AS [GameDate],
		G.TournamentStage AS [TournamentStage],
		G.Attendance,
		G.TeamA,
		G.TeamB,
		G.Winner
FROM WorldCupSchema.Games G
Join WorldCupSchema.Stadiums S ON S.StadiumID = G.StadiumID
Join WorldCupSchema.Tournaments T ON T.TournamentID = G.TournamentID
Join WorldCupSchema.Teams TeamA ON TeamA.TeamID = G.TeamA
Join WorldCupSchema.Teams TeamB ON TeamB.TeamID = G.TeamB
ORDER BY G.TournamentStage ASC
GO

--Gets the away team's game stats
--used to populate GameView.xaml
CREATE OR ALTER PROCEDURE [WorldCupSchema].[RetrieveGameStatsAwayTeam]
	@GameID INT
AS
BEGIN
SELECT
	ALLG.GameID,
	(ALLG.TournamentID + 1986) as TournamentYear,
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 1 AND PGS.GameID = ALLG.GameID AND ALLG.TeamB = TP.TeamID
	) AS 'Goals',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 2 AND PGS.GameID = ALLG.GameID AND ALLG.TeamB = TP.TeamID
	) AS 'Saves',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 3 AND PGS.GameID = ALLG.GameID AND ALLG.TeamB = TP.TeamID
	) AS 'Assists',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 4 AND PGS.GameID = ALLG.GameID AND ALLG.TeamB = TP.TeamID
	) AS 'Tackles',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 5 AND PGS.GameID = ALLG.GameID AND ALLG.TeamB = TP.TeamID
	) AS 'YellowCard',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 6 AND PGS.GameID = ALLG.GameID AND ALLG.TeamB = TP.TeamID
	) AS 'RedCard'

FROM WorldCupSchema.Games ALLG
WHERE ALLG.GameID = @GameID
END;

GO

--Gets the home team's game stats
--used to populate GameView.xaml
CREATE OR ALTER PROCEDURE [WorldCupSchema].[RetrieveGameStatsHomeTeam]
	@GameID INT
AS
BEGIN
SELECT
	ALLG.GameID,
	(ALLG.TournamentID + 1986) as TournamentYear,
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 1 AND PGS.GameID = ALLG.GameID AND ALLG.TeamA = TP.TeamID
	) AS 'Goals',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 2 AND PGS.GameID = ALLG.GameID AND ALLG.TeamA = TP.TeamID
	) AS 'Saves',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 3 AND PGS.GameID = ALLG.GameID AND ALLG.TeamA = TP.TeamID
	) AS 'Assists',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 4 AND PGS.GameID = ALLG.GameID AND ALLG.TeamA = TP.TeamID
	) AS 'Tackles',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 5 AND PGS.GameID = ALLG.GameID AND ALLG.TeamA = TP.TeamID
	) AS 'YellowCard',
	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
	WHERE PGS.StatID = 6 AND PGS.GameID = ALLG.GameID AND ALLG.TeamA = TP.TeamID
	) AS 'RedCard'

FROM WorldCupSchema.Games ALLG
WHERE ALLG.GameID = @GameID
END;

--Gets all managers who fit thie search criteria
--used in ManagerSearch.xaml
CREATE OR ALTER PROCEDURE WorldCupSchema.GetManagerByName
   @Name NVARCHAR(48)
AS
BEGIN
    SELECT *
FROM WorldCupSchema.Managers M
WHERE (M.[Name] LIKE '%' + @Name + '%') OR @Name IS NULL
END
GO

--Gets all managers in the Managers Table
--used to populate ManagerSearch.xaml
CREATE OR ALTER PROCEDURE [WorldCupSchema].[RetrieveManagers]
AS
BEGIN
SELECT *
FROM WorldCupSchema.Managers M
END;
GO

--Inserts a player into the Players table
--used in the PlayerCreate.xaml
CREATE PROCEDURE [WorldCupSchema].[CreatePlayer]
   @Name NVARCHAR(48),
   @Age DATE,
   @Position NVARCHAR(12),
   @Height INT,
   @Weight INT,
   @PlayerID INT = 0 OUTPUT
AS
BEGIN
INSERT WorldCupSchema.Players([Name], Age, Position, Height, Weight)
VALUES(@Name, @Age, @Position, @Height, @Weight);
SET @PlayerID = SCOPE_IDENTITY();
END;

--Gets all players that fit the search criteria
--used for search and filter functionality in PlayerSearch.xaml
CREATE OR ALTER PROCEDURE WorldCupSchema.GetPlayerByEveryTrait
   @Name NVARCHAR(48),
   @Age DATETIME,
   @Position NVARCHAR(3) NULL,
   @Height INT,
   @Weight INT
AS
BEGIN
    
	SELECT *
        FROM   WorldCupSchema.Players P
        WHERE (P.Name LIKE '%' + @Name + '%' OR @Name IS NULL)
        AND (P.Age < @Age OR @Age IS NULL)
        AND (P.Position LIKE '%' + @Position + '%' OR @Position IS NULL)
		AND (P.Height < @Height)
        AND (P.Weight < @Weight)
END;
GO

--Gets all of the players in the Players Table
--used to populate PlayerSearch.xaml Data Grid
CREATE OR ALTER PROCEDURE WorldCupSchema.RetrievePlayers
AS

SELECT *
FROM WorldCupSchema.Players P;
GO

--Updates a players attributes to the user's input
--used in PlayerUpdate.xaml
CREATE OR ALTER PROCEDURE WorldCupSchema.UpdatePlayer
   @Name NVARCHAR(48),
   @Age DATE,
   @Position NVARCHAR(12),
   @Height INT,
   @Weight INT,
   @PlayerID INT
AS
BEGIN
    UPDATE [WorldCupSchema].Players
    SET
		Name=ISNULL(@Name,Name), 
        Age=ISNULL(@Age,Age), 
        Position=ISNULL(@Position, Position),
		Height=case when @Height = 0 then Height else @Height end,
		Weight=case when @Weight = 0 then Weight else @Weight end
    WHERE PlayerID=@PlayerID
END
GO

--Creates a player stat based upon the user's input
--used in PlayerGameStatCreateView.xaml
CREATE OR ALTER PROCEDURE WorldCupSchema.CreatePlayerGameStat
   @GameID INT,
   @PlayerID INT,
   @Stat VARCHAR(20),
   @GameTime INT
AS
BEGIN
    INSERT INTO [WorldCupSchema].PlayerGameStat(GameID, PlayerID, StatID, GameTime)
    SELECT @GameID, @PlayerID, S.StatID, @GameTime
	FROM [WorldCupSchema].[Stats] S
	JOIN Games G ON G.GameID = @GameID
	JOIN Teams TA ON TA.TeamID = G.TeamA
	JOIN Teams TB ON TB.TeamID = G.TeamB
	JOIN TeamPlayer TP ON TP.PlayerID = @PlayerID
	WHERE S.Stat = @Stat AND (TP.TeamID = TB.TeamID OR TA.TeamID = G.TeamB)
END
GO

--Filters teams based on a user's search terms
--used in TeamSearch.xaml
CREATE OR ALTER PROCEDURE WorldCupSchema.GetTeamByNaton
	@Nation NVARCHAR(40),
	@TeamID INT =0 OUT
AS
BEGIN
    SELECT *
	FROM WorldCupSchema.Teams T
	WHERE T.Nation = @Nation
END;

--Gets all Teams in the Teams Table
--used to populate the Data Grid in TeamSearch.xaml
CREATE OR ALTER PROCEDURE WorldCupSchema.RetrieveTeams
AS

SELECT *
FROM WorldCupSchema.Teams T;
GO

--Gets all of the Tournaments in the Tournaments Table
--used to populate the Data Grid in TournamentsSearch.xaml
CREATE OR ALTER PROCEDURE [WorldCupSchema].RetrieveTournaments
AS
BEGIN
SELECT T.TournamentID + 1986 AS Tournament, L.Country, T.StartDate, T.EndDate
FROM WorldCupSchema.Tournaments T
JOIN WorldCupSchema.Locations L ON L.LocationID = T.LocationID
END;
GO

EXEC [WorldCupSchema].RetrieveTournaments