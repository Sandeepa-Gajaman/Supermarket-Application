namespace Supermarket_Management_System
{
    partial class FormDashboard
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
            this.PanelCashier = new System.Windows.Forms.Panel();
            this.ButtonCustomerRegistration = new System.Windows.Forms.Button();
            this.ButtonPOS = new System.Windows.Forms.Button();
            this.PanelManager = new System.Windows.Forms.Panel();
            this.ButtonManagementReports = new System.Windows.Forms.Button();
            this.ButtonInventoryManagement = new System.Windows.Forms.Button();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.PanelCashier.SuspendLayout();
            this.PanelManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCashier
            // 
            this.PanelCashier.Controls.Add(this.ButtonCustomerRegistration);
            this.PanelCashier.Controls.Add(this.ButtonPOS);
            this.PanelCashier.Location = new System.Drawing.Point(13, 13);
            this.PanelCashier.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCashier.Name = "PanelCashier";
            this.PanelCashier.Size = new System.Drawing.Size(347, 340);
            this.PanelCashier.TabIndex = 0;
            // 
            // ButtonCustomerRegistration
            // 
            this.ButtonCustomerRegistration.Location = new System.Drawing.Point(99, 215);
            this.ButtonCustomerRegistration.Name = "ButtonCustomerRegistration";
            this.ButtonCustomerRegistration.Size = new System.Drawing.Size(150, 50);
            this.ButtonCustomerRegistration.TabIndex = 1;
            this.ButtonCustomerRegistration.Text = "Customer Registration";
            this.ButtonCustomerRegistration.UseVisualStyleBackColor = true;
            this.ButtonCustomerRegistration.Click += new System.EventHandler(this.ButtonCustomerRegistration_Click);
            // 
            // ButtonPOS
            // 
            this.ButtonPOS.Location = new System.Drawing.Point(99, 77);
            this.ButtonPOS.Name = "ButtonPOS";
            this.ButtonPOS.Size = new System.Drawing.Size(150, 50);
            this.ButtonPOS.TabIndex = 0;
            this.ButtonPOS.Text = "POS";
            this.ButtonPOS.UseVisualStyleBackColor = true;
            this.ButtonPOS.Click += new System.EventHandler(this.ButtonPOS_Click);
            // 
            // PanelManager
            // 
            this.PanelManager.Controls.Add(this.ButtonManagementReports);
            this.PanelManager.Controls.Add(this.ButtonInventoryManagement);
            this.PanelManager.Location = new System.Drawing.Point(368, 13);
            this.PanelManager.Margin = new System.Windows.Forms.Padding(4);
            this.PanelManager.Name = "PanelManager";
            this.PanelManager.Size = new System.Drawing.Size(338, 340);
            this.PanelManager.TabIndex = 1;
            // 
            // ButtonManagementReports
            // 
            this.ButtonManagementReports.Location = new System.Drawing.Point(96, 215);
            this.ButtonManagementReports.Name = "ButtonManagementReports";
            this.ButtonManagementReports.Size = new System.Drawing.Size(150, 50);
            this.ButtonManagementReports.TabIndex = 3;
            this.ButtonManagementReports.Text = "Manangement Reports";
            this.ButtonManagementReports.UseVisualStyleBackColor = true;
            this.ButtonManagementReports.Click += new System.EventHandler(this.ButtonManagementReports_Click);
            // 
            // ButtonInventoryManagement
            // 
            this.ButtonInventoryManagement.Location = new System.Drawing.Point(96, 77);
            this.ButtonInventoryManagement.Name = "ButtonInventoryManagement";
            this.ButtonInventoryManagement.Size = new System.Drawing.Size(150, 50);
            this.ButtonInventoryManagement.TabIndex = 2;
            this.ButtonInventoryManagement.Text = "Inventory Management";
            this.ButtonInventoryManagement.UseVisualStyleBackColor = true;
            this.ButtonInventoryManagement.Click += new System.EventHandler(this.ButtonInventoryManagement_Click);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Location = new System.Drawing.Point(285, 378);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(150, 50);
            this.ButtonLogout.TabIndex = 2;
            this.ButtonLogout.Text = "Log Out";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 452);
            this.Controls.Add(this.ButtonLogout);
            this.Controls.Add(this.PanelManager);
            this.Controls.Add(this.PanelCashier);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.PanelCashier.ResumeLayout(false);
            this.PanelManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelCashier;
        private System.Windows.Forms.Button ButtonCustomerRegistration;
        private System.Windows.Forms.Button ButtonPOS;
        private System.Windows.Forms.Panel PanelManager;
        private System.Windows.Forms.Button ButtonManagementReports;
        private System.Windows.Forms.Button ButtonInventoryManagement;
        private System.Windows.Forms.Button ButtonLogout;
    }
}