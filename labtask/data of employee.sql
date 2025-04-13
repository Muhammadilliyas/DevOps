CREATE DATABASE employeeDB01;

use employeeDB01;

create table department_info(
depid integer primary key,
departmentname varchar(20) not null,
departmentlocation varchar(40) not null,
);

CREATE table employee_info(
empid integer primary key,
empname varchar(20) not null,
empsalary decimal(10,2) not null,
job varchar(20),
phone integer unique,
depid integer foreign key  references department_info(depid)
);

insert into department_info values(1,'computer','block b');
insert into employee_info values(1,'ali',20000.20,'instructor',111,1);

--insert into employee_info(empid,empname,empsalary,depid)
--values(2,'arif',5000,1);

select empid,empname from employee_info;
select * from department_info;

select *from employee_info;

update employee_info
set empsalary+=1000
where empid =1;

delete from employee_info
where empid=1;

-- Update the column definition for job to allow for longer job titles
ALTER TABLE employee_info
ALTER COLUMN job varchar(50);
drop 
-- Insert data for 20 employees into the employee_info table
INSERT INTO employee_info (empid, empname, empsalary, job, phone, depid) VALUES
(10, 'John Doe', 50000, 'Manager', 1234567890, 1),
(20, 'Jane Smith', 45000, 'Developer', 1234567891, 1),
(30, 'Michael Johnson', 60000, 'Analyst', 1234567892, 1),
(40, 'Emily Brown', 55000, 'Designer', 1234567893, 1),
(50, 'David Wilson', 52000, 'Engineer', 1234567894, 1),
(60, 'Sarah Davis', 48000, 'Tester', 1234567895, 1),
(70, 'Robert Martinez', 62000, 'Project Manager', 1234567896, 1),
(80, 'Jennifer Taylor', 58000, 'System Administrator', 1234567897, 1),
(90, 'William Anderson', 53000, 'Data Scientist', 1234567898, 1),
(100, 'Jessica Hernandez', 49000, 'Business Analyst', 1234567899, 1),
(110, 'Christopher Gonzalez', 61000, 'Software Engineer', 1234567800, 1),
(120, 'Amanda Perez', 57000, 'Quality Assurance', 1234567801, 1),
(130, 'Matthew Carter', 54000, 'Network Administrator', 1234567802, 1),
(140, 'Stephanie Flores', 50000, 'Network Administrator', 1234567803, 1),
(150, 'Daniel Scott', 63000, 'Product Manager', 1234567804, 1),
(160, 'Ashley Lee', 59000, 'UI/UX Designer', 1234567805, 1),
(170, 'Andrew King', 56000, 'Frontend Developer', 1234567806, 1),
(180, 'Olivia Wright', 52000, 'Backend Developer', 1234567807, 1),
(190, 'James Thomas', 64000, 'DevOps Engineer', 1234567808, 1),
(200, 'Megan Hall', 60000, 'Technical Writer', 1234567809, 1);

select *from department_info;

select job, count(*) from employee_info group by  job;
select  empsalary, count(*) from employee_info group by empsalary;

select *from employee_info;
order by empsalary DESC;

select *from employee_info
order by empname;
 
select *from employee_info;

select *from employee_info
where
empid=50 or empname ='abc';

select *from employee_info
where
not empid=40;
--column ke name change
select empid as 'EMPID',empname as 'EMPLOYEE NAME',empsalary as 'SALARY' from employee_info;

select sum(empsalary) as 'sum of salary' from employee_info;
select AVG(empsalary) as 'Average of salary' from employee_info;

select min(empsalary) as 'minimum salary' from employee_info;
select max(empsalary) as 'maximum salary' from employee_info;

select count(empname) as 'NO OF EMPLOYEE',min(empsalary) as 'minimum salary',max(empsalary) as 'maximum salary' from employee_info;

--top ke rows ko execute krne ke lye
--or last 3 rows ko execute or usme bi last wali ko sb se pehle top pe show hoga
select top 3 *from employee_info order by empid desc;

select abs(-10) as 'absolute';

select round(10.955,0);
select CEILING(20.10);
select FLOOR(20.99);

select SIGN(-453),SIGN(154),SIGN(0);

select SQUARE(5),SQRT(25);

select PI(),cos(30),sin(90),TAN(45);

--find length of character
select empname, len(empname) from employee_info;
select min(len(empname)) as 'mininum length of employee'from employee_info;
select max(len(empname)) as 'maximum length of employee'from employee_info;

select empname,UPPER(empname)from employee_info;
select empname,lower(empname)from employee_info;

select empname,upper(REVERSE(empname))from employee_info;

select LTRIM('    anything'),rtrim('anything    ');

select empname,SUBSTRING(empname,1,3)from employee_info;
select empname,replicate(empname,3)from employee_info;
select empname,REPLACE(empname,'jane','hello')from employee_info;
select FORMAT(123456789,'######-####');
select CONCAT('hello','',empname,'','world')from employee_info;
select QUOTENAME(empname,'<>')from employee_info;

select GETDATE();
select SYSDATETIME();
select DATENAME(month,getdate());
select DATENAME(WEEKDAY,getdate());
select DATEDIFF(week,'january 10 1965',getdate());
select DATEDIFF(hour,'january 10 1965',getdate());
select DATEADD(month,10,getdate());
select DATEADD(HOUR,10,getdate());
select ISDATE('10-12-2023');
select ISDATE('11111');

select from employee_info  order by empid
offset 1 rows fetch next 1 rows only;

select *from employee_info;

Select EmpId, EmpName , EmpSalary , departmentname ,departmentlocation
from employee_info inner join department_info on 
Employee_info.depid = Department_info.depid;

alter table employee_info 
drop constraint [FK__employee___depid__4CA06362];

select empid , empname , empsalary , departmentname ,departmentlocation 
from employee_info e right outer join department_info d on
e.depid = d.depid;


select empid , empname , empsalary , departmentname ,departmentlocation 
from employee_info e full outer join department_info d on
e.depid = d.depid;


create table study(
S_ID int,
C_ID int 
);


insert into study values(1,1);
insert into study values(2,2);
insert into study values(1,2);

select *from study;
select t1.S_ID from study t1, study t2
where t1.S_ID = t2.S_ID and
t1.C_ID <> t2.C_ID;

select distinct t1.S_ID from study t1, study t2
where t1.S_ID = t2.S_ID and
t1.C_ID <> t2.C_ID;

alter table employee_info
add addr varchar(100);

select *from employee_info;

select e.empid, e.empname, e.addr
from employee_info e, department_info d
where e.depid = d.depid and 
e.addr = d.departmentlocation;

Declare @name varchar(50)

begin
declare @salary numeric;
set @salary = (select avg (EmpSalary) from Employee

begin declare @1 int , @s2 int @3s int ,@s4 int ,@s5 int @sum int, @perc numeric;
sekect @s1 = 0000.......
begin while(select min(empsalary) from employee_info)<80000
begin 
update employee_info set empSalary  
if((select min salary(empsalary from em

create view v highernersemployee
 as select * from v_emoloyeedeoarmtmentwise 
 as 
 select empNAame , 





create table employeeLog(
empid int,
empname varchar(50),
empsalary numeric,
phone int,
depid int,
empaddress varchar(100),
modifiedby varchar(50),
modifieddate date
);
select * from employeeLog




-->Insert
alter trigger tr_insertEmpLog
on employee_info
after insert
as
begin
    insert into employeeLog
select empid, empname, empsalary, job,phone, depid, 
    *from inserted;
end
Insert into employee_info values (101,'Qasim', 500000, 'Manager', 1234, 1)
select * from employeeLog;



-->adding column to emplog
alter table employeeLog
add action varchar(50)


-->inserting after add a new column
alter trigger tr_insertEmpLog
on employe_info
after insert
as
begin
    insert into employeeLog
select empId, empName, empSalary, phone, deptId, Address, 'Ahmed', GETDATE(),'Inserted'
    from inserted;
end
Insert into employe_info values (50,'Hassan', 45000,'Manager', 43423, 1, 'abcd')
select * from employeeLog

-->Delete
create trigger tr_deleteEmpLog
on employe_info
after delete
as
begin
    insert into employeeLog
select empId, empName, empSalary, phone, deptId, Address, 'Ahmed', GETDATE(),'Deleted'
    from deleted;
end

delete from employe_info
where empId = 35

select * from employeeLog


-->
create or alter trigger tr_messageOnCreateTable
on database
For CREATE_TABLE
AS
BEGIN
   PRINT'NEW TABLE CREATED SUCCESSFULLY ...!'
END

CREATE TABLE emp(
id int
);


create or alter trigger tr_messageOnCreateORDropTable
on database
For CREATE_TABLE,DROP_TABLE
AS
BEGIN
   PRINT'NEW TABLE CREATED OR DROPED SUCCESSFULLY ...!'
END

CREATE TABLE emp11(
id int
);

DROP TABLE emp1

