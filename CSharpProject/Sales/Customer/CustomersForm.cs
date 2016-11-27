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
    public partial class CustomersForm : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString);
        SqlCommand command;
        SqlDataReader reader;
        

        public CustomersForm()
        {
            InitializeComponent();
            loadData();
            loadCombobox();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CustomerInputForm frm = new CustomerInputForm();
            frm.ShowDialog(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select Customer!");
                return;
            }
            DataGridViewRow r = dgvCustomers.SelectedRows[0];
            CustomerInputForm frm = new CustomerInputForm();
            frm.setInfo(r.Cells["clmId"].Value.ToString(), r.Cells["clmCompanyName"].Value.ToString(), r.Cells["clmContactName"].Value.ToString(),
                r.Cells["clmContactTitle"].Value.ToString(), r.Cells["clmAddress"].Value.ToString(), r.Cells["clmCity"].Value.ToString(),
                r.Cells["clmRegion"].Value.ToString(), r.Cells["clmPostalCode"].Value.ToString(), r.Cells["clmCountry"].Value.ToString(),
                r.Cells["clmPhone"].Value.ToString(), r.Cells["clmFax"].Value.ToString());
            frm.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select Customer!");
                return;
            }
            DataGridViewRow r = dgvCustomers.SelectedRows[0];

            try
            {
                command = new SqlCommand();
                command.CommandText = "DELETE_CUSTOMER";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@custid", SqlDbType.NVarChar).Value = r.Cells["clmId"].Value.ToString();

                connection.Open();

                command.ExecuteNonQuery();
                
                loadData();
                MessageBox.Show("Success!");
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

        public void loadData()
        {
            try
            {
                command = new SqlCommand();    
                command.CommandText = "LOAD_DATA";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                
                connection.Open();

                reader = command.ExecuteReader();
                dgvCustomers.Rows.Clear();
                while (reader.Read())
                {
                    dgvCustomers.Rows.Add(reader[0].ToString() ,reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
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

        string searchType = "";

        private void cbbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbSearchType.SelectedIndex)
            {
                case 0:
                    searchType = "companyname";
                    break;
                case 1:
                    searchType = "contactname";
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchType == "")
            {
                MessageBox.Show("Please select search type!");
                return;
            }
            try
            {
                command = new SqlCommand();
                if (searchType == "companyname")
                {
                    command.CommandText = "SEARCH_CUSTOMER_BY_COMPANYNAME";
                }
                else
                {
                    command.CommandText = "SEARCH_CUSTOMER_BY_CONTACTNAME";
                }
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@value", SqlDbType.NVarChar).Value = txtSearchValue.Text;

                connection.Open();

                reader = command.ExecuteReader();
                dgvCustomers.Rows.Clear();
                while (reader.Read())
                {
                    dgvCustomers.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                        reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(),
                        reader[10].ToString());
                }
                txtSearchValue.Clear();
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvCustomers.Rows.Clear();
            loadData();
        }

        private void loadCombobox()
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
                    cbbSearchByCountry.Items.Add(reader[0].ToString());
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

        private void cbbSearchByCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "SEARCH_CUSTOMER_BY_COUNTRY";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@value", SqlDbType.NVarChar).Value = cbbSearchByCountry.GetItemText(cbbSearchByCountry.SelectedItem);

                connection.Open();

                reader = command.ExecuteReader();
                dgvCustomers.Rows.Clear();
                while (reader.Read())
                {
                    dgvCustomers.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
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
