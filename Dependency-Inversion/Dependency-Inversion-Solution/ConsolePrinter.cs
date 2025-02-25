using System;

namespace Dependency_Inversion_Solution;

public class ConsolePrinter : IPrinter
{
    public void Print(ShoppingCart cart)
    {
        Console.WriteLine();
        Console.WriteLine("SHOPPING CART");
        Console.WriteLine("~~~~~~~~~~~~~");

        foreach (var item in cart.Items)
        {
            Console.WriteLine($"{item.Title} - {item.Price:C} x {item.Quantity} = {item.Quantity * item.Price:C}");
        }
    }
}
