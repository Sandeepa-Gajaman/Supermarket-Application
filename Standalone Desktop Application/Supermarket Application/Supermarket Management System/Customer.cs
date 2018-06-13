using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketSystemDevLibrary;
namespace Supermarket_Management_System
{
    class Customer
    {
        private int customerid;
        private int shopcount;
        private decimal totalpurchase;
        ItemDatabaseHelper customer=new ItemDatabaseHelper();
      
        private List<object> customerdetails;
        public void checkcustomer(string loyaltycardnumber)
        {

            customerdetails=customer.GetDetails(loyaltycardnumber);
        }
        public void setcustomerid()
        {
            customerid = Convert.ToInt32(customerdetails[0]);
        }
        public int getcustomerid()
        {
           
            return customerid;
        }
        public void setshopcount()
        {
            shopcount = Convert.ToInt32(customerdetails[1]);
        }
        public int getshopcount()
        {
            return shopcount;
        }
        public void settotalpurchasevalue()
        {
            totalpurchase = Convert.ToDecimal(customerdetails[2]);
        }
        public decimal gettotalpurchasevalue()
        {
            return totalpurchase;
        }
        


    }
}
