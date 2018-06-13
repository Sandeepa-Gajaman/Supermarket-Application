using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketSystemDevLibrary;
using System.Data;

namespace Supermarket_Management_System
{
    class GeneralSales
    {
        private decimal TotalSales = 0;
        private int TotalOrders = 0, TotalUnitsSold = 0;
        private ReportDatabaseHelper ReportDatabaseHelper;
        
        public GeneralSales()
        {
            ReportDatabaseHelper = new ReportDatabaseHelper();
        }

        public bool BasicStatistics(string StartDate, string EndDate)
        {
            //TotalSales = ReportDatabaseHelper.GetTotalSales(StartDate, EndDate);    ////////////
            if((TotalOrders= ReportDatabaseHelper.GetTotalOrders(StartDate, EndDate))!= -999 && 
                (TotalUnitsSold= ReportDatabaseHelper.GetTotalUnitsSold(StartDate, EndDate))!= -999)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        public DataTable GetItemDemand(string Order)
        {
            string Option = "";
            switch (Order)
            {
                case "Ascending":
                    Option = "asc";
                    break;
                case "Descending":
                    Option = "desc";
                    break;
            }
            return ReportDatabaseHelper.GetItemDemand(Option);
        }

        public string GetStartDate(string Value)
        {
            DateTime CurrentDate = DateTime.Now;
            //DateTime ReferenceDate= new DateTime(0, 0, 0);
            string Temp;
            DateTime SubtractedDate= new DateTime();

            switch (Value)
            {
                case "1 Day":
                    SubtractedDate= CurrentDate.AddDays(-1);
                    break;
                case "1 Week":
                    SubtractedDate = CurrentDate.AddDays(-7);
                    break;
                case "1 Month":
                    SubtractedDate = CurrentDate.AddMonths(-1);
                    break;
                case "3 Months":
                    SubtractedDate = CurrentDate.AddMonths(-3);
                    break;
                case "6 Months":
                    SubtractedDate = CurrentDate.AddMonths(-6);
                    break;
                case "1 Year":
                    SubtractedDate = CurrentDate.AddYears(-1);
                    break;
                case "2 Years":
                    SubtractedDate = CurrentDate.AddYears(-1);
                    break;
            }
            Temp = SubtractedDate.ToString("yyyy-MM-dd");
            return Temp;
        }

        public string GetEndDate()
        { 
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        //Getter and setter functions.
        public decimal GetTotalSales()
        {
            return TotalSales;
        }

        public int GetTotalOrders()
        {
            return TotalOrders;
        }

        public int GetTotalUnitsSold()
        {
            return TotalUnitsSold;
        }
    }
}
