CREATE OR ALTER PROCEDURE [WorldCupSchema].[DoTraitsMatterLosers]
AS
BEGIN
	SELECT CAST(DATEADD(DAY, AVG(DATEDIFF(DAY, '1900-01-01', P.Age)), '1900-01-01') as DATE) as 'LoserAgeAVG',
	AVG(P.Height) as 'LoserHeightAVG',
	AVG(P.Weight) as 'LoserWeightAVG'

	FROM WorldCupSchema.PlayerGameStat PGS
		JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
		JOIN WorldCupSchema.TeamPlayer TP ON TP.PlayerID = P.PlayerID
		JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
		JOIN WorldCupSchema.Games G On G.GameID = PGS.GameID
	WHERE T.TeamID != G.Winner 
	AND YEAR(G.GameDate) = 2010 
	AND MONTH(TP.StartDate) < 5 AND YEAR(TP.StartDate) <= 2010
	AND MONTH(TP.EndDate) > 6 AND YEAR(TP.EndDate) >= 2010;
END;
GO