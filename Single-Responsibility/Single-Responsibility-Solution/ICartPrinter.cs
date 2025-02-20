using System;

namespace Single_Responsibility_Solution;

public interface ICartPrinter
{
    void Print(List<ShoppingCartItem> items);
}
