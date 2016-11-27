namespace suppliers
{
    partial class AddSupp
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Contitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtConTitle = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalcode = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorCompany = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContactNa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContactTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCountry = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbbRegion = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContactNa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContactTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Name";
            // 
            // Contitle
            // 
            this.Contitle.AutoSize = true;
            this.Contitle.Location = new System.Drawing.Point(339, 113);
            this.Contitle.Name = "Contitle";
            this.Contitle.Size = new System.Drawing.Size(67, 13);
            this.Contitle.TabIndex = 3;
            this.Contitle.Text = "Contact Title";
            this.Contitle.Click += new System.EventHandler(this.Contitle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Region";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Postalcode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fax";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(419, 56);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(208, 20);
            this.txtCompany.TabIndex = 12;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(110, 56);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(208, 20);
            this.txtContact.TabIndex = 13;
            // 
            // txtConTitle
            // 
            this.txtConTitle.Location = new System.Drawing.Point(419, 112);
            this.txtConTitle.Name = "txtConTitle";
            this.txtConTitle.Size = new System.Drawing.Size(208, 20);
            this.txtConTitle.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 108);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(208, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(419, 168);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(208, 20);
            this.txtCity.TabIndex = 16;
            // 
            // txtPostalcode
            // 
            this.txtPostalcode.Location = new System.Drawing.Point(419, 232);
            this.txtPostalcode.Name = "txtPostalcode";
            this.txtPostalcode.Size = new System.Drawing.Size(208, 20);
            this.txtPostalcode.TabIndex = 18;
            this.txtPostalcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPostalcode_KeyDown);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(110, 351);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(208, 23);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "OK";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(419, 351);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(208, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbbCountry
            // 
            this.cbbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Location = new System.Drawing.Point(110, 228);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(208, 21);
            this.cbbCountry.TabIndex = 27;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(110, 292);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(208, 20);
            this.txtFax.TabIndex = 28;
            this.txtFax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFax_KeyDown);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(419, 287);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(208, 20);
            this.txtPhone.TabIndex = 29;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Supplier";
            // 
            // errorCompany
            // 
            this.errorCompany.ContainerControl = this;
            // 
            // errorContactNa
            // 
            this.errorContactNa.ContainerControl = this;
            // 
            // errorContactTitle
            // 
            this.errorContactTitle.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.ContainerControl = this;
            // 
            // errorCity
            // 
            this.errorCity.ContainerControl = this;
            // 
            // errorCountry
            // 
            this.errorCountry.ContainerControl = this;
            // 
            // errorPhone
            // 
            this.errorPhone.ContainerControl = this;
            // 
            // cbbRegion
            // 
            this.cbbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRegion.FormattingEnabled = true;
            this.cbbRegion.Location = new System.Drawing.Point(110, 176);
            this.cbbRegion.Name = "cbbRegion";
            this.cbbRegion.Size = new System.Drawing.Size(208, 21);
            this.cbbRegion.TabIndex = 32;
            this.cbbRegion.SelectedIndexChanged += new System.EventHandler(this.cbbRegion_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 33;
            this.lblId.Visible = false;
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 391);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cbbRegion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.cbbCountry);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtPostalcode);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtConTitle);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Contitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupp";
            this.Text = "AddSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.errorCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContactNa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContactTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Contitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtConTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalcode;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorCompany;
        private System.Windows.Forms.ErrorProvider errorContactNa;
        private System.Windows.Forms.ErrorProvider errorContactTitle;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorCity;
        private System.Windows.Forms.ErrorProvider errorCountry;
        private System.Windows.Forms.ErrorProvider errorPhone;
        private System.Windows.Forms.ComboBox cbbRegion;
        private System.Windows.Forms.Label lblId;
    }
}