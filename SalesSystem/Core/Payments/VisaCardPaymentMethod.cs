using SalesSystem.Payments.Abstraction;
using System;

namespace SalesSystem.Core.Payments
{
    internal class VisaCardPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            // عمولة 2% فقط إذا كان المبلغ أقل من 10,000 ولا توجد عمولة للمبالغ الأكبر
            var commission = amount < 10000 ? amount * 0.02 : 0;
            var chargedAmount = amount + commission;

            // طباعة قيم التصحيح (يمكن إزالتها لاحقًا)
            Console.WriteLine($"[Debug] Visa Charge - Amount: {amount}, Commission: {commission}, Total: {chargedAmount}");

            return new Payment
            {
                customerId = customerId,  // تصحيح الحالة (الكاميل كيس)
                ChargeAmount = chargedAmount,
                RefrenceNumber = Guid.NewGuid()  // تصحيح اسم الخاصية
            };
        }
    }
}