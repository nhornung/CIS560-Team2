CREATE OR ALTER PROCEDURE WorldCupSchema.GetPlayerByEveryTrait
   @Name NVARCHAR(48),
   @Age DATETIME,
   @Position NVARCHAR(3) NULL,
   @Height INT,
   @Weight INT
AS
BEGIN
    
	SELECT *
        FROM   WorldCupSchema.Players P
        WHERE (P.Name LIKE '%' + @Name + '%' OR @Name IS NULL)
        AND (P.Age < @Age OR @Age IS NULL)
        AND (P.Position LIKE '%' + @Position + '%' OR @Position IS NULL)
		AND (P.Height < @Height)
        AND (P.Weight < @Weight)
END;
GO