using System;
using System.Text.Json;

namespace Single_Responsibility_Solution;

public class JSONCartStorage : ICartStorage
{
    public List<ShoppingCartItem> LoadFromFile(string fileName)
    {
        using var reader = new StreamReader(new FileStream(fileName, FileMode.Open));
        var jsonString = reader.ReadToEnd();
        reader.Close();

        var items = new List<ShoppingCartItem>();
        items.Clear();
        var loadItems = JsonSerializer.Deserialize<List<ShoppingCartItem>>(jsonString);
        if (loadItems != null)
        {
            items.AddRange(loadItems);
        }
        return items;
    }

    public void SaveToFile(string fileName, List<ShoppingCartItem> items)
    {
        string jsonString = JsonSerializer.Serialize(items);

        using var writer = new StreamWriter(new FileStream(fileName, FileMode.Create));
        writer.Write(jsonString);
        writer.Flush();
        writer.Close();
    }
}
