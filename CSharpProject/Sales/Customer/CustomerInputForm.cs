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
    public partial class CustomerInputForm : Form
    {
        bool bAdd;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString);
        SqlCommand command;
        SqlDataReader reader;

        public CustomerInputForm()
        {
            InitializeComponent();
            loadCountry();
            loadRegion();
            bAdd = true;
        }

        private void txtPostalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }
            if (bAdd)
            {
                addNewCustomer();
            }
            else
            {
                updateCustomer();
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
            //Test contact name
            string contactName = txtContactName.Text.Trim();
            if (contactName.Length == 0)
            {
                errContactName.SetError(txtContactName, "Please enter Contact Name!");
                error = true;
            }
            else
            {
                errContactName.Clear();
            }
            //Test contact title
            string contactTitle = txtContactTitle.Text.Trim();
            if (contactTitle.Length == 0)
            {
                errContactTitle.SetError(txtContactTitle, "Please enter Contact Title!");
                error = true;
            }
            else
            {
                errContactTitle.Clear();
            }
            //Test address
            string address = txtAddress.Text.Trim();
            if (address.Length == 0)
            {
                errAddress.SetError(txtAddress, "Please enter Address!");
                error = true;
            }
            else
            {
                errAddress.Clear();
            }
            //Test city
            string city = txtCity.Text.Trim();
            if (city.Length == 0)
            {
                errCity.SetError(txtCity, "Please enter City!");
                error = true;
            }
            else
            {
                errCity.Clear();
            }
            //Test country
            if (cbbCountry.SelectedIndex < 0)
            {
                errCountry.SetError(cbbCountry, "Please select Country!");
            }
            else
            {
                errCountry.Clear();
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

        public void addNewCustomer()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "ADD_CUSTOMER";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.Add("@companyname", SqlDbType.NVarChar).Value = txtCompany.Text;
                command.Parameters.Add("@contactname", SqlDbType.NVarChar).Value = txtContactName.Text;
                command.Parameters.Add("@contacttitle", SqlDbType.NVarChar).Value = txtContactTitle.Text;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text;
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = txtCity.Text;
                if (cbbRegion.GetItemText(cbbRegion.SelectedItem).Length == 0)
                {
                    command.Parameters.Add("@region", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    command.Parameters.Add("@region", SqlDbType.NVarChar).Value = cbbRegion.GetItemText(cbbRegion.SelectedItem);
                }                
                if (txtPostalCode.Text.Length == 0)
                {
                    command.Parameters.Add("@postalcode", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    command.Parameters.Add("@postalcode", SqlDbType.NVarChar).Value = txtPostalCode.Text;
                }                
                command.Parameters.Add("@country", SqlDbType.NVarChar).Value = cbbCountry.GetItemText(cbbCountry.SelectedItem);
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = txtPhone.Text;
                if (txtPostalCode.Text.Length == 0)
                {
                    command.Parameters.Add("@fax", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    command.Parameters.Add("@fax", SqlDbType.NVarChar).Value = txtFax.Text;
                }                

                connection.Open();

                command.ExecuteNonQuery();

                CustomersForm owner = (CustomersForm)this.Owner;
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

        public void updateCustomer()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "UPDATE_CUSTOMER";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.Add("@custid", SqlDbType.NVarChar).Value = lblId.Text;
                command.Parameters.Add("@companyname", SqlDbType.NVarChar).Value = txtCompany.Text;
                command.Parameters.Add("@contactname", SqlDbType.NVarChar).Value = txtContactName.Text;
                command.Parameters.Add("@contacttitle", SqlDbType.NVarChar).Value = txtContactTitle.Text;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtAddress.Text;
                command.Parameters.Add("@city", SqlDbType.NVarChar).Value = txtCity.Text;
                command.Parameters.Add("@region", SqlDbType.NVarChar).Value = cbbRegion.GetItemText(cbbRegion.SelectedItem);
                command.Parameters.Add("@postalcode", SqlDbType.NVarChar).Value = txtPostalCode.Text;
                command.Parameters.Add("@country", SqlDbType.NVarChar).Value = cbbCountry.GetItemText(cbbCountry.SelectedItem);
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = txtPhone.Text;
                command.Parameters.Add("@fax", SqlDbType.NVarChar).Value = txtFax.Text;

                connection.Open();

                command.ExecuteNonQuery();

                CustomersForm owner = (CustomersForm)this.Owner;
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

        public void setInfo(string id, string companyname, string contactname, string contacttitle, string address, string city,
            string region, string postalcode, string country, string phone, string fax)
        {
            this.lblId.Text = id;
            this.txtCompany.Text = companyname;
            this.txtContactName.Text = contactname;
            this.txtContactTitle.Text = contacttitle;
            this.txtAddress.Text = address;
            this.txtCity.Text = city;
            this.cbbRegion.SelectedItem = region;
            this.txtPostalCode.Text = postalcode;
            this.cbbCountry.SelectedItem = country;
            this.txtPhone.Text = phone;
            this.txtFax.Text = fax;
            bAdd = false;
        }

        private void loadCountry()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "LOAD_COUNTRY";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbbCountry.Items.Add(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                ex.log();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
        }

        private void loadRegion()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "LOAD_REGION";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();           
                while (reader.Read())
                {
                    cbbRegion.Items.Add(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                ex.log();                
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                connection.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (bAdd)
            {
                this.txtCompany.Clear();
                this.txtContactName.Clear();
                this.txtContactTitle.Clear();
                this.txtAddress.Clear();
                this.txtCity.Clear();
                this.cbbRegion.ResetText();
                this.cbbRegion.SelectedIndex = -1;
                this.txtPostalCode.Clear();
                this.cbbCountry.ResetText();
                this.cbbCountry.SelectedIndex = -1;
                this.txtPhone.Clear();
                this.txtFax.Clear();
            }
            else
            {
                try
                {
                    command = new SqlCommand();
                    command.CommandText = "RELOAD_UPDATE_DATA";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.Add("@custid", SqlDbType.NVarChar).Value = lblId.Text;

                    connection.Open();

                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        setInfo(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                            reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(),
                            reader[10].ToString());
                    }
                }
                catch (Exception ex)
                {
                    ex.log();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}
