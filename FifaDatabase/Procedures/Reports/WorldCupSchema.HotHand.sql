
CREATE OR ALTER PROCEDURE [WorldCupSchema].[HotHand]
AS
BEGIN
SELECT ALLP.Name,

	(SELECT TOP (20) COUNT(PGS.StatID)
	FROM WorldCupSchema.PlayerGameStat PGS
	JOIN WorldCupSchema.Players P ON P.PlayerID = ALLP.PlayerID
	JOIN WorldCupSchema.Games G On G.GameID = PGS.GameID
	WHERE PGS.StatID = 1 AND PGS.GameID = G.GameID AND PGS.PlayerID = ALLP.PlayerID AND YEAR(GameDate) = 2010
	) AS 'Goals'
	

FROM WorldCupSchema.Players ALLP
ORDER BY 'Goals' DESC
OFFSET 0 ROWS
FETCH NEXT 20 ROWS ONLY
END;
GO

EXEC [WorldCupSchema].[HotHand]
GO