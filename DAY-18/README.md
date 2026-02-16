# Daily Assignment
📅 Date: 16 February 2026

---

## Assignment :-

---

## Q1. What problem was EF solving compared to ADO.NET?
**Answer:**  
First we understand what is ado.net so ado.net is basicaly data access technology used to established the database connections,write sql query manually and   retriving the data using commands and data readears

problems with ADO.NET is

1.too much boiler plate code means we need to write sql query manually open the connections,close the connection but EF core handles it by automaticaly doing this
EF core automaticaly open and close the connections 

2.In ADO.NET we need to manualy map the database tables with c# classes but with EF core it automaticaly map the c# classes with databse tables

3.The main problem that solve by EF core is change tracking . chnage tracking is the  feature of EF core that track the changes made in the class entity and updates the database accordingly but with ADO.NET we need to manully track the change

4.In ADO.NET there is no support of migration like if i add one column in the table then i need to manually write the altrer table query and update the database manully 
but with EF core there is a concept called migration we simply  use Add-Migration columnadd then Update-Database  this automatically update the database schema

5.With EF core we have database independencs support means today i used sqlserver and tomorrow my requirements are changed and i need postrge sql so only thing i need to change is database provider in case of EF core but with ADO.NET i need to rewrite the query from sqlserver to postgre sql because in ADO.NET there is no support of linq so we need to write the query manually for each provider 






---

## Q2.  Explain EDM architecture (Conceptual, Mapping, Storage).


**Answer:**  
EDM architecture is divided in the following components

1.EDM:Entity Data Model

EDM has further divided into  3 more parts

i.Conceptual Model:
Conceptual model contains the model classes and relationship and it is independent of the database table design 

ii.Mapping Model:
Mapping Model map the entity of the our class to database tables  it provides the information about how our coceptual model is mapped storage model


iii.Storage Model
Storage Model stores the actual database data means it defines the actual schema of our database like keys,stored procedure,views,tables etc..

2.LINQ to ENTITY

linq to entity is basically used write the query against the database object model it basically returns the entities that are defined inside our conceptual model

3.Entity SQL

entity sql is separate language used for EF 6 only that is used to retrive the data from the EDM not from the 

4.Object Service

Object Service are basically used to conver the database data into the .net objects In a real-time scenario, most of the time we might have to work with entities such as in-memory objects or a collection of in-memory objects. To do this we need Object Services. We can use it to query data, from almost all data stores, with less code.


5.Entity Data Client Provider

the main role of this layer is to convert the linq to entities or entity sql into the sql query that is understood by the underlying database it communicates with the ADO.NET that send or retrive data from the database

6.ADO.Net data provider

This layer communicates with the database using standard ADO.Net.  


## Q3.Difference between EF Core and EF6.

### EF 6

Supports only Sql server

Supposts only windows specific operating systen

performance is slower

works only with .Net framework

in this lazy loading works automatically

### EF Core

Supports wide range of databases like sqlserver,postgre sql,sqllite etc..

supports cross platform like mac os,windows,linux

performance is faster

works with .Net core,.Net 6,7,8

we need to install pakage to enable lazy loading

## Q4. What happens internally when SaveChanges() is called?

SaveChanges() method is used to save all the changes into the database it is the method of DbContex

how it works?
EF core use Chnage tracking to keep track of the status of the entities.entities have basically  like Added,Modified,Deleted, etc states.this method keeps track of all the recored inside the change tracker

when savechange() method runs then it internally calls the detectchange() method that check the and compare the old and new value of the property then marks entities as added,deleted,modified

after that EF core group all our entities based on the state and generate sql for it.like if we have state as added then it generate alter sql commands

then EF core starts the transaction and send query to the database and query is run into the database and returns the result


## Q5.What is Change Tracking?
Change tracking is a feature in a ORM framework that automatically detects changes made to objects and updates databases accordingly 

when we call SaveChanges() method than  ef core detects what has changed and generate correct sql command

ex:

var student = context.Students.First(s => s.Id == 1);

here we just fetched first student record from the database state=Unchanged

now we update name like student.Name="manan" now ef core compare the old value with the new value 

//old="ashish" //new="manan"

now when we run SaveChanges() then EF core detects changes and generate sql and marked state unchanged again

## Q5.Difference between DbContext and DbSet?

### DbContext
DbContext in the EF core is the main class that manages the database connection,tracking changes in the entities,sending queries to the database, etc..

it manages the whole database session

it directly talk to the database via savechanges method

it has multiple DbSet
### DbSet
DbSet basically represents the database table and used to perform the CRUD operation 

it represent one table inside the DbContext

it dont talk directly with database table

it has multiple Entity records
---
