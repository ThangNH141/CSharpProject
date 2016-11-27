namespace Employees
{
    partial class frmEmployees
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
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleOFCourtesy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hiredayte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MgrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBDFrom = new System.Windows.Forms.DateTimePicker();
            this.dtBDTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.btnSearchFn = new System.Windows.Forms.Button();
            this.btnSearchLn = new System.Windows.Forms.Button();
            this.btnSerachBd = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.erFn = new System.Windows.Forms.ErrorProvider(this.components);
            this.erLn = new System.Windows.Forms.ErrorProvider(this.components);
            this.erBd = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erFn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erLn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erBd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployees
            // 
            this.dgEmployees.AllowUserToAddRows = false;
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.Lastname,
            this.Firstname,
            this.Title,
            this.TitleOFCourtesy,
            this.Birthdate,
            this.Hiredayte,
            this.Address,
            this.City,
            this.Region,
            this.PostalCode,
            this.Country,
            this.Phone,
            this.MgrID});
            this.dgEmployees.Location = new System.Drawing.Point(12, 193);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.RowTemplate.Height = 24;
            this.dgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmployees.Size = new System.Drawing.Size(1450, 286);
            this.dgEmployees.TabIndex = 0;
            // 
            // EmpID
            // 
            this.EmpID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpID.HeaderText = "EmpID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lastname.HeaderText = "Lastname";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // TitleOFCourtesy
            // 
            this.TitleOFCourtesy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitleOFCourtesy.HeaderText = "TitleOFCourtesy";
            this.TitleOFCourtesy.Name = "TitleOFCourtesy";
            this.TitleOFCourtesy.ReadOnly = true;
            // 
            // Birthdate
            // 
            this.Birthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.ReadOnly = true;
            // 
            // Hiredayte
            // 
            this.Hiredayte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hiredayte.HeaderText = "Hiredate";
            this.Hiredayte.Name = "Hiredayte";
            this.Hiredayte.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Region
            // 
            this.Region.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // PostalCode
            // 
            this.PostalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PostalCode.HeaderText = "PostalCode";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // MgrID
            // 
            this.MgrID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MgrID.HeaderText = "MgrID";
            this.MgrID.Name = "MgrID";
            this.MgrID.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEES";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 499);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(863, 499);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(647, 499);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthdate";
            // 
            // dtBDFrom
            // 
            this.dtBDFrom.Location = new System.Drawing.Point(113, 85);
            this.dtBDFrom.Name = "dtBDFrom";
            this.dtBDFrom.Size = new System.Drawing.Size(200, 22);
            this.dtBDFrom.TabIndex = 8;
            // 
            // dtBDTo
            // 
            this.dtBDTo.Location = new System.Drawing.Point(367, 85);
            this.dtBDTo.Name = "dtBDTo";
            this.dtBDTo.Size = new System.Drawing.Size(200, 22);
            this.dtBDTo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "to";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(113, 23);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(454, 22);
            this.txtFirstname.TabIndex = 11;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(113, 55);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(454, 22);
            this.txtLastname.TabIndex = 12;
            // 
            // btnSearchFn
            // 
            this.btnSearchFn.Location = new System.Drawing.Point(593, 22);
            this.btnSearchFn.Name = "btnSearchFn";
            this.btnSearchFn.Size = new System.Drawing.Size(118, 23);
            this.btnSearchFn.TabIndex = 13;
            this.btnSearchFn.Text = "Search";
            this.btnSearchFn.UseVisualStyleBackColor = true;
            this.btnSearchFn.Click += new System.EventHandler(this.btnSearchFn_Click);
            // 
            // btnSearchLn
            // 
            this.btnSearchLn.Location = new System.Drawing.Point(593, 55);
            this.btnSearchLn.Name = "btnSearchLn";
            this.btnSearchLn.Size = new System.Drawing.Size(118, 23);
            this.btnSearchLn.TabIndex = 14;
            this.btnSearchLn.Text = "Search";
            this.btnSearchLn.UseVisualStyleBackColor = true;
            this.btnSearchLn.Click += new System.EventHandler(this.btnSearchLn_Click);
            // 
            // btnSerachBd
            // 
            this.btnSerachBd.Location = new System.Drawing.Point(593, 87);
            this.btnSerachBd.Name = "btnSerachBd";
            this.btnSerachBd.Size = new System.Drawing.Size(118, 23);
            this.btnSerachBd.TabIndex = 15;
            this.btnSerachBd.Text = "Search";
            this.btnSerachBd.UseVisualStyleBackColor = true;
            this.btnSerachBd.Click += new System.EventHandler(this.btnSerachBd_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(737, 24);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 86);
            this.btnShowAll.TabIndex = 16;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.btnSerachBd);
            this.groupBox1.Controls.Add(this.btnSearchLn);
            this.groupBox1.Controls.Add(this.btnSearchFn);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtBDTo);
            this.groupBox1.Controls.Add(this.dtBDFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(418, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 121);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // erFn
            // 
            this.erFn.ContainerControl = this;
            // 
            // erLn
            // 
            this.erLn.ContainerControl = this;
            // 
            // erBd
            // 
            this.erBd.ContainerControl = this;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEmployees);
            this.Name = "frmEmployees";
            this.Text = "EMPLOYEES";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erFn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erLn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erBd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleOFCourtesy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hiredayte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MgrID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBDFrom;
        private System.Windows.Forms.DateTimePicker dtBDTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Button btnSearchFn;
        private System.Windows.Forms.Button btnSearchLn;
        private System.Windows.Forms.Button btnSerachBd;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider erFn;
        private System.Windows.Forms.ErrorProvider erLn;
        private System.Windows.Forms.ErrorProvider erBd;
    }
}

