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