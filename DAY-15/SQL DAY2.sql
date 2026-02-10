use TRAINING

create table Department(
  DepartmentId int primary key,
  DepartmentName varchar(30)
)

insert into Department(DepartmentId,DepartmentName)
values 
(1,'IT'),
(2,'HR'),
(3,'Sales'),
(4,'Finance'),
(5,'Marketing')

select * from Department


update Employee
set DepartmentId=
case
when Department='IT' then 1
when Department='HR' then 2
when Department='Sales' then 3
when Department='Finance' then 4
when Department='Marketing' then 5
end;

select * from Employee


alter table Employee
drop column Department

-- Que:1
create view vw_EmployeeBasicInfo 
as
select EmployeeID,FirstName,LastName
from Employee

alter view vw_EmployeeBasicInfo
as
select EmployeeID,FirstName,LastName,DepartmentId
from Employee

select * from vw_EmployeeBasicInfo


-- Que:2
with finance_data
AS (
select * from Employee
where DepartmentId=4
)
select * from finance_data


-- Que:3
select * into #tempTable
from Employee
where DepartmentId=2

select * from #tempTable

-- Que : 4
create table skill(
skillId int primary key,
skill  varchar(20)
)

insert into skill(skillId,skill)
values
(1,'Singing'),
(2,'Dancing'),
(3,'Traveling'),
(4,'Cooking')





select * from skill

create table EmployeeSkill(
EmployeeID int,
skillId int,
foreign key(skillId)
references skill(skillId),
foreign key(EmployeeID)
references Employee(EmployeeID),
primary key(EmployeeID,skillId)
)

insert into EmployeeSkill(EmployeeID,skillId)
values
(1,1),
(1,3),
(2,4),
(3,4),
(3,3),
(4,1)

with cte as (
select EmployeeID as id from EmployeeSkill
group by EmployeeID
having COUNT(*)>1
)
select * from Employee
where EmployeeID in (select id from cte)

-- Que:5

-- foreign keys
alter table  Employee
add DepartmentId int;

alter table Employee
add constraint FK_Employee_Department
foreign key (DepartmentId)
references Department(DepartmentId);

-- primary keys
alter table Employee
alter column EmployeeID int not null

alter table Employee
add primary key (EmployeeID)

--unique keys
alter table Employee
add unique (Email)
