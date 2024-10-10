/* INSERT
-- Insert data into the Events table in the Date and Name columns.
INSERT INTO Events (Date, Name)
-- Values to be inserted into the Events table.
VALUES 
	('04/04/2024', 'Patrick Sean Lange-Nielsen');
*/

/* UPDATE
-- Update data in the Events table in the Date and Name columns.
UPDATE Events
-- Set the Date and Name columns to the following values.
SET Date = '05/04/2024', Name = 'Patrick Sean Lange-Nielsen æ ø å'
-- Update the row where the EventID is 1.
WHERE EventID = 1;
*/

/* SELECT
-- Select all data from the Events table
SELECT EventId, Date, Name, Attendees, Description
-- From the Events table
FROM Events;
*/

/* DELETE
-- Delete data from the table Events where the EventID is 2.
DELETE FROM Events WHERE EventID = 2;
*/

-- Delete all data from the tables in the database.
DELETE FROM Address;
DELETE FROM CareCenter;
DELETE FROM Employee;
DELETE FROM Resident;
DELETE FROM Task;
DELETE FROM Medicine;
DELETE FROM Role;

-- Reset the identity seed for the tables in the database.
-- This resets the ids to 1.
DBCC CHECKIDENT (Address, RESEED, 0);
DBCC CHECKIDENT (CareCenter, RESEED, 0);
DBCC CHECKIDENT (Employee, RESEED, 0);
DBCC CHECKIDENT (Resident, RESEED, 0);
DBCC CHECKIDENT (Task, RESEED, 0);
DBCC CHECKIDENT (Medicine, RESEED, 0);
DBCC CHECKIDENT (Role, RESEED, 0);

-- Insert data into the Address table in the Street, City, State, and Zip columns.
INSERT INTO Address (Street, City, State, Zip)
VALUES 
	('Rosengårds Alle 52', 'Vejle', 'Region Syddanmark', 7100),
	('Storegade 2A', 'Klovborg', 'Region Midtjylland', 8765),
	('Hejlskovparken 60', 'Egtved', 'Region Syddanmark', 6040);

-- Insert data into the CareCenter table in the Name and AddressId columns.
INSERT INTO CareCenter (Name, AddressId)
VALUES 
	('Plejecenter Rosengården', 1),
	('Plejecenter Østervang', 2),
	('Plejecenter Hejlskov', 3);

-- Insert data into the Employee table in the Name and CareCenterId columns.
INSERT INTO Employee (Name, CareCenterId)
VALUES 
	('Anne Jensen', 1),
	('Henrik Thomsen', 1),
	('Tina Larsen', 3),
	('Julie Mortensen', 2),
	('Niels Jørgensen', 2),
	('Lars Olsen', 3);

-- Insert data into the Resident table in the Name, RoomNumber, and CareCenterId columns.
INSERT INTO Resident (Name, RoomNumber, CareCenterId)
VALUES
	('Patrick', '21a', 1),
	('Tobias', '46c', 2),
	('Simon', '33', 3),
	('Noah A.', '103', 1),
	('Chris', '4b', 2),
	('Noah Obi', '17', 3);

-- Inser data into the Task table in the Name and ResidentId columns.
INSERT INTO Task (Name, ResidentId)
VALUES
	('Opgave 1', 1),
	('Opgave 2', 2),
	('Opgave 3', 3),
	('Opgave 4', 4),
	('Opgave 5', 5),
	('Opgave 6', 6);

-- Insert data into the Medicine table in the Name, Unit Amount, TaskId columns.
INSERT INTO Medicine (Name, Unit, Amount, TaskId)
VALUES
	('Panodil', '500 mg', 2, 2),
	('Glucosamin Complex', '400 mg', 1, 4),
	('Hjertemagnyl', '75 mg', 3, 6);

-- Insert data into the Role table in the RoleName column.
INSERT INTO Role (RoleName)
VALUES
	('SOSU-medarbejder'),
	('Taskplanner'),
	('Administrator');