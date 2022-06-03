

Create database Job_Management

use [Job_Management]


create table STUDENT (
ID int Identity (1,1) primary key not null,
fullName  nvarchar(50) not null,
dateOfBirth varchar(50),
_address nvarchar(100),
gender nvarchar(15),
phoneNumber varchar(15),
healthCondition varchar(50),
additionalCondition varchar(50),
userID int not null)

insert into EMPLOYER values ('name', 'address', '0123124', 1)
