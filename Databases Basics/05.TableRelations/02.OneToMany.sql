CREATE TABLE Models (
	Id INT IDENTITY (101,1),
	Name VARCHAR(100),
	ManufacturerID INT NOT NULL
)

CREATE TABLE Manufacturers (
	Id INT IDENTITY,
	Name VARCHAR(100),
	EstablishedOn DATE
)

INSERT INTO Models (Name, ManufacturerID)
VALUES ('X1', 1),
	   ('i6', 1),
	   ('Model S', 2),
	   ('Model X', 2),
	   ('Model 3', 2),
	   ('Nova', 3)

INSERT INTO Manufacturers (Name, EstablishedOn)
VALUES ('BMW', '07/03/1916'),
	('Tesla', '01/01/2003'),
	('Lada', '01/05/1966')

ALTER TABLE Models
ADD CONSTRAINT PK_Models 
PRIMARY KEY (Id)

ALTER TABLE Manufacturers
ADD CONSTRAINT PK_Manufacturers 
PRIMARY KEY (Id)

ALTER TABLE Models
ADD CONSTRAINT FK_Models_Manufacturers
FOREIGN KEY (ManufacturerID)
REFERENCES Manufacturers(Id)