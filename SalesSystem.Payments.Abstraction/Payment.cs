using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payments.Abstraction
{
    public class Payment
    {
        public int customerId { get; set; }
        public double ChargeAmount { get; set; }
        public Guid RefrenceNumber { get; set; }

    }
}

