namespace CSharpProject.Sales.Order
{
    partial class EditForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shippedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shipperComboBox = new System.Windows.Forms.ComboBox();
            this.freightTextBox = new System.Windows.Forms.TextBox();
            this.shipNameLbl = new System.Windows.Forms.Label();
            this.shipnameTextBox = new System.Windows.Forms.TextBox();
            this.shipaddressTextBox = new System.Windows.Forms.TextBox();
            this.shipcityTextBox = new System.Windows.Forms.TextBox();
            this.shipregionTextBox = new System.Windows.Forms.TextBox();
            this.shippostalcodeTextBox = new System.Windows.Forms.TextBox();
            this.shipCountryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.controlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee";
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.CustomFormat = "dd/MM/yyy";
            this.orderDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDateTimePicker.Location = new System.Drawing.Point(91, 104);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.orderDateTimePicker.TabIndex = 3;
            this.orderDateTimePicker.ValueChanged += new System.EventHandler(this.orderDateTimePicker_ValueChanged);
            // 
            // requiredDateTimePicker
            // 
            this.requiredDateTimePicker.CustomFormat = "dd/MM/yyy";
            this.requiredDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.requiredDateTimePicker.Location = new System.Drawing.Point(91, 130);
            this.requiredDateTimePicker.Name = "requiredDateTimePicker";
            this.requiredDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.requiredDateTimePicker.TabIndex = 4;
            this.requiredDateTimePicker.ValueChanged += new System.EventHandler(this.requiredDateTimePicker_ValueChanged);
            // 
            // shippedDateTimePicker
            // 
            this.shippedDateTimePicker.CustomFormat = "dd/MM/yyy";
            this.shippedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.shippedDateTimePicker.Location = new System.Drawing.Point(91, 156);
            this.shippedDateTimePicker.Name = "shippedDateTimePicker";
            this.shippedDateTimePicker.Size = new System.Drawing.Size(150, 20);
            this.shippedDateTimePicker.TabIndex = 5;
            this.shippedDateTimePicker.ValueChanged += new System.EventHandler(this.shippedDateTimePicker_ValueChanged);
            // 
            // shipperComboBox
            // 
            this.shipperComboBox.FormattingEnabled = true;
            this.shipperComboBox.Location = new System.Drawing.Point(365, 49);
            this.shipperComboBox.Name = "shipperComboBox";
            this.shipperComboBox.Size = new System.Drawing.Size(178, 21);
            this.shipperComboBox.TabIndex = 7;
            this.shipperComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shipperComboBox_KeyPress);
            this.shipperComboBox.Leave += new System.EventHandler(this.shipperComboBox_Leave);
            // 
            // freightTextBox
            // 
            this.freightTextBox.Location = new System.Drawing.Point(91, 182);
            this.freightTextBox.Name = "freightTextBox";
            this.freightTextBox.Size = new System.Drawing.Size(150, 20);
            this.freightTextBox.TabIndex = 6;
            this.freightTextBox.TextChanged += new System.EventHandler(this.freightTextBox_TextChanged);
            // 
            // shipNameLbl
            // 
            this.shipNameLbl.AutoSize = true;
            this.shipNameLbl.Location = new System.Drawing.Point(275, 75);
            this.shipNameLbl.Name = "shipNameLbl";
            this.shipNameLbl.Size = new System.Drawing.Size(57, 13);
            this.shipNameLbl.TabIndex = 11;
            this.shipNameLbl.Text = "Ship name";
            // 
            // shipnameTextBox
            // 
            this.shipnameTextBox.Location = new System.Drawing.Point(365, 75);
            this.shipnameTextBox.Name = "shipnameTextBox";
            this.shipnameTextBox.Size = new System.Drawing.Size(178, 20);
            this.shipnameTextBox.TabIndex = 8;
            this.shipnameTextBox.TextChanged += new System.EventHandler(this.shipnameTextBox_TextChanged);
            // 
            // shipaddressTextBox
            // 
            this.shipaddressTextBox.Location = new System.Drawing.Point(365, 102);
            this.shipaddressTextBox.Name = "shipaddressTextBox";
            this.shipaddressTextBox.Size = new System.Drawing.Size(178, 20);
            this.shipaddressTextBox.TabIndex = 9;
            this.shipaddressTextBox.TextChanged += new System.EventHandler(this.shipaddressTextBox_TextChanged);
            // 
            // shipcityTextBox
            // 
            this.shipcityTextBox.Location = new System.Drawing.Point(365, 130);
            this.shipcityTextBox.Name = "shipcityTextBox";
            this.shipcityTextBox.Size = new System.Drawing.Size(178, 20);
            this.shipcityTextBox.TabIndex = 10;
            this.shipcityTextBox.TextChanged += new System.EventHandler(this.shipcityTextBox_TextChanged);
            // 
            // shipregionTextBox
            // 
            this.shipregionTextBox.Location = new System.Drawing.Point(365, 156);
            this.shipregionTextBox.Name = "shipregionTextBox";
            this.shipregionTextBox.Size = new System.Drawing.Size(178, 20);
            this.shipregionTextBox.TabIndex = 11;
            this.shipregionTextBox.TextChanged += new System.EventHandler(this.shipregionTextBox_TextChanged);
            // 
            // shippostalcodeTextBox
            // 
            this.shippostalcodeTextBox.Location = new System.Drawing.Point(365, 182);
            this.shippostalcodeTextBox.Name = "shippostalcodeTextBox";
            this.shippostalcodeTextBox.Size = new System.Drawing.Size(178, 20);
            this.shippostalcodeTextBox.TabIndex = 12;
            this.shippostalcodeTextBox.TextChanged += new System.EventHandler(this.shippostalcodeTextBox_TextChanged);
            // 
            // shipCountryTextBox
            // 
            this.shipCountryTextBox.Location = new System.Drawing.Point(365, 208);
            this.shipCountryTextBox.Name = "shipCountryTextBox";
            this.shipCountryTextBox.Size = new System.Drawing.Size(178, 20);
            this.shipCountryTextBox.TabIndex = 13;
            this.shipCountryTextBox.TextChanged += new System.EventHandler(this.shipCountryTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Order date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Required date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Shipped date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Shipper";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Freight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ship address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ship city";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ship region";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Ship postal code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ship country";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(8, 19);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 29;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(143, 19);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 30;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.resetBtn);
            this.controlGroupBox.Controls.Add(this.editBtn);
            this.controlGroupBox.Location = new System.Drawing.Point(181, 234);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(224, 54);
            this.controlGroupBox.TabIndex = 31;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(238, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(94, 41);
            this.titleLabel.TabIndex = 32;
            this.titleLabel.Text = "EDIT";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(91, 76);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(150, 21);
            this.employeeComboBox.TabIndex = 2;
            this.employeeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeeComboBox_KeyPress);
            this.employeeComboBox.Leave += new System.EventHandler(this.employeeComboBox_Leave);
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(91, 49);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(150, 21);
            this.customerComboBox.TabIndex = 1;
            this.customerComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerComboBox_KeyPress);
            this.customerComboBox.Leave += new System.EventHandler(this.customerComboBox_Leave);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 292);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shipCountryTextBox);
            this.Controls.Add(this.shippostalcodeTextBox);
            this.Controls.Add(this.shipregionTextBox);
            this.Controls.Add(this.shipcityTextBox);
            this.Controls.Add(this.shipaddressTextBox);
            this.Controls.Add(this.shipnameTextBox);
            this.Controls.Add(this.shipNameLbl);
            this.Controls.Add(this.freightTextBox);
            this.Controls.Add(this.shipperComboBox);
            this.Controls.Add(this.shippedDateTimePicker);
            this.Controls.Add(this.requiredDateTimePicker);
            this.Controls.Add(this.orderDateTimePicker);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.controlGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker requiredDateTimePicker;
        private System.Windows.Forms.DateTimePicker shippedDateTimePicker;
        private System.Windows.Forms.ComboBox shipperComboBox;
        private System.Windows.Forms.TextBox freightTextBox;
        private System.Windows.Forms.Label shipNameLbl;
        private System.Windows.Forms.TextBox shipnameTextBox;
        private System.Windows.Forms.TextBox shipaddressTextBox;
        private System.Windows.Forms.TextBox shipcityTextBox;
        private System.Windows.Forms.TextBox shipregionTextBox;
        private System.Windows.Forms.TextBox shippostalcodeTextBox;
        private System.Windows.Forms.TextBox shipCountryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker;
    }
}