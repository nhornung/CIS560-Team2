CREATE OR ALTER PROCEDURE WorldCupSchema.GetPlayerByName
   @Name NVARCHAR(48)
AS
BEGIN
    SELECT *
FROM WorldCupSchema.Players P
WHERE P.Name = @Name;
END
GO