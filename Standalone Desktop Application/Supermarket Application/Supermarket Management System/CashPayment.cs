using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketSystemDevLibrary;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    class CashPayment :Payment
    {
        
       // private decimal totalpurchase;
        private decimal balance;
        private decimal payment;


        
        OrderController orc = new OrderController();
        PaymentController pc = new PaymentController();
        ItemDatabaseHelper idh = new ItemDatabaseHelper();
        public void setorderid(int Orderid)
        {
            orderid = Orderid;
            //MessageBox.Show(orderid.ToString(), "orderid");
        }
        public void settotalamountpayment(decimal Totalpayment)
        {
            totalamountwithdiscount = Totalpayment;
          //  MessageBox.Show(totalamountwithdiscount.ToString(), "totalamountwithdiscountt");

        }
        public void setpayment(decimal Payment)
        {
            payment = Payment;
            //MessageBox.Show(payment.ToString(),"payment");
        }
        public decimal getbalance()
        {
            return balance;
        }
        public void setpaymenttype(string Paymenttype)
        {
            paymenttype = Paymenttype;
            //MessageBox.Show(paymenttype.ToString(), "payment type");
        }
        public override bool insertpayment()
        {
            bool details=false;
            if (payment >= totalamountwithdiscount)
            {
               balance = payment - totalamountwithdiscount;
                details=idh.insertpayment(orderid, paymenttype, totalamountwithdiscount);
               // MessageBox.Show(balance.ToString() + "balance");

                return details;
            }
            else
            {
                balance = 0.00m;
                try
                {

                    throw new CashValidation(payment);

                }
                catch(CashValidation e)
                {
                    e.Validation();
                    details = false;
                }
                return details;
            }
        }
        
    }
}
