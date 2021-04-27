BULK INSERT WorldCupSchema.Stadiums
FROM 'D:\pythonRepos\GetSoccerStats\venue.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

--ALTER TABLE WorldCupSchema.Stadiums
--ALTER COLUMN Capacity int;