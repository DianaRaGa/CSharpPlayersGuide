# C# Cheat Sheet

A quick reference based on what I have learned so far.

| Concept | What I think of it as |
|---|---|
| `string` | Text |
| `int` | Whole number |
| `bool` | True/false |
| `string name` | Declare a string variable |
| `=` | Assign a value |
| `Console.WriteLine()` | Print to console |
| `//` | Comment |
| `if` | Do something only if condition is true |
| `else` | Otherwise |
| `foreach` | Repeat for each item |
| `List<T>` | Collection of items |
| `//` | Comment out one line |
| `/* ... */` | Comment out multiple lines |
| `int age = 30;` | Declare + assign |
| `int age;` | Declare |
| `age = 30;` | Assign |
| `Variable` | Has a name, type, and value |
| `.GetType()` |  To print the type of a variable in C# |


## 🧩 Variables

| Concept | What I think of it as |
|---|---|
| `int` | Whole number |
| `string` | Text |
| `float` | Decimal number with less precision |
| `double` | Decimal number with more precision |
| `bool` | True or false |
| Variable | A named box that holds a value |
| Type | What kind of value the box can hold |
| `=` | Assign a value |
| `int age = 30;` | Declare + assign |
| `int age;` | Declare |
| `age = 30;` | Assign / reassign |

### Number literals

| Literal | Type |
|---|---|
| `10` | `int` |
| `10.5` | `double` |
| `10.5F` | `float` |
| `10.5M` | `decimal` |

`F` → tells C# the decimal literal is a `float`.

### Comments

| Syntax | What I think of it as |
|---|---|
| `//` | Comment out one line |
| `/* ... */` | Comment out multiple lines |

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
