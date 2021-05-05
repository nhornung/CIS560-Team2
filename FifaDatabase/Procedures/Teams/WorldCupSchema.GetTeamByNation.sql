CREATE OR ALTER PROCEDURE WorldCupSchema.GetTeamByNaton
	@Nation NVARCHAR(40),
	@TeamID INT =0 OUT
AS
BEGIN
    SELECT *
	FROM WorldCupSchema.Teams T
	WHERE T.Nation = @Nation
END;