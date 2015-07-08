--problem 3 
SELECT c.CountryName,c.CountryCode,
(CASE 
	WHEN c.CurrencyCode = 'EUR' THEN 'Euro'
	ELSE 'Not Euro'
END) as 'Currency'
FROM Countries c 
ORDER BY c.CountryName

--problem 4 

SELECT CountryName as [Country Name], IsoCode as [ISO Code]
FROM Countries
WHERE CountryName LIKE '%A%A%A%'
ORDER BY IsoCode

-- problem 5 
SELECT p.PeakName,m.MountainRange as [Mountain],p.Elevation
FROM Peaks p
	JOIN Mountains m
	ON	p.MountainId= m.Id
ORDER BY p.Elevation DESC , p.PeakName ASC

--problem 6 

SELECT p.PeakName,m.MountainRange as [Mountain] ,c.CountryName, cont.ContinentName
FROM Peaks p 
	JOIN Mountains m 
		on p.MountainId = m.Id
	JOIN MountainsCountries mc
		on m.Id = mc.MountainId
	JOIN Countries c
		on mc.CountryCode = c.CountryCode
	JOIN Continents cont
		on c.ContinentCode = cont.ContinentCode
ORDER BY p.PeakName,c.CountryName

--problem 7


SELECT r.RiverName as [River] ,COUNT(c.CountryName) as[Countries Count]
FROM Rivers r 
	JOIN CountriesRivers cr 
		ON r.Id = cr.RiverId
	JOIN Countries c
		on cr.CountryCode = c.CountryCode
GROUP BY r.RiverName
HAVING COUNT (c.CountryCode) >=3
ORDER BY r.RiverName

-- problem 8

SELECT MAX(p.Elevation) as [MaxElevation], MIN(p.Elevation) as [MinElevation] ,AVG(p.Elevation) as [AverageElevation]
FROM Peaks p

--problem 9

SELECT c.CountryName,cont.ContinentName, COUNT(r.Id) as [RiversCount], ISNULL(SUM(r.Length),0) as  [TotalLength]
FROM Countries c 
	LEFT JOIN Continents cont
		on c.ContinentCode = cont.ContinentCode
	LEFT JOIN CountriesRivers cr 
		on cr.CountryCode = c.CountryCode
	LEFT JOIN Rivers r 
		on cr.RiverId = r.Id
GROUP BY c.CountryName,cont.ContinentName
ORDER BY [RiversCount] DESC ,[TotalLength] DESC, c.CountryName ASC

--problem 10 



SELECT cur.CurrencyCode as [CurrencyCode] ,cur.description as [Currency],COUNT(c.CountryCode) as [NumberOfCountries]
FROM Currencies cur 
	 LEFT JOIN Countries c
		on cur.CurrencyCode = c.CurrencyCode
GROUP BY cur.CurrencyCode,cur.Description
ORDER BY [NumberOfCountries] DESC ,[Currency] ASC

--problem 11 


SELECT cont.ContinentName ,SUM (CAST (c.AreaInSqKm AS BIGINT)) as [CountriesArea], SUM (CAST (c.Population AS BIGINT)) as [CountriesPopulation]
FROM Continents cont
	JOIN Countries c
		on cont.ContinentCode = c.ContinentCode
GROUP BY cont.ContinentName
ORDER BY CountriesPopulation DESC


--problem 12 


SELECT c.CountryName , MAX(p.Elevation)  as [HighestPeakElevation] ,MAX(r.Length) as [LongestRiverLength]
FROM Countries c 
	LEFT JOIN MountainsCountries mc
		ON mc.CountryCode = c.CountryCode
	LEFT JOIN Mountains m 
		on mc.MountainId  = m.Id
	LEFT JOIN Peaks p
		ON p.MountainId= m.Id
	LEFT JOIN CountriesRivers cr 
		ON c.CountryCode = cr.CountryCode
	LEFT JOIN Rivers r 
		on r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY [HighestPeakElevation] DESC , LongestRiverLength DESC , c.CountryName

--problem 13


SELECT p.PeakName ,r.RiverName ,LOWER(CONCAT(p.PeakName,SUBSTRING(r.RiverName,2, LEN(r.RiverName)))) as [Mix]
FROM Peaks p,Rivers r
WHERE RIGHT(p.PeakName,1) =LEFT(r.RiverName,1)
ORDER BY Mix


--problem 14 

SELECT  c.CountryName as[Country] ,
		ISNULL(( SELECT pe.PeakName FROM Peaks pe WHERE pe.Elevation = MAX(p.Elevation)),'(no highest peak)') as [Highest Peak Name],
		ISNULL(MAX (p.Elevation),0) as [Highest Peak Elevation],
		ISNULL( 
		(
			SELECT mo.MountainRange 
			FROM Mountains mo 
			WHERE  mo.Id = 
				(
				select pe.MountainId 
				from Peaks pe 
				where pe.Elevation = MAX(p.Elevation) )
				),'(no mountain)' 

		) as [Mountain]
FROM Countries c 
	LEFT JOIN MountainsCountries mc
		on c.CountryCode = mc.CountryCode
	LEFT JOIN Mountains m
		on mc.MountainId  = m.Id
	LEFT JOIN Peaks p
		on p.MountainId  =m.Id

GROUP BY c.CountryName 
ORDER BY c.CountryName,[Highest Peak Name]


-- Problem 15 -------------------------------


CREATE TABLE [Monasteries]
(
Id int IDENTITY(1,1) PRIMARY KEY,
Name nvarchar(50)  NULL,
CountryCode char(2) NULL,
CONSTRAINT fk_MontastiriesCountry FOREIGN KEY (CountryCode)
REFERENCES Countries(CountryCode),
)

ALTER TABLE Countries
ADD IsDeleted bit NOT NULL DEFAULT 0 


GO

UPDATE Countries 
SET IsDeleted = 0
WHERE Countries.CountryCode IN 
(SELECT c.CountryCode
FROM Countries c 
	LEFT JOIN CountriesRivers cr 
		on c.CountryCode = cr.CountryCode
	LEFT JOIN Rivers r
		on cr.RiverId = r.Id
GROUP BY c.CountryCode
HAVING  COUNT (r.Id)>3)

SELECT m.Name as [Monastery], c.CountryName as[Country] 
FROM Monasteries m 
	JOIN Countries c 
		on m.CountryCode = c.CountryCode
WHERE c.IsDeleted =0
ORDER BY m.Name

GO

--problem 16 --------------------------------
GO

UPDATE Countries
SET CountryName = 'Burma'
WHERE CountryName = 'Myanmar'

INSERT INTO Monasteries(Name,CountryCode)
VALUES ('Hanga Abbey',(SELECT c.CountryCode FROM Countries c WHERE c.CountryName = 'Tanzania')),
		('Myin-Tin-Daik',(SELECT c.CountryCode FROM Countries c WHERE c.CountryName = 'Myanmar'))

SELECT * 
FROM Countries 
WHERE CountryName = 'Burma'

SELECT cont.ContinentName ,c.CountryName , COUNT(m.Name) as [MonasteriesCount]
FROM Continents cont 
	LEFT JOIN Countries c
		ON cont.ContinentCode = c.ContinentCode
	LEFT JOIN Monasteries m
		on c.CountryCode = m.CountryCode
		WHERE c.IsDeleted = 0
GROUP BY cont.ContinentName,c.CountryName
ORDER BY [MonasteriesCount] DESC ,c.CountryName


--- problem 17 -----------------------------------

-- SELECT m.MountainRange as [Mountains],p.PeakName as [name] ,p.Elevation as [elevation]
-- FROM Mountains m
	-- JOIN Peaks p
		-- ON p.MountainId = m.Id
-- GROUP BY m.MountainRange , p.PeakName,p.Elevation
-- ORDER BY m.MountainRange ASC
	-- FOR XML path, root;


IF OBJECT_ID('fn_MountainsPeaksJSON') IS NOT NULL
  DROP FUNCTION fn_MountainsPeaksJSON
GO

CREATE FUNCTION fn_MountainsPeaksJSON()
	RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @json NVARCHAR(MAX) = '{"mountains":['

	DECLARE montainsCursor CURSOR FOR
	SELECT Id, MountainRange FROM Mountains

	OPEN montainsCursor
	DECLARE @mountainName NVARCHAR(MAX)
	DECLARE @mountainId INT
	FETCH NEXT FROM montainsCursor INTO @mountainId, @mountainName
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @json = @json + '{"name":"' + @mountainName + '","peaks":['

		DECLARE peaksCursor CURSOR FOR
		SELECT PeakName, Elevation FROM Peaks
		WHERE MountainId = @mountainId

		OPEN peaksCursor
		DECLARE @peakName NVARCHAR(MAX)
		DECLARE @elevation INT
		FETCH NEXT FROM peaksCursor INTO @peakName, @elevation
		WHILE @@FETCH_STATUS = 0
		BEGIN
			SET @json = @json + '{"name":"' + @peakName + '",' +
				'"elevation":' + CONVERT(NVARCHAR(MAX), @elevation) + '}'
			FETCH NEXT FROM peaksCursor INTO @peakName, @elevation
			IF @@FETCH_STATUS = 0
				SET @json = @json + ','
		END
		CLOSE peaksCursor
		DEALLOCATE peaksCursor
		SET @json = @json + ']}'

		FETCH NEXT FROM montainsCursor INTO @mountainId, @mountainName
		IF @@FETCH_STATUS = 0
			SET @json = @json + ','
	END
	CLOSE montainsCursor
	DEALLOCATE montainsCursor

	SET @json = @json + ']}'
	RETURN @json
END
GO