/*
Created		11/10/2024
Modified		11/10/2024
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/

Create Database SchoolDB
USE SchoolDB

Create table [Student]
(
	[StudentID] Nvarchar(10) NOT NULL,
	[FullName] Nvarchar(255) NOT NULL,
	[AverageScore] Float NOT NULL,
	[FacultyID] Integer NOT NULL,
	[MajorID] Char(1) NOT NULL,
	[Avatar] Image NULL,
Primary Key ([StudentID])
) 
go

Create table [Faculty]
(
	[FacultyID] Integer NOT NULL,
	[FacultyName] Nvarchar(255) NOT NULL,
Primary Key ([FacultyID])
) 
go

Create table [Major]
(
	[FacultyID] Integer NOT NULL,
	[MajorID] Char(1) NOT NULL,
	[Name] Nvarchar(255) NOT NULL,
Primary Key ([FacultyID],[MajorID])
) 
go


Alter table [Major] add  foreign key([FacultyID]) references [Faculty] ([FacultyID])  on update no action on delete no action 
go
Alter table [Student] add  foreign key([FacultyID],[MajorID]) references [Major] ([FacultyID],[MajorID])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


