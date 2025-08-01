using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Core.States
{
    internal class OrderProcessedState : IOrderState
    {
        private Order _order;

        public OrderProcessedState(Order order)
        {
            _order = order;
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
            _order.State = new OrderShippedState(_order);
        }
    }
}
