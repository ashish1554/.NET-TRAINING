use training


-- Que:1
alter function TotalExperience(@join as date)
returns decimal(10,1)
as
begin 
  return datediff(day,@join,getutcdate())/365.25
end

select FirstName,dbo.TotalExperience(DateOfJoining) as exp from Employee

--Que:2

alter function Senior(@Id int)
returns table
as
return 
(
select  FirstName,
        DateOfJoining,
        DepartmentId,
        dbo.TotalExperience(DateOfJoining) as Experience,

        case
        when dbo.TotalExperience(DateOfJoining)>5 then 'yes'
        else 'no'
        end as IsSeniorEmployee 

        from Employee

        where DepartmentId=@Id
)

select * from dbo.Senior(2)


-- Que:3
alter procedure spInsertEmployee
@EmployeeId int,
@FirstName varchar(50),
@LastName varchar(50),
@Email varchar(100),
@Salary decimal(10,2),
@DateOfJoining date,
@DepartmentId int
as
begin 
begin try
insert into Employee
(EmployeeID,FirstName,LastName,Email,Salary,DateOfJoining,DepartmentId)
values
(@EmployeeID,@FirstName,@LastName,@Email,@Salary,@DateOfJoining,@DepartmentId)
end try
begin catch
select
error_message() as [Error-Message]
end catch
end

exec spInsertEmployee 1001,'abc','def','abceee@gmail.com',54000,'2020-12-03',2

select * from Employee 
exec spInsertEmployee 1002,'xy','ze','amit.sharma@company.com',54000,'2020-12-03',2

-- Que:4

alter procedure SalaryCalculation
@StartDate date,
@EndDate date
as
begin 
declare @totalday decimal(10,2) 
set @totalday= datediff(day, @StartDate,@EndDate)/365.25/12
select DepartmentId,@totalday*sum(Salary) as totalsalary from Employee where DateOfJoining between @StartDate and @EndDate group by DepartmentId
end



exec SalaryCalculation '2020-12-03' ,'2026-12-03'


--Que:5

create table Orders
(
OrderId int primary key,
EmployeeID int
foreign key(EmployeeID) 
references Employee(EmployeeID),
amount int
)


create table OrderAudit
(
OrderId int
foreign key(OrderId)
references Orders(OrderId),
InsertedDate date,
InsertedBy int 
foreign key(InsertedBy)
references Employee(EmployeeID)
)

select * from OrderAudit

insert into Orders
(OrderId,EmployeeID,amount)
values
(5,3,50),
(6,2,580),
(7,1,450),
(8,3,2000)

insert into Orders
(OrderId,EmployeeID,amount)
values
(9,7,50)

select * from Orders

create trigger tr_insert_record
on Orders
after insert
as
begin 
insert into OrderAudit(OrderId,InsertedDate,InsertedBy)
select OrderId,GETUTCDATE(),EmployeeId
from inserted
  PRINT 'Trigger executed successfully. Record added to OrderAudit.';
end


--Que : 6
create table Product
(
productId int primary key,
OrderStatus varchar(200)
)

insert into Product
(productId,OrderStatus)
values
(1,'active'),
(2,'completed'),
(3,'cancel'),
(4,'active'),
(5,'completed'),
(6,'cancel')

delete from Product
where productId=1


alter trigger tgr_OrderStatus
on Product
after delete
as
begin
declare @orderStatus varchar(200)

select @orderStatus=OrderStatus from inserted

if exists(
select 1 from deleted
where OrderStatus='active'  
)
begin
print 'can not delete product with active order status'
rollback
end
end