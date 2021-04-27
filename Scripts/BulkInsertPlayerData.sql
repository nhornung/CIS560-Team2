BULK INSERT WorldCupSchema.Players
FROM 'D:\pythonRepos\GetSoccerStats\players.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO
--DELETE FROM WorldCupSchema.Players WHERE 1 != 2;
--SELECT * FROM WorldCupSchema.Players;