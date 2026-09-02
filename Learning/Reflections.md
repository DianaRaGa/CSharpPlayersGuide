# Learning Reflections

Personal notes about what clicked, what confused me,
and how the concepts connect to things I already know.

---

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


