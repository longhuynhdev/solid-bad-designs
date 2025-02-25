using System;

namespace Interface_Segregation_Solution;

public interface IOnlineStore
{
    void AddProduct(int productId, int quantity);
    void RemoveProduct(int productId, int quantity);
    IEnumerable<CartItem> GetItems();
}

