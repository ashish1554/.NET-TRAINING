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