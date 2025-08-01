using SalesSystem.Payments.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Core.Payments
{
    internal class PayPalPaymentProcessor : PaymentProcessor
    {
        protected override IPaymentMethod CreatePaymentMethod()
        {
            return new PayPalPaymentMethod();
        }
    }
}
