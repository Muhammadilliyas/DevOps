CREATE DATABASE employeeDB1;

USE employeeDB1;

CREATE TABLE department_info(
depId INTEGER PRIMARY KEY,
departmentName VARCHAR(20) NOT NULL,
departmentLocation VARCHAR(40) NOT NULL
);

CREATE TABLE emploeeyee_info(
empID INTEGER PRIMARY KEY,
empName VARCHAR(20) NOT NULL,
empSalary DECIMAL(10,2) NOT NULL,
job VARCHAR(20),
phone INTEGER UNIQUE,
depId INTEGER FOREIGN KEY REFERENCES department_info(depId)
);

INSERT INTO department_info VALUES(1, 'COMPUTER SCIENCE','Block D');

INSERT INTO employee_info VALUES(1, 'ALi',20000.20,'INSTRUCTOR',111,1);

INSERT INTO employee_info(empID,empName,empSalary,depId)
VALUES(2,'Haider',5000,1);

SELECT empID,empName FROM employee_info;
SELECT * FROM department_info;
