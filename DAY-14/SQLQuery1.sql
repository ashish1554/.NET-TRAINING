use TRAINING

create table Employee(
    EmployeeID INT,
    FirstName VARCHAR(50),
 	LastName VARCHAR(50),
 	Email VARCHAR(100),
 	Department VARCHAR(50),
 	Salary DECIMAL(10,2),
 	DateOfJoining DATE
);

INSERT INTO Employee (EmployeeID, FirstName, LastName, Email, Department, Salary, DateOfJoining)
VALUES
(1,'Amit','Sharma','amit.sharma@company.com','IT',55000,'2019-01-15'),
(2,'Rahul','Verma','rahul.verma@company.com','HR',42000,'2020-03-10'),
(3,'Neha','Patel','neha.patel@company.com','Finance',60000,'2018-07-25'),
(4,'Priya','Mehta','priya.mehta@company.com','IT',72000,'2021-06-01'),
(5,'Kunal','Joshi','kunal.joshi@company.com','Sales',45000,'2019-11-12'),
(6,'Ankit','Gupta','ankit.gupta@company.com','IT',68000,'2020-02-20'),
(7,'Sneha','Iyer','sneha.iyer@company.com','HR',40000,'2018-09-17'),
(8,'Rohit','Kumar','rohit.kumar@company.com','Finance',75000,'2017-05-30'),
(9,'Pooja','Singh','pooja.singh@company.com','Marketing',50000,'2021-01-10'),
(10,'Vikas','Malhotra','vikas.malhotra@company.com','Sales',47000,'2019-08-05'),

(11,'Suresh','Reddy','suresh.reddy@company.com','IT',82000,'2016-04-12'),
(12,'Nikita','Agarwal','nikita.agarwal@company.com','HR',39000,'2022-02-01'),
(13,'Manish','Bansal','manish.bansal@company.com','Finance',65000,'2018-10-18'),
(14,'Divya','Kapoor','divya.kapoor@company.com','Marketing',52000,'2020-07-07'),
(15,'Arjun','Nair','arjun.nair@company.com','IT',90000,'2015-12-21'),
(16,'Kavita','Desai','kavita.desai@company.com','HR',41000,'2019-04-09'),
(17,'Mohit','Chauhan','mohit.chauhan@company.com','Sales',48000,'2021-09-14'),
(18,'Ritu','Saxena','ritu.saxena@company.com','Finance',70000,'2017-03-28'),
(19,'Aakash','Yadav','aakash.yadav@company.com','IT',61000,'2020-11-11'),
(20,'Meenal','Shah','meenal.shah@company.com','Marketing',53000,'2018-06-22'),

(21,'Harsh','Jain','harsh.jain@company.com','IT',76000,'2019-02-19'),
(22,'Swati','Mishra','swati.mishra@company.com','HR',38000,'2021-12-03'),
(23,'Deepak','Pandey','deepak.pandey@company.com','Finance',64000,'2016-08-16'),
(24,'Isha','Arora','isha.arora@company.com','Marketing',51000,'2020-05-25'),
(25,'Sanjay','Kulkarni','sanjay.kulkarni@company.com','Sales',46000,'2018-01-08'),

(26,'Nitin','Soni','nitin.soni@company.com','IT',83000,'2017-09-09'),
(27,'Alka','Rao','alka.rao@company.com','HR',42000,'2019-10-10'),
(28,'Yogesh','Thakur','yogesh.thakur@company.com','Finance',69000,'2016-06-06'),
(29,'Bhavna','Chopra','bhavna.chopra@company.com','Marketing',54000,'2021-04-04'),
(30,'Ramesh','Pillai','ramesh.pillai@company.com','IT',88000,'2015-03-03'),

(31,'Pankaj','Rawat','pankaj.rawat@company.com','Sales',49000,'2020-12-12'),
(32,'Sunita','Kohli','sunita.kohli@company.com','HR',40000,'2018-08-08'),
(33,'Abhishek','Dubey','abhishek.dubey@company.com','IT',67000,'2019-07-07'),
(34,'Tina','Fernandes','tina.fernandes@company.com','Marketing',56000,'2021-06-06'),
(35,'Gaurav','Singhal','gaurav.singhal@company.com','Finance',72000,'2017-02-02'),

(36,'Raj','Joshi','raj.joshi@company.com','IT',64000,'2019-01-01'),
(37,'Nisha','Khatri','nisha.khatri@company.com','HR',41000,'2020-02-02'),
(38,'Vivek','Mishra','vivek.mishra@company.com','Finance',66000,'2018-03-03'),
(39,'Anjali','Bose','anjali.bose@company.com','Marketing',55000,'2021-04-04'),
(40,'Tarun','Goel','tarun.goel@company.com','Sales',48000,'2019-05-05'),

(41,'Ravi','Sinha','ravi.sinha@company.com','IT',71000,'2017-06-06'),
(42,'Pallavi','Joshi','pallavi.joshi@company.com','HR',43000,'2020-07-07'),
(43,'Saket','Kulkarni','saket.kulkarni@company.com','Finance',68000,'2018-08-08'),
(44,'Komal','Naik','komal.naik@company.com','Marketing',56000,'2021-09-09'),
(45,'Naveen','Chandra','naveen.chandra@company.com','Sales',50000,'2019-10-10'),

(46,'Aman','Tiwari','aman.tiwari@company.com','IT',73000,'2017-11-11'),
(47,'Sheetal','More','sheetal.more@company.com','HR',42000,'2018-12-12'),
(48,'Prakash','Menon','prakash.menon@company.com','Finance',70000,'2019-01-13'),
(49,'Kiran','Shetty','kiran.shetty@company.com','Marketing',58000,'2020-02-14'),
(50,'Vimal','Rathod','vimal.rathod@company.com','Sales',51000,'2021-03-15'),

(51,'Siddharth','Malik','siddharth.malik@company.com','IT',60000,'2020-04-01'),
(52,'Rina','Bhatt','rina.bhatt@company.com','HR',39000,'2020-04-02'),
(53,'Kartik','Mehra','kartik.mehra@company.com','Finance',62000,'2020-04-03'),
(54,'Anusha','Rangan','anusha.rangan@company.com','Marketing',54000,'2020-04-04'),
(55,'Dev','Solanki','dev.solanki@company.com','Sales',48000,'2020-04-05'),

(56,'Naveena','Krishnan','naveena.krishnan@company.com','IT',61000,'2020-05-01'),
(57,'Parth','Doshi','parth.doshi@company.com','HR',40000,'2020-05-02'),
(58,'Ashwin','Iyer','ashwin.iyer@company.com','Finance',63000,'2020-05-03'),
(59,'Mitali','Ghosh','mitali.ghosh@company.com','Marketing',55000,'2020-05-04'),
(60,'Chirag','Vora','chirag.vora@company.com','Sales',49000,'2020-05-05'),

(61,'Aditya','Kulkarni','aditya.kulkarni@company.com','IT',62000,'2020-06-01'),
(62,'Poonam','Bhardwaj','poonam.bhardwaj@company.com','HR',41000,'2020-06-02'),
(63,'Rajat','Mathur','rajat.mathur@company.com','Finance',64000,'2020-06-03'),
(64,'Snehal','Patil','snehal.patil@company.com','Marketing',56000,'2020-06-04'),
(65,'Yash','Chaudhary','yash.chaudhary@company.com','Sales',50000,'2020-06-05'),

(66,'Saurabh','Tripathi','saurabh.tripathi@company.com','IT',63000,'2020-07-01'),
(67,'Neelam','Khandelwal','neelam.khandelwal@company.com','HR',42000,'2020-07-02'),
(68,'Varun','Aggarwal','varun.aggarwal@company.com','Finance',65000,'2020-07-03'),
(69,'Ritika','Banerjee','ritika.banerjee@company.com','Marketing',57000,'2020-07-04'),
(70,'Kishan','Prajapati','kishan.prajapati@company.com','Sales',51000,'2020-07-05'),

(71,'Akshay','Borkar','akshay.borkar@company.com','IT',64000,'2020-08-01'),
(72,'Shilpa','Naidu','shilpa.naidu@company.com','HR',43000,'2020-08-02'),
(73,'Nikhil','Chopra','nikhil.chopra@company.com','Finance',66000,'2020-08-03'),
(74,'Pallav','Sen','pallav.sen@company.com','Marketing',58000,'2020-08-04'),
(75,'Hardik','Pandya','hardik.pandya@company.com','Sales',52000,'2020-08-05'),

(76,'Rohini','Kulshreshtha','rohini.kulshreshtha@company.com','IT',65000,'2020-09-01'),
(77,'Manav','Seth','manav.seth@company.com','HR',44000,'2020-09-02'),
(78,'Pranav','Deshpande','pranav.deshpande@company.com','Finance',67000,'2020-09-03'),
(79,'Ishita','Mukherjee','ishita.mukherjee@company.com','Marketing',59000,'2020-09-04'),
(80,'Rakesh','Lal','rakesh.lal@company.com','Sales',53000,'2020-09-05'),

(81,'Apoorva','Shinde','apoorva.shinde@company.com','IT',66000,'2020-10-01'),
(82,'Deepali','Sawant','deepali.sawant@company.com','HR',45000,'2020-10-02'),
(83,'Samar','Kohli','samar.kohli@company.com','Finance',68000,'2020-10-03'),
(84,'Tanvi','Mahajan','tanvi.mahajan@company.com','Marketing',60000,'2020-10-04'),
(85,'Rohan','Bedi','rohan.bedi@company.com','Sales',54000,'2020-10-05'),

(86,'Kunal','Bhargava','kunal.bhargava@company.com','IT',67000,'2020-11-01'),
(87,'Aarti','Nene','aarti.nene@company.com','HR',46000,'2020-11-02'),
(88,'Harshit','Srivastava','harshit.srivastava@company.com','Finance',69000,'2020-11-03'),
(89,'Megha','Chatterjee','megha.chatterjee@company.com','Marketing',61000,'2020-11-04'),
(90,'Jay','Shukla','jay.shukla@company.com','Sales',55000,'2020-11-05'),

(91,'Omkar','Joshi','omkar.joshi@company.com','IT',68000,'2020-12-01'),
(92,'Shweta','Kuldeep','shweta.kuldeep@company.com','HR',47000,'2020-12-02'),
(93,'Anirudh','Rastogi','anirudh.rastogi@company.com','Finance',70000,'2020-12-03'),
(94,'Kritika','Bansal','kritika.bansal@company.com','Marketing',62000,'2020-12-04'),
(95,'Sahil','Nagpal','sahil.nagpal@company.com','Sales',56000,'2020-12-05'),

(96,'Vineet','Chandra','vineet.chandra@company.com','IT',69000,'2021-01-01'),
(97,'Nandini','Vernekar','nandini.vernekar@company.com','HR',48000,'2021-01-02'),
(98,'Arvind','Subramanian','arvind.subramanian@company.com','Finance',71000,'2021-01-03'),
(99,'Saumya','Rathore','saumya.rathore@company.com','Marketing',63000,'2021-01-04'),
(100,'Keshav','Upadhyay','keshav.upadhyay@company.com','IT',72000,'2021-01-05');


select * from Employee

--- 1. Write a SQL query to retrieve the TOP 5 highest-paid employees. Ensure the result is correct by applying proper ordering.
select top 5 * from Employee
order by Salary desc

---2. Write a query to fetch DISTINCT department names from the Employee table where the department name starts with the letter 'S'.

select distinct Department from Employee
where Department like 'S%'


---3. Write a query to retrieve employees whose Department is IN ('HR', 'Finance', 'IT') AND whose Salary is greater than 50,000.

select * from Employee
where Department IN ('HR', 'Finance', 'IT') AND Salary>50000

---4. Write a query to retrieve employees who belong to the 'Sales' department OR have a Salary greater than 75,000. Explain your filtering logic using SQL comments.

select * from Employee
where Department='Sales' or Salary>75000

---here i first check department is sales or not if not then check salary>75000 using or operator means this is valid any one condition that is true 

---5. Write a query to find all employees whose Email contains their FirstName anywhere in the email using the LIKE operator.

select * from Employee
where Email like '%'+ FirstName +'%'


---6. Write a query to display employees ordered by DateOfJoining (oldest first) and return rows 6 to 10 using OFFSET FETCH.

select * from Employee
order by DateOfJoining 
offset 5 rows
fetch next 5 rows only


/*7. Write a query to retrieve employees where:
 - Department is 'IT' AND Salary is greater than 60,000
 OR
 - Department is 'HR' AND DateOfJoining is before '2020-01-01'

 Use parentheses correctly to control logical precedence.
*/

select * from Employee
where (Department='IT' and Salary>=60000) or (Department='HR' and DateOfJoining<'2020-01-01')