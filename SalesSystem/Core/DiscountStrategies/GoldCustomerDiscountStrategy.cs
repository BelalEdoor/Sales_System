namespace StrategyPattern.Core.DiscountStrategies
{
    public class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double TotalPrice)
        {
            return TotalPrice >= 10000 ? 0.1 : 0;
        }
    }
}
