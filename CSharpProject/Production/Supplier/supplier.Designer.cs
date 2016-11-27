namespace suppliers
{
    partial class Supplier
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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSreach = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbbSearchType = new System.Windows.Forms.ComboBox();
            this.cbbSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSreach = new System.Windows.Forms.Button();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvSupplier.Location = new System.Drawing.Point(10, 112);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(800, 241);
            this.dgvSupplier.TabIndex = 0;
            this.dgvSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(42, 385);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(153, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(297, 385);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(600, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sreach By";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSreach
            // 
            this.txtSreach.Location = new System.Drawing.Point(201, 60);
            this.txtSreach.Name = "txtSreach";
            this.txtSreach.Size = new System.Drawing.Size(141, 20);
            this.txtSreach.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(735, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbbSearchType
            // 
            this.cbbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchType.FormattingEnabled = true;
            this.cbbSearchType.Items.AddRange(new object[] {
            "Company Name",
            "Contact Name"});
            this.cbbSearchType.Location = new System.Drawing.Point(74, 59);
            this.cbbSearchType.Name = "cbbSearchType";
            this.cbbSearchType.Size = new System.Drawing.Size(121, 21);
            this.cbbSearchType.TabIndex = 8;
            this.cbbSearchType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbSearchBy
            // 
            this.cbbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchBy.FormattingEnabled = true;
            this.cbbSearchBy.Location = new System.Drawing.Point(560, 59);
            this.cbbSearchBy.Name = "cbbSearchBy";
            this.cbbSearchBy.Size = new System.Drawing.Size(121, 21);
            this.cbbSearchBy.TabIndex = 9;
            this.cbbSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnSreach
            // 
            this.btnSreach.Location = new System.Drawing.Point(348, 59);
            this.btnSreach.Name = "btnSreach";
            this.btnSreach.Size = new System.Drawing.Size(75, 23);
            this.btnSreach.TabIndex = 10;
            this.btnSreach.Text = "Search";
            this.btnSreach.UseVisualStyleBackColor = true;
            this.btnSreach.Click += new System.EventHandler(this.btnSreach_Click);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            // 
            // clmCompanyName
            // 
            this.clmCompanyName.HeaderText = "Company Name";
            this.clmCompanyName.Name = "clmCompanyName";
            // 
            // clmContactName
            // 
            this.clmContactName.HeaderText = "Contact Name";
            this.clmContactName.Name = "clmContactName";
            // 
            // clmContactTitle
            // 
            this.clmContactTitle.HeaderText = "Contact Title";
            this.clmContactTitle.Name = "clmContactTitle";
            // 
            // clmAddress
            // 
            this.clmAddress.HeaderText = "Address";
            this.clmAddress.Name = "clmAddress";
            // 
            // clmCity
            // 
            this.clmCity.HeaderText = "City";
            this.clmCity.Name = "clmCity";
            // 
            // clmRegion
            // 
            this.clmRegion.HeaderText = "Region";
            this.clmRegion.Name = "clmRegion";
            // 
            // clmPostalCode
            // 
            this.clmPostalCode.HeaderText = "Postal Code";
            this.clmPostalCode.Name = "clmPostalCode";
            // 
            // clmCountry
            // 
            this.clmCountry.HeaderText = "Country";
            this.clmCountry.Name = "clmCountry";
            // 
            // clmPhone
            // 
            this.clmPhone.HeaderText = "Phone";
            this.clmPhone.Name = "clmPhone";
            // 
            // clmFax
            // 
            this.clmFax.HeaderText = "Fax";
            this.clmFax.Name = "clmFax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search By Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Suppliers";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSreach);
            this.Controls.Add(this.cbbSearchBy);
            this.Controls.Add(this.cbbSearchType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSreach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Supplier";
            this.Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSreach;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbbSearchType;
        private System.Windows.Forms.ComboBox cbbSearchBy;
        private System.Windows.Forms.Button btnSreach;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

