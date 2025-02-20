using System;

namespace Single_Responsibility_Solution;

public interface ICartStorage
{
    public List<ShoppingCartItem> LoadFromFile(string fileName);
    public void SaveToFile(string fileName, List<ShoppingCartItem> items);
}
