using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Supermarket_Management_System
{
    class OrderItemController
    {
        private List<object> Cart;
        private int noofrows;
        private int ItemQuantity;
        private int itemid;
        private decimal TotalPrice;
        private int Orderid;
        private bool details = false;
        OrderItem itm = new OrderItem();
        public void SetCart(List<object> cart)
        {
            Cart = cart;
        }
        public void setorderid(int orderid)
        {
            Orderid = orderid;
        }
        public bool setitemorder()
        {
           // MessageBox.Show(Cart.Count.ToString(),"cartitem");
            int a = Convert.ToInt32(Cart.Count());
            noofrows = a / 8;
            int row = 0;
            for (int i = 0; i < noofrows; i++)
            {
                /* for (int j = 0; j <= 7; j++)
                 {
                     //list.Add(this.dataGridView3.Rows[i].Cells[j].Value);
                 }
                 /*  list.Add(this.dataGridView3.Rows[i].Cells[0].Value);
                   list.Add(this.dataGridView3.Rows[i].Cells[5].Value);
                   list.Add(this.dataGridView3.Rows[i].Cells[7].Value);*/
                itemid = Convert.ToInt32(Cart[0+row]);
                ItemQuantity = Convert.ToInt32(Cart[5+row]);
                TotalPrice = Convert.ToDecimal(Cart[7+row]);

                itm.SetItemId(itemid);
                itm.SetQuantity(ItemQuantity);
                itm.SetTotalPrice(TotalPrice);
                itm.setorderid(Orderid);
                details = itm.SetItemQuantity();
                if (details == false)
                {
                    details = false;
                    break;
                }
                else
                {
                    row=row+8;
                }
                

            }
            return details;
        }
    }
}
