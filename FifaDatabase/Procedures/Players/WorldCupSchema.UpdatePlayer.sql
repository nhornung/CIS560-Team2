CREATE OR ALTER PROCEDURE WorldCupSchema.UpdatePlayer
   @Name NVARCHAR(48),
   @Age DATE,
   @Position NVARCHAR(12),
   @Height INT,
   @Weight INT,
   @PlayerID INT
AS
BEGIN
    UPDATE [WorldCupSchema].Players
    SET
		Name=ISNULL(@Name,Name), 
        Age=ISNULL(@Age,Age), 
        Position=ISNULL(@Position, Position),
		Height=case when @Height = 0 then Height else @Height end,
		Weight=case when @Weight = 0 then Weight else @Weight end
    WHERE PlayerID=@PlayerID
END
GO