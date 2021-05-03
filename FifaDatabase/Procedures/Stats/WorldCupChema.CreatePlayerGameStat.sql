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
	WHERE S.Stat = @Stat
END
GO