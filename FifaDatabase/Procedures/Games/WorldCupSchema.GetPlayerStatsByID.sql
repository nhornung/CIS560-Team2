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