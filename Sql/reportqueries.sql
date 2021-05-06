--Report Queries!


/*Gets the average height, weight, and age of every player on each losing
	team in the year 2010. This report is meant for managers of soccer teams,
	so they can have a better idea of who to go after in Free Agency, and see
	which matchups may favor their team.
	This report is supposed to be used in tandem with "[DoTraitsMatterWinners]"
*/

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

/*Gets the average height, weight, and age of every player on each winning
	team in the year 2010. This report is meant for managers of soccer teams,
	so they can have a better idea of who to go after in Free Agency, and see
	which matchups may favor their team.
	This report is supposed to be used in tandem with "[DoTraitsMatterWinners]"
*/
CREATE OR ALTER PROCEDURE [WorldCupSchema].[DoTraitsMatterWinners]
AS
BEGIN
	SELECT CAST(DATEADD(DAY, AVG(DATEDIFF(DAY, '1900-01-01', P.Age)), '1900-01-01') as DATE) as 'WinnerAgeAVG',
	AVG(P.Height) as 'WinnerHeightAVG',
	AVG(P.Weight) as 'WinnerWeightAVG'

	FROM WorldCupSchema.PlayerGameStat PGS
		JOIN WorldCupSchema.Players P ON P.PlayerID = PGS.PlayerID
		JOIN WorldCupSchema.TeamPlayer TP ON TP.PlayerID = P.PlayerID
		JOIN WorldCupSchema.Teams T ON T.TeamID = TP.TeamID
		JOIN WorldCupSchema.Games G On G.GameID = PGS.GameID
	WHERE T.TeamID = G.Winner 
	AND YEAR(G.GameDate) = 2010 
	AND MONTH(TP.StartDate) < 5 AND YEAR(TP.StartDate) <= 2010
	AND MONTH(TP.EndDate) > 6 AND YEAR(TP.EndDate) >= 2010;
END;
GO

/*Gets the top ten average TV ratings for each team in the time period specified by the user, and
	organizes the results from highest average to lowest average.
	This report is might be put to best use by a TV network so they can sign contracts with
	the best producing teams.
*/
CREATE OR ALTER PROCEDURE WorldCupSchema.[GetViewershipByStageOrTeam]
	@Stage NVARCHAR(50),
	@GameDate1 DATE,
	@GameDate2 DATE
AS
BEGIN

	SELECT TOP (10) AVG(N.Viewers) as [Views], T.Nation, @Stage as Stage
	FROM WorldCupSchema.Games G
		JOIN WorldCupSchema.Networks  N ON N.GameID = G.GameID
		JOIN WorldCupSchema.Teams T ON T.TeamID = G.TeamA OR T.TeamID = G.TeamB
	WHERE (@Stage IS NOT NULL AND G.TournamentStage = @Stage)
		  OR (@Stage IS NULL)
		  AND G.GameDate > @GameDate1
		  AND G.GameDate < @GameDate2
	GROUP BY T.Nation
	ORDER BY AVG(N.Viewers) DESC

END;

/*Gets the historical winning percentage of each national team that has ever
	played in the World Cup between 1986-2010. The report then lists that club's
	average goals per game so that managers can have a better of how much scoring matters
	when trying to win a soccer game
*/
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



/*Yet another report query meant to bring more data to the eyes of the coaching staff
	This query shows a list of the top ten goal scorers in the World Cup in 2010. The players
	are ordered from most goals to least.
*/
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