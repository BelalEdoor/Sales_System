using System;
using System.Linq;
using SalesSystem;
using SalesSystem.Core;
using SalesSystem.Core.Payments;
using SalesSystem.Core.ShoppingCarts;
using SalesSystem.Payments.Abstraction;
using StrategyPattern.Core;

var customers = new CustomerDataReader().GetCustomers();
var items = new ItemDataReader().GetItems();

while (true)
{
    Console.WriteLine("Customer List:");
    foreach (var customer in customers)
        Console.WriteLine($"\t{customer.Id}. {customer.Name} ({customer.Category})");

    Console.WriteLine("\nItem List:");
    foreach (var item in items)
        Console.WriteLine($"\t{item.Id}. {item.Name} ({item.Unitprice:0.00})");

    Console.Write("\nEnter Customer ID: ");
    int customerId;
    while (!int.TryParse(Console.ReadLine(), out customerId) || !customers.Any(c => c.Id == customerId))
        Console.Write("Invalid input. Please enter a valid Customer ID: ");

    Console.Write("Select Shopping Cart Type (Online | InStore): ");
    ShoppingCart shoppingCart;
    while (true)
    {
        var cartType = Console.ReadLine();
        if (cartType.Equals("Online", StringComparison.OrdinalIgnoreCase))
        {
            shoppingCart = new OnlineShoppingCart();
            break;
        }
        if (cartType.Equals("InStore", StringComparison.OrdinalIgnoreCase))
        {
            shoppingCart = new InStoreShoppingCart();
            break;
        }
        Console.Write("Invalid input. Please enter 'Online' or 'InStore': ");
    }

    while (true)
    {
        Console.Write("Enter Item ID (0 to Complete the order): ");
        int itemId;
        while (!int.TryParse(Console.ReadLine(), out itemId) || (itemId != 0 && !items.Any(i => i.Id == itemId)))
            Console.Write("Invalid input. Please enter a valid Item ID or 0 to complete: ");

        if (itemId == 0) break;

        Console.Write("Enter Item Quantity: ");
        double quantity;
        while (!double.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            Console.Write("Invalid input. Please enter a positive number: ");

        var item = items.First(x => x.Id == itemId);
        shoppingCart.AddItem(item.Id, quantity, item.Unitprice);
        Console.WriteLine($"Added {quantity} x {item.Name} (Unit Price: {item.Unitprice:0.00})");
    }

    var selectedCustomer = customers.First(x => x.Id == customerId);
    Console.Write("Select Payment Gateway (Visa | PayPal): ");
    PaymentProcessor paymentProcessor;
    while (true)
    {
        var gateway = Console.ReadLine();
        if (gateway.Equals("Visa", StringComparison.OrdinalIgnoreCase))
        {
            paymentProcessor = new VisaCardPaymentProcessor();
            break;
        }
        if (gateway.Equals("PayPal", StringComparison.OrdinalIgnoreCase))
        {
            paymentProcessor = new PayPalPaymentProcessor();
            break;
        }
        Console.Write("Invalid input. Please enter 'Visa' or 'PayPal': ");
    }

    shoppingCart.Checkout(selectedCustomer, paymentProcessor);

    Console.WriteLine("\nPress any key to create another invoice...");
    Console.ReadKey();
    Console.Clear();
}