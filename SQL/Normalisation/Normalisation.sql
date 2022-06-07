use Assignment1
--============1NF==============
--Each table cell should contain a single value.
--Each record needs to be unique.
CREATE TABLE ClintRent(
ClintNo VARCHAR(20),
CName VARCHAR(20) NOT NULL,
PropertyNo VARCHAR(10),
pAddress VARCHAR(30),
RentStart DATE,
RentFinish DATE,
Rent INT,
OwnerNo VARCHAR(10),
OName VARCHAR(20)
)
select * from ClintRent
insert into ClintRent values 
('CR76','Johan Kay','PG4','6 Lawrence St,Glasgow','1-JUL-00','31-AUG-01',350,'CO40','Tina Murphy'),
('CR76','Johan Kay','PG16','5 Novar Dr,Glasgow','1-SEP-02','1-SEP-02',450,'CO93','Tony Shaw'),
('CR56','Aline Stewart','PG4','6 Lawrence St,Glasgow','1-SEP-99','10-JAN-00',350,'CO40','Tina Murphy'),
('CR56','Aline Stewart','PG36','2 onor Rd, Glasgow','10-OCT-00','1-DEC-01',370,'CO93','Tony Shaw'),
('CR56','Aline Stewart','PG16','5 Novar Dr,Glasgow','1-NOV-02','1-AUG-03',450,'CO93','Tony Shaw')
--=======2NF==========
--Rule 1- Be in 1NF
--Rule 2- Single Column Primary Key that does not functionally dependant on any subset of candidate key relation
create table T1_2NF(
ClintId int primary key,
ClintNo varchar(10) unique,
CName varchar(30))

insert into T1_2NF values
(1,'CR76','Johan Kay'),
(2,'CR56','Aline Stewart')

create table T2_2NF(
ClintId int foreign key references  T1_2NF(ClintId),
PropertyNo VARCHAR(10),
pAddress VARCHAR(30),
RentStart DATE,
RentFinish DATE,
Rent INT,
OwnerNo VARCHAR(10),
OName VARCHAR(20))

insert into T2_2NF values 
(1,'PG4','6 Lawrence St,Glasgow','1-JUL-00','31-AUG-01',350,'CO40','Tina Murphy'),
(1,'PG16','5 Novar Dr,Glasgow','1-SEP-02','1-SEP-02',450,'CO93','Tony Shaw'),
(2,'PG4','6 Lawrence St,Glasgow','1-SEP-99','10-JAN-00',350,'CO40','Tina Murphy'),
(2,'PG36','2 onor Rd, Glasgow','10-OCT-00','1-DEC-01',370,'CO93','Tony Shaw'),
(2,'PG16','5 Novar Dr,Glasgow','1-NOV-02','1-AUG-03',450,'CO93','Tony Shaw')

select * from T1_2NF
select * from T2_2NF

--=========3NF=========
--Rule 1- Be in 2NF
--Rule 2- Has no transitive functional dependencies
create table T1_3NF(
ClintId int primary key,
ClintNo varchar(10) unique ,
CName varchar(30))

insert into T1_3NF values
(1,'CR76','Johan Kay'),
(2,'CR56','Aline Stewart')

create table T2_3NF(
OwnerId int primary key,
OwnerNo VARCHAR(10),
OName VARCHAR(20))

insert into T2_3NF values
(101,'CO40','Tina Murphy'),
(102,'CO93','Tony Shaw')

create table T3_3NF(
ClintId int foreign key references  T1_3NF(ClintId),
PropertyNo VARCHAR(10),
pAddress VARCHAR(30),
RentStart DATE,
RentFinish DATE,
Rent INT,
OwnerId int foreign key references T2_3NF(OwnerId))

insert into T3_3NF values
(1,'PG4','6 Lawrence St,Glasgow','1-JUL-00','31-AUG-01',350,101),
(1,'PG16','5 Novar Dr,Glasgow','1-SEP-02','1-SEP-02',450,102),
(2,'PG4','6 Lawrence St,Glasgow','1-SEP-99','10-JAN-00',350,101),
(2,'PG36','2 onor Rd, Glasgow','10-OCT-00','1-DEC-01',370,102),
(2,'PG16','5 Novar Dr,Glasgow','1-NOV-02','1-AUG-03',450,102)

select * from T1_3NF
select * from T2_3NF
select * from T3_3NF


