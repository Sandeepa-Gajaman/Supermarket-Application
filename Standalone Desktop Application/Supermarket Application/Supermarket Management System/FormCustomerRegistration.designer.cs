namespace supermarket
{
    partial class FormCustomerRegistration
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
            this.lblfname = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblmobilenumber = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtmobilenumber = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(47, 112);
            this.lblfname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(76, 17);
            this.lblfname.TabIndex = 0;
            this.lblfname.Text = "First Name";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(47, 174);
            this.lbllname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(76, 17);
            this.lbllname.TabIndex = 1;
            this.lbllname.Text = "Last Name";
            // 
            // lblmobilenumber
            // 
            this.lblmobilenumber.AutoSize = true;
            this.lblmobilenumber.Location = new System.Drawing.Point(47, 250);
            this.lblmobilenumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmobilenumber.Name = "lblmobilenumber";
            this.lblmobilenumber.Size = new System.Drawing.Size(103, 17);
            this.lblmobilenumber.TabIndex = 2;
            this.lblmobilenumber.Text = "Mobile Number";
            this.lblmobilenumber.Click += new System.EventHandler(this.lblmobilenumber_Click);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(243, 112);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(265, 22);
            this.txtfname.TabIndex = 3;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(243, 174);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(265, 22);
            this.txtlname.TabIndex = 4;
            // 
            // txtmobilenumber
            // 
            this.txtmobilenumber.Location = new System.Drawing.Point(243, 241);
            this.txtmobilenumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmobilenumber.Name = "txtmobilenumber";
            this.txtmobilenumber.Size = new System.Drawing.Size(265, 22);
            this.txtmobilenumber.TabIndex = 5;
            this.txtmobilenumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(391, 310);
            this.btnregister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(100, 28);
            this.btnregister.TabIndex = 6;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // FormCustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 517);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtmobilenumber);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lblmobilenumber);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCustomerRegistration";
            this.Text = "Customer Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblmobilenumber;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtmobilenumber;
        private System.Windows.Forms.Button btnregister;
    }
}

