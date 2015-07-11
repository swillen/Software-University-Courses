SELECT TeamName FROM Teams
ORDER BY TeamName

--problem 02 

SELECT TOP 50  c.CountryName , c.Population
FROM Countries c
ORDER BY c.Population DESC,c.CountryName
 

--problem 03 

SELECT c.CountryName ,c.CountryCode ,
 (CASE
  WHEN c.CurrencyCode = 'EUR' THEN 'Inside'
  ELSE 'Outside' END ) as [Eurozone]
	
FROM Countries c
ORDER BY c.CountryName


--problm 04  - Teams holding numbers 
use Football
SELECT TeamName as [Team Name], CountryCode as [Country Code]
FROM Teams
WHERE TeamName LIKE '%[0-9]%'
ORDER BY CountryCode



---Problem 5.	International Matches


SELECT  home.CountryName as [Home Team], away.CountryName as [Away Team] , i.MatchDate as [Match Date]
FROM InternationalMatches i
JOIN Countries home
	on i.HomeCountryCode = home.CountryCode
JOIN Countries away 
	on i.AwayCountryCode =away.CountryCode
ORDER BY [Match Date] DESC


--Problem 6.	*Teams with their League and League Country

SELECT t.TeamName as [Team Name],l.LeagueName as [League] , ISNULL(c.CountryName ,'International') as [League Country]
FROM Teams t 
	 JOIN Leagues_Teams lt
		ON t.Id = lt.TeamId
	JOIN Leagues l 
		ON lt.LeagueId = l.Id
	LEFT JOIN Countries c 
		ON l.CountryCode = c.CountryCode
GROUP BY l.LeagueName ,t.TeamName,c.CountryName
ORDER BY t.TeamName


--Problem 7.	* Teams with more than One Match
--Find all teams that have more than 1 match in any league. Sort the results by team name. 
--Name the columns exactly like in the table below. Submit for evaluation the result grid with headers.


            ----------------------- 01 ------------------------------
SELECT DISTINCT t.TeamName  as [Team], 
(
SELECT COUNT(*)
FROM TeamMatches teammatch 
WHERE teammatch.HomeTeamId = t.Id OR teammatch.AwayTeamId = t.Id
) as [Matches Count]
FROM Teams t
	LEFT JOIN TeamMatches home
		ON t.Id  =home.HomeTeamId
	LEFT JOIN TeamMatches away
		ON t.Id = away.AwayTeamId

WHERE (SELECT COUNT(*)
FROM TeamMatches teammatch 
WHERE teammatch.HomeTeamId = t.Id OR teammatch.AwayTeamId = t.Id)>1
ORDER BY t.TeamName


		--------------------------------------------02------------------------------

DECLARE @teamMatches table (
	hometeamId int NOT NULL,
	numberofMatches int NOT NULL
	)
insert into @teamMatches
SELECT tm.HomeTeamId ,COUNT(*)
FROM TeamMatches tm
GROUP BY tm.HomeTeamId 

insert into @teamMatches
SELECT tm.AwayTeamId ,COUNT(*)
FROM TeamMatches tm
GROUP BY tm.AwayTeamId 

SELECT t.TeamName as [Team],SUM(ft.numberofMatches) as [Matches Count]
FROM @teamMatches ft 
	JOIN Teams t 
		ON ft.hometeamId = t.Id
GROUP BY t.TeamName
HAVING SUM(ft.numberofMatches)>1
ORDER BY Team

SELECT 
  t.TeamName AS Team, 
  (SELECT COUNT(DISTINCT tm.Id) 
   FROM TeamMatches tm
   WHERE tm.HomeTeamId = t.Id OR tm.AwayTeamId = t.Id) AS [Matches Count]
FROM
  Teams t
WHERE
  (SELECT COUNT(DISTINCT tm.Id) 
   FROM TeamMatches tm
   WHERE tm.HomeTeamId = t.Id OR tm.AwayTeamId = t.Id) > 1
ORDER BY TeamName


--Problem 8.	Number of Teams and Matches in Leagues 

SELECT l.LeagueName as [League Name] ,COUNT(DISTINCT lt.TeamId) as [Teams] , COUNT (DISTINCT tm.Id) as [Matches],
AVG(ISNULL(tm.HomeGoals,0) + ISNULL(tm.AwayGoals,0)) as [Average Goals]
FROM Leagues l 
	LEFT JOIN Leagues_Teams lt 
		ON l.Id = lt.LeagueId
	LEFT JOIN TeamMatches tm
		ON l.Id = tm.LeagueId
GROUP BY l.LeagueName
ORDER BY Teams DESC,Matches DESC 


--Problem 9.	Total Goals per Team in all Matches

SELECT  t.TeamName ,
 ISNULL(SUM(home.HomeGoals),0) + ISNULL(SUM (away.AwayGoals),0) as [Total Goals]
FROM Teams t 
	LEFT JOIN TeamMatches home
		ON home.HomeTeamId = t.Id
	LEFT JOIN TeamMatches away
		ON away.AwayTeamId = t.Id
GROUP BY t.TeamName
ORDER BY  [Total Goals] DESC,t.TeamName

---Problem 10.	Pairs of Matches on the Same Day

SELECT tm.MatchDate as [First Date],tm2.MatchDate as [Second Date]
FROM TeamMatches tm , TeamMatches tm2
WHERE tm.MatchDate < tm2.MatchDate AND
DATEDIFF(DAY,tm.MatchDate,tm2.MatchDate) <1
ORDER BY [First Date] DESC , [Second Date] DESC


--Problem 11.	Mix of Team Names


SELECT LOWER(SUBSTRING(t1.teamname, 1, LEN(t1.TeamName) - 1) +  REVERSE(t2.TeamName)) AS Mix
FROM Teams t1, Teams t2
WHERE RIGHT(t1.TeamName, 1) = RIGHT(t2.TeamName, 1)
ORDER BY Mix


--Problem 12.	Countries with International and Team Matches

SELECT c.CountryName as [Country Name], COUNT(DISTINCT home.Id) + COUNT(DISTINCT away.Id) as [International Matches],
COUNT (DISTINCT tm.Id) as [Team Matches]
FROM Countries c
	LEFT JOIN InternationalMatches home
		ON c.CountryCode = home.HomeCountryCode
	LEFT JOIN InternationalMatches away
		ON c.CountryCode = away.AwayCountryCode
	LEFT JOIN Leagues l 
		ON l.CountryCode = c.CountryCode
	LEFT JOIN TeamMatches tm
		ON l.Id = tm.LeagueId
GROUP BY c.CountryName
HAVING COUNT(DISTINCT home.Id) + COUNT(DISTINCT away.Id) >0 OR 
COUNT (DISTINCT tm.Id) >0
ORDER BY [International Matches] DESC , [Team Matches]  DESC,c.CountryName

-- problem 13 


--CREATE TABLE [FriendlyMatches]
--(
--id int IDENTITY(1,1) PRIMARY KEY,
--HomeTeamID int  NULL,
--AwayTeamId int NULL,
--MatchDate datetime NULL,
--column_5 nvarchar(50),
--CONSTRAINT fk_HomeTeams FOREIGN KEY (HomeTeamID)
--REFERENCES Teams(id),
--CONSTRAINT fk_AwayTeams FOREIGN KEY (AwayTeamId)
--REFERENCES Teams(id)
--)

SELECT home.TeamName as [Home Team], away.TeamName as [Away Team] , fm.MatchDate as [Match Date]
FROM FriendlyMatches fm
	LEFT JOIN Teams home 
		ON fm.HomeTeamID = home.Id
	LEFT JOIN Teams away
		ON fm.AwayTeamId = away.Id
UNION
SELECT 
  t1.TeamName AS [Home Team],
  t2.TeamName AS [Away Team],
  tm.MatchDate AS [Match Date]
FROM TeamMatches tm
JOIN Teams t1 on t1.Id = tm.HomeTeamId
JOIN Teams t2 on t2.Id = tm.AwayTeamId
ORDER BY [Match Date] DESC



---- problem 14 

ALTER TABLE Leagues 
ADD IsSeasonal bit DEFAULT 0

INSERT INTO TeamMatches (HomeTeamId,AwayTeamId,HomeGoals,AwayGoals,MatchDate,LeagueId)
VALUES 
 
((SELECT Id FROM Teams WHERE TeamName='Empoli'), 
 (SELECT Id FROM Teams WHERE TeamName='Parma'), 
 2, 2, '19-Apr-2015 16:00', 
 (SELECT Id FROM Leagues WHERE LeagueName='Italian Serie A')),

((SELECT Id FROM Teams WHERE TeamName='Internazionale'), 
 (SELECT Id FROM Teams WHERE TeamName='AC Milan'), 
 0, 0, '19-Apr-2015 21:45', 
 (SELECT Id FROM Leagues WHERE LeagueName='Italian Serie A'))


UPDATE Leagues
SET IsSeasonal = 1
WHERE Leagues.Id IN (

 SELECT l.Id 
 FROM Leagues l
	 JOIN TeamMatches tm
		ON l.Id = tm.LeagueId
GROUP BY l.Id
HAVING COUNT (tm.Id)>0 )


SELECT 
	t1.TeamName AS [Home Team],
	tm.HomeGoals AS [Home Goals],
	t2.TeamName AS [Away Team],
	tm.AwayGoals AS [Away Goals],
	l.LeagueName AS [League Name]
FROM TeamMatches tm
JOIN Leagues l ON l.Id = tm.LeagueId
JOIN Teams t1 ON tm.HomeTeamId = t1.Id
JOIN Teams t2 ON tm.AwayTeamId = t2.Id
WHERE tm.MatchDate > '10-Apr-2015'
ORDER BY [League Name], [Home Goals] DESC, [Away Goals] DESC


-- problem 15 
GO

ALTER function fn_TeamsJSON()
returns nvarchar(MAX)
AS
BEGIN

	DECLARE @json NVARCHAR(MAX) = '{"teams":['

	DECLARE teamsCursor CURSOR FOR
	SELECT Id, TeamName FROM Teams
	WHERE CountryCode = 'BG'
	ORDER BY TeamName

	OPEN teamsCursor
	DECLARE @TeamName NVARCHAR(MAX)
	DECLARE @TeamId INT
	FETCH NEXT FROM teamsCursor INTO @TeamId, @TeamName
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @json = @json + '{"name":"' + @TeamName + '","matches":['

		DECLARE matchesCursor CURSOR FOR
		SELECT t1.TeamName, t2.TeamName, HomeGoals, AwayGoals, MatchDate FROM TeamMatches
		LEFT JOIN Teams t1 ON t1.Id = HomeTeamId
		LEFT JOIN Teams t2 ON t2.Id = AwayTeamId
		WHERE HomeTeamId = @TeamId OR AwayTeamId = @TeamId
		ORDER BY TeamMatches.MatchDate DESC

		OPEN matchesCursor
		DECLARE @HomeTeamName NVARCHAR(MAX)
		DECLARE @AwayTeamName NVARCHAR(MAX)
		DECLARE @HomeGoals INT
		DECLARE @AwayGoals INT
		DECLARE @MatchDate DATE
		FETCH NEXT FROM matchesCursor INTO @HomeTeamName, @AwayTeamName, @HomeGoals, @AwayGoals, @MatchDate
		WHILE @@FETCH_STATUS = 0
		BEGIN
			SET @json = @json + '{"' + @HomeTeamName + '":' + CONVERT(NVARCHAR(MAX), @HomeGoals) + ',"' + 
						@AwayTeamName + '":' + CONVERT(NVARCHAR(MAX), @AwayGoals) + 
						',"date":' + CONVERT(NVARCHAR(MAX), @MatchDate, 103) + '}'
			FETCH NEXT FROM matchesCursor INTO @HomeTeamName, @AwayTeamName, @HomeGoals, @AwayGoals, @MatchDate
			IF @@FETCH_STATUS = 0
				SET @json = @json + ','
		END
		CLOSE matchesCursor
		DEALLOCATE matchesCursor	
		SET @json = @json + ']}'

		FETCH NEXT FROM teamsCursor INTO @TeamId, @TeamName
		IF @@FETCH_STATUS = 0
			SET @json = @json + ','
	END
	CLOSE teamsCursor
	DEALLOCATE teamsCursor

	SET @json = @json + ']}'
	RETURN @json
END
GO

SELECT dbo.fn_TeamsJSON()