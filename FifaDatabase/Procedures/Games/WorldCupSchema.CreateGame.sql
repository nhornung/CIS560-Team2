CREATE OR ALTER PROCEDURE WorldCupSchema.CreateGame
	
	@StadiumID INT,
	@TournamentID INT,
	@Home INT,
	@Away INT,
	@GameDate Date,
	@TournamentStage VARCHAR(40),
	@Attendance INT,
	@Winner INT,
	@GameID	 INT = 0 OUTPUT   

AS
BEGIN
    INSERT INTO WorldCupSchema.Games(StadiumID, TournamentID, TeamA, TeamB, GameDate , Attendance, TournamentStage, Winner)
    SELECT @StadiumID, @TournamentID, 
	(SELECT T.TeamID
	FROM WorldCupSchema.Teams T
	WHERE T.TeamID = @Home
	),
	(SELECT T.TeamID
	FROM WorldCupSchema.Teams T
	WHERE T.TeamID = @Away
	),
	@GameDate, @Attendance, @TournamentStage,
	(SELECT T.TeamID
	FROM WorldCupSchema.Teams T
	WHERE T.TeamID = @Winner
	)
	FROM [WorldCupSchema].Teams T
	WHERE T.TeamID = @Home
SET @GameID = SCOPE_IDENTITY();
	
END