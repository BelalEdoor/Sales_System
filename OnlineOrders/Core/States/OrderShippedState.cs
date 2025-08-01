using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Core.States
{
    internal class OrderShippedState : IOrderState
    {
        private Order _order;

        public OrderShippedState(Order order)
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
            _order.State = new OrderReturnedState(_order);
        }

        public void Shipp()
        {
            throw new NotImplementedException();
        }
    }
}
