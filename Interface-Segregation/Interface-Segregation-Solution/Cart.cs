using System;

namespace Interface_Segregation_Solution;

public class Cart : ICart
{
    private readonly List<CartItem> items = new List<CartItem>();

    public void AddItems(IEnumerable<CartItem> items)
    {
        this.items.AddRange(items);
    }


    public Order Checkout(CheckoutInfo checkoutInfo)
    {
        if (checkoutInfo == null)
            throw new InvalidOperationException("checkoutInfo is null");

        return new Order { Id = 999 };
    }
}
