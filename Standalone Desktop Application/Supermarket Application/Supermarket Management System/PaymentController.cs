using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketSystemDevLibrary;
using MySql.Data.MySqlClient;
using MySql;
using System.Windows.Forms;
namespace Supermarket_Management_System
{
    class PaymentController
    {

        private string cardnumber;
        private int cutomerid;
        private int shop_count;
        private decimal totalamountpay;
        private string paymenttype;
        private decimal payment;
        private decimal balance;

        
       
        private int orderid;
        public void setcardnumber(string cardno)
        {
            cardnumber = cardno;
        }
        public void setorderid(int Orderid)
        {
            orderid = Orderid;

        }
        public void settotalamountpay(decimal Totalamountpay)
        {
            totalamountpay = Totalamountpay;
            //MessageBox.Show(totalamountpay.ToString(), "total amount pay");
        }
        public void settotal(decimal Payment)
        {
            payment = Payment;
           
        }
        public void setpaymenttype(string Paymenttype)
        {
            paymenttype = Paymenttype;
        }
        public bool setpayment()
        {
            bool details=false;
            if(paymenttype== "Cash")
            {
                CashPayment cp = new CashPayment();
                cp.setorderid(orderid);
                cp.setpayment(payment);
                cp.settotalamountpayment(totalamountpay);
                cp.setpaymenttype(paymenttype);
                details=cp.insertpayment();
                balance=cp.getbalance();
               
                

                
            }
            else if(paymenttype== "CreditCard")
            {
               // MessageBox.Show("credit card");
                CardPayment cd = new CardPayment();
                cd.setcardno(cardnumber);
                cd.setorderid(orderid);
                cd.settotalamountpayment(totalamountpay);
                cd.CardType(paymenttype);
                details = cd.insertpayment();
            }
            else if(paymenttype == "DebitCard")
            {
                CardPayment cd = new CardPayment();
                cd.setcardno(cardnumber);
                cd.setorderid(orderid);
                cd.settotalamountpayment(totalamountpay);
                cd.CardType(paymenttype);
                details = cd.insertpayment();
            }
            return details;
        }
        public decimal getbalance()
        {
            return balance;
        }
        public void SetCardNumber(string Cardnumber )
        {
            cardnumber = Cardnumber;
        }

        
    }
}
