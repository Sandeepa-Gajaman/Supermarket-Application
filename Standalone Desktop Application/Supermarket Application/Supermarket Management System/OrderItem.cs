using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketSystemDevLibrary;

namespace Supermarket_Management_System
{
    class OrderItem
    {
        private int ItemId;
        private decimal TotalPrice;
        private int Orderid;
        private int ItemQuantity;
        bool details = false;
        private ItemDatabaseHelper itemdatabasehelper = new ItemDatabaseHelper();
        
        public void SetItemId(int itemid)
        {
            ItemId = itemid;
        }
        public void SetTotalPrice(decimal totalprice)
        {
            TotalPrice = totalprice;
        }
        public void SetQuantity(int itemquantity)
        {
            ItemQuantity = itemquantity;
        }
        public void setorderid(int orderid)
        {
            Orderid = orderid;
        }
        public bool SetItemQuantity()
        {
          
           details =itemdatabasehelper.SetItemQuantity(Orderid, ItemId, ItemQuantity, TotalPrice);
            return details;
         }
    }

}
