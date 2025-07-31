using StrategyPattern.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Core.ShoppingCarts
{
    internal abstract class ShoppingCart
    {
        private List<InvoicesLine> _Lines = new();

        public void AddItem(int itemId, double quantity, double unitprice)
        {

            _Lines.Add(new InvoicesLine
            {
                ItemId = itemId,
                Quantity = quantity,
                UnitPrice = unitprice
            });
        }
        public void Checkout(Customer customer)
        {
            var invoice = new Invoices
            {
                Customer = customer,
                Lines = _Lines
            };
            ApplyTaxes(invoice);
            ApplyDiscount(invoice);
            ApplyPayment(invoice);
        }

        private void ApplyTaxes(Invoices invoice)
            {
            invoice.Taxes = invoice.TotalPrice * 0.15;
            }
        protected abstract void ApplyDiscount(Invoices invoice);
            
        private void ApplyPayment(Invoices invoice)
        {
           Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"({GetType().Name}) Invoice for Customer `{  invoice.Customer.Name}`with net price:`{invoice.NetPrice}`");
            Console.ForegroundColor = ConsoleColor.White;
        }

    
       
    }
}
