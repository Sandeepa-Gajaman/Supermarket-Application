using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    class OrderController
    {
        private int customerid;
        private decimal total;
      //  private List<object> connectiondetails;
        private int orderid;
        
        Order order = new Order();
        
        public void setcustomerid(int Customerid)
        {
            customerid = Customerid;
        }
        public void settotal(decimal Total)
        {
            total = Total;
           // MessageBox.Show(total.ToString(), "total");
            
        }
        public void setorder()
        {
            order.setcustomerid(customerid);
            order.settotalvalue(total);
            order.setemployeeid();
            order.setTime();
            order.setDate();
            order.setorder();
            
        }
        public int getorderid()
        {
            orderid = order.getorderid();

            return orderid;
        }
        public void setorderid(int Orderid)
        {
            orderid = Orderid;
        }
        public bool deleteorder()
        {
            bool details=false;
            order.setorderid(orderid);
            details=order.Deleteorder();
            return details;
        }
        public bool updatecustomerid()
        {
            order.setcustomerid(customerid);
            order.setorderid(orderid);
            return  order.updateorder();

        }
        

        

    }
}
