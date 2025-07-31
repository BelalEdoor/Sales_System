using SalesSystem;
using SalesSystem.Core;
using SalesSystem.Core.ShoppingCarts;
using StrategyPattern.Core;

var customers = new CustomerDataReader().GetCustomers();
var items = new ItemDataReader().GetItems();

Console.WriteLine("Customer List:");
foreach (var customer in customers)
    Console.WriteLine($"\t{customer.Id}. {customer.Name} ({customer.Category})");

Console.WriteLine();
Console.WriteLine("Item List:");
foreach (var item in items)
    Console.WriteLine($"\t{item.Id}. {item.Name} ({item.Unitprice:0.00})");

Console.WriteLine();
Console.Write($"Enter Customer ID: ");
var customerId = int.Parse(Console.ReadLine());

Console.Write("Select Shopping Cart Type (Online | InStore): ");
ShoppingCart shoppingCart = Console.ReadLine().Equals("Online", StringComparison.OrdinalIgnoreCase)
    ? new OnlineShoppingCart()
    : new InStoreShoppingCart();

while (true)
{
    Console.Write("Enter Item ID (0 to Complete the order): ");
    var itemId = int.Parse(Console.ReadLine());

    if (itemId == 0)
        break;

    Console.Write("Enter Item Quantity: ");
    var quantity = double.Parse(Console.ReadLine());
    var item = items.First(x => x.Id == itemId);
    shoppingCart.AddItem(itemId, quantity, item.Unitprice);
}

var selectedCustomer = customers.First(x => x.Id == customerId);
shoppingCart.Checkout(selectedCustomer); // تأكد من استدعاء Checkout
Console.ReadKey();