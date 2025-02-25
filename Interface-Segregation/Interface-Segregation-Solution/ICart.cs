using System;

namespace Interface_Segregation_Solution;

public interface ICart
{
    void AddItems(IEnumerable<CartItem> items);
    Order Checkout(CheckoutInfo checkoutInfo);
}
