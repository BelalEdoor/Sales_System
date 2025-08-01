using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Core.States
{
    internal class OrderCanceledState : IOrderState
    {
        private Order order;

        public OrderCanceledState(Order order)
        {
            this.order = order;
        }

        public void Cancele()
        {
            throw new NotImplementedException();
        }

        public void Confirm()
        {
            throw new NotImplementedException();
        }

        public void Deliver()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }

        public void Return()
        {
            throw new NotImplementedException();
        }

        public void Shipp()
        {
            throw new NotImplementedException();
        }
    }
}
