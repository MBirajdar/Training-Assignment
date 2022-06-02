create database EmployeeManagement
create table Code_Employee ( empno int primary key, 
empname varchar(50) not null, 
empsal numeric(10,2) check(empsal >= 25000) , 
emptype varchar(1) check(emptype in('C','P')))
select * from Code_Employee
select * from Code_Employee



create or alter proc Employee_Management(@empname varchar(50), @empsal numeric(10,2 ), @emptype varchar(1))
as
begin
declare @empid int =(select max(empno) from Code_Employee)
begin
declare @empno int = @empid + 1;
insert into Code_Employee values(@empname,@empsal,@emptype)
end
end

execute Employee_Management @empname='Manoj',@empsal=28500,@emptype='p'