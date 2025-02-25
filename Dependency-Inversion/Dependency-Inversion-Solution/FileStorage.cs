using System;
using System.Text.Json;

namespace Dependency_Inversion_Solution;

public class FileStorage : IStorage
{
    private string fileName;

    public FileStorage(string fileName)
    {
        this.fileName = fileName;
    }

    public ShoppingCart? Load()
    {
        using var reader = new StreamReader(new FileStream(fileName, FileMode.Open));
        var jsonString = reader.ReadToEnd();
        reader.Close();

        var loadItems = JsonSerializer.Deserialize<List<ShoppingCartItem>>(jsonString);
        if (loadItems != null)
        {
            var cart = new ShoppingCart();
            foreach (var item in loadItems)
            {
                cart.Add(item);
            }
            return cart;
        }

        return null;
    }

    public void Save(ShoppingCart cart)
    {
        string jsonString = JsonSerializer.Serialize(cart.Items);

        using var writer = new StreamWriter(new FileStream(fileName, FileMode.Create));
        writer.Write(jsonString);
        writer.Flush();
        writer.Close();
    }
}
