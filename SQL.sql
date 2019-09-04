Create Database Sample1

--Rename Database
Alter Database Sample1 Modify Name = Sample2
sp_renameDB 'Sample2', 'MTT'

--Drop Database MTT

Create Table tblTask
(
Id int NOT NULL Primary Key,
Title nvarchar(50) NOT NULL,
Description nvarchar(100),
Deleted int NOT NULL,
StatusId int NOT NULL
)

Create Table tblStatus
(
Id int NOT NULL Primary Key,
Status int
)

Alter Table tblTask 
add constraint tblTask_StatusId_FK
Foreign Key (StatusId) References tblStatus(Id)

Alter Table tblTask 
add constraint tblTask_StatusId_DF
Default 1  FOR StatusId

Alter Table tblTask 
add constraint tblTask_Deleted_DF
Default 0  FOR Deleted

--Drop Table tblTask
--Drop Table tblStatus
