// The Triangle Farmer

// Objectives:
// 1. Write a program that lets you input the triangle's base size and height
// 2. Compute the area of a triangle by turning the above equiation into code
// 3. Write the results of the computation


Console.WriteLine("Hello P-Tanh! Welcome to your area calculator");
Console.WriteLine("Please enter the base of your triangle:");
// Converting the input form the user to a float
float TriangleBase = float.Parse(Console.ReadLine());
Console.WriteLine("Awsome! can you input the height of your triangle please?:");

float TriangleHeight = float.Parse(Console.ReadLine());
// The area of the triangle's formula
float TriangleArea = (TriangleBase * TriangleHeight) / 2;

Console.WriteLine("The area of your triangle is: ");
// Result
Console.WriteLine(TriangleArea);

// Notes: How to avoid having a string instead of a number? with the try else like in python?