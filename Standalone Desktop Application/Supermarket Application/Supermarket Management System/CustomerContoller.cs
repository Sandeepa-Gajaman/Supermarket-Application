using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Management_System
{
    class CustomerContoller
    {
        private string mobilenumber;
        private int customerid;
        private int shopcount;
        private decimal totalpurchase;
        Customer custom = new Customer();
        public void Checkcustomer(string loyaltycardnumber)
        {
            custom.checkcustomer(loyaltycardnumber);
            custom.setcustomerid();
            custom.setshopcount();
            custom.settotalpurchasevalue();
        }
        public int getcustomerid()
        {
            return custom.getcustomerid();
        }
        public int getshopcount()
        {
            return custom.getshopcount();
        }
        public decimal gettotalpurchase()
        {
            return custom.gettotalpurchasevalue();
        }
    }
}
