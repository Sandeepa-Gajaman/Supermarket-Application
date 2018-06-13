using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System
{
   abstract class Payment
    {
        protected decimal totalamountwithdiscount;
        protected int orderid;
        protected string paymenttype;
        public abstract bool insertpayment();     
    }
}
