using Interface_Segregation_Solution;

IOnlineStore onlineStore = new OnlineStore();

onlineStore.AddProduct(1, 1);
onlineStore.AddProduct(2, 10);
onlineStore.AddProduct(3, 100);

var checkoutInfo = new CheckoutInfo();
ICart cart = new Cart();
cart.AddItems(onlineStore.GetItems());
var order = cart.Checkout(checkoutInfo);

Console.WriteLine($"Order created, Id = {order.Id}");