CREATE PROCEDURE [WorldCupSchema].[CreatePlayer]
   @Name NVARCHAR(48),
   @Age DATE,
   @Position NVARCHAR(12),
   @Height INT,
   @Weight INT,
   @PlayerID INT = 0 OUTPUT
AS
BEGIN
INSERT WorldCupSchema.Players([Name], Age, Position, Height, Weight)
VALUES(@Name, @Age, @Position, @Height, @Weight);
SET @PlayerID = SCOPE_IDENTITY();
END;