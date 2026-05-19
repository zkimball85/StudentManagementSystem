use master

CREATE DATABASE SMS;
GO

USE SMS;
GO

CREATE TABLE Student
(
	StudentId		Int			PRIMARY KEY IDENTITY,
	FName			Varchar(40) NOT NULL, 
	LName			Varchar(40) NOT NULL,
	DateOfBirth		Date		NOT NULL
)