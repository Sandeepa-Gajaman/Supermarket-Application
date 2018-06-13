namespace Supermarket_Management_System
{
    partial class FormManagementReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabGeneralSales = new System.Windows.Forms.TabPage();
            this.PanelGeneralSales3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBoxGeneralSalesDemandSorter = new System.Windows.Forms.ComboBox();
            this.LabelItemsBasedOnDemand = new System.Windows.Forms.Label();
            this.DataGridViewgeneralSales = new System.Windows.Forms.DataGridView();
            this.PanelGeneralSales2 = new System.Windows.Forms.Panel();
            this.LabelTotalUnitsSoldValue = new System.Windows.Forms.Label();
            this.LabelTotalOrdersValue = new System.Windows.Forms.Label();
            this.LabelTotalSalesValue = new System.Windows.Forms.Label();
            this.LabelTotalUnitsSold = new System.Windows.Forms.Label();
            this.LabelTotalSales = new System.Windows.Forms.Label();
            this.LabelTotalOrders = new System.Windows.Forms.Label();
            this.PanelGeneralSales1 = new System.Windows.Forms.Panel();
            this.ButtonGeneralSalesShow1 = new System.Windows.Forms.Button();
            this.LabelPeriod = new System.Windows.Forms.Label();
            this.ComboBoxGeneralSalesPeriod = new System.Windows.Forms.ComboBox();
            this.TabItemSales = new System.Windows.Forms.TabPage();
            this.TabControlMain.SuspendLayout();
            this.TabGeneralSales.SuspendLayout();
            this.PanelGeneralSales3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewgeneralSales)).BeginInit();
            this.PanelGeneralSales2.SuspendLayout();
            this.PanelGeneralSales1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabGeneralSales);
            this.TabControlMain.Controls.Add(this.TabItemSales);
            this.TabControlMain.Location = new System.Drawing.Point(3, 3);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(1113, 547);
            this.TabControlMain.TabIndex = 0;
            // 
            // TabGeneralSales
            // 
            this.TabGeneralSales.Controls.Add(this.PanelGeneralSales3);
            this.TabGeneralSales.Controls.Add(this.PanelGeneralSales2);
            this.TabGeneralSales.Controls.Add(this.PanelGeneralSales1);
            this.TabGeneralSales.Location = new System.Drawing.Point(4, 29);
            this.TabGeneralSales.Name = "TabGeneralSales";
            this.TabGeneralSales.Padding = new System.Windows.Forms.Padding(3);
            this.TabGeneralSales.Size = new System.Drawing.Size(1105, 514);
            this.TabGeneralSales.TabIndex = 0;
            this.TabGeneralSales.Text = "General Sales";
            this.TabGeneralSales.UseVisualStyleBackColor = true;
            // 
            // PanelGeneralSales3
            // 
            this.PanelGeneralSales3.BackColor = System.Drawing.Color.LightGray;
            this.PanelGeneralSales3.Controls.Add(this.button1);
            this.PanelGeneralSales3.Controls.Add(this.ComboBoxGeneralSalesDemandSorter);
            this.PanelGeneralSales3.Controls.Add(this.LabelItemsBasedOnDemand);
            this.PanelGeneralSales3.Controls.Add(this.DataGridViewgeneralSales);
            this.PanelGeneralSales3.Location = new System.Drawing.Point(463, 0);
            this.PanelGeneralSales3.Name = "PanelGeneralSales3";
            this.PanelGeneralSales3.Size = new System.Drawing.Size(642, 514);
            this.PanelGeneralSales3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBoxGeneralSalesDemandSorter
            // 
            this.ComboBoxGeneralSalesDemandSorter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGeneralSalesDemandSorter.FormattingEnabled = true;
            this.ComboBoxGeneralSalesDemandSorter.Items.AddRange(new object[] {
            "Descending",
            "Ascending"});
            this.ComboBoxGeneralSalesDemandSorter.Location = new System.Drawing.Point(361, 40);
            this.ComboBoxGeneralSalesDemandSorter.Name = "ComboBoxGeneralSalesDemandSorter";
            this.ComboBoxGeneralSalesDemandSorter.Size = new System.Drawing.Size(180, 28);
            this.ComboBoxGeneralSalesDemandSorter.TabIndex = 2;
            this.ComboBoxGeneralSalesDemandSorter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGeneralSalesDemandSorter_SelectedIndexChanged);
            // 
            // LabelItemsBasedOnDemand
            // 
            this.LabelItemsBasedOnDemand.AutoSize = true;
            this.LabelItemsBasedOnDemand.Location = new System.Drawing.Point(69, 43);
            this.LabelItemsBasedOnDemand.Name = "LabelItemsBasedOnDemand";
            this.LabelItemsBasedOnDemand.Size = new System.Drawing.Size(194, 20);
            this.LabelItemsBasedOnDemand.TabIndex = 1;
            this.LabelItemsBasedOnDemand.Text = "Items Based on Demand";
            // 
            // DataGridViewgeneralSales
            // 
            this.DataGridViewgeneralSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewgeneralSales.Location = new System.Drawing.Point(0, 176);
            this.DataGridViewgeneralSales.Name = "DataGridViewgeneralSales";
            this.DataGridViewgeneralSales.RowTemplate.Height = 24;
            this.DataGridViewgeneralSales.Size = new System.Drawing.Size(642, 338);
            this.DataGridViewgeneralSales.TabIndex = 0;
            // 
            // PanelGeneralSales2
            // 
            this.PanelGeneralSales2.BackColor = System.Drawing.Color.LightGray;
            this.PanelGeneralSales2.Controls.Add(this.LabelTotalUnitsSoldValue);
            this.PanelGeneralSales2.Controls.Add(this.LabelTotalOrdersValue);
            this.PanelGeneralSales2.Controls.Add(this.LabelTotalSalesValue);
            this.PanelGeneralSales2.Controls.Add(this.LabelTotalUnitsSold);
            this.PanelGeneralSales2.Controls.Add(this.LabelTotalSales);
            this.PanelGeneralSales2.Controls.Add(this.LabelTotalOrders);
            this.PanelGeneralSales2.Location = new System.Drawing.Point(3, 176);
            this.PanelGeneralSales2.Name = "PanelGeneralSales2";
            this.PanelGeneralSales2.Size = new System.Drawing.Size(457, 338);
            this.PanelGeneralSales2.TabIndex = 9;
            // 
            // LabelTotalUnitsSoldValue
            // 
            this.LabelTotalUnitsSoldValue.AutoSize = true;
            this.LabelTotalUnitsSoldValue.Location = new System.Drawing.Point(195, 155);
            this.LabelTotalUnitsSoldValue.Name = "LabelTotalUnitsSoldValue";
            this.LabelTotalUnitsSoldValue.Size = new System.Drawing.Size(51, 20);
            this.LabelTotalUnitsSoldValue.TabIndex = 11;
            this.LabelTotalUnitsSoldValue.Text = "Value";
            // 
            // LabelTotalOrdersValue
            // 
            this.LabelTotalOrdersValue.AutoSize = true;
            this.LabelTotalOrdersValue.Location = new System.Drawing.Point(195, 97);
            this.LabelTotalOrdersValue.Name = "LabelTotalOrdersValue";
            this.LabelTotalOrdersValue.Size = new System.Drawing.Size(51, 20);
            this.LabelTotalOrdersValue.TabIndex = 10;
            this.LabelTotalOrdersValue.Text = "Value";
            // 
            // LabelTotalSalesValue
            // 
            this.LabelTotalSalesValue.AutoSize = true;
            this.LabelTotalSalesValue.Location = new System.Drawing.Point(195, 38);
            this.LabelTotalSalesValue.Name = "LabelTotalSalesValue";
            this.LabelTotalSalesValue.Size = new System.Drawing.Size(51, 20);
            this.LabelTotalSalesValue.TabIndex = 9;
            this.LabelTotalSalesValue.Text = "Value";
            // 
            // LabelTotalUnitsSold
            // 
            this.LabelTotalUnitsSold.AutoSize = true;
            this.LabelTotalUnitsSold.Location = new System.Drawing.Point(36, 155);
            this.LabelTotalUnitsSold.Name = "LabelTotalUnitsSold";
            this.LabelTotalUnitsSold.Size = new System.Drawing.Size(128, 20);
            this.LabelTotalUnitsSold.TabIndex = 4;
            this.LabelTotalUnitsSold.Text = "Total Units Sold";
            // 
            // LabelTotalSales
            // 
            this.LabelTotalSales.AutoSize = true;
            this.LabelTotalSales.Location = new System.Drawing.Point(36, 38);
            this.LabelTotalSales.Name = "LabelTotalSales";
            this.LabelTotalSales.Size = new System.Drawing.Size(93, 20);
            this.LabelTotalSales.TabIndex = 3;
            this.LabelTotalSales.Text = "Total Sales";
            // 
            // LabelTotalOrders
            // 
            this.LabelTotalOrders.AutoSize = true;
            this.LabelTotalOrders.Location = new System.Drawing.Point(36, 97);
            this.LabelTotalOrders.Name = "LabelTotalOrders";
            this.LabelTotalOrders.Size = new System.Drawing.Size(103, 20);
            this.LabelTotalOrders.TabIndex = 5;
            this.LabelTotalOrders.Text = "Total Orders";
            // 
            // PanelGeneralSales1
            // 
            this.PanelGeneralSales1.BackColor = System.Drawing.Color.LightGray;
            this.PanelGeneralSales1.Controls.Add(this.ButtonGeneralSalesShow1);
            this.PanelGeneralSales1.Controls.Add(this.LabelPeriod);
            this.PanelGeneralSales1.Controls.Add(this.ComboBoxGeneralSalesPeriod);
            this.PanelGeneralSales1.Location = new System.Drawing.Point(3, 0);
            this.PanelGeneralSales1.Name = "PanelGeneralSales1";
            this.PanelGeneralSales1.Size = new System.Drawing.Size(457, 177);
            this.PanelGeneralSales1.TabIndex = 2;
            // 
            // ButtonGeneralSalesShow1
            // 
            this.ButtonGeneralSalesShow1.Location = new System.Drawing.Point(169, 106);
            this.ButtonGeneralSalesShow1.Name = "ButtonGeneralSalesShow1";
            this.ButtonGeneralSalesShow1.Size = new System.Drawing.Size(120, 40);
            this.ButtonGeneralSalesShow1.TabIndex = 2;
            this.ButtonGeneralSalesShow1.Text = "Show";
            this.ButtonGeneralSalesShow1.UseVisualStyleBackColor = true;
            this.ButtonGeneralSalesShow1.Click += new System.EventHandler(this.ButtonGeneralSalesShow1_Click);
            // 
            // LabelPeriod
            // 
            this.LabelPeriod.AutoSize = true;
            this.LabelPeriod.Location = new System.Drawing.Point(36, 43);
            this.LabelPeriod.Name = "LabelPeriod";
            this.LabelPeriod.Size = new System.Drawing.Size(57, 20);
            this.LabelPeriod.TabIndex = 0;
            this.LabelPeriod.Text = "Period";
            // 
            // ComboBoxGeneralSalesPeriod
            // 
            this.ComboBoxGeneralSalesPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGeneralSalesPeriod.FormattingEnabled = true;
            this.ComboBoxGeneralSalesPeriod.Items.AddRange(new object[] {
            "1 Month",
            "3 Months",
            "6 Months",
            "1 Year",
            "2 Years",
            "\t\t\t"});
            this.ComboBoxGeneralSalesPeriod.Location = new System.Drawing.Point(169, 40);
            this.ComboBoxGeneralSalesPeriod.Name = "ComboBoxGeneralSalesPeriod";
            this.ComboBoxGeneralSalesPeriod.Size = new System.Drawing.Size(180, 28);
            this.ComboBoxGeneralSalesPeriod.TabIndex = 1;
            this.ComboBoxGeneralSalesPeriod.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGeneralSalesPeriod_SelectedIndexChanged);
            // 
            // TabItemSales
            // 
            this.TabItemSales.Location = new System.Drawing.Point(4, 29);
            this.TabItemSales.Name = "TabItemSales";
            this.TabItemSales.Padding = new System.Windows.Forms.Padding(3);
            this.TabItemSales.Size = new System.Drawing.Size(1105, 514);
            this.TabItemSales.TabIndex = 1;
            this.TabItemSales.Text = "Item Sales";
            this.TabItemSales.UseVisualStyleBackColor = true;
            // 
            // FormManagementReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 553);
            this.Controls.Add(this.TabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManagementReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Reports";
            this.TabControlMain.ResumeLayout(false);
            this.TabGeneralSales.ResumeLayout(false);
            this.PanelGeneralSales3.ResumeLayout(false);
            this.PanelGeneralSales3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewgeneralSales)).EndInit();
            this.PanelGeneralSales2.ResumeLayout(false);
            this.PanelGeneralSales2.PerformLayout();
            this.PanelGeneralSales1.ResumeLayout(false);
            this.PanelGeneralSales1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabGeneralSales;
        private System.Windows.Forms.Panel PanelGeneralSales2;
        private System.Windows.Forms.Label LabelTotalUnitsSold;
        private System.Windows.Forms.Label LabelTotalSales;
        private System.Windows.Forms.Label LabelTotalOrders;
        private System.Windows.Forms.Panel PanelGeneralSales1;
        private System.Windows.Forms.Label LabelPeriod;
        private System.Windows.Forms.ComboBox ComboBoxGeneralSalesPeriod;
        private System.Windows.Forms.TabPage TabItemSales;
        private System.Windows.Forms.Label LabelTotalUnitsSoldValue;
        private System.Windows.Forms.Label LabelTotalOrdersValue;
        private System.Windows.Forms.Label LabelTotalSalesValue;
        private System.Windows.Forms.Panel PanelGeneralSales3;
        private System.Windows.Forms.Button ButtonGeneralSalesShow1;
        private System.Windows.Forms.ComboBox ComboBoxGeneralSalesDemandSorter;
        private System.Windows.Forms.Label LabelItemsBasedOnDemand;
        private System.Windows.Forms.DataGridView DataGridViewgeneralSales;
        private System.Windows.Forms.Button button1;
    }
}