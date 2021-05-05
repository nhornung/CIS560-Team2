CREATE OR ALTER PROCEDURE [WorldCupSchema].GetWinningPercentageOfGoaliestTeams
AS
BEGIN
SELECT
	ALLT.Nation,

	(CAST((SELECT COUNT(G.Winner)
	FROM WorldCupSchema.Games G
	JOIN WorldCupSchema.Teams T ON T.TeamID = G.Winner
	WHERE ALLT.TeamID = T.TeamID
	) as FLOAT)/

	CAST((SELECT COUNT(T.TeamID)
	FROM WorldCupSchema.Games G
	JOIN WorldCupSchema.Teams T ON T.TeamID = TeamA OR T.TeamID = TeamB
	WHERE ALLT.TeamID = T.TeamID 
	) AS FLOAT))AS 'WinningPercentage',

	(SELECT COUNT(PGS.StatID)
	FROM WorldCupSchema.Games G
	JOIN WorldCupSchema.Teams T ON T.TeamID = TeamA OR T.TeamID = TeamB
	JOIN WorldCupSchema.PlayerGameStat PGS ON PGS.GameID = G.GameID
	JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
	JOIN WorldCupSchema.TeamPlayer TP ON  TP.PlayerID = P.PlayerID
	WHERE PGS.StatID = 1 AND ALLT.TeamID = T.TeamID AND  ALLT.TeamID = TP.TeamID
	) /

	CAST((SELECT COUNT(T.TeamID)
	FROM WorldCupSchema.Games G
	JOIN WorldCupSchema.Teams T ON T.TeamID = TeamA OR T.TeamID = TeamB
	WHERE ALLT.TeamID = T.TeamID 
	) AS FLOAT)AS 'GoalsPerGame'


FROM WorldCupSchema.Teams ALLT
ORDER BY 'WinningPercentage' DESC, 'GoalsPerGame' DESC
END;