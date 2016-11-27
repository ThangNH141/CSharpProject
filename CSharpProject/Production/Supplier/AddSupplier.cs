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

namespace suppliers
{
    public partial class AddSupp : Form
    {
        bool bAdd;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString);
        SqlCommand command;
        SqlDataReader reader;
        public AddSupp()
        {
            InitializeComponent();
            bAdd = true;
            loadCountry();
            loadRegion();
            bAdd = true;
        }

        private void maskedPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }
            if (bAdd==true)
            {
                addNewSupplier();
            }
            else
            {
                updateSupplier();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }
            if (bAdd == false)
            {
                updateSupplier();
            }
            
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtFax_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtPostalcode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private bool validateInput()
        {
            bool error = false;
            //Test company
            string company = txtCompany.Text.Trim();
            if (company.Length == 0)
            {
                errorCompany.SetError(txtCompany, "Please enter Company Name!");
                error = true;
            }
            else
            {
                errorCompany.Clear();
            }
            //Test contact name
            string contactName = txtContact.Text.Trim();
            if (contactName.Length == 0)
            {
                errorContactNa.SetError(txtContact, "Please enter Contact Name!");
                error = true;
            }
            else
            {
               errorContactNa.Clear();
            }
            //Test contact title
            string contactTitle = txtConTitle.Text.Trim();
            if (contactTitle.Length == 0)
            {
                errorContactTitle.SetError(txtConTitle, "Please enter Contact Title!");
                error = true;
            }
            else
            {
                errorContactTitle.Clear();
            }
            //Test address
            string address = txtAddress.Text.Trim();
            if (address.Length == 0)
            {
               errorAddress.SetError(txtAddress, "Please enter Address!");
                error = true;
            }
            else
            {
                errorAddress.Clear();
            }
            //Test city
            string city = txtCity.Text.Trim();
            if (city.Length == 0)
            {
               errorCity.SetError(txtCity, "Please enter City!");
                error = true;
            }
            else
            {
                errorCity.Clear();
            }
            //Test country
            if (cbbCountry.SelectedIndex < 0)
            {
               errorCountry.SetError(cbbCountry, "Please select Country!");
            }
            else
            {
                errorCountry.Clear();
            }
            //Test phone
            string phone = txtPhone.Text.Trim();
            if (phone.Length == 0)
            {
                errorPhone.SetError(txtPhone, "Please enter Phone!");
                error = true;
            }
            else
            {
                errorPhone.Clear();
            }
            return !error;
        }
        public void addNewSupplier()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "AddSupplier";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.Add("@companyname", SqlDbType.NVarChar).Value = txtCompany.Text;
                command.Parameters.Add("@contactname", SqlDbType.NVarChar).Value = txtContact.Text;
                command.Parameters.Add("@contacttitle", SqlDbType.NVarChar).Value = txtConTitle.Text;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text;
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = txtCity.Text;
                command.Parameters.Add("@region", SqlDbType.NVarChar).Value = cbbRegion.GetItemText(cbbRegion.SelectedItem);
                command.Parameters.Add("@postalcode", SqlDbType.NVarChar).Value = txtPostalcode.Text;
                command.Parameters.Add("@country", SqlDbType.NVarChar).Value = cbbCountry.GetItemText(cbbCountry.SelectedItem);
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = txtPhone.Text;
                command.Parameters.Add("@fax", SqlDbType.NVarChar).Value = txtFax.Text;

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                Supplier owner = (Supplier)this.Owner;
                owner.loadData();
                MessageBox.Show("Add Supplier Successfull!");
                this.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }


        public void updateSupplier()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "UpdateSupplier";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.Add("@supplierid", SqlDbType.NVarChar).Value = lblId.Text;
                command.Parameters.Add("@companyname", SqlDbType.NVarChar).Value = txtCompany.Text;
                command.Parameters.Add("@contactname", SqlDbType.NVarChar).Value = txtContact.Text;
                command.Parameters.Add("@contacttitle", SqlDbType.NVarChar).Value = txtConTitle.Text;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text;
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = txtCity.Text;
                command.Parameters.Add("@region", SqlDbType.NVarChar).Value = cbbRegion.GetItemText(cbbRegion.SelectedItem);
                command.Parameters.Add("@postalcode", SqlDbType.NVarChar).Value = txtPostalcode.Text;
                command.Parameters.Add("@country", SqlDbType.NVarChar).Value = cbbCountry.GetItemText(cbbCountry.SelectedItem);
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = txtPhone.Text;
                command.Parameters.Add("@fax", SqlDbType.NVarChar).Value = txtFax.Text;

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                Supplier owner = (Supplier)this.Owner;
                owner.loadData();
                MessageBox.Show("Update Supplier Successfull!");
                this.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void setInfo(string id, string companyname, string contactname, string contacttitle, string address, string city,
          string region, string postalcode, string country, string phone, string fax)
        {
            this.lblId.Text = id;
            this.txtCompany.Text = companyname;
            this.txtContact.Text = contactname;
            this.txtConTitle.Text = contacttitle;
            this.txtAddress.Text = address;
            this.txtCity.Text = city;
            this.cbbRegion.SelectedItem = region;
            this.txtPostalcode.Text = postalcode;
            this.cbbCountry.SelectedItem = country;
            this.txtPhone.Text = phone;
            this.txtFax.Text = fax;
            bAdd = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void loadCountry()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "LoadCountry";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbCountry.Items.Add(reader[0].ToString());
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void loadRegion()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "LoadRegion";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbRegion.Items.Add(reader[0].ToString());
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                reader.Close();
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Contitle_Click(object sender, EventArgs e)
        {

        }
    }
}
