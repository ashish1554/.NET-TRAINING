# Daily Assignment
📅 Date: 22 January 2026

---

## Assignment :-

---

## Q1. Performance impact of boxing
**Answer:**  
First of boxing is the process of converting value types into the reference type

During Boxing

1)Memory is allocated on the heap

2)Memory is copied from the stack to heap

3)Value is then wrapped in object

when we convert value into reference type then it allocates the memory on the heap it copies the value types from stack  and increase the load of the cpu because heap allocations are more expensive than stack allocation

In General practice we avoids the use of boxing and unboxing instead we use generic collections like list




---

## Q2. 

## Delegates vs interfaces

**Answer:**  

### Delegates
Delegates could be a method only

If Delegate available in our scope then we can use it

We can implements delegates n number of times

When we use methods defining using delegates we do not requires object of the class where method is defined

delegate does not support inheritance

Memory is assign at runtime

It can wrap the static method 

### Interfaces

Interface can contains both methods and properties

We can use interface only when class implements it

Interface can be implemented only one time

To access the method we need to object of the class that implements interfaces

interface supports inheritance

Memory is assigne at compile time

It cannot wrap the static method





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
Type safety means we can use only allowed types of data with variable,methods,etc.. it ensures that number is treated like number string is treated like string and ensures they are not mix with each other means like if we declare like string number="123" as we declare it as string so it must be treated like number 123

There are two types:

1)Static type safety:Errors are caught at the compile time  before program runs

2)Dynamic type safety:Errors are caught at the runtime when program is running


## Q2.Performance benefits of generics
**Answer:**  
without generics value types are converted into object and object are converted back to the value  this is called boxing and unboxing  it requires extra memory

generics provides the inherent type casting means we dont need to explicitly  cast the elements after retriving process from the the collections 

