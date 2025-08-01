using StrategyPattern.Core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core
{
    public class InvoiceManager
    {
        private ICustomerDiscountStrategy _disccountStrategy;
        public void SetDiscountStrategy (ICustomerDiscountStrategy Strategy)
        {
            _disccountStrategy = Strategy;
        }
        public Invoices CreateInvoice(Customer customer, double quantity, double unitPrice)
        {
            // إنشاء الفاتورة
            var invoice = new Invoices
            {
                Customer = customer,
                Lines = new[]
                {
                        new InvoicesLine { Quantity = quantity, UnitPrice = unitPrice }
                },
            };
            invoice.DiscountPercentage = _disccountStrategy.CalculateDiscount(invoice.TotalPrice);

            return invoice;
        }
    }
}
