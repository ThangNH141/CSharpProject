namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.txtSearchOrderID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchProductID = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Unitp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Quality = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Dis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchOrderID
            // 
            this.txtSearchOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSearchOrderID.FormattingEnabled = true;
            this.txtSearchOrderID.Location = new System.Drawing.Point(152, 48);
            this.txtSearchOrderID.Name = "txtSearchOrderID";
            this.txtSearchOrderID.Size = new System.Drawing.Size(121, 21);
            this.txtSearchOrderID.TabIndex = 0;
            this.txtSearchOrderID.SelectedIndexChanged += new System.EventHandler(this.txtSearchOrderID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product ID:";
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSearchProductID.FormattingEnabled = true;
            this.txtSearchProductID.Location = new System.Drawing.Point(152, 95);
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.Size = new System.Drawing.Size(121, 21);
            this.txtSearchProductID.TabIndex = 3;
            this.txtSearchProductID.SelectedIndexChanged += new System.EventHandler(this.txtSearchProductID_SelectedIndexChanged);
            this.txtSearchProductID.SelectedValueChanged += new System.EventHandler(this.txtSearchProductID_SelectedValueChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(397, 96);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unit Price:";
            // 
            // Unitp
            // 
            this.Unitp.Location = new System.Drawing.Point(152, 137);
            this.Unitp.Name = "Unitp";
            this.Unitp.Size = new System.Drawing.Size(247, 20);
            this.Unitp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quality:";
            // 
            // Quality
            // 
            this.Quality.Location = new System.Drawing.Point(152, 180);
            this.Quality.Name = "Quality";
            this.Quality.Size = new System.Drawing.Size(247, 20);
            this.Quality.TabIndex = 9;
            this.Quality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Quality_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Discount:";
            // 
            // Dis
            // 
            this.Dis.Location = new System.Drawing.Point(152, 226);
            this.Dis.Name = "Dis";
            this.Dis.Size = new System.Drawing.Size(247, 20);
            this.Dis.TabIndex = 11;
            this.Dis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dis_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Quality);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Unitp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtSearchProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchOrderID);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtSearchOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtSearchProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Unitp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Dis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}