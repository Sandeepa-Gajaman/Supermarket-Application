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
    public partial class FormManagementReports : Form
    {
        public FormManagementReports()
        {
            InitializeComponent();
            ComboBoxGeneralSalesPeriod.SelectedItem = "1 Month";
            ComboBoxGeneralSalesDemandSorter.SelectedItem = "Ascending";
        }

        private void ButtonGeneralSalesShow1_Click(object sender, EventArgs e)
        {
            GeneralSales GeneralSales = new GeneralSales();
  
            if(GeneralSales.BasicStatistics(GeneralSales.GetStartDate(ComboBoxGeneralSalesPeriod.SelectedItem.ToString()),
                GeneralSales.GetEndDate())== true)
            {
                //LabelTotalSalesValue.Text = GeneralSales.GetTotalSales().ToString();    /////////
                LabelTotalOrdersValue.Text = GeneralSales.GetTotalOrders().ToString();
                LabelTotalUnitsSoldValue.Text = GeneralSales.GetTotalUnitsSold().ToString();
            }
            else
            {
                //Error handling not required.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralSales GeneralSales = new GeneralSales();
            switch (ComboBoxGeneralSalesDemandSorter.SelectedItem.ToString())
            {
                case "Ascending":
                    DataGridViewgeneralSales.DataSource= GeneralSales.GetItemDemand("Ascending");
                    break;
                case "Descending":
                    DataGridViewgeneralSales.DataSource= GeneralSales.GetItemDemand("Descending");
                    break;     
            }
        }

        private void ComboBoxGeneralSalesDemandSorter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewgeneralSales.DataSource = null;
            //button1_Click(button1, null);
        }

        private void ComboBoxGeneralSalesPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LabelTotalSalesValue.Text = "";                                 //////////////
            LabelTotalOrdersValue.Text = "";
            LabelTotalUnitsSoldValue.Text = "";
            //ButtonGeneralSalesShow1_Click(ButtonGeneralSalesShow1, null);
        }
    }
}
