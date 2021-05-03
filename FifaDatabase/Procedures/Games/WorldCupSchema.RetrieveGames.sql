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