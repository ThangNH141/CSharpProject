using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CSharpProject;

namespace CustomersShippersForm
{
    public partial class ShipperInputForm : Form
    {
        bool bAdd;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString);
        SqlCommand command;

        public ShipperInputForm()
        {
            InitializeComponent();
            bAdd = true;
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }
            if (bAdd)
            {
                addNewShipper();
            }
            else
            {
                updateShipper();
            }
        }

        private void updateShipper()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "UPDATE_SHIPPER";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.Add("@shipperid", SqlDbType.NVarChar).Value = lblId.Text;
                command.Parameters.Add("@companyname", SqlDbType.NVarChar).Value = txtCompany.Text;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = txtPhone.Text;

                connection.Open();

                command.ExecuteNonQuery();

                ShippersForm owner = (ShippersForm)this.Owner;
                owner.loadData();
                MessageBox.Show("Success!");
                this.Close();
            }
            catch (Exception ex)
            {
                ex.log();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void addNewShipper()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "ADD_SHIPPER";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@companyname", SqlDbType.NVarChar).Value = txtCompany.Text;
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = txtPhone.Text;

                connection.Open();

                command.ExecuteNonQuery();                

                ShippersForm owner = (ShippersForm)this.Owner;
                owner.loadData();
                MessageBox.Show("Success!");
                this.Close();
            }
            catch (Exception ex)
            {
                ex.log();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private bool validateInput()
        {
            bool error = false;
            //Test company
            string company = txtCompany.Text.Trim();
            if (company.Length == 0)
            {
                errCompany.SetError(txtCompany, "Please enter Company Name!");
                error = true;
            }
            else
            {
                errCompany.Clear();
            }
            //Test phone
            string phone = txtPhone.Text.Trim();
            if (phone.Length == 0)
            {
                errPhone.SetError(txtPhone, "Please enter Phone!");
                error = true;
            }
            else
            {
                errPhone.Clear();
            }
            return !error;
        }

        public void setInfo(string id, string companyname, string phone)
        {
            this.lblId.Text = id;
            this.txtCompany.Text = companyname;
            this.txtPhone.Text = phone;
            bAdd = false;
        }
    }
}
