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