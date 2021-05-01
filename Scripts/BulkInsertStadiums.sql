--SET IDENTITY_INSERT WorldCupSchema.Stadiums OFF
--GO
--DBCC CHECKIDENT (WorldCupSchema.Stadiums, RESEED, 1);
--GO

--BULK INSERT WorldCupSchema.Stadiums
--FROM 'D:\pythonRepos\GetSoccerStats\venue.csv'
--WITH
--(
--    FIRSTROW = 2,
--    FIELDTERMINATOR = ',',  --CSV field delimiter
--    ROWTERMINATOR = '\n',   --Use to shift the control to next row
--    TABLOCK
--);
--GO

SELECT * FROM WorldCupSchema.Stadiums WHERE 2=2;