CREATE TABLE ClintRent(
ClintNo VARCHAR(20),
CName VARCHAR(20) NOT NULL,
PropertyNo VARCHAR(10),
pAddress VARCHAR(30),
RentStart DATE,
RentFinish DATE,
Rent INT,
OwnerNo VARCHAR(10),
OName VARCHAR(20),
)
select * from ClintRent
insert into ClintRent values 
('CR76','Johan Kay','PG4','6 Lawrence St,Glasgow','1-JUL-00','31-AUG-01',350,'CO40','Tina Murphy'),
('CR76','Johan Kay','PG16','5 Novar Dr,Glasgow','1-SEP-02','1-SEP-02',450,'CO93','Tony Shaw'),
('CR56','Aline Stewart','PG4','6 Lawrence St,Glasgow','1-SEP-99','10-JAN-00',350,'CO40','Tina Murphy'),
('CR56','Aline Stewart','PG36','2 onor Rd, Glasgow','10-OCT-00','1-DEC-01',370,'CO93','Tony Shaw'),
('CR56','Aline Stewart','PG16','5 Novar Dr,Glasgow','1-NOV-02','1-AUG-03',450,'CO93','Tony Shaw')
