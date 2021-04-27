SET IDENTITY_INSERT WorldCupSchema.Games ON


BULK INSERT WorldCupSchema.Games
FROM 'D:\pythonRepos\GetSoccerStats\match_data.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '0x0a' ,   --Use to shift the control to next row
    TABLOCK
)
GO
--ALTER TABLE WorldCupSchema.Games
--ALTER COLUMN Attendance bigint;
SELECT * FROM WorldCupSchema.Games