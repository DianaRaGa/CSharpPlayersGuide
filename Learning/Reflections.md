# Learning Reflections

Personal notes about what clicked, what confused me,
and how the concepts connect to things I already know.

---

## **2026-09-21** - I thought I knew you, Console ʕʘ‿ʘʔ

Today I finished the Level 8 — Console 2.0 section of the book. I think this level was packed with information in a pretty short section, so there is a lot to unpack.

I got to learn more useful tricks for working with the console and, honestly, how to have a little more fun with it. Things like making it beep, changing its colors, formatting text, and printing things in more useful ways.

I do feel like I'm doing a good job of finding the time to learn all of this. However, for my current role, the level of C# I need is more focused on creating web pages, APIs, and all of that. I like having the background and understanding the basics, but I do find myself wondering: **How does all of this eventually turn into a full-on web page or an API?** I think about that a lot.

But I'll keep following this learning path and see what I can accomplish by the end of the book, because it definitely seems like there is still a lot to uncover.

(I'm only at Level 8 ʕ´• ᴥ•̥`ʔ)

## **2026-09-16**🧙‍♀️ — Increment, Casting & Math, Level 7 DONE

Today was mostly about understanding how C# handles numbers and types.

### ➕ Increment & Decrement
`++` and `--` are basically tiny shortcuts for changing a value by 1.

The only important plot twist is **prefix vs. postfix**:

- `++x` → change first, then use it
- `x++` → use it first, then change it

Side quest energy. 🗡️  
Useful to recognize, but not something I need to obsess over yet.

### 🔄 Casting
This one made C# feel *very* different from Python.

C# really wants me to know **what type of value I'm working with**.

- **Implicit casting** → C# can safely convert it for me.
- **Explicit casting** → I have to tell C# to do it.

The big lesson:  
> ⚠️ Know your types before doing calculations.

Otherwise, I might expect `0.2` and get `0` because integer division happened instead.

### 💥 Overflow & Round-off
Another reminder that computers have limits.

Different numeric types have different ranges and precision, so I need to keep an eye on:

- values getting too large → **overflow**
- decimal precision → **round-off errors**

Not something to fear, just something to remember exists.

### 🧮 Math & MathF
These were actually pretty fun to discover.

`Math` and `MathF` give me ready-made mathematical tools, including things like powers, roots, rounding and trigonometry.

For web development, I probably won't be summoning trigonometry thoug. 

But the fact that these are useful for things like game development made the topic much more interesting.

### 🧠 Today's takeaway

C# is making me more conscious of **what kind of data I'm actually working with**.

Python often lets me just *do the thing*.  
C# sometimes makes me stop and say:

> "Wait... what TYPE of thing am I doing this with?" 👀

And honestly, I think that's starting to make sense.

## **2026-09-09** - 🏰 Calculating for the Kings (๑ᵔ⤙ᵔ๑)

I created a program to calculate the points for the kingdoms of three kings, just like the book asked. It ended up being... quite a long piece of code. 😂

While working on it, I kept thinking about how I would do this in Python: use a list or dictionary, loop through the kings, ask how many I wanted to calculate, and avoid hardcoding everything. But instead of getting stuck trying to make this version “perfect,” I decided to take the ride and use the tools I have learned from the book so far.

It was actually a good reminder that **I don't need to optimize everything before I understand the basics.** Making these small programs simple enough that I can finish them and come back the next day is helping me keep learning consistently instead of spending hours trying to make every little program amazing.

I also learned about updating variables and the increment/decrement operators. So far, C# feels pretty familiar coming from Python, which is nice. I probably should start refreshing my Python too. 😅

**Takeaway:** It's okay if my C# code isn't the most elegant solution yet. Right now, I'm learning how C# thinks—and that's more important than making every program perfect.

## **2026-09-09** - Chocolate Eggs? Chocolate Chickens? A Duckbear That Eats Chocolate Eggs? ʕ⊙ᴥ⊙ʔ

Today's Level 7 challenge was **The Four Sisters and the Duckbear**. It was fun and easy, and I had some fun playing around with ASCII art and printing it using `Console.WriteLine()`.

I put the `Parse()` method to use (I believe that's what it's called?) to convert the input into an integer. I still don't know how to make the input safer. I could just search for it and figure it out, but I want to take this slow and steady so I can keep going without giving it my maximum effort every time and then not wanting to come back to it.

I also used `Console.WriteLine(@"...")` to get the multiline ASCII art into the console. Very nice and handy trick!

I really enjoy using calculations, and I definitely want to keep working with them. But I do want to understand how this fits into my work, since at my company, calculations are usually sent to the server through an API.

Also side note, I have to remember to use camelCase because aparrently it's a C# thing ʕᵔᴥᵔʔ.

## **2026-09-08** - Math & The Triangle Farmer ʕノ•ᴥ•ʔノ◕

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
```

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


