// See https://aka.ms/new-console-template for more information

using Liskov_Substitution_Solution;

var r = new Rectangle(10, 20);
Console.WriteLine($"Rectangle (10, 20) Area: {r.GetArea()}");

var s = new Square(10);
Console.WriteLine($"Square (10,10 ) Area: {s.GetArea()}");

// Now we can work with specific types if we need to modify dimensions
if (r is Rectangle rect)
{
    rect.Width = 20;
    Console.WriteLine($"Rectangle (20, 20) Area: {rect.GetArea()}");
}