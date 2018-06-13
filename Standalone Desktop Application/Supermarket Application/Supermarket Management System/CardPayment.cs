using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketSystemDevLibrary;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    class CardPayment :Payment
    {
        ItemDatabaseHelper itemdatabasehelper = new ItemDatabaseHelper();
        private string cardno;
       
        
        public void setorderid(int Orderid)
        {
            orderid = Orderid;
        }
        public void setcardno(string Cardno)
        {
            cardno = Cardno;
        }
        public void CardType(string Cardtype)
        {
            paymenttype = Cardtype;
        }
        public void settotalamountpayment(decimal Totalpayment)
        {
            totalamountwithdiscount = Totalpayment;
            

        }
        public  override bool insertpayment()
        {
            bool details = false;
            //MessageBox.Show(cardno.Length.ToString(),"length");
            if (cardno.Length==10)
            
            {
               // MessageBox.Show(orderid.ToString(), paymenttype);
               // MessageBox.Show(totalamountwithdiscount.ToString());
                
                details = itemdatabasehelper.insertpayment(orderid, paymenttype, totalamountwithdiscount);
                

                
            }
            else
            {
                try
                {
                    details = false;
                    throw new CardValidation(paymenttype);
                }
                catch(CardValidation e)
                {
                    details = false;
                    e.Validation();
                }
                
            }
            return details;
        }
        //if(cardno)
    }
}
