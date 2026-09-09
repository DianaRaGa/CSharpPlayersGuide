# Learning Reflections

Personal notes about what clicked, what confused me,
and how the concepts connect to things I already know.

---

## **2026-09-03,04,05** - Math & The Triangle Farmer ʕノ•ᴥ•ʔノ◕

**Level 7:** The Triangle Farmer 🧑‍🌾📐

### Learned
- Math operators in C# work similarly to Python.
- C# follows the same order of operations.
- `Console.ReadLine()` returns a `string`.
- `float.Parse()` converts the input into a `float`.

### 💡 Realization
Turning a math formula into code was simple:

```csharp
float TriangleArea = (TriangleBase * TriangleHeight) / 2;

The interesting part was handling user input:

User input → string → float.Parse() → float

### 🛠️ Next

Learn how to safely handle invalid user input.

C# equivalent to Python's try/except → investigate TryParse.

## **2026-09-03,04,05** - Level 6 The C# Type System Returns ʕっ•ᴥ•ʔっ💕

This level 6has been somhow easy but it took me so loooong to complete. The concepts where familiar and the variables where understandable. I don't think I'm remembering all of it and using them will requiere me 
to serach for the types but know I know what types they are and that's something.

The three challenges where fun but the firs one took me soooo long to complete. so I'm glad I finished this level.

The variables are easy to follow and understandable. Eager to know how I'm going to use them.

## **2026-09-03,04,05** - Level 6 The C# Type System

I'm, currently working my way throug the level 6 of the book, doing the challenge but on pause because i have to make the code with the 14 types of variables descrived in this section.

The second day I'm doing this excercice. It has been tedious because I have to search in the syntax in the book the types described and then make the variable and I keep changing the format to get the order that I like. I'm taking my time but yes its been tedious because I also put the short description to really understand it.

Completed the Variable Shop and the Variable Shop Returns challenge.

### Learned
- C# variables have a **name, type, and value**.
- C# requires the type to be declared.
- Decimal literals have types too: `double` by default, `float` with `F`.
- Existing variables can be given new values without creating new variables.

## **2026-09-01** - Level 05 Variables

I started with a `mkdir` command to create the folder Level 05 and at first I used the `git mkdir Level_05` but this was wrong, is just `mkdir Level_05` and aparently it does not show a status or anything to say is done. ʕ੭·͡ᴥ·ʔ੭

Completed Level 5: **Variables**. It was fun and quick!

### Learned
- Variables have a **name, type, and value**.
- C# requires the variable's type to be declared.
- So far I worked with `string` and `int`.
- A variable can be declared and assigned separately or in the same statement.
- Variable names cannot contain spaces or symbols such as `-`, `&`, `$`, etc.
- The book uses a **box** as a mental model for a variable.

### Realizations
C# variables feel similar to Python, but C# is more explicit about the type:

```csharp
int age;
age = 30;
```

or 

```csharp
int age = 30;
```

I also noticed that b = a gives b the value that a has at that moment. It *does not make b follow a* if a changes later.

I also learned that multiple assignments can be written like: 

```csharp
a = b = c = 10;
```

The book points out that we spend more time **reading and debugging code than writing it**, which makes clear naming and consistent conventions important. Code should be understandable to humans, not just functional.

Also... the colors in the C# IDE make the code look pretty. ʕ♥ᴥ♥ʔ

## **2026-08-29** - Commenting

One of the things I've noticed is the amount of notes I make and try to explain something. I do get that notes and comments on the code could help me and other to understand but I do thend to overdo them.

I will keep this in mind to be clear enough in what I'm doing, but also consise enough to want to read it later on.

## **2026-08-29** - ***Base Class Library (BCL)***: Namespaces, Class, Methods, and Statements

I had to re-read the begining of Lever 3 to get up to spead again with the content.

I left to long in betwen sessions and now that I began again feel like I need to get in context again.

I just visualized the BCL as a huge container with more things inside it and things inside those things, just like a russian doll 🪆.

I like the analogy og the workers, I could only imagine thiny people called `Methods` inside the computer or the `.NET` and doing diferent jobs in a specific area called `class` in a floor named `namespace` in the `BCL` building.

The challenges where entertining and easy to do. I wish I can make more complex things but I'll take it step by step.

> [!TIP]
> Be patient and learn the basics, later on you will do more complex stuff (just keep on working on it).

## **2026-08-26** — Variables, Types, and Methods

### What clicked

C# feels more explicit than Python when working with variables.

In Python I can write:

```python
name = "Diana"
```
and Python determines the type.

In C#:
```csharp
string name = "Diana";
```
I explicitly tell C# that name is a string.


