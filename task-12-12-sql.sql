create database task1;
create table customers(
customersId int not null,
 number int not null,
 LastName varchar(255) not null,
 FirstName varchar(255) not null,
);

create table nameorader(
 oraderId int not null,
 number int not null,
 customersId int not null,
 ordarState varchar(255) not null,
 stortId varchar(255) not null,
);
create table products(
 productsId int not null,
 brandId int not null,
 productsnumber int not null,
 ordarState varchar(255) not null,
 price varchar(255) not null,
);
CREATE TABLE Employee (
	EmployeeID INT IDENTITY(1,1),
	FirstName VARCHAR(255) NOT NULL,
	MiddleInitial VARCHAR(255),
	LastName VARCHAR(255) NOT NULL,
	salary INT,
	JobID INT 
);