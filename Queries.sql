DECLARE @male INT, @female INT, 
@vet INT, @cleaner INT, @trainer INT,
@tropical INT, @subtropical INT,
@rabies INT, @carnivore INT;
SET @male = 0;
SET @female = 1;
SET @vet = 0;
SET @cleaner = 1;
SET @trainer = 3;
SET @tropical = 2;
SET @subtropical = 3;
SET @rabies = 9;
SET @carnivore = 0;

SELECT * FROM Workers
WHERE Occupation = @cleaner 
AND Gender = @male
AND Age > 20
AND Payrate < 60000
ORDER BY DateJoined;

SELECT COUNT(*) FROM Workers
WHERE cast (Workers.DateJoined as date) > '2019-03-01';

SELECT * FROM Workers /* SELECT Workers,Id, Workers.FirstName, Animals.WorkerId, Animals.Name FROM Workers */
JOIN Animals
ON (Animals.WorkerId = Workers.Id)
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