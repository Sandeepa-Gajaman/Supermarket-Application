namespace Supermarket_Management_System
{
    partial class FormInventory
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
            this.TabAddQuantity = new System.Windows.Forms.TabPage();
            this.ButtonAddQuantity = new System.Windows.Forms.Button();
            this.TextBoxAddQuantityQuantity = new System.Windows.Forms.TextBox();
            this.LabelAddQuantityItemQuantity = new System.Windows.Forms.Label();
            this.LabelAddQuantityItemCode = new System.Windows.Forms.Label();
            this.TextBoxAddQuantityItemCode = new System.Windows.Forms.TextBox();
            this.TabRemoveQuantity = new System.Windows.Forms.TabPage();
            this.ButttonRemoveQuantity = new System.Windows.Forms.Button();
            this.TextBoxRemoveQuantityQuantity = new System.Windows.Forms.TextBox();
            this.TextBoxRemoveQuantityItemCode = new System.Windows.Forms.TextBox();
            this.LabelRemoveQuantityQuantity = new System.Windows.Forms.Label();
            this.LabelRemoveQuantityItemCode = new System.Windows.Forms.Label();
            this.TabAddItem = new System.Windows.Forms.TabPage();
            this.ButtonAddItem = new System.Windows.Forms.Button();
            this.LabelAddItemItemUnitPrice = new System.Windows.Forms.Label();
            this.LabelAddItemItemVolume = new System.Windows.Forms.Label();
            this.LabelAddItemItemDescription = new System.Windows.Forms.Label();
            this.LabelAddItemItemName = new System.Windows.Forms.Label();
            this.LabelAddItemItemBrand = new System.Windows.Forms.Label();
            this.LabelAddItemItemCategory = new System.Windows.Forms.Label();
            this.TextBoxAddItemItemUnitPrice = new System.Windows.Forms.TextBox();
            this.TextBoxAddItemItemVolume = new System.Windows.Forms.TextBox();
            this.TextBoxAddItemItemDescription = new System.Windows.Forms.TextBox();
            this.TextBoxAddItemItemName = new System.Windows.Forms.TextBox();
            this.TextBoxAddItemItemBrand = new System.Windows.Forms.TextBox();
            this.TextBoxAddItemItemCategory = new System.Windows.Forms.TextBox();
            this.TabRemoveItem = new System.Windows.Forms.TabPage();
            this.DatagridViewSearchItem = new System.Windows.Forms.DataGridView();
            this.TextBoxSearchBar = new System.Windows.Forms.TextBox();
            this.ComboBoxItemFilter = new System.Windows.Forms.ComboBox();
            this.PanelSearchFilters = new System.Windows.Forms.Panel();
            this.ComboBoxSupplierFilter = new System.Windows.Forms.ComboBox();
            this.LabelSearchBar = new System.Windows.Forms.Label();
            this.LabelSupplierFilter = new System.Windows.Forms.Label();
            this.LabelItemFilter = new System.Windows.Forms.Label();
            this.LabelSelectSearchSection = new System.Windows.Forms.Label();
            this.ComboBoxFilterSection = new System.Windows.Forms.ComboBox();
            this.LabelRemoveItemItemCode = new System.Windows.Forms.Label();
            this.TextBoxRemoveItemItemCode = new System.Windows.Forms.TextBox();
            this.ButtonRemoveItem = new System.Windows.Forms.Button();
            this.TabControlMain.SuspendLayout();
            this.TabAddQuantity.SuspendLayout();
            this.TabRemoveQuantity.SuspendLayout();
            this.TabAddItem.SuspendLayout();
            this.TabRemoveItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridViewSearchItem)).BeginInit();
            this.PanelSearchFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabAddQuantity);
            this.TabControlMain.Controls.Add(this.TabRemoveQuantity);
            this.TabControlMain.Controls.Add(this.TabAddItem);
            this.TabControlMain.Controls.Add(this.TabRemoveItem);
            this.TabControlMain.Location = new System.Drawing.Point(12, 12);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(589, 716);
            this.TabControlMain.TabIndex = 0;
            // 
            // TabAddQuantity
            // 
            this.TabAddQuantity.Controls.Add(this.ButtonAddQuantity);
            this.TabAddQuantity.Controls.Add(this.TextBoxAddQuantityQuantity);
            this.TabAddQuantity.Controls.Add(this.LabelAddQuantityItemQuantity);
            this.TabAddQuantity.Controls.Add(this.LabelAddQuantityItemCode);
            this.TabAddQuantity.Controls.Add(this.TextBoxAddQuantityItemCode);
            this.TabAddQuantity.Location = new System.Drawing.Point(4, 29);
            this.TabAddQuantity.Name = "TabAddQuantity";
            this.TabAddQuantity.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddQuantity.Size = new System.Drawing.Size(581, 683);
            this.TabAddQuantity.TabIndex = 0;
            this.TabAddQuantity.Text = "Add Quantity";
            this.TabAddQuantity.UseVisualStyleBackColor = true;
            // 
            // ButtonAddQuantity
            // 
            this.ButtonAddQuantity.Location = new System.Drawing.Point(214, 406);
            this.ButtonAddQuantity.Name = "ButtonAddQuantity";
            this.ButtonAddQuantity.Size = new System.Drawing.Size(150, 50);
            this.ButtonAddQuantity.TabIndex = 4;
            this.ButtonAddQuantity.Text = "Add Quantity";
            this.ButtonAddQuantity.UseVisualStyleBackColor = true;
            this.ButtonAddQuantity.Click += new System.EventHandler(this.ButtonAddQuantity_Click);
            // 
            // TextBoxAddQuantityQuantity
            // 
            this.TextBoxAddQuantityQuantity.Location = new System.Drawing.Point(251, 214);
            this.TextBoxAddQuantityQuantity.Name = "TextBoxAddQuantityQuantity";
            this.TextBoxAddQuantityQuantity.Size = new System.Drawing.Size(212, 27);
            this.TextBoxAddQuantityQuantity.TabIndex = 3;
            this.TextBoxAddQuantityQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelAddQuantityItemQuantity
            // 
            this.LabelAddQuantityItemQuantity.AutoSize = true;
            this.LabelAddQuantityItemQuantity.Location = new System.Drawing.Point(62, 217);
            this.LabelAddQuantityItemQuantity.Name = "LabelAddQuantityItemQuantity";
            this.LabelAddQuantityItemQuantity.Size = new System.Drawing.Size(71, 20);
            this.LabelAddQuantityItemQuantity.TabIndex = 2;
            this.LabelAddQuantityItemQuantity.Text = "Quantity";
            // 
            // LabelAddQuantityItemCode
            // 
            this.LabelAddQuantityItemCode.AutoSize = true;
            this.LabelAddQuantityItemCode.Location = new System.Drawing.Point(62, 80);
            this.LabelAddQuantityItemCode.Name = "LabelAddQuantityItemCode";
            this.LabelAddQuantityItemCode.Size = new System.Drawing.Size(85, 20);
            this.LabelAddQuantityItemCode.TabIndex = 1;
            this.LabelAddQuantityItemCode.Text = "Item Code";
            // 
            // TextBoxAddQuantityItemCode
            // 
            this.TextBoxAddQuantityItemCode.Location = new System.Drawing.Point(251, 77);
            this.TextBoxAddQuantityItemCode.Name = "TextBoxAddQuantityItemCode";
            this.TextBoxAddQuantityItemCode.Size = new System.Drawing.Size(212, 27);
            this.TextBoxAddQuantityItemCode.TabIndex = 0;
            this.TextBoxAddQuantityItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TabRemoveQuantity
            // 
            this.TabRemoveQuantity.Controls.Add(this.ButttonRemoveQuantity);
            this.TabRemoveQuantity.Controls.Add(this.TextBoxRemoveQuantityQuantity);
            this.TabRemoveQuantity.Controls.Add(this.TextBoxRemoveQuantityItemCode);
            this.TabRemoveQuantity.Controls.Add(this.LabelRemoveQuantityQuantity);
            this.TabRemoveQuantity.Controls.Add(this.LabelRemoveQuantityItemCode);
            this.TabRemoveQuantity.Location = new System.Drawing.Point(4, 29);
            this.TabRemoveQuantity.Name = "TabRemoveQuantity";
            this.TabRemoveQuantity.Padding = new System.Windows.Forms.Padding(3);
            this.TabRemoveQuantity.Size = new System.Drawing.Size(581, 683);
            this.TabRemoveQuantity.TabIndex = 1;
            this.TabRemoveQuantity.Text = "Remove Quantity";
            this.TabRemoveQuantity.UseVisualStyleBackColor = true;
            // 
            // ButttonRemoveQuantity
            // 
            this.ButttonRemoveQuantity.Location = new System.Drawing.Point(213, 401);
            this.ButttonRemoveQuantity.Name = "ButttonRemoveQuantity";
            this.ButttonRemoveQuantity.Size = new System.Drawing.Size(150, 50);
            this.ButttonRemoveQuantity.TabIndex = 4;
            this.ButttonRemoveQuantity.Text = "Remove Quantity";
            this.ButttonRemoveQuantity.UseVisualStyleBackColor = true;
            this.ButttonRemoveQuantity.Click += new System.EventHandler(this.ButttonRemoveQuantity_Click);
            // 
            // TextBoxRemoveQuantityQuantity
            // 
            this.TextBoxRemoveQuantityQuantity.Location = new System.Drawing.Point(237, 214);
            this.TextBoxRemoveQuantityQuantity.Name = "TextBoxRemoveQuantityQuantity";
            this.TextBoxRemoveQuantityQuantity.Size = new System.Drawing.Size(212, 27);
            this.TextBoxRemoveQuantityQuantity.TabIndex = 3;
            this.TextBoxRemoveQuantityQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxRemoveQuantityItemCode
            // 
            this.TextBoxRemoveQuantityItemCode.Location = new System.Drawing.Point(237, 77);
            this.TextBoxRemoveQuantityItemCode.Name = "TextBoxRemoveQuantityItemCode";
            this.TextBoxRemoveQuantityItemCode.Size = new System.Drawing.Size(212, 27);
            this.TextBoxRemoveQuantityItemCode.TabIndex = 2;
            this.TextBoxRemoveQuantityItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelRemoveQuantityQuantity
            // 
            this.LabelRemoveQuantityQuantity.AutoSize = true;
            this.LabelRemoveQuantityQuantity.Location = new System.Drawing.Point(79, 217);
            this.LabelRemoveQuantityQuantity.Name = "LabelRemoveQuantityQuantity";
            this.LabelRemoveQuantityQuantity.Size = new System.Drawing.Size(108, 20);
            this.LabelRemoveQuantityQuantity.TabIndex = 1;
            this.LabelRemoveQuantityQuantity.Text = "Item Quantity";
            // 
            // LabelRemoveQuantityItemCode
            // 
            this.LabelRemoveQuantityItemCode.AutoSize = true;
            this.LabelRemoveQuantityItemCode.Location = new System.Drawing.Point(79, 80);
            this.LabelRemoveQuantityItemCode.Name = "LabelRemoveQuantityItemCode";
            this.LabelRemoveQuantityItemCode.Size = new System.Drawing.Size(85, 20);
            this.LabelRemoveQuantityItemCode.TabIndex = 0;
            this.LabelRemoveQuantityItemCode.Text = "Item Code";
            // 
            // TabAddItem
            // 
            this.TabAddItem.Controls.Add(this.ButtonAddItem);
            this.TabAddItem.Controls.Add(this.LabelAddItemItemUnitPrice);
            this.TabAddItem.Controls.Add(this.LabelAddItemItemVolume);
            this.TabAddItem.Controls.Add(this.LabelAddItemItemDescription);
            this.TabAddItem.Controls.Add(this.LabelAddItemItemName);
            this.TabAddItem.Controls.Add(this.LabelAddItemItemBrand);
            this.TabAddItem.Controls.Add(this.LabelAddItemItemCategory);
            this.TabAddItem.Controls.Add(this.TextBoxAddItemItemUnitPrice);
            this.TabAddItem.Controls.Add(this.TextBoxAddItemItemVolume);
            this.TabAddItem.Controls.Add(this.TextBoxAddItemItemDescription);
            this.TabAddItem.Controls.Add(this.TextBoxAddItemItemName);
            this.TabAddItem.Controls.Add(this.TextBoxAddItemItemBrand);
            this.TabAddItem.Controls.Add(this.TextBoxAddItemItemCategory);
            this.TabAddItem.Location = new System.Drawing.Point(4, 29);
            this.TabAddItem.Name = "TabAddItem";
            this.TabAddItem.Size = new System.Drawing.Size(581, 683);
            this.TabAddItem.TabIndex = 2;
            this.TabAddItem.Text = "Add Item";
            this.TabAddItem.UseVisualStyleBackColor = true;
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.Location = new System.Drawing.Point(198, 550);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(150, 50);
            this.ButtonAddItem.TabIndex = 12;
            this.ButtonAddItem.Text = "Add Item";
            this.ButtonAddItem.UseVisualStyleBackColor = true;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // LabelAddItemItemUnitPrice
            // 
            this.LabelAddItemItemUnitPrice.AutoSize = true;
            this.LabelAddItemItemUnitPrice.Location = new System.Drawing.Point(77, 397);
            this.LabelAddItemItemUnitPrice.Name = "LabelAddItemItemUnitPrice";
            this.LabelAddItemItemUnitPrice.Size = new System.Drawing.Size(120, 20);
            this.LabelAddItemItemUnitPrice.TabIndex = 11;
            this.LabelAddItemItemUnitPrice.Text = "Item Unit Price";
            // 
            // LabelAddItemItemVolume
            // 
            this.LabelAddItemItemVolume.AutoSize = true;
            this.LabelAddItemItemVolume.Location = new System.Drawing.Point(77, 331);
            this.LabelAddItemItemVolume.Name = "LabelAddItemItemVolume";
            this.LabelAddItemItemVolume.Size = new System.Drawing.Size(102, 20);
            this.LabelAddItemItemVolume.TabIndex = 10;
            this.LabelAddItemItemVolume.Text = "Item Volume";
            // 
            // LabelAddItemItemDescription
            // 
            this.LabelAddItemItemDescription.AutoSize = true;
            this.LabelAddItemItemDescription.Location = new System.Drawing.Point(77, 270);
            this.LabelAddItemItemDescription.Name = "LabelAddItemItemDescription";
            this.LabelAddItemItemDescription.Size = new System.Drawing.Size(132, 20);
            this.LabelAddItemItemDescription.TabIndex = 9;
            this.LabelAddItemItemDescription.Text = "Item Description";
            // 
            // LabelAddItemItemName
            // 
            this.LabelAddItemItemName.AutoSize = true;
            this.LabelAddItemItemName.Location = new System.Drawing.Point(77, 208);
            this.LabelAddItemItemName.Name = "LabelAddItemItemName";
            this.LabelAddItemItemName.Size = new System.Drawing.Size(90, 20);
            this.LabelAddItemItemName.TabIndex = 8;
            this.LabelAddItemItemName.Text = "Item Name";
            // 
            // LabelAddItemItemBrand
            // 
            this.LabelAddItemItemBrand.AutoSize = true;
            this.LabelAddItemItemBrand.Location = new System.Drawing.Point(77, 145);
            this.LabelAddItemItemBrand.Name = "LabelAddItemItemBrand";
            this.LabelAddItemItemBrand.Size = new System.Drawing.Size(91, 20);
            this.LabelAddItemItemBrand.TabIndex = 7;
            this.LabelAddItemItemBrand.Text = "Item Brand";
            // 
            // LabelAddItemItemCategory
            // 
            this.LabelAddItemItemCategory.AutoSize = true;
            this.LabelAddItemItemCategory.Location = new System.Drawing.Point(77, 80);
            this.LabelAddItemItemCategory.Name = "LabelAddItemItemCategory";
            this.LabelAddItemItemCategory.Size = new System.Drawing.Size(113, 20);
            this.LabelAddItemItemCategory.TabIndex = 6;
            this.LabelAddItemItemCategory.Text = "Item Category";
            // 
            // TextBoxAddItemItemUnitPrice
            // 
            this.TextBoxAddItemItemUnitPrice.Location = new System.Drawing.Point(285, 394);
            this.TextBoxAddItemItemUnitPrice.Name = "TextBoxAddItemItemUnitPrice";
            this.TextBoxAddItemItemUnitPrice.Size = new System.Drawing.Size(212, 27);
            this.TextBoxAddItemItemUnitPrice.TabIndex = 5;
            // 
            // TextBoxAddItemItemVolume
            // 
            this.TextBoxAddItemItemVolume.Location = new System.Drawing.Point(285, 328);
            this.TextBoxAddItemItemVolume.Name = "TextBoxAddItemItemVolume";
            this.TextBoxAddItemItemVolume.Size = new System.Drawing.Size(212, 27);
            this.TextBoxAddItemItemVolume.TabIndex = 4;
            // 
            // TextBoxAddItemItemDescription
            // 
            this.TextBoxAddItemItemDescription.Location = new System.Drawing.Point(285, 267);
            this.TextBoxAddItemItemDescription.Name = "TextBoxAddItemItemDescription";
            this.TextBoxAddItemItemDescription.Size = new System.Drawing.Size(212, 27);
            this.TextBoxAddItemItemDescription.TabIndex = 3;
            // 
            // TextBoxAddItemItemName
            // 
            this.TextBoxAddItemItemName.Location = new System.Drawing.Point(285, 205);
            this.TextBoxAddItemItemName.Name = "TextBoxAddItemItemName";
            this.TextBoxAddItemItemName.Size = new System.Drawing.Size(212, 27);
            this.TextBoxAddItemItemName.TabIndex = 2;
            // 
            // TextBoxAddItemItemBrand
            // 
            this.TextBoxAddItemItemBrand.Location = new System.Drawing.Point(285, 142);
            this.TextBoxAddItemItemBrand.Name = "TextBoxAddItemItemBrand";
            this.TextBoxAddItemItemBrand.Size = new System.Drawing.Size(212, 27);
            this.TextBoxAddItemItemBrand.TabIndex = 1;
            // 
            // TextBoxAddItemItemCategory
            // 
            this.TextBoxAddItemItemCategory.Location = new System.Drawing.Point(285, 77);
            this.TextBoxAddItemItemCategory.Name = "TextBoxAddItemItemCategory";
            this.TextBoxAddItemItemCategory.Size = new System.Drawing.Size(212, 27);
            this.TextBoxAddItemItemCategory.TabIndex = 0;
            // 
            // TabRemoveItem
            // 
            this.TabRemoveItem.Controls.Add(this.ButtonRemoveItem);
            this.TabRemoveItem.Controls.Add(this.TextBoxRemoveItemItemCode);
            this.TabRemoveItem.Controls.Add(this.LabelRemoveItemItemCode);
            this.TabRemoveItem.Location = new System.Drawing.Point(4, 29);
            this.TabRemoveItem.Name = "TabRemoveItem";
            this.TabRemoveItem.Size = new System.Drawing.Size(581, 683);
            this.TabRemoveItem.TabIndex = 3;
            this.TabRemoveItem.Text = "Remove Item";
            this.TabRemoveItem.UseVisualStyleBackColor = true;
            // 
            // DatagridViewSearchItem
            // 
            this.DatagridViewSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridViewSearchItem.Location = new System.Drawing.Point(635, 320);
            this.DatagridViewSearchItem.Name = "DatagridViewSearchItem";
            this.DatagridViewSearchItem.RowTemplate.Height = 24;
            this.DatagridViewSearchItem.Size = new System.Drawing.Size(835, 408);
            this.DatagridViewSearchItem.TabIndex = 0;
            // 
            // TextBoxSearchBar
            // 
            this.TextBoxSearchBar.Location = new System.Drawing.Point(278, 243);
            this.TextBoxSearchBar.Name = "TextBoxSearchBar";
            this.TextBoxSearchBar.Size = new System.Drawing.Size(212, 27);
            this.TextBoxSearchBar.TabIndex = 1;
            this.TextBoxSearchBar.TextChanged += new System.EventHandler(this.TextBoxSearchBar_TextChanged);
            this.TextBoxSearchBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxSearchBar_KeyUp);
            // 
            // ComboBoxItemFilter
            // 
            this.ComboBoxItemFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxItemFilter.FormattingEnabled = true;
            this.ComboBoxItemFilter.Items.AddRange(new object[] {
            "Item Name",
            "Item Category",
            "Item Code",
            "Item Brand"});
            this.ComboBoxItemFilter.Location = new System.Drawing.Point(278, 106);
            this.ComboBoxItemFilter.Name = "ComboBoxItemFilter";
            this.ComboBoxItemFilter.Size = new System.Drawing.Size(212, 28);
            this.ComboBoxItemFilter.TabIndex = 2;
            this.ComboBoxItemFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItemFilter_SelectedIndexChanged);
            // 
            // PanelSearchFilters
            // 
            this.PanelSearchFilters.Controls.Add(this.ComboBoxSupplierFilter);
            this.PanelSearchFilters.Controls.Add(this.LabelSearchBar);
            this.PanelSearchFilters.Controls.Add(this.LabelSupplierFilter);
            this.PanelSearchFilters.Controls.Add(this.LabelItemFilter);
            this.PanelSearchFilters.Controls.Add(this.LabelSelectSearchSection);
            this.PanelSearchFilters.Controls.Add(this.ComboBoxFilterSection);
            this.PanelSearchFilters.Controls.Add(this.ComboBoxItemFilter);
            this.PanelSearchFilters.Controls.Add(this.TextBoxSearchBar);
            this.PanelSearchFilters.Location = new System.Drawing.Point(635, 12);
            this.PanelSearchFilters.Name = "PanelSearchFilters";
            this.PanelSearchFilters.Size = new System.Drawing.Size(835, 302);
            this.PanelSearchFilters.TabIndex = 3;
            // 
            // ComboBoxSupplierFilter
            // 
            this.ComboBoxSupplierFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSupplierFilter.FormattingEnabled = true;
            this.ComboBoxSupplierFilter.Items.AddRange(new object[] {
            "Supplier Name",
            "Supplier Code",
            "Supplier City",
            "Supplier Address"});
            this.ComboBoxSupplierFilter.Location = new System.Drawing.Point(278, 176);
            this.ComboBoxSupplierFilter.Name = "ComboBoxSupplierFilter";
            this.ComboBoxSupplierFilter.Size = new System.Drawing.Size(212, 28);
            this.ComboBoxSupplierFilter.TabIndex = 8;
            this.ComboBoxSupplierFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSupplierFilter_SelectedIndexChanged);
            // 
            // LabelSearchBar
            // 
            this.LabelSearchBar.AutoSize = true;
            this.LabelSearchBar.Location = new System.Drawing.Point(58, 246);
            this.LabelSearchBar.Name = "LabelSearchBar";
            this.LabelSearchBar.Size = new System.Drawing.Size(106, 20);
            this.LabelSearchBar.TabIndex = 7;
            this.LabelSearchBar.Text = "Search Term";
            // 
            // LabelSupplierFilter
            // 
            this.LabelSupplierFilter.AutoSize = true;
            this.LabelSupplierFilter.Location = new System.Drawing.Point(58, 179);
            this.LabelSupplierFilter.Name = "LabelSupplierFilter";
            this.LabelSupplierFilter.Size = new System.Drawing.Size(153, 20);
            this.LabelSupplierFilter.TabIndex = 6;
            this.LabelSupplierFilter.Text = "Search Supplier By";
            // 
            // LabelItemFilter
            // 
            this.LabelItemFilter.AutoSize = true;
            this.LabelItemFilter.Location = new System.Drawing.Point(58, 109);
            this.LabelItemFilter.Name = "LabelItemFilter";
            this.LabelItemFilter.Size = new System.Drawing.Size(124, 20);
            this.LabelItemFilter.TabIndex = 5;
            this.LabelItemFilter.Text = "Search Item By";
            // 
            // LabelSelectSearchSection
            // 
            this.LabelSelectSearchSection.AutoSize = true;
            this.LabelSelectSearchSection.Location = new System.Drawing.Point(58, 32);
            this.LabelSelectSearchSection.Name = "LabelSelectSearchSection";
            this.LabelSelectSearchSection.Size = new System.Drawing.Size(123, 20);
            this.LabelSelectSearchSection.TabIndex = 4;
            this.LabelSelectSearchSection.Text = "Search Section";
            // 
            // ComboBoxFilterSection
            // 
            this.ComboBoxFilterSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterSection.FormattingEnabled = true;
            this.ComboBoxFilterSection.Items.AddRange(new object[] {
            "Item",
            "Supplier"});
            this.ComboBoxFilterSection.Location = new System.Drawing.Point(278, 29);
            this.ComboBoxFilterSection.Name = "ComboBoxFilterSection";
            this.ComboBoxFilterSection.Size = new System.Drawing.Size(212, 28);
            this.ComboBoxFilterSection.TabIndex = 3;
            this.ComboBoxFilterSection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterSection_SelectedIndexChanged);
            // 
            // LabelRemoveItemItemCode
            // 
            this.LabelRemoveItemItemCode.AutoSize = true;
            this.LabelRemoveItemItemCode.Location = new System.Drawing.Point(81, 80);
            this.LabelRemoveItemItemCode.Name = "LabelRemoveItemItemCode";
            this.LabelRemoveItemItemCode.Size = new System.Drawing.Size(85, 20);
            this.LabelRemoveItemItemCode.TabIndex = 0;
            this.LabelRemoveItemItemCode.Text = "Item Code";
            // 
            // TextBoxRemoveItemItemCode
            // 
            this.TextBoxRemoveItemItemCode.Location = new System.Drawing.Point(293, 77);
            this.TextBoxRemoveItemItemCode.Name = "TextBoxRemoveItemItemCode";
            this.TextBoxRemoveItemItemCode.Size = new System.Drawing.Size(212, 27);
            this.TextBoxRemoveItemItemCode.TabIndex = 2;
            this.TextBoxRemoveItemItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonRemoveItem
            // 
            this.ButtonRemoveItem.Location = new System.Drawing.Point(212, 455);
            this.ButtonRemoveItem.Name = "ButtonRemoveItem";
            this.ButtonRemoveItem.Size = new System.Drawing.Size(150, 50);
            this.ButtonRemoveItem.TabIndex = 4;
            this.ButtonRemoveItem.Text = "Remove Item";
            this.ButtonRemoveItem.UseVisualStyleBackColor = true;
            this.ButtonRemoveItem.Click += new System.EventHandler(this.ButtonRemoveItem_Click);
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 740);
            this.Controls.Add(this.PanelSearchFilters);
            this.Controls.Add(this.DatagridViewSearchItem);
            this.Controls.Add(this.TabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.TabControlMain.ResumeLayout(false);
            this.TabAddQuantity.ResumeLayout(false);
            this.TabAddQuantity.PerformLayout();
            this.TabRemoveQuantity.ResumeLayout(false);
            this.TabRemoveQuantity.PerformLayout();
            this.TabAddItem.ResumeLayout(false);
            this.TabAddItem.PerformLayout();
            this.TabRemoveItem.ResumeLayout(false);
            this.TabRemoveItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridViewSearchItem)).EndInit();
            this.PanelSearchFilters.ResumeLayout(false);
            this.PanelSearchFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabAddQuantity;
        private System.Windows.Forms.TabPage TabRemoveQuantity;
        private System.Windows.Forms.TabPage TabAddItem;
        private System.Windows.Forms.TabPage TabRemoveItem;
        private System.Windows.Forms.DataGridView DatagridViewSearchItem;
        private System.Windows.Forms.TextBox TextBoxSearchBar;
        private System.Windows.Forms.ComboBox ComboBoxItemFilter;
        private System.Windows.Forms.Panel PanelSearchFilters;
        private System.Windows.Forms.ComboBox ComboBoxFilterSection;
        private System.Windows.Forms.Label LabelSupplierFilter;
        private System.Windows.Forms.Label LabelItemFilter;
        private System.Windows.Forms.Label LabelSelectSearchSection;
        private System.Windows.Forms.ComboBox ComboBoxSupplierFilter;
        private System.Windows.Forms.Label LabelSearchBar;
        private System.Windows.Forms.Button ButtonAddQuantity;
        private System.Windows.Forms.TextBox TextBoxAddQuantityQuantity;
        private System.Windows.Forms.Label LabelAddQuantityItemQuantity;
        private System.Windows.Forms.Label LabelAddQuantityItemCode;
        private System.Windows.Forms.TextBox TextBoxAddQuantityItemCode;
        private System.Windows.Forms.Button ButttonRemoveQuantity;
        private System.Windows.Forms.TextBox TextBoxRemoveQuantityQuantity;
        private System.Windows.Forms.TextBox TextBoxRemoveQuantityItemCode;
        private System.Windows.Forms.Label LabelRemoveQuantityQuantity;
        private System.Windows.Forms.Label LabelRemoveQuantityItemCode;
        private System.Windows.Forms.Button ButtonAddItem;
        private System.Windows.Forms.Label LabelAddItemItemUnitPrice;
        private System.Windows.Forms.Label LabelAddItemItemVolume;
        private System.Windows.Forms.Label LabelAddItemItemDescription;
        private System.Windows.Forms.Label LabelAddItemItemName;
        private System.Windows.Forms.Label LabelAddItemItemBrand;
        private System.Windows.Forms.Label LabelAddItemItemCategory;
        private System.Windows.Forms.TextBox TextBoxAddItemItemUnitPrice;
        private System.Windows.Forms.TextBox TextBoxAddItemItemVolume;
        private System.Windows.Forms.TextBox TextBoxAddItemItemDescription;
        private System.Windows.Forms.TextBox TextBoxAddItemItemName;
        private System.Windows.Forms.TextBox TextBoxAddItemItemBrand;
        private System.Windows.Forms.TextBox TextBoxAddItemItemCategory;
        private System.Windows.Forms.Label LabelRemoveItemItemCode;
        private System.Windows.Forms.Button ButtonRemoveItem;
        private System.Windows.Forms.TextBox TextBoxRemoveItemItemCode;
    }
}