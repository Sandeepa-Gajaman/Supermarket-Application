using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using SupermarketSystemDevLibrary;

namespace Supermarket_Management_System
{
    class CheckItem
    {
        private string ItemCategory;
        private int ItemId;
        private int Quantity;
        public void setItemCategory(String itemcategory)
        {
          
            
            this.ItemCategory = itemcategory;
           
        }
        public void SetItemCode(String itemid)
        {
            ItemId=Convert.ToInt32(itemid);
        }
        public void SetItemQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public  DataTable check()
        {

            ItemDatabaseHelper it = new ItemDatabaseHelper();
            return it.SelectItemsByCategory(ItemCategory);
          
        }
        public bool updatequantity()
        {
            ItemDatabaseHelper it = new ItemDatabaseHelper();
            bool i=it.UpdateQuantity(ItemId,Quantity);
            return i;
        }
    }
}
