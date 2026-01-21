# Daily Assignment
📅 Date: 21 January 2026

---

## Enum and Struct Assignment :-

---

## Q1. Advantages of Enum
**Answer:**  
Enum is used to defined the named constant and it is a user defined data type

Enum improves the readability by avoiding the magic numbers like if we are using the manually for active status=1 and pending=0 then it is much more harder but if we create enum of Status then we can use it by Status.Active which is more readable

In enum errors are caught at the compile time instead of run time



---

## Q2. Limitations of structs
**Answer:**  
The first key limitation of struct is that it is the value type

Struct can not supports the inheritance means we can not inherite the property from another struct

We can not declare the parameter less constructor because compiler provide the default constructor you can not override this (in newer version it is allowed)

In struct we need to initialize all the field because struct are value typed and not have any partially initialization 





---

## Namespaces Assignment :-
---
## Q1.Importance of namespaces in large systems
**Answer:**  
When many developers works on the heavy code base then that are the chances that they may make the same class so to takle it and organizing the code in structure way namespace were intrpduced it makes our code clearner and readable 

Namespace is used to group the same functionality together so it becomes easy to manage especially when the codebase is very bulky

Namespace supports team based working like differnet teams working on the different part of the system using the separate namespace

Namespace also supports the reusibility means it makes easy for us to reuse the part of the system in other project 

---


## Lambda Assignment :-

---
## Q1.Benefits of lambda expressions
**Answer:**  
Lambda expressions are the anonymous functions(Function without name) they reduce the need to write the boilerplate code  means to create function for simpler logic and allows us to write inline logic make the code more redable

Lambda expressions are primaly used in LINQ for filtering,sorting and selecting the specific data 

Lambda expressions reduce the code length by removing unnecassary syntax  so that we can write our logic in fewer lines


---
## Q2.Lambda vs traditional methods
**Answer:**
### Lambda expression
they are Anonymous function means there is no need to name of function

it is used only one time and good for simple logic

it can be written in sorter syntax instead of multiple lines

### EX:

```
(a, b) => a + b

```
### traditional methods

We need to excplicitly give names of method

it can be reused multiple times by method calling and suitable for complex logic

it is requires multiple lines of codes

### EX:

```
int Add(int a, int b)
{
    return a + b;
}
```


---
## Generics Assignment :-

---

## Q1.Type safety
**Answer:**  
Type safety means we can use only allowed types of data with variable,methods,etc.. it ensures that number is treated like number string is treated like string and ensures they are not mix with each other means like if we declare like string number="123" as we declare it as string so it must be treated like string not a number 123

There are two types:

1)Static type safety:Errors are caught at the compile time  before program runs

2)Dynamic type safety:Errors are caught at the runtime when program is running


## Q2.Performance benefits of generics
**Answer:**  
One of the best performance benefit is typesafety without generics value types are converted into object and object are converted back to the value  this is called boxing and unboxing  it requires extra memory

generics provides the inherent type casting means we dont need to explicitly  cast the elements after retriving process from the the collections 

using generic it allows us to write methods or classes that can be used multiple times so basically it provides code reusibility like if i want to swap 2 integers and 2 strings so instead of creating 2 different methods i simply create one generic method that works for both so it increace reusibility

