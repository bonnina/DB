DECLARE @male INT, @female INT, 
@vet INT, @cleaner INT, @trainer INT,
@tropical INT, @subtropical INT,
@rabies INT, 
@carnivore INT, @fish INT;

SET @male = 0;
SET @female = 1;
SET @vet = 0;
SET @cleaner = 1;
SET @trainer = 3;
SET @tropical = 2;
SET @subtropical = 3;
SET @rabies = 9;
SET @carnivore = 0;
SET @fish = 8;

SELECT * FROM Workers
WHERE Occupation = @cleaner 
AND Gender = @male
AND Age > 20
AND Payrate < 60000
ORDER BY DateJoined;

SELECT COUNT(*) FROM Workers
WHERE cast (Workers.DateJoined as date) > '2019-03-01';

SELECT Workers.Id, Workers.FirstName, Animals.WorkerId, Animals.Name 
FROM Workers 
JOIN Animals
ON Animals.WorkerId = Workers.Id
WHERE Animals.Name = 'Teddy';

SELECT COUNT(*) FROM Workers 
JOIN Animals 
ON (Animals.WorkerId = Workers.Id)
WHERE Animals.Species = 'Dolphin';

SELECT * FROM Workers
JOIN Animals
ON (Animals.WorkerId = Workers.Id)
WHERE Workers.Occupation = @vet
OR Workers.Occupation = @cleaner
OR Workers.Occupation = @trainer;

SELECT COUNT(*) FROM Workers
JOIN Animals
ON (Animals.WorkerId = Workers.Id)
WHERE Workers.Occupation = @vet
OR Workers.Occupation = @cleaner
OR Workers.Occupation = @trainer;

SELECT * FROM Animals
WHERE EnclosureNumber = 75
AND Age > 10
AND Weight > 500
AND Gender = @female
ORDER BY Name ASC;

SELECT COUNT(*) FROM Animals
WHERE EnclosureNumber = 125
AND Age = 5
AND Weight < 100
AND Gender = @male;

SELECT * FROM Animals
Where Age = 3
AND (ClimatZone = @tropical
OR ClimatZone = @subtropical);

SELECT COUNT(*) FROM Animals
Where ClimatZone = @tropical
OR ClimatZone = @subtropical;

SELECT * FROM Animals
JOIN Vaccinations
ON Animals.MedicalRecordId = Vaccinations.MedicalRecordId
JOIN MedicalRecords
ON Animals.MedicalRecordId = MedicalRecords.Id
WHERE cast (Vaccinations.Date as date) > '2021-06-01'
AND MedicalRecords.ExpectingChildren = 'true'
AND Animals.Age > 2;

SELECT COUNT(*) FROM Animals
JOIN Illnesses
ON Animals.MedicalRecordId = Illnesses.MedicalRecordId
WHERE Illnesses.Name = @rabies
AND Animals.Gender = @male
AND Animals.AnimalId != NULL;

SELECT * FROM Animals
WHERE DietType = @carnivore
AND Weight > 400 
AND Weight < 700;

SELECT * FROM Animals
WHERE ClimatZone = @tropical
OR ClimatZone = @subtropical;

SELECT * FROM Suppliers
JOIN Deliveries 
ON Deliveries.SupplierId = Suppliers.Id
WHERE cast (Deliveries.Date as date) > '2019-01-01'
AND cast (Deliveries.Date as date) < '2020-12-01'
AND Deliveries.Amount = 165
AND Deliveries.Price < 5;

SELECT COUNT(*) FROM Suppliers
JOIN Deliveries 
ON Deliveries.SupplierId = Suppliers.Id
JOIN Foods on Deliveries.ProductId = Foods.Id
WHERE cast (Deliveries.Date as date) > '2019-01-01'
AND cast (Deliveries.Date as date) < '2020-12-01'
AND Foods.Type = @fish
AND Deliveries.Amount = 165
AND Deliveries.Price < 5;

SELECT Suppliers.Id, Foods.Id, Foods.SupplierId, Foods.Type
FROM Suppliers
JOIN Foods on Foods.SupplierId = Suppliers.Id
WHERE Suppliers.Name = 'Self'

SELECT Suppliers.Id, Suppliers.Name, Deliveries.SupplierId, Deliveries.ProductId, SUM(Deliveries.Amount) as amount 
FROM Suppliers
JOIN Deliveries 
ON Deliveries.SupplierId = Suppliers.Id
JOIN Foods on Deliveries.ProductId = Foods.Id
WHERE Suppliers.Name = 'Self'
GROUP BY Suppliers.Id, Suppliers.Name, Deliveries.SupplierId, Deliveries.ProductId