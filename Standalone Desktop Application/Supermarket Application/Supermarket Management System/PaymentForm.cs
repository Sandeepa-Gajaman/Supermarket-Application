using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Supermarket_Management_System
{
    public partial class PaymentForm : Form
    {
        private decimal discountpercentage;
        private String loyaltycardnumber;
        private List<object> Cart;
        private decimal Total = 0.00m;
        private decimal discount=0.00m;
        private decimal Totalamountpay = 0.00m;
        private int customerid = 2;
        private int totalshopcount;
        private decimal totalpurchasevalue;
        private decimal balance;
        private bool details=false;
        private bool paymentsucceed = false;
        private int orderid;
        //List<object> cart,decimal total
        public PaymentForm(List<object> cart, decimal total)
        {
            InitializeComponent();
            CashPayment.Visible = false;
            DebitCard.Visible = false;
            CreditCard.Visible = false;
           // Paymentbutton.Visible = false;
            Cart = cart;
            Total = total;
            Totalamountpay = total;
            PaymentLabel.Text = Total.ToString();
            TotalPaymentLable.Text = Total.ToString();
            //MessageBox.Show(customerid.ToString(),"jkjk");
            OrderController orc = new OrderController();
            orc.setcustomerid(customerid);
            orc.settotal(Total);
            orc.setorder();
            orderid = orc.getorderid();
            if(orderid==0)
            {
                Paymentbutton.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Cash")
            {
             //   MessageBox.Show(orderid.ToString());
                  PaymentController pcobject = new PaymentController();
                try
                {

                    pcobject.setorderid(orderid);
                    pcobject.setpaymenttype(comboBox1.Text);
                    pcobject.settotal(Convert.ToDecimal(textBox1.Text));
                    pcobject.settotalamountpay(Totalamountpay);
                    details = pcobject.setpayment();
                    balance = pcobject.getbalance();
                    if (details == true)
                    {
                       // MessageBox.Show("okay");
                        OrderItemController oic = new OrderItemController();
                        oic.SetCart(Cart);
                        oic.setorderid(orderid);
                        details = oic.setitemorder();
                        if (details == true)
                        {
                           // MessageBox.Show("order item is set");
                            Balancelabel.Text = balance.ToString();
                            Paymentbutton.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("order item is not set");
                        }




                    }
                    else
                    {
                        //MessageBox.Show("not okay");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("please input valid amount");
                }





            }

            else if (comboBox1.Text == "CreditCard")
            {
                try
                {
                    PaymentController pcobject = new PaymentController();
                    Regex regex = new Regex(@"^[0-9]+$");
                    if (regex.IsMatch(CreditCardBox3.Text))
                    {
                        // MessageBox.Show("true");   
                       
                        pcobject.setorderid(orderid);
                        pcobject.setpaymenttype(comboBox1.Text);
                        pcobject.setcardnumber(CreditCardBox3.Text);
                        pcobject.settotalamountpay(Totalamountpay);
                        details = pcobject.setpayment();
                        if (details == true)
                        {
                            //MessageBox.Show("okay");
                            OrderItemController oic = new OrderItemController();
                            oic.SetCart(Cart);
                            oic.setorderid(orderid);
                            details = oic.setitemorder();
                            if (details == true)
                            {
                               // MessageBox.Show("order item is set");
                                Balancelabel.Text = balance.ToString();
                                Paymentbutton.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("order item is not set");
                            }




                        }
                        else
                        {
                            MessageBox.Show("sorry");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Input Valid number");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Input Valid numberhh");
                }

                
            }
            else if (comboBox1.Text == "DebitCard")
            {
                try
                {
                    PaymentController pcobject = new PaymentController();
                    Regex regex = new Regex(@"^[0-9]+$");
                    if (regex.IsMatch(DebitCardtextBox.Text))
                    {
                        // MessageBox.Show("true");   

                        pcobject.setorderid(orderid);
                        pcobject.setpaymenttype(comboBox1.Text);
                        pcobject.setcardnumber(DebitCardtextBox.Text);
                        pcobject.settotalamountpay(Totalamountpay);
                        details = pcobject.setpayment();
                        if (details == true)
                        {
                            //MessageBox.Show("okay");
                            OrderItemController oic = new OrderItemController();
                            oic.SetCart(Cart);
                            oic.setorderid(orderid);
                            details = oic.setitemorder();
                            if (details == true)
                            {
                                //MessageBox.Show("order item is set");
                                Balancelabel.Text = balance.ToString();
                                Paymentbutton.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("order item is not set");
                            }




                        }
                        else
                        {
                            MessageBox.Show("sorry");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Input Valid number");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Input Valid number");
                }


            }













        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                DebitCard.Visible = false;
                CreditCard.Visible = false;
                CashPayment.Visible = true;
                Paymentbutton.Visible = Enabled;
                textBox1.Text = "";

            }
            else if (comboBox1.Text == "CreditCard")
            {
               
                CashPayment.Visible = true;
                DebitCard.Visible = false;
                CreditCard.Visible = true;
                Paymentbutton.Visible = Enabled;
                CreditCardBox3.Text = "";
            }
            else if (comboBox1.Text == "DebitCard")
            {
               
                //  Cash.Visible = false;
                CashPayment.Visible = true;
                DebitCard.Visible = true;
                CreditCard.Visible = true;
                Paymentbutton.Visible = Enabled;
                DebitCardtextBox.Text = "";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CashPayment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DebitCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Validatecustomerbutton_Click(object sender, EventArgs e)
        {
            loyaltycardnumber = LoyaltytextBox.Text;
            
            CustomerContoller co = new CustomerContoller();
            co.Checkcustomer(loyaltycardnumber);
            customerid = co.getcustomerid();
            totalshopcount = co.getshopcount();
            totalpurchasevalue = co.gettotalpurchase();
          /*  MessageBox.Show(customerid.ToString() + "customerid");
            MessageBox.Show(totalshopcount.ToString() + "totalshopcount");
            MessageBox.Show(totalpurchasevalue.ToString() + "totalpurchasevalue");
            */
           
            if (customerid!=2 )
            {
               MessageBox.Show("loyal customer");

             
                if(totalpurchasevalue>=0&& totalpurchasevalue<= 5000)
                {
                    discountpercentage = 5.00m;
                    discount = (Total * discountpercentage)/100;
                    discount = (decimal)(Math.Round(discount, 2));
                    DiscountLabel.Text = discount.ToString();
                    Totalamountpay = Total - discount;
                    Totalamountpay = (decimal)(Math.Round(Totalamountpay, 2));
                    TotalPaymentLable.Text = Totalamountpay.ToString();
                  
                }
                else if (totalpurchasevalue >= 10000)
                {
                    discountpercentage = 10.00m;
                    discount = (Total * discountpercentage)/100;
                    discount = (decimal)(Math.Round(discount, 2));
                    DiscountLabel.Text = discount.ToString();
                    Totalamountpay = Total - discount;
                    Totalamountpay = (decimal)(Math.Round(Totalamountpay, 2));
                    TotalPaymentLable.Text = Totalamountpay.ToString();
                 
                }
                else
                {
                    discountpercentage = 0.00m;
                    discount = 0.00m;
                   
                    DiscountLabel.Text = discount.ToString();
                    Totalamountpay = Total - discount;
                    Totalamountpay = (decimal)(Math.Round(Totalamountpay, 2));
                    TotalPaymentLable.Text = Totalamountpay.ToString();
                }
                OrderController oc = new OrderController();
                oc.setcustomerid(customerid);
                oc.setorderid(orderid);
                bool details=oc.updatecustomerid();
                if (details == false)
                {
                    MessageBox.Show("customer was not updated");
                }
                



            }
            else 
            {
                
                MessageBox.Show("Please input appropriate telephone number");
               // MessageBox.Show("normal customer");
                DiscountLabel.Text = "0.00";
                customerid = 2;

            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            if(details==false)
            {
                OrderController orc = new OrderController();
               // MessageBox.Show(orderid.ToString(), "orderid");
                orc.setorderid(orderid);
                bool i=orc.deleteorder();
                if(i==true)
                {
                    //MessageBox.Show("order is deleted");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("order is not deleted");
                   // this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
