using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payments.Abstraction
{
    public abstract class PaymentProcessor
    {
        public Payment ProcessPayment(int customerId, double amount)
        {
            var paymentMathod = CreatePaymentMethod();
            var payment = paymentMathod.Charge(customerId, amount);

            return payment;

        }

        protected abstract IPaymentMethod CreatePaymentMethod();

    }
}

