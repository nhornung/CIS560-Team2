BULK INSERT WorldCupSchema.Managers
FROM 'mockmanagers.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

SET IDENTITY_INSERT WorldCupSchema.Games OFF
BULK INSERT WorldCupSchema.Games
FROM 'match_data.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n' ,   --Use to shift the control to next row
    TABLOCK
)
GO

BULK INSERT WorldCupSchema.Networks
FROM 'NetworkMockData.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n' ,   --Use to shift the control to next row
    TABLOCK
)

GO

GO

BULK INSERT WorldCupSchema.Players
FROM 'players.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

BULK INSERT WorldCupSchema.PlayerGameStat
FROM 'player_game_stats.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)
GO

SELECT * FROM WorldCupSchema.PlayerGameStat

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

BULK INSERT WorldCupSchema.Teams
FROM 'team_data.csv'
WITH
(
    FIRSTROW = 2,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
)

INSERT INTO WorldCupSchema.[Stats](Stat)
VALUES('Goal');
INSERT INTO WorldCupSchema.[Stats](Stat)
VALUES('Save');
INSERT INTO WorldCupSchema.[Stats](Stat)
VALUES('Tackle');
INSERT INTO WorldCupSchema.[Stats](Stat)
VALUES('Assist');
INSERT INTO WorldCupSchema.[Stats](Stat)
VALUES('Yellow Card');
INSERT INTO WorldCupSchema.[Stats](Stat)
VALUES('Red Card');
INSERT INTO WorldCupSchema.[Stats](Stat)
VALUES('Goal');

INSERT INTO WorldCupSchema.[Locations](Country)
VALUES('South Africa')
INSERT INTO WorldCupSchema.[Locations](Country)
VALUES('Germany')
INSERT INTO WorldCupSchema.[Locations](Country)
VALUES('Japan')
INSERT INTO WorldCupSchema.[Locations](Country)
VALUES('France')
INSERT INTO WorldCupSchema.[Locations](Country)
VALUES('United States')
INSERT INTO WorldCupSchema.[Locations](Country)
VALUES('Italy')
INSERT INTO WorldCupSchema.[Locations](Country)
VALUES('Mexico')


SET IDENTITY_INSERT WorldCupSchema.Tournaments ON
INSERT INTO WorldCupSchema.Tournaments(TournamentID,LocationID, StartDate, EndDate)
VALUES(0, 6, '06-01-1986', '06-29-1986')
INSERT INTO WorldCupSchema.Tournaments(TournamentID,LocationID, StartDate, EndDate)
VALUES(4, 7, '05-30-1990', '06-27-1990')
INSERT INTO WorldCupSchema.Tournaments(TournamentID,LocationID, StartDate, EndDate)
VALUES(8, 5, '06-01-1994', '06-29-1994')
INSERT INTO WorldCupSchema.Tournaments(TournamentID,LocationID, StartDate, EndDate)
VALUES(12, 4, '06-01-1998', '06-29-1998')
INSERT INTO WorldCupSchema.Tournaments(TournamentID,LocationID, StartDate, EndDate)
VALUES(16, 3, '06-11-2002', '07-05-2002')
INSERT INTO WorldCupSchema.Tournaments(TournamentID,LocationID, StartDate, EndDate)
VALUES(20, 2, '06-10-2006', '07-10-2006')
INSERT INTO WorldCupSchema.Tournaments(TournamentID,LocationID, StartDate, EndDate)
VALUES(24, 1, '06-12-2010', '07-01-2010')


