namespace Supermarket_Management_System
{
    partial class PaymentForm
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
            this.CashPayment = new System.Windows.Forms.Panel();
            this.Balancelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreditCard = new System.Windows.Forms.Panel();
            this.CreditCardBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Paymentbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LoyaltytextBox = new System.Windows.Forms.TextBox();
            this.Validatecustomerbutton = new System.Windows.Forms.Button();
            this.DebitCard = new System.Windows.Forms.Panel();
            this.DebitCardtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.TotalPaymentLable = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.CashPayment.SuspendLayout();
            this.CreditCard.SuspendLayout();
            this.DebitCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashPayment
            // 
            this.CashPayment.Controls.Add(this.Balancelabel);
            this.CashPayment.Controls.Add(this.label2);
            this.CashPayment.Controls.Add(this.textBox1);
            this.CashPayment.Controls.Add(this.label1);
            this.CashPayment.Location = new System.Drawing.Point(21, 333);
            this.CashPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CashPayment.Name = "CashPayment";
            this.CashPayment.Size = new System.Drawing.Size(627, 236);
            this.CashPayment.TabIndex = 0;
            this.CashPayment.Paint += new System.Windows.Forms.PaintEventHandler(this.CashPayment_Paint);
            // 
            // Balancelabel
            // 
            this.Balancelabel.AutoSize = true;
            this.Balancelabel.Location = new System.Drawing.Point(268, 132);
            this.Balancelabel.Name = "Balancelabel";
            this.Balancelabel.Size = new System.Drawing.Size(31, 20);
            this.Balancelabel.TabIndex = 3;
            this.Balancelabel.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cash Payment";
            // 
            // CreditCard
            // 
            this.CreditCard.Controls.Add(this.CreditCardBox3);
            this.CreditCard.Controls.Add(this.label5);
            this.CreditCard.Location = new System.Drawing.Point(21, 333);
            this.CreditCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.Size = new System.Drawing.Size(627, 236);
            this.CreditCard.TabIndex = 5;
            // 
            // CreditCardBox3
            // 
            this.CreditCardBox3.Location = new System.Drawing.Point(225, 95);
            this.CreditCardBox3.Name = "CreditCardBox3";
            this.CreditCardBox3.Size = new System.Drawing.Size(352, 26);
            this.CreditCardBox3.TabIndex = 1;
            this.CreditCardBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Credit Card Number";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "CreditCard",
            "DebitCard"});
            this.comboBox1.Location = new System.Drawing.Point(238, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Option";
            // 
            // Paymentbutton
            // 
            this.Paymentbutton.Location = new System.Drawing.Point(319, 609);
            this.Paymentbutton.Name = "Paymentbutton";
            this.Paymentbutton.Size = new System.Drawing.Size(131, 38);
            this.Paymentbutton.TabIndex = 5;
            this.Paymentbutton.Text = "Pay";
            this.Paymentbutton.UseVisualStyleBackColor = true;
            this.Paymentbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loyalty card number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // LoyaltytextBox
            // 
            this.LoyaltytextBox.Location = new System.Drawing.Point(242, 26);
            this.LoyaltytextBox.Name = "LoyaltytextBox";
            this.LoyaltytextBox.Size = new System.Drawing.Size(352, 26);
            this.LoyaltytextBox.TabIndex = 2;
            // 
            // Validatecustomerbutton
            // 
            this.Validatecustomerbutton.Location = new System.Drawing.Point(238, 80);
            this.Validatecustomerbutton.Name = "Validatecustomerbutton";
            this.Validatecustomerbutton.Size = new System.Drawing.Size(131, 38);
            this.Validatecustomerbutton.TabIndex = 7;
            this.Validatecustomerbutton.Text = "Valid customer";
            this.Validatecustomerbutton.UseVisualStyleBackColor = true;
            this.Validatecustomerbutton.Click += new System.EventHandler(this.Validatecustomerbutton_Click);
            // 
            // DebitCard
            // 
            this.DebitCard.Controls.Add(this.DebitCardtextBox);
            this.DebitCard.Controls.Add(this.label7);
            this.DebitCard.Location = new System.Drawing.Point(21, 333);
            this.DebitCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DebitCard.Name = "DebitCard";
            this.DebitCard.Size = new System.Drawing.Size(627, 236);
            this.DebitCard.TabIndex = 6;
            // 
            // DebitCardtextBox
            // 
            this.DebitCardtextBox.Location = new System.Drawing.Point(225, 95);
            this.DebitCardtextBox.Name = "DebitCardtextBox";
            this.DebitCardtextBox.Size = new System.Drawing.Size(352, 26);
            this.DebitCardtextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Debit Card Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Payment";
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Location = new System.Drawing.Point(233, 204);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(40, 20);
            this.PaymentLabel.TabIndex = 9;
            this.PaymentLabel.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Discount";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(232, 253);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(40, 20);
            this.DiscountLabel.TabIndex = 11;
            this.DiscountLabel.Text = "0.00";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(20, 294);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(110, 20);
            this.Label.TabIndex = 12;
            this.Label.Text = "Total Payment";
            // 
            // TotalPaymentLable
            // 
            this.TotalPaymentLable.AutoSize = true;
            this.TotalPaymentLable.Location = new System.Drawing.Point(233, 294);
            this.TotalPaymentLable.Name = "TotalPaymentLable";
            this.TotalPaymentLable.Size = new System.Drawing.Size(40, 20);
            this.TotalPaymentLable.TabIndex = 13;
            this.TotalPaymentLable.Text = "0.00";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.Control;
            this.Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.Location = new System.Drawing.Point(69, 609);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(131, 38);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.TotalPaymentLable);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.DebitCard);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CreditCard);
            this.Controls.Add(this.PaymentLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Validatecustomerbutton);
            this.Controls.Add(this.LoyaltytextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Paymentbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CashPayment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.CashPayment.ResumeLayout(false);
            this.CashPayment.PerformLayout();
            this.CreditCard.ResumeLayout(false);
            this.CreditCard.PerformLayout();
            this.DebitCard.ResumeLayout(false);
            this.DebitCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CashPayment;
        private System.Windows.Forms.Label Balancelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel CreditCard;
        private System.Windows.Forms.TextBox CreditCardBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Paymentbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoyaltytextBox;
        private System.Windows.Forms.Button Validatecustomerbutton;
        private System.Windows.Forms.Panel DebitCard;
        private System.Windows.Forms.TextBox DebitCardtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label TotalPaymentLable;
        private System.Windows.Forms.Button Back;
    }
}