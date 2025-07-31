using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Core
{
    internal class ItemDataReader
    {
        public IEnumerable<Item> GetItems()
        {
            return new[]
            {
                new Item {Id = 1, Name = "Laptop", Unitprice = 10000},
                new Item {Id = 2, Name = "LCD", Unitprice = 2000},
                new Item {Id = 3, Name = "Keyboard", Unitprice = 150},
                new Item {Id = 4, Name = "Mouse", Unitprice = 100}

            };
        }
    }
}
