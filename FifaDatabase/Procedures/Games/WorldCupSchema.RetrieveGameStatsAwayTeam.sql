CREATE OR ALTER PROCEDURE [WorldCupSchema].[RetrieveGameStatsAwayTeam]
	@GameID INT
AS
BEGIN
SELECT
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

