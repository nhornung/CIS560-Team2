CREATE OR ALTER PROCEDURE WorldCupSchema.UpdatePlayer
   @OldName NVARCHAR(48),
   @OldAge DATE,
   @OldPosition NVARCHAR(12),

   @Name NVARCHAR(48),
   @Age DATE,
   @Position NVARCHAR(12),
   @Height INT,
   @Weight INT,
   @PlayerID INT = 0 OUTPUT
AS
BEGIN
    UPDATE [WorldCupSchema].Players
    SET
		Name=ISNULL(@Name,Name), 
        Age=ISNULL(@Age,Age), 
        Position=ISNULL(@Position, Position),
		Height=case when @Height = 0 then Height else @Height end,
		Weight=case when @Weight = 0 then Weight else @Weight end
    WHERE Name=@OldName AND Position = @OldPosition AND Age= @OldAge
END
GO