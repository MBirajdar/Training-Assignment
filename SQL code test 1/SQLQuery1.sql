create database Test1
use Test1
Create table EMP8 (
Empid int primary key,
Name varchar(30),
Salary float,
Deptno int
)
select * from EMP8
insert into EMP8   
values(1,'Manoj',1000,10),
(2,'Rahul',2000,20),
(3,'Mahesh',3000,30),
(4,'Nikita',4000,40)

--a.accept only 10,20,30 as deptno
alter table EMP8 add constraint Deptnocheck check(Deptno=10 or Deptno=20 or Deptno=30)
update EMP8 set  Salary=10000 where Empid in(1,2)
-- b.    Every employee salary must be in the range of 5000 to 50000 only
alter table EMP8 add constraint salrange check(Salary>5000 and Salary<500000)


--Q no 2


SELECT DATEDIFF(dd,'1999/09/18','2022/05/17') AS DateDiff;



