use training

create table Employees(
EmployeeId int primary key,
Name varchar(50) not null,
Salary int check(Salary>15000),
HireDate date default(getutcdate()),
DepartmentId int 
foreign key(DepartmentId)
references Departments(DepartmentId)
)

create table Departments(
DepartmentId int primary key,
DepartmentName varchar(50) unique not null
)

--Alter Table & Comstraint


alter table Employees
add Email varchar(50) unique

alter table Employees
add IsActive bit default 1


alter table Employees
drop constraint CK__Employees__Salar__18EBB532

alter table Employees
alter column Salary decimal(10,2)

alter table Employees
add constraint HireDate check(HireDate<=getutcdate())

select * from Employees


--DML


insert into Departments
(DepartmentId,DepartmentName)
values
(1,'IT'),
(2,'HR'),
(3,'Marketing'),
(4,'Sales'),
(5,'Finance')

insert into Departments
(DepartmentId,DepartmentName)
values
(6,'Product'),
(7,'Research')

select * from Departments

insert into Employees
(EmployeeId,Name,Email,Salary,HireDate,DepartmentId)
values
(1, 'John Smith', 'john.smith@email.com', 18000, '2022-03-15', 1),
(2, 'Sarah Johnson', 'sarah.j@email.com', 22000, '2021-07-10', 2),
(3, 'Michael Brown', 'michael.b@email.com', 25000, '2020-01-20', 3),
(4, 'Emily Davis', 'emily.d@email.com', 19500, '2023-02-05', 4),
(5, 'David Wilson', 'david.w@email.com', 30000, '2019-11-18', 5),
(6, 'Jessica Miller', 'jessica.m@email.com', 27000, '2022-08-25', 1),
(7, 'Daniel Moore', 'daniel.m@email.com', 21000, '2020-09-30', 2),
(8, 'Olivia Taylor', 'olivia.t@email.com', 32000, '2018-06-12', 3),
(9, 'James Anderson', 'james.a@email.com', 17500, '2021-04-22', 4),
(10, 'Sophia Thomas', 'sophia.t@email.com', 29000, '2019-12-01', 5);

insert into Employees
(EmployeeId,Name,Email,Salary,HireDate,DepartmentId)
values
(11, 'Andrew Clark', 'andrew.clark@email.com', 24000, '2022-05-14', 1),
(12, 'Priya Sharma', 'priya.sharma@email.com', 26000, '2021-11-03', 1),
(13, 'Robert King', 'robert.king@email.com', 23000, '2023-01-19', 1);



update Employees
set Salary=Salary+Salary*0.05 where DepartmentId=1

update Employees
set IsActive=0
where HireDate<'2020-01-01'

delete from Employees
where IsActive=0

update Employees
set DepartmentId=5 where EmployeeId in (1,6)


--Joins
select e.Name,d.DepartmentName
from Employees e
inner join Departments d
on e.DepartmentId=d.DepartmentId


select d.DepartmentName
from Departments d
left join Employees e
on e.DepartmentId=d.DepartmentId
where e.EmployeeId is null

select d.departmentName,Max(e.Salary) as max_salary
from Departments d 
left join Employees e
on e.DepartmentId=d.DepartmentId
group by DepartmentName


select * from Employees