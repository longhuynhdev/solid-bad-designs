using System;

namespace Single_Responsibility_Solution;

public class HTMLCartPrinter : ICartPrinter
{
    public void Print(List<ShoppingCartItem> items)
    {
        Console.WriteLine("<!DOCTYPE html>");
        Console.WriteLine("<html lang=\"en\">");
        Console.WriteLine("<head>");
        Console.WriteLine("    <meta charset=\"UTF-8\">");
        Console.WriteLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
        Console.WriteLine("    <title>Shopping Cart</title>");
        Console.WriteLine("</head>");
        Console.WriteLine("<body>");
        Console.WriteLine("    <main>");
        Console.WriteLine("        <h1>SHOPPING CART</h1>");
        Console.WriteLine("        <hr>");
        Console.WriteLine("        <ul>");
        foreach (var item in items)
        {
            Console.WriteLine($"            <li>{item.Title} - {item.Price:C} x {item.Quantity} = {item.Quantity * item.Price:C}</li>");
        }
        Console.WriteLine("        </ul>");

        Console.WriteLine("    </main>");
        Console.WriteLine("</body>");
        Console.WriteLine("</html>");
    }
}
