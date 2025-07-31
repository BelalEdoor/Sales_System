using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core
{
    internal class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer() {
                    Id = 1,
                    Name = "Belal Edoor",
                    Category = CustomerCategory.Gold
                },
                new Customer() {
                    Id = 2,
                    Name = "Ahmad Najar", 
                    Category = CustomerCategory.Silver
                },
                 new Customer() {
                    Id = 3,
                    Name = "Mahmoud Abd",
                    Category = CustomerCategory.New 
                }


            };
        }
    }
}
