using Single_Responsibility_Solution;

var cart = new ShoppingCart();
var storage = new JSONCartStorage();
var consolePrinter = new ConsoleCartPrinter();
var htmlPrinter = new HTMLCartPrinter();

cart.Add(new ShoppingCartItem()
{
    Price = 1200,
    ProductId = 1,
    Quantity = 1,
    Title = "iPhone 12"
});
cart.Add(new ShoppingCartItem()
{
    Price = 1400,
    ProductId = 1,
    Quantity = 2,
    Title = "iPhone 14"
});

// Print using different formats
consolePrinter.Print(cart.Items.ToList());
htmlPrinter.Print(cart.Items.ToList());

// Save to file
storage.SaveToFile("cart.json", cart.Items.ToList());

cart.Clear();
consolePrinter.Print(cart.Items.ToList());

// Load from file
var loadedItems = storage.LoadFromFile("cart.json");
foreach (var item in loadedItems)
{
    cart.Add(item);
}
consolePrinter.Print(cart.Items.ToList());