BULK INSERT WorldCupSchema.Managers
FROM 'D:\pythonRepos\GetSoccerStats\mockmanagers.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

SELECT * FROM WorldCupSchema.Managers