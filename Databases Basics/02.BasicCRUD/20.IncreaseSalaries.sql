UPDATE Employees
SET Salary += Salary * 0.12
WHERE DepartmentId IN (SELECT DepartmentID FROM Departments WHERE NAME IN ('Engineering', 'Tool Design', 'Marketing', 'Information Services'))
SELECT Salary FROM Employees

