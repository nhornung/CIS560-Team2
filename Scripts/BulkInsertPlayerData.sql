
--USE WideWorldImporters;

--BULK INSERT WorldCupSchema.Players
--FROM 'D:\pythonRepos\GetSoccerStats\players.csv'
--WITH
--(
--    FIRSTROW = 1,
--	KEEPIDENTITY,
--    FIELDTERMINATOR = ',',  --CSV field delimiter
--    ROWTERMINATOR = '\n',   --Use to shift the control to next row
--    TABLOCK
--)
--GO
--TRUNCATE TABLE WorldCupSchema.Players;
--GO
SELECT * FROM WorldCupSchema.Players;