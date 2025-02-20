using System;

namespace Single_Responsibility_Solution;

public class ConsoleCartPrinter : ICartPrinter
{
    public void Print(List<ShoppingCartItem> items)
    {
        Console.WriteLine();
        Console.WriteLine("SHOPPING CART");
        Console.WriteLine("~~~~~~~~~~~~~");

        foreach (var item in items)
        {
            Console.WriteLine($"{item.Title} - {item.Price:C} x {item.Quantity} = {item.Quantity * item.Price:C}");
        }
    }
}
