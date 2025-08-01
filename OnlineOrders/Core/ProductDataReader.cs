using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Core
{
    internal class ProductDataReader
    {
        public IEnumerable<Products> GetProducts()
        {
            return new[]
            {
                new Products {Id = 1, Name = "Laptop", UnitPrice = 10000},
                new Products {Id = 2, Name = "LCD", UnitPrice = 2000},
                new Products {Id = 3, Name = "Keyboard", UnitPrice = 150},
                new Products {Id = 4, Name = "Mouse", UnitPrice = 100}
            };
        }
    }
}
