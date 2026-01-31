# Daily Assignment
📅 Date: 13 January 2026

---

## ASSIGNMENT 1:-

---

## Q1. How is a console application created?
**Answer:**  
A console application is created by creating a project that runs in a command-line interface. In .NET, it is created using a Console App template, which generates a program that executes code inside the `Main()` method and displays output in the console window.

---

## Q2. What is the purpose of the `Main()` method?
**Answer:**  
The `Main()` method is the entry point of a console application. The program starts execution from the `Main()` method, and without it, the application cannot run.

---

## Q3. What is the difference between `Console.Write()` and `Console.WriteLine()`?
**Answer:**  
`Console.Write()` prints output on the same line and does not move the cursor to the next line.
`Console.WriteLine()` prints output and then moves the cursor to the next line.

---

## ASSIGNMENT 2:-

---

## Q1. What is .NET?
**Answer:**  
.NET is a free, open-source, cross-platform developer platform from Microsoft for building various applications  using languages like C#, F#, and VB.NET

## Q2 Difference between .NET Framework, .NET Core, and .NET (latest)
**Answer:**  
### .NET Framework
-original .NET by microsoft
-Release in 2002
-No Cross Platform Support
-Used In Old Enterprise Environment apps
-Not Open Source

### .NET Core
-Rewrittern .NET for Modern apps
-It Supports Cross-Platform like windows,linux,macOs
-It is open source
-.NET core is stopped by microsoft

### .NET(Latest)
-Unified version of .NET Framework
-.NET framework+core
-One Platform for everthing

---

## Q3. Role of C# in the .NET ecosystem
**Answer:**  
C# is the main Programming language used to build application on the .NET platform. It is used to write application logic accessing .NET features  and building mobile and desktop applications.

---

## ASSIGNMENT 3:-

---

### Observation
I observed when i used value type then during method calling its original value cant change but in reference type it passes the reference so change in the value during method calling can change the actual content also

---

## ASSIGNMENT 4:-

---

### Nullable operator ?
Allows value types to store null

### .HasValue
Check whether a nullable value type actually Contains value or not. It returns true if not null and false if null

### Null-coalescing operator ??
if left side is null it return right side

---

## ASSIGNMENT 5:-

---

## Q1. Why nullable types were introduced
Value types cannot store null but in real life,many values can be missing like age,phone number,etc..  for ex.if i entered age=0 then it is like misleading because 0 is valid age in sort it is used to represent data safely and clearly 

## Q2. Scenarios where nullable types are preferred
It is used when value type wants to represent "no value".For ex like when we read some data from APIs,Files,inputs there in these cases values are missing.In database some values are also allows null values

---

## ASSIGNMENT 6:-
covered in the code

---

## Assignment 7 – Comparison Table

| Feature            | const | readonly |
|--------------------|-------|----------|
| Initialization     | Must be initialized at the time of declaration | Can be initialized at declaration or inside the constructor |
| Runtime behavior   | Compile-time constant, value is fixed and replaced at compile time | Runtime constant, value is set once and cannot be   changed afterward |
| Use cases          | Used for fixed values that never change, such as mathematical constants or configuration values | Used for values that should not change after object creation, such as IDs or configuration set during construction |