BULK INSERT WorldCupSchema.Teams
FROM 'D:\pythonRepos\GetSoccerStats\team_data.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)

