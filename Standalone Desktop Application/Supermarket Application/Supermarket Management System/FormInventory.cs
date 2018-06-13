using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketSystemDevLibrary;



namespace Supermarket_Management_System
{
    public partial class FormInventory : Form
    {
        ItemDatabaseHelper DatabaseHelper = new ItemDatabaseHelper();
        SupplierDatabaseHelper SupplierDatabaseHelper = new SupplierDatabaseHelper();

        public FormInventory()
        {
            InitializeComponent();
            ComboBoxFilterSection.SelectedItem = "Item";
            ComboBoxSupplierFilter.Enabled = false;
            ComboBoxItemFilter.Enabled = true;
            ComboBoxItemFilter.SelectedItem = "Item Name";
            ComboBoxSupplierFilter.SelectedItem = "Supplier Name";
        }

        private void TextBoxSearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(TextBoxSearchBar.Text)== false)
                {
                    if(ComboBoxFilterSection.SelectedItem.ToString()== "Item")
                    {
                        switch (ComboBoxItemFilter.SelectedItem.ToString())
                        {
                            case "Item Name":
                                DatagridViewSearchItem.DataSource = DatabaseHelper.SelectItemsByName(TextBoxSearchBar.Text);
                                break;
                            case "Item Category":
                                DatagridViewSearchItem.DataSource = DatabaseHelper.SelectItemsByCategory(TextBoxSearchBar.Text);
                                break;
                            case "Item Code":
                                DatagridViewSearchItem.DataSource = DatabaseHelper.SelectItemsByCode(Convert.ToInt32(TextBoxSearchBar.Text));
                                break;
                            case "Item Brand":
                                DatagridViewSearchItem.DataSource = DatabaseHelper.SelectItemsByBrand(TextBoxSearchBar.Text);
                                break;
                        }
                    }
                    else if(ComboBoxFilterSection.SelectedItem.ToString()== "Supplier")
                    {
                        switch (ComboBoxSupplierFilter.SelectedItem.ToString())
                        {
                            case "Supplier Name":
                                DatagridViewSearchItem.DataSource = SupplierDatabaseHelper.SelectSupplierByName(TextBoxSearchBar.Text);
                                break;
                            case "Supplier Code":
                                DatagridViewSearchItem.DataSource = SupplierDatabaseHelper.SelectSupplierByCode(Convert.ToInt32(TextBoxSearchBar.Text));
                                break;
                            case "Supplier City":
                                DatagridViewSearchItem.DataSource = SupplierDatabaseHelper.SelectSupplierByCity(TextBoxSearchBar.Text);
                                break;
                            case "Supplier Address":
                                DatagridViewSearchItem.DataSource = SupplierDatabaseHelper.SelectSupplierByAddress(TextBoxSearchBar.Text);
                                break;
                        }
                    }
                }
                else
                {
                    DatagridViewSearchItem.DataSource = null;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter correct input!", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Error, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxFilterSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatagridViewSearchItem.DataSource = null;
            TextBoxSearchBar.Text = "";
            switch (ComboBoxFilterSection.SelectedItem.ToString())
            {
                case "Item":
                    ComboBoxSupplierFilter.Enabled = false;
                    ComboBoxItemFilter.Enabled = true;
                    break;
                case "Supplier":
                    ComboBoxItemFilter.Enabled = false;
                    ComboBoxSupplierFilter.Enabled = true;
                    break;
            }
        }

        private void ComboBoxSupplierFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatagridViewSearchItem.DataSource = null;
            TextBoxSearchBar.Text = "";
        }

        private void ComboBoxItemFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatagridViewSearchItem.DataSource = null;
            TextBoxSearchBar.Text = "";
        }

        private void TextBoxSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAddQuantity_Click(object sender, EventArgs e)
        {
            Item Item = new Item();
            try
            {
                bool Result= Item.IncreaseQuantity(Convert.ToInt32(TextBoxAddQuantityItemCode.Text), Convert.ToInt32(TextBoxAddQuantityQuantity.Text));
                if (Result)
                {
                    TextBoxAddQuantityItemCode.Clear(); TextBoxAddQuantityQuantity.Clear();
                    MessageBox.Show("Quantity has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBoxSearchBar_KeyUp(TextBoxSearchBar, null);
                }
                else
                {
                    MessageBox.Show("Couldn't add quantity! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter correct input!", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Error, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButttonRemoveQuantity_Click(object sender, EventArgs e)
        {
            Item Item = new Item();
            try
            {
                bool result= Item.DecreaseQuantity(Convert.ToInt32(TextBoxRemoveQuantityItemCode.Text), Convert.ToInt32(TextBoxRemoveQuantityQuantity.Text));
                if (result)
                {
                    TextBoxRemoveQuantityItemCode.Clear(); TextBoxRemoveQuantityQuantity.Clear();
                    MessageBox.Show("Quantity has been successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBoxSearchBar_KeyUp(TextBoxSearchBar, null);
                }
                else
                {
                    MessageBox.Show("Couldn't remove quantity! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter correct input!", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Error, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            Item Item = new Item();
            try
            {
                Item.SetItemCategory(TextBoxAddItemItemCategory.Text);
                Item.SetItemBrand(TextBoxAddItemItemBrand.Text);
                Item.SetItemName(TextBoxAddItemItemName.Text);
                Item.SetItemDescription(TextBoxAddItemItemDescription.Text);
                Item.SetItemVolume(TextBoxAddItemItemVolume.Text);
                Item.SetItemUnitPrice(Convert.ToDecimal(TextBoxAddItemItemUnitPrice.Text));
                bool Result= Item.AddItem();
                if (Result)
                {
                    MessageBox.Show("Item has been successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Couldn't add item! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter correct input!", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't add item. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Resets form elements.
        /// </summary>
        /// <param name="Form">The form object to be reset</param>
        private void ResetForm(Form Form)
        {
            foreach (Control X in Form.Controls)
            {
                if (X is TextBox) { ((TextBox)X).Clear(); }
                //if (X is Label) { ((Label)X).Text = null; }
                if (X is RadioButton) { ((RadioButton)X).Checked = false; }
                if (X is CheckBox) { ((CheckBox)X).Checked = false; }
            }
        }

        private void ButtonRemoveItem_Click(object sender, EventArgs e)
        {
            Item Item = new Item();
            try
            {
                bool result = Item.RemoveItem(Convert.ToInt32(TextBoxRemoveItemItemCode.Text));
                if (result)
                {
                    TextBoxRemoveItemItemCode.Clear(); 
                    MessageBox.Show("Item has been successfully removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBoxSearchBar_KeyUp(TextBoxSearchBar, null);
                }
                else
                {
                    MessageBox.Show("Couldn't remove Item! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter correct input!", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Error, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
