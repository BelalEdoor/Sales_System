using SalesSystem.Payments.Abstraction;
using System;

namespace SalesSystem.Core.Payments
{
    internal class PayPalPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            // عمولة ثابتة 5% لجميع المبالغ
            var commission = amount * 0.05;
            var chargedAmount = amount + commission;

            Console.WriteLine($"[Debug] PayPal Charge - Amount: {amount}, Commission: {commission}, Total: {chargedAmount}");

            return new Payment
            {
                customerId = customerId,
                ChargeAmount = chargedAmount,
                RefrenceNumber = Guid.NewGuid()
            };
        }
    }
}