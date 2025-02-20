using System;

namespace Single_Responsibility_Solution;

public class ShoppingCartItem
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public string? Title { get; set; }
    public double Price { get; set; }
}