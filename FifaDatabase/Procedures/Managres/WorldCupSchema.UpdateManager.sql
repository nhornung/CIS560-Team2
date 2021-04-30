create or alter procedure WorldCupSchema.UpdateManager
   @OldName NVARCHAR(48),
   @OldNationality NVARCHAR(32),
   @Name NVARCHAR(48),
   @Nationality NVARCHAR(32)
as 

update WorldCupSchema.Managers
set 
	Name = @Name,
	Nationality = @Nationality
from WorldCupSchema.Managers where Name = @OldName AND Nationality = @OldNationality
GO