SELECT 
	e.FirstName, 
	e.LastName, 
	r.Description, 
	FORMAT(OpenDate, 'yyyy-MM-dd') AS OpenDate 
FROM Employees AS e
JOIN Reports AS r ON r.EmployeeId = e.Id
ORDER BY e.Id, r.OpenDate, r.Id