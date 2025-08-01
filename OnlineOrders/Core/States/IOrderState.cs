using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Core.States
{
    internal interface IOrderState
    {
        void Confirm();
        void Cancele();
        void Process();
        void Shipp();
        void Deliver();
        void Return();
    }
}
