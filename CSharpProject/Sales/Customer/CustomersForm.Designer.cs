namespace CustomersShippersForm
{
    partial class CustomersForm
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cbbSearchByCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmCompanyName,
            this.clmContactName,
            this.clmContactTitle,
            this.clmAddress,
            this.clmCity,
            this.clmRegion,
            this.clmPostalCode,
            this.clmCountry,
            this.clmPhone,
            this.clmFax});
            this.dgvCustomers.Location = new System.Drawing.Point(12, 76);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(1873, 393);
            this.dgvCustomers.TabIndex = 0;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmCompanyName
            // 
            this.clmCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCompanyName.HeaderText = "Company Name";
            this.clmCompanyName.Name = "clmCompanyName";
            this.clmCompanyName.ReadOnly = true;
            // 
            // clmContactName
            // 
            this.clmContactName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmContactName.HeaderText = "Contact Name";
            this.clmContactName.Name = "clmContactName";
            this.clmContactName.ReadOnly = true;
            // 
            // clmContactTitle
            // 
            this.clmContactTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmContactTitle.HeaderText = "Contact Title";
            this.clmContactTitle.Name = "clmContactTitle";
            this.clmContactTitle.ReadOnly = true;
            // 
            // clmAddress
            // 
            this.clmAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAddress.HeaderText = "Address";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            // 
            // clmCity
            // 
            this.clmCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCity.HeaderText = "City";
            this.clmCity.Name = "clmCity";
            this.clmCity.ReadOnly = true;
            // 
            // clmRegion
            // 
            this.clmRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmRegion.HeaderText = "Region";
            this.clmRegion.Name = "clmRegion";
            this.clmRegion.ReadOnly = true;
            // 
            // clmPostalCode
            // 
            this.clmPostalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPostalCode.HeaderText = "Postal Code";
            this.clmPostalCode.Name = "clmPostalCode";
            this.clmPostalCode.ReadOnly = true;
            // 
            // clmCountry
            // 
            this.clmCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCountry.HeaderText = "Country";
            this.clmCountry.Name = "clmCountry";
            this.clmCountry.ReadOnly = true;
            // 
            // clmPhone
            // 
            this.clmPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPhone.HeaderText = "Phone";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.ReadOnly = true;
            // 
            // clmFax
            // 
            this.clmFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFax.HeaderText = "Fax";
            this.clmFax.Name = "clmFax";
            this.clmFax.ReadOnly = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(105, 496);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 42);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(219, 496);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(326, 496);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1330, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by:";
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Items.AddRange(new object[] {
            "Company Name",
            "Contact Name"});
            this.cbbSearchType.Location = new System.Drawing.Point(1420, 504);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(180, 28);
            this.cbbSearchType.TabIndex = 5;
            this.cbbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbbSearchType_SelectedIndexChanged);
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(1606, 504);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(130, 26);
            this.txtSearchValue.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1742, 502);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(1643, 27);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(174, 42);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cbbSearchByCountry
            // 
            this.cbbSearchByCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchByCountry.FormattingEnabled = true;
            this.cbbSearchByCountry.Location = new System.Drawing.Point(1420, 538);
            this.cbbSearchByCountry.Name = "cbbSearchByCountry";
            this.cbbSearchByCountry.Size = new System.Drawing.Size(180, 28);
            this.cbbSearchByCountry.TabIndex = 9;
            this.cbbSearchByCountry.SelectedIndexChanged += new System.EventHandler(this.cbbSearchByCountry_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(794, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "CUSTOMERS";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1897, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbSearchByCountry);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "CustomersForm";
            this.Text = "Customer Detail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cbbSearchByCountry;
        private System.Windows.Forms.Label label2;
    }
}

