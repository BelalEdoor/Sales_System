using OnlineOrders.Core.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Core
{
    internal class Order
    {
        public Order() 
        {
            State = new OrderDraftState(this);
        }
        public IOrderState State { get; internal set; }
        public List<OrderLine> Lines { get; set; } = new();
        //public void SetState(OrderState newState)
        //{
        //    if (
        //        (State == OrderState.Draft && newState != OrderState.Confirmed) ||
        //        (State == OrderState.Confirmed && newState != OrderState.Canceled && newState != OrderState.UnderProcessing) ||
        //        (State == OrderState.UnderProcessing && newState != OrderState.Shipped) ||
        //        (State == OrderState.Shipped && newState != OrderState.Delivered) ||
        //        (State == OrderState.Delivered && newState != OrderState.Returned)
        //    )
        //    {
        //        throw new InvalidOperationException($"Moving from state '{State}' to state '{newState}' is not allowed.");
        //    }

        //    State = newState;
        //}
        public void Confirm()
        {
            State.Confirm();
        }
        public void Cancele()
        {
            State.Cancele();
        }
        public void Process()
        {
            State.Process();
        }
        public void Shipp()
        {
            State.Shipp();
        }
        public void Deliver()
        {
            State.Deliver(); 
        }
        public void Return()
        {
            State.Return();
        }
    }
}
