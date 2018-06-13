using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class Form1 : Form
    {
        int RowNumber=0;
        decimal TotalPrice;
        int rowindexnumber=-1;//set -1
        public Form1()
        {
            InitializeComponent();
            CheckItem begin = new CheckItem();
            begin.setItemCategory("");
            dataGridView1.DataSource = begin.check();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckItem CI = new CheckItem();
            CI.setItemCategory(textBox1.Text);
            dataGridView1.DataSource = CI.check();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            this.dataGridView2.Rows[0].Cells[0].Value = selectedrow.Cells[0].Value.ToString();
            this.dataGridView2.Rows[0].Cells[1].Value = selectedrow.Cells[1].Value.ToString();
            this.dataGridView2.Rows[0].Cells[2].Value = selectedrow.Cells[2].Value.ToString();
            this.dataGridView2.Rows[0].Cells[3].Value = selectedrow.Cells[3].Value.ToString();
            this.dataGridView2.Rows[0].Cells[4].Value = selectedrow.Cells[5].Value.ToString();
            this.dataGridView2.Rows[0].Cells[5].Value = selectedrow.Cells[6].Value.ToString();
            this.dataGridView2.Rows[0].Cells[6].Value = selectedrow.Cells[7].Value.ToString();

            if(this.dataGridView2.Rows[0].Cells[5].Value.ToString()=="0"|| this.dataGridView2.Rows[0].Cells[5].Value.ToString() == "")
            {

                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soldQuantity;
            int rowcount=1;
            int Itemfound=0;

            try
            {
                int Totalquantity = Convert.ToInt32(dataGridView2.Rows[0].Cells[5].Value);
                soldQuantity = Convert.ToInt32(textBox2.Text);

                Totalquantity = Totalquantity - Convert.ToInt32(textBox2.Text);
                if (Totalquantity < 0)
                {
                    MessageBox.Show("Sorry");
                    return;
                }
                else
                {
                    rowcount = dataGridView3.Rows.Count;
                  
                    for (int i = 0; i < rowcount; i++)
                    {
                        if (Convert.ToInt32(dataGridView3.Rows[i].Cells[0].Value) == Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value))
                        {
                            
                            this.dataGridView3.Rows[i].Cells[5].Value = Convert.ToInt32(this.dataGridView3.Rows[i].Cells[5].Value) + soldQuantity;
                            this.dataGridView3.Rows[i].Cells[7].Value = Convert.ToInt32(this.dataGridView3.Rows[i].Cells[5].Value) * Convert.ToDecimal(dataGridView2.Rows[0].Cells[6].Value);
                            TotalPrice = TotalPrice + Convert.ToInt32(soldQuantity) * Convert.ToDecimal(dataGridView2.Rows[0].Cells[6].Value);
                            label5.Text = TotalPrice.ToString();
                            Itemfound = 1;
                            dataGridView2.Rows[0].Cells[5].Value = Totalquantity;
                            CheckItem obj = new CheckItem();
                            obj.SetItemCode(dataGridView2.Rows[0].Cells[0].Value.ToString());
                            obj.SetItemQuantity(-Convert.ToInt32(soldQuantity));
                            bool k = obj.updatequantity();
                            if (k == true)
                            {
                             
                                obj.setItemCategory("");
                                dataGridView1.DataSource = obj.check();
                            }

                            break;

                        }



                        

                    }
                   if(Itemfound==0)
                    {
                       
                        dataGridView3.Rows.Add();
                        dataGridView2.Rows[0].Cells[5].Value = Totalquantity;



                        this.dataGridView3.Rows[RowNumber].Cells[0].Value = dataGridView2.Rows[0].Cells[0].Value;
                        this.dataGridView3.Rows[RowNumber].Cells[1].Value = dataGridView2.Rows[0].Cells[1].Value;
                        this.dataGridView3.Rows[RowNumber].Cells[2].Value = dataGridView2.Rows[0].Cells[2].Value;
                        this.dataGridView3.Rows[RowNumber].Cells[3].Value = dataGridView2.Rows[0].Cells[3].Value;
                        this.dataGridView3.Rows[RowNumber].Cells[4].Value = dataGridView2.Rows[0].Cells[4].Value;
                        this.dataGridView3.Rows[RowNumber].Cells[5].Value = soldQuantity;
                        this.dataGridView3.Rows[RowNumber].Cells[6].Value = dataGridView2.Rows[0].Cells[6].Value;

                        this.dataGridView3.Rows[RowNumber].Cells[7].Value = Convert.ToInt32(soldQuantity) * Convert.ToDecimal(dataGridView2.Rows[0].Cells[6].Value);
                    
                        RowNumber++;
                        TotalPrice = TotalPrice + Convert.ToInt32(soldQuantity) * Convert.ToDecimal(dataGridView2.Rows[0].Cells[6].Value);
                        CheckItem obj = new CheckItem();
                        obj.SetItemCode(dataGridView2.Rows[0].Cells[0].Value.ToString());
                        obj.SetItemQuantity(-Convert.ToInt32(soldQuantity));
                        bool i = obj.updatequantity();
                        if (i == true)
                        {
                         
                            obj.setItemCategory("");
                            dataGridView1.DataSource = obj.check();
                        }
                        


                        
                        label5.Text = TotalPrice.ToString();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please input Number");
            }
            if(dataGridView3.Rows.Count>1)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();

            int noofrows = dataGridView3.Rows.Count;
          
            for (int i = 0; i < noofrows-1; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    list.Add(this.dataGridView3.Rows[i].Cells[j].Value);
                }
           
            }
            
            Decimal total = Convert.ToDecimal(label5.Text);

          
           PaymentForm form = new PaymentForm(list,total);
           form.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rowindexnumber != -1)
            {
               
                try
                {
                    double total = Convert.ToDouble(label5.Text);
                    CheckItem obj = new CheckItem();
                    obj.SetItemCode(dataGridView3.Rows[rowindexnumber].Cells[0].Value.ToString());
                    obj.SetItemQuantity(Convert.ToInt32(dataGridView3.Rows[rowindexnumber].Cells[5].Value.ToString()));
                    bool i = obj.updatequantity();
                    if (i == true)
                    {
                        CheckItem begin = new CheckItem();
                        begin.setItemCategory("");
                        dataGridView1.DataSource = begin.check();
                        int noofrows = dataGridView3.Rows.Count;
                      //  MessageBox.Show(noofrows.ToString());
                        if(noofrows==2)
                        {
                            button2.Enabled = false;
                        }
                    }
                    total = total - Convert.ToDouble(dataGridView3.Rows[rowindexnumber].Cells[7].Value);
                 
                    RowNumber--;
                    TotalPrice = Convert.ToDecimal(total);
                    label5.Text = total.ToString();
                    dataGridView3.Rows.RemoveAt(rowindexnumber);
                    dataGridView2.Rows.Clear();
                    textBox2.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("please select a row");
                }
            }
            else
            {
                MessageBox.Show("Please select a row ");
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindexnumber = e.RowIndex;
        }
    }
}
