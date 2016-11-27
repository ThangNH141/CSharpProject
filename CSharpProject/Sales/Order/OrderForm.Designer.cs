namespace CSharpProject.Sales.Order
{
    partial class OrderForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coulmnOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRequiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coulmnShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShipCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShipRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShipPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnShipCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.showallBtn = new System.Windows.Forms.Button();
            this.nameSearchBtn = new System.Windows.Forms.Button();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.dateSearchBtn = new System.Windows.Forms.Button();
            this.comboBoxSearchCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnCustomer,
            this.columnEmployee,
            this.coulmnOrderDate,
            this.columnRequiredDate,
            this.columnShippedDate,
            this.columnShipper,
            this.columnFreight,
            this.coulmnShipName,
            this.columnShipAddress,
            this.columnShipCity,
            this.columnShipRegion,
            this.columnShipPostalCode,
            this.columnShipCountry});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(12, 115);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1114, 320);
            this.dataGridView.TabIndex = 0;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Id";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnCustomer
            // 
            this.columnCustomer.HeaderText = "Customer";
            this.columnCustomer.Name = "columnCustomer";
            this.columnCustomer.ReadOnly = true;
            // 
            // columnEmployee
            // 
            this.columnEmployee.HeaderText = "Employee";
            this.columnEmployee.Name = "columnEmployee";
            this.columnEmployee.ReadOnly = true;
            // 
            // coulmnOrderDate
            // 
            this.coulmnOrderDate.HeaderText = "Order Date";
            this.coulmnOrderDate.Name = "coulmnOrderDate";
            this.coulmnOrderDate.ReadOnly = true;
            // 
            // columnRequiredDate
            // 
            this.columnRequiredDate.HeaderText = "Required Date";
            this.columnRequiredDate.Name = "columnRequiredDate";
            this.columnRequiredDate.ReadOnly = true;
            // 
            // columnShippedDate
            // 
            this.columnShippedDate.HeaderText = "Shipped Date";
            this.columnShippedDate.Name = "columnShippedDate";
            this.columnShippedDate.ReadOnly = true;
            // 
            // columnShipper
            // 
            this.columnShipper.HeaderText = "Shipper";
            this.columnShipper.Name = "columnShipper";
            this.columnShipper.ReadOnly = true;
            // 
            // columnFreight
            // 
            this.columnFreight.HeaderText = "Freight";
            this.columnFreight.Name = "columnFreight";
            this.columnFreight.ReadOnly = true;
            // 
            // coulmnShipName
            // 
            this.coulmnShipName.HeaderText = "Ship Name";
            this.coulmnShipName.Name = "coulmnShipName";
            this.coulmnShipName.ReadOnly = true;
            // 
            // columnShipAddress
            // 
            this.columnShipAddress.HeaderText = "Ship Address";
            this.columnShipAddress.Name = "columnShipAddress";
            this.columnShipAddress.ReadOnly = true;
            // 
            // columnShipCity
            // 
            this.columnShipCity.HeaderText = "Ship City";
            this.columnShipCity.Name = "columnShipCity";
            this.columnShipCity.ReadOnly = true;
            // 
            // columnShipRegion
            // 
            this.columnShipRegion.HeaderText = "Ship Region";
            this.columnShipRegion.Name = "columnShipRegion";
            this.columnShipRegion.ReadOnly = true;
            // 
            // columnShipPostalCode
            // 
            this.columnShipPostalCode.HeaderText = "Ship Postal Code";
            this.columnShipPostalCode.Name = "columnShipPostalCode";
            this.columnShipPostalCode.ReadOnly = true;
            // 
            // columnShipCountry
            // 
            this.columnShipCountry.HeaderText = "Ship Country";
            this.columnShipCountry.Name = "columnShipCountry";
            this.columnShipCountry.ReadOnly = true;
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(280, 441);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(117, 23);
            this.newBtn.TabIndex = 1;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(696, 441);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(132, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(490, 441);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(127, 23);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.showallBtn);
            this.searchGroupBox.Controls.Add(this.nameSearchBtn);
            this.searchGroupBox.Controls.Add(this.customerTextBox);
            this.searchGroupBox.Controls.Add(this.dateSearchBtn);
            this.searchGroupBox.Controls.Add(this.comboBoxSearchCategory);
            this.searchGroupBox.Controls.Add(this.label3);
            this.searchGroupBox.Controls.Add(this.dateTimePickerToDate);
            this.searchGroupBox.Controls.Add(this.dateTimePickerFromDate);
            this.searchGroupBox.Controls.Add(this.label2);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Location = new System.Drawing.Point(280, 28);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(548, 81);
            this.searchGroupBox.TabIndex = 3;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // showallBtn
            // 
            this.showallBtn.Location = new System.Drawing.Point(467, 19);
            this.showallBtn.Name = "showallBtn";
            this.showallBtn.Size = new System.Drawing.Size(75, 52);
            this.showallBtn.TabIndex = 9;
            this.showallBtn.Text = "Show all";
            this.showallBtn.UseVisualStyleBackColor = true;
            this.showallBtn.Click += new System.EventHandler(this.showallBtn_Click);
            // 
            // nameSearchBtn
            // 
            this.nameSearchBtn.Location = new System.Drawing.Point(397, 19);
            this.nameSearchBtn.Name = "nameSearchBtn";
            this.nameSearchBtn.Size = new System.Drawing.Size(65, 23);
            this.nameSearchBtn.TabIndex = 8;
            this.nameSearchBtn.Text = "Search";
            this.nameSearchBtn.UseVisualStyleBackColor = true;
            this.nameSearchBtn.Click += new System.EventHandler(this.nameSearchBtn_Click);
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(97, 21);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(294, 20);
            this.customerTextBox.TabIndex = 7;
            // 
            // dateSearchBtn
            // 
            this.dateSearchBtn.Location = new System.Drawing.Point(397, 48);
            this.dateSearchBtn.Name = "dateSearchBtn";
            this.dateSearchBtn.Size = new System.Drawing.Size(65, 23);
            this.dateSearchBtn.TabIndex = 6;
            this.dateSearchBtn.Text = "Search";
            this.dateSearchBtn.UseVisualStyleBackColor = true;
            this.dateSearchBtn.Click += new System.EventHandler(this.dateSearchBtn_Click);
            // 
            // comboBoxSearchCategory
            // 
            this.comboBoxSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchCategory.FormattingEnabled = true;
            this.comboBoxSearchCategory.Items.AddRange(new object[] {
            "Order date",
            "Required date",
            "Shipped date"});
            this.comboBoxSearchCategory.Location = new System.Drawing.Point(300, 50);
            this.comboBoxSearchCategory.Name = "comboBoxSearchCategory";
            this.comboBoxSearchCategory.Size = new System.Drawing.Size(91, 21);
            this.comboBoxSearchCategory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "to";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(173, 50);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerToDate.TabIndex = 3;
            this.dateTimePickerToDate.ValueChanged += new System.EventHandler(this.dateTimePickerToDate_ValueChanged);
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(47, 50);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerFromDate.TabIndex = 2;
            this.dateTimePickerFromDate.ValueChanged += new System.EventHandler(this.dateTimePickerFromDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 43);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 506);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.dataGridView);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nameSearchBtn;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Button dateSearchBtn;
        private System.Windows.Forms.ComboBox comboBoxSearchCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Button showallBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn coulmnOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRequiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn coulmnShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShipCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShipRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShipPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnShipCountry;
    }
}