# Daily Assignment
📅 Date: 23 January 2026

---

## Assignment :-

---

## Q1. async vs multithreading
**Answer:** 

### async

async programing uses a single thread or very few thread

async is best of I/O bound task because an I/O bound task spends their most of the time on waiting for response like fetching data from api,http request handling,file upload etc...

goal of async programing is to reduce the waiting time

async programing require few memory usage

as in async programing generally one thread is used it is hard to achieve the true parallelism 

due to single thread async avoid context switching



### multithreading

multithreading uses multiple thread to complete the task in parallel

multithreading is best for CPU bound task because CPU bound task spends their most of the time in computation CPU bound task require heavy computaions like image processing,matrix multiplication,encryption etc ...

goal of multithreading is to save execution time

multithreading requires more memory compare to async programing

multithreading uses multiple thread im parallel using multiple cores of the cpu so it achives the true parallesim

multithreading supports context switching





---

## Q2. 

## Common async pitfalls

**Answer:**  
First of the word pitfalls means the hidden problem that can cause big isssue if we are not aware about that

### 1)Blocking the call
if we block the async code then it will lead to deadlock in UI  if we use method like .Result or .Wait  then it looks like callilng async code in sync manner

### Ex:
```
var result=Fun().Result; // this is bad 
var result=await Fun(); //this one is suggessted

var result=Thread.Sleep(1000); //this is also a common bad practice in this Sleep method block the main thread

```

### 2)Using Await inside the loop
if you await insie the loop without considering parallel flow of the program  it can looks like sync execution even though async tasks are independent of each other so it is suggest to use Task.WhenAll() method	to run async task concurrently when they all are independent of each other


### 3)Async call inside sync method
if we use async method inside the the sync method without await keyword then what happens actully hear is when we hit async method then it goes to async method and in that method let say we have delay of around 2000ms and due to we dont use await inside our sync method to call the async method so the sync method dont move further untill the result from async is came 

this things comes to in picture when we work with UI apps like in normal console apps we dont have an synchronization context so code can continue with any thread so using .Result in normal console app works fine but when we work with UI Synchronization context must requries the same thread to return from it await state

### 4)Fire-and-Forget
if we call async method without await then what happes like if there is some exception occurs during the execution of the async method then it will never be handled and directly start it execution from main method so developer never got to know if there is any exception in the code because in case of async method exceptions are not throw immediately but it stored inside the returing Task so without awaiting that Task we never got to know if there is any exception is there or not

