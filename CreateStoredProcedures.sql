CREATE PROC spPeopleGetAll
AS
BEGIN
SELECT * FROM PEOPLE
END

CREATE PROC spPeopleGetById
@ID INT
AS
BEGIN
SELECT * FROM PEOPLE WHERE id = @ID
END

CREATE PROC spPeopleDeleteById
@ID INT
AS
BEGIN
DELETE FROM PEOPLE WHERE id = @ID
END

CREATE PROC spPeopleDeleteAll
AS
BEGIN
DELETE FROM PEOPLE
END

CREATE PROC spPeopleInsert
@LastName nvarchar(50),
@FirstName nvarchar(50),
@MiddleName nvarchar(50),
@Age int,
@Email nvarchar(50),
@Phone nvarchar(50),
@AddressLine1 nvarchar(50),
@AddressLine2 nvarchar(50),
@UnitOrApartmentNumber nvarchar(50),
@City nvarchar(50),
@State nvarchar(50),
@Zipcode nvarchar(50),
@CreatedDate date,
@CreatedBy nvarchar(50),
@UpdatedDate date,
@UpdatedBy nvarchar(50),
@Password nvarchar(50),
@Salt nvarchar(50),
@IsLocked nvarchar(50),
@LastLockedDateTime datetime,
@FailedAttempts int
AS
BEGIN
INSERT INTO People VALUES (@LastName, @FirstName, @MiddleName, @Age, @Email, @Phone, @AddressLine1, @AddressLine2, @UnitOrApartmentNumber, @City, @State, @Zipcode, @CreatedDate, @CreatedBy, @UpdatedDate, @UpdatedBy, @Password, @Salt, @IsLocked, @LastLockedDateTime, @FailedAttempts)
END



CREATE PROC spPeopleUpdate
@id int,
@LastName nvarchar(50),
@FirstName nvarchar(50),
@MiddleName nvarchar(50),
@Age int,
@Email nvarchar(50),
@Phone nvarchar(50),
@AddressLine1 nvarchar(50),
@AddressLine2 nvarchar(50),
@UnitOrApartmentNumber nvarchar(50),
@City nvarchar(50),
@State nvarchar(50),
@Zipcode nvarchar(50),
@CreatedDate date,
@CreatedBy nvarchar(50),
@UpdatedDate date,
@UpdatedBy nvarchar(50),
@Password nvarchar(50),
@Salt nvarchar(50),
@IsLocked nvarchar(50),
@LastLockedDateTime datetime,
@FailedAttempts int
AS
BEGIN
UPDATE People SET 
LastName = @LastName, 
FirstName = @FirstName, 
MiddleName = @MiddleName, 
Age = @Age, 
Email = @Email, 
Phone = @Phone, 
AddressLine1 = @AddressLine1, 
AddressLine2 = @AddressLine2, 
UnitOrApartmentNumber = @UnitOrApartmentNumber, 
City = @City, 
State = @State, 
Zipcode = @Zipcode, 
CreatedDate = @CreatedDate, 
CreatedBy = @CreatedBy, 
UpdatedDate = @UpdatedDate, 
UpdatedBy = @UpdatedBy, 
Password = @Password, 
Salt = @Salt, 
IsLocked = @IsLocked, 
LastLockedDateTime = @LastLockedDateTime, 
FailedAttempts = @FailedAttempts
WHERE id = @id
END

CREATE PROC spDepartmentsGetAll
AS
BEGIN
SELECT * FROM Departments
END

CREATE PROC spDepartmentsGetById
@ID INT
AS
BEGIN
SELECT * FROM Departments WHERE id = @ID
END

CREATE PROC spDepartmentsDeleteById
@ID INT
AS
BEGIN
DELETE FROM Departments WHERE id = @ID
END

CREATE PROC spDepartmentsDeleteAll
AS
BEGIN
DELETE FROM Departments
END

CREATE PROC spDepartmentsInsert
@Name nvarchar(50),
@Budget float,
@StartDate date,
@Instructorid int,
@RowVersion nvarchar(50),
@CreatedDate date,
@CreatedBy nvarchar(50),
@UpdatedDate date,
@UpdatedBy nvarchar(50)
AS
BEGIN
INSERT INTO Departments VALUES (@Name,@Budget,@StartDate,@Instructorid,@RowVersion,@CreatedDate,@CreatedBy,@UpdatedDate,@UpdatedBy)
END



CREATE PROC spDepartmentsUpdate
@id int,
@Name nvarchar(50),
@Budget float,
@StartDate date,
@Instructorid int,
@RowVersion nvarchar(50),
@CreatedDate date,
@CreatedBy nvarchar(50),
@UpdatedDate date,
@UpdatedBy nvarchar(50)
AS
BEGIN
UPDATE Departments SET 
Name = @Name,
Budget = @Budget,
StartDate = @StartDate,
Instructorid = @Instructorid,
RowVersion = @RowVersion,
CreatedDate = @CreatedDate,
CreatedBy = @CreatedBy,
UpdatedDate = @UpdatedDate,
UpdatedBy = @UpdatedBy
WHERE id = @id
END

CREATE PROC spCoursesGetAll
AS
BEGIN
SELECT * FROM Courses
END

CREATE PROC spCoursesGetById
@ID INT
AS
BEGIN
SELECT * FROM Courses WHERE id = @ID
END

CREATE PROC spCoursesDeleteById
@ID INT
AS
BEGIN
DELETE FROM Courses WHERE id = @ID
END

CREATE PROC spCoursesDeleteAll
AS
BEGIN
DELETE FROM Courses
END

CREATE PROC spCoursesInsert
@Title nvarchar(50),
@Credits float,
@Departmentid int,
@CreatedDate date,
@CreatedBy nvarchar(50),
@UpdatedDate date,
@UpdatedBy nvarchar(50)
AS
BEGIN
INSERT INTO Courses VALUES (@Title,
@Credits,
@Departmentid,
@CreatedDate,
@CreatedBy,
@UpdatedDate,
@UpdatedBy)
END



CREATE PROC spCoursesUpdate
@id int,
@Title nvarchar(50),
@Credits float,
@Departmentid int,
@CreatedDate date,
@CreatedBy nvarchar(50),
@UpdatedDate date,
@UpdatedBy nvarchar(50)
AS
BEGIN
UPDATE Courses SET 
Title = @Title,
Credits = @Credits,
Departmentid = @Departmentid,
CreatedDate = @CreatedDate,
CreatedBy = @CreatedBy,
UpdatedDate = @UpdatedDate,
UpdatedBy = @UpdatedBy
WHERE id = @id
END


EXECUTE spDepartmentsInsert 1,1,'2000-01-01',6,1,'2000-01-01',1,'2000-01-01',1


EXECUTE spDepartmentsUpdate 3, 2,1,'2000-01-01',6,1,'2000-01-01',1,'2000-01-01',1

EXECUTE spDepartmentsGetAll

DELETE FROM Instructor

CREATE PROC DeleteAllTables
AS
BEGIN
DELETE FROM Courses
DELETE FROM Departments
DELETE FROM Enrollments
DELETE FROM Instructor
DELETE FROM InstructorCourses
DELETE FROM OfficeAssignments
DELETE FROM People
DELETE FROM PersonRoles
DELETE FROM Roles
DELETE FROM Student
END