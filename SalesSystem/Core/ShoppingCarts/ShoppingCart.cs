using SalesSystem.Payments.Abstraction;
using StrategyPattern.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Core.ShoppingCarts
{
    public abstract class ShoppingCart
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
        
        public void Checkout(Customer customer, PaymentProcessor paymentProcessor)
        {
            var invoice = new Invoices
            {
                Customer = customer,
                Lines = _Lines
            };
            ApplyTaxes(invoice);
            ApplyDiscount(invoice);
            ProcessPayment(invoice, paymentProcessor);
        }

        private void ApplyTaxes(Invoices invoice)
            {
            invoice.Taxes = invoice.TotalPrice * 0.15;
            }
        protected abstract void ApplyDiscount(Invoices invoice);

        private void ProcessPayment(Invoices invoice, PaymentProcessor paymentProcessor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"({GetType().Name}) Invoice for Customer `{invoice.Customer.Name}`with net price:`{invoice.NetPrice}`");
            
            var payment = paymentProcessor.ProcessPayment(invoice.Customer.Id, invoice.NetPrice);
            Console.WriteLine($"Customer Charged with {payment.ChargeAmount }, payment ref : {payment.RefrenceNumber}"); 

            Console.ForegroundColor = ConsoleColor.White;
        }
   
    
       
    }
}
