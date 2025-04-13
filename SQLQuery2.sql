Create database universityDB1;

use universityDB1;

create table Student(
ID integer primary key,
SName varchar (20) not null,
dept_name varchar (20) not null,
);

create table Course(
course_id integer primary key,
title varchar (20),
dept_Name varchar (20),
credits varchar (20),
prereq_id integer foreign key references Course(course_id)

);

create table Section(
sec_id integer primary key,
course_id integer foreign key references Course(course_id),
semester integer ,
syear integer,
instructor_id integer foreign key references Instructor(Ins_ID)
);

create table Classroom(
room_no integer primary key,
building varchar (20),
capacity integer,
);

create table Time_Slot(
time_slot_id integer primary key,
Wday integer ,
start_time integer ,
end_time integer,
);

create table Takes (
student_id integer foreign key references Student(ID),
sec_id integer foreign key references Section(sec_id),
primary key(student_id, sec_id ),
);

create table Instructor(
Ins_ID integer primary key,
ins_name varchar (20),
ins_dept_name varchar ,
salary decimal ,
);

create table Teaches(
Ins_ID integer foreign key references Instructor(Ins_ID),
course_id integer foreign key references Course(course_id),
primary key(Ins_ID,course_id)
);
