using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketSystemDevLibrary;

namespace Supermarket_Management_System
{
    class Order
    {
        private  string date;
        private string time;
        private int employeeid;
        private int customerid;
        private decimal total;
        private List<object> connectiondetails;
        private int orderid;

        public void setDate()
        {
            date=DateTime.Now.ToString("yyyy-MM-dd");
            //return date;
        }
        public void setTime()
        {
             time=DateTime.Now.ToLongTimeString();
           // return time;

        }
        public void setcustomerid(int Customerid)
        {
            customerid=Customerid;
        }
        public void setemployeeid()
        {
            employeeid = 1;
        }
        public void settotalvalue(decimal Total)
        {
            total = Total;
        }
        public void setorder()
        {
            ItemDatabaseHelper IT = new ItemDatabaseHelper();
          
            orderid=IT.setorder(customerid,time,date,employeeid,total);
         
        }
        public int getorderid()
        {
            return orderid;
        }
        public void setorderid(int Orderid)
        {
            orderid = Orderid;
        }
        public bool Deleteorder()
        {
            ItemDatabaseHelper IT = new ItemDatabaseHelper();
            return IT.DeleteItem(orderid);
        }
        public bool updateorder()
        {
            ItemDatabaseHelper IT = new ItemDatabaseHelper();
            return IT.UpdateCustomer(orderid, customerid);
        }


    }
}
