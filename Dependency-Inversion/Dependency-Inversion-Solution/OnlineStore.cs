using System;

namespace Dependency_Inversion_Solution;

public class OnlineStore
{
    private readonly IPrinter printer;
    private readonly IStorage storage;

    public ShoppingCart Cart { get; private set; }

    public OnlineStore(IPrinter printer, IStorage storage)
    {
        Cart = new ShoppingCart();

        this.printer = printer;
        this.storage = storage;
    }

    public void Save()
    {
        storage.Save(Cart);
    }

    public void Load()
    {
        var cart = storage.Load();
        if (cart != null)
        {
            this.Cart = cart;
        }
        else
        {
            throw new Exception("Error loading cart");
        }
    }

    public void Print()
    {
        printer.Print(Cart);
    }
}
