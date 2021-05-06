CREATE OR ALTER PROCEDURE WorldCupSchema.GetManagerByName
   @Name NVARCHAR(48)
AS
BEGIN
    SELECT *
FROM WorldCupSchema.Managers M
WHERE (M.[Name] LIKE '%' + @Name + '%') OR @Name IS NULL
END
GO