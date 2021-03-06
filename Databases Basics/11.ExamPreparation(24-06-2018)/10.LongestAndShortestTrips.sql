SELECT
	a.Id,
	CONCAT(a.FirstName, ' ', a.LastName) AS FullName,
	MAX(DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate)) AS LongestTrip,
	MIN(DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate)) AS ShortestTrip
FROM Accounts AS a
JOIN AccountsTrips AS att ON att.AccountId = a.id
JOIN Trips AS t ON t.Id = att.TripId
WHERE a.MiddleName IS NULL AND t.CancelDate IS NULL
GROUP BY a.Id, a.FirstName, a.LastName
ORDER BY LongestTrip DESC, a.Id