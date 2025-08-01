using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern.Core
{
    public class Invoices
    {
        public Customer Customer { get; set; } = new Customer();
        public IEnumerable<InvoicesLine> Lines { get; set; } = new List<InvoicesLine>();
        public double TotalPrice => Lines.Sum(x => x.Quantity * x.UnitPrice);
        public double DiscountPercentage { get; set; }
        public double Taxes { get; set; }
        public double NetPrice => TotalPrice - (TotalPrice * DiscountPercentage);
        
    }
}
