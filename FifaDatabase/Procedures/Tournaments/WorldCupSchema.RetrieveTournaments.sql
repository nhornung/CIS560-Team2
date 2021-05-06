CREATE OR ALTER PROCEDURE [WorldCupSchema].RetrieveTournaments
AS
BEGIN
SELECT T.TournamentID + 1986 AS Tournament, L.Country, T.StartDate, T.EndDate
FROM WorldCupSchema.Tournaments T
JOIN WorldCupSchema.Locations L ON L.LocationID = T.LocationID
END;
GO

EXEC [WorldCupSchema].RetrieveTournaments