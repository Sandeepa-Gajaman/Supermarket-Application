using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketSystemDevLibrary;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    class Item
    {
        private int ItemId;
        private string ItemCategory;
        private string ItemBrand;
        private string ItemName;
        private string ItemDescription;
        private string ItemVolume;
        private int ItemQuantity;
        private decimal ItemUnitPrice;
        private decimal TotalPrice;
        private int Orderid;
        private ItemDatabaseHelper ItemDatabaseHelper;

        public Item()
        {
            ItemDatabaseHelper = new ItemDatabaseHelper();
        }

        /// <summary>
        /// Adds a new item to the item table
        /// </summary>
        /// <returns>True on success or false on failure</returns>
        public bool AddItem()
        {
            if (ItemDatabaseHelper.AddItem(ItemCategory, ItemBrand, ItemName, ItemDescription, ItemVolume, ItemUnitPrice))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Removes an existing item from the item table.
        /// </summary>
        /// <param name="ItemCode">Item code</param>
        /// <returns>True on success or false on failure</returns>
        public bool RemoveItem(int ItemCode)
        {
            if (ItemDatabaseHelper.RemoveItem(ItemCode))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Increase the quantity of an item in the inventory. The specified quantity is added to the existing
        /// quantity in the inventory if the new quantity will be under the inventory maximum limit.
        /// </summary>
        /// <param name="ItemCode">Item code</param>
        /// <param name="ItemQuantity">Quantity to be added</param>
        /// <returns>True on success or false on failure</returns>
        public bool IncreaseQuantity(int ItemCode, int ItemQuantity)
        {
            int MaxItems = 999999;
            int AvailableQuantity= ItemDatabaseHelper.GetQuantity(ItemCode);
            if(AvailableQuantity== -999)    
            {
                return false;
            }
            if((AvailableQuantity+ ItemQuantity)< MaxItems)
            {
                ItemDatabaseHelper.SetQuantity(ItemCode, AvailableQuantity+ ItemQuantity);
                return true;
            }
            else
            {
                MessageBox.Show("New quantity exceeds inventory capacity! Please select a lower quantity.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        /// <summary>
        /// Decrease the quantity of an item in the inventory. The specified quantity is removed from the existing quantity in the inventory
        /// if the new quantity will not be less than the inventory minimum limit.
        /// </summary>
        /// <param name="ItemCode">Item code</param>
        /// <param name="ItemQuantity">Quantity to be removed</param>
        /// <returns>True on success or false on failure</returns>
        public bool DecreaseQuantity(int ItemCode, int ItemQuantity)
        {
            int MinItems = 0;
            int AvailableQuantity = ItemDatabaseHelper.GetQuantity(ItemCode);
            if(AvailableQuantity== -999)
            {
                return false;
            }
            if((AvailableQuantity- ItemQuantity)>= MinItems)
            {
                ItemDatabaseHelper.SetQuantity(ItemCode, AvailableQuantity- ItemQuantity);
                return true;
            }
            else
            {
                int InadequateQuantity = AvailableQuantity - ItemQuantity;
                MessageBox.Show("Not enough quantity in the inventory! (Inadequate quantity- "+ InadequateQuantity+ " units). Please select a lower quantity. ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        //Setter functions.
        public void SetItemCategory(string ItemCategory)
        {
            this.ItemCategory = ItemCategory;
        }

        public void SetItemBrand(string ItemBrand)
        {
            this.ItemBrand = ItemBrand;
        }

        public void SetItemName(string ItemName)
        {
            this.ItemName = ItemName;
        }

        public void SetItemDescription(string ItemDescription)
        {
            this.ItemDescription = ItemDescription;
        }

        public void SetItemVolume(string ItemVolume)
        {
            this.ItemVolume = ItemVolume;
        }

        public void SetItemUnitPrice(decimal ItemUnitPrice)
        {
            this.ItemUnitPrice = ItemUnitPrice;
        }
        

    }
}
