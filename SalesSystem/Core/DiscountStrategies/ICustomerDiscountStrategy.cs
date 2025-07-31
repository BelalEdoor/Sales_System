namespace StrategyPattern.Core.DiscountStrategies
{
    public interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totalPrice);
    }
}
