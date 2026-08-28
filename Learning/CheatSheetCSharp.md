# C# Cheat Sheet

A quick reference based on what I have learned so far.

---

## Variables

```csharp
string name = "Diana";
int age = 30;

type variableName = value;

string → data type
name → variable name
= → assignment operator
"Diana" → value

## Declaration vs Initialization

string name;
Declares a variable.

string name = "Diana";
Declares and initializes the variable.

## Reassignment

name = "Jeff";

## Common Types

string name = "Diana";
int age = 30;

string → text
int → whole numbers

## Methods

Console.WriteLine("Hello!");

## Program Flow

Basic C# programs generally execute statements sequentially:

Console.WriteLine("First");
Console.WriteLine("Second");

Output:
First
Second

More complex control flow can change this using things like:

if
else
foreach
while
methods
await

## Type Safety

C# keeps track of the declared type of a variable.

This works:

string name = "Diana";

This does not:
string name = "Diana";
name = 30;

because 30 is an int, not a string.
