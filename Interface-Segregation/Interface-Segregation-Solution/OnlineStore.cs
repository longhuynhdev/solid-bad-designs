using System;

namespace Interface_Segregation_Solution;

public class OnlineStore : IOnlineStore
{
    private readonly Dictionary<int, int> cart = new Dictionary<int, int>();

    public void AddProduct(int productId, int quantity)
    {
        if (cart.ContainsKey(productId))
        {
            cart[productId] = cart[productId] + quantity;
        }
        else
        {
            cart.Add(productId, quantity);
        }
    }

    public void RemoveProduct(int productId, int quantity)
    {
        if (cart.TryGetValue(productId, out int value))
        {
            int newQuantity = value - quantity;
            if (newQuantity > 0)
            {
                cart[productId] = newQuantity;
            }
            else
            {
                cart.Remove(productId);
            }
        }
    }

    public IEnumerable<CartItem> GetItems()
    {
        return cart.Select(item => new CartItem 
        { 
            ProductId = item.Key, 
            Quantity = item.Value 
        });
    }

    
}
