using StrategyPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Core.ShoppingCarts
{
    internal class OnlineShoppingCart : ShoppingCart
    {
        protected override void ApplyDiscount(Invoices invoice)
        {
            if (invoice.TotalPrice > 10000)
            {
                invoice.DiscountPercentage = 0.05;
            }

        }
    }
}
