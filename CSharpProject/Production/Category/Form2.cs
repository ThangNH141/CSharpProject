using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGroup
{
    public partial class AddCategories : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString);
        SqlCommand command;
        SqlDataReader reader;
        bool bAdd;
        public AddCategories()
        {
            InitializeComponent();
            bAdd = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }
            if (bAdd==true)
            {
                addNewCategories();
            }
            
        }

        private void updateCategories()
        {
            
            try
            {
                command = new SqlCommand();
                command.CommandText = "UpdateCategories";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.Add("@categoryid", SqlDbType.NVarChar).Value = laID.Text;
                command.Parameters.Add("@categoryname", SqlDbType.NVarChar).Value = txtCateName.Text;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = txtDes.Text;

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                Categories owner = (Categories)this.Owner;
                owner.loadData();
                MessageBox.Show("Update Successfull!");
                this.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void addNewCategories()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "AddCategories";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@categoryname", SqlDbType.NVarChar).Value = txtCateName.Text;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = txtDes.Text;

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                Categories owner = (Categories)this.Owner;
                owner.loadData();
                MessageBox.Show("Add New Categories Successfull!");
                this.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private bool validateInput()
        {
            bool error = false;
            //Test company
            string categories = txtCateName.Text.Trim();
            if (categories.Length == 0)
            {
                errorName.SetError(txtCateName, "Please enter categories name!");
                error = true;
            }
            else
            {
                errorName.Clear();
            }
            //Test phone
            string description = txtDes.Text.Trim();
            if (description.Length == 0)
            {
                errorDescrip.SetError(txtDes, "Please enter description!");
                error = true;
            }
            else
            {
                errorDescrip.Clear();
            }
            return !error;
        }

        public void setInfo(string id, string categoryname, string description)
        {
            this.laID.Text = id;
            this.txtCateName.Text = categoryname;
            this.txtDes.Text = description;
            bAdd = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }
            if (bAdd== false)
            {
                updateCategories();
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
