using SalesSystem.Core.DiscountStrategies;
using StrategyPattern.Core;
using StrategyPattern.Core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem
{
    internal class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateICustomerDiscountStrategy(CustomerCategory Category)
        {
            if (Category == CustomerCategory.Silver)
                return new SilverCustomerDiscountStrategy();
            else if (Category == CustomerCategory.Gold)
                return new GoldCustomerDiscountStrategy();
            return new NullDiscountStrategy();
        }
    }
}
