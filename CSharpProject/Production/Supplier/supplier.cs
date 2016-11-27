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

namespace suppliers
{
    public partial class Supplier : Form

    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString);
        SqlCommand command;
        SqlDataReader reader;
        public Supplier()
        {
            InitializeComponent();
            loadData();
            loadCombobox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSupp frm = new AddSupp();
            frm.Owner = this;
            frm.ShowDialog();
        }//new

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbSearchType.SelectedIndex)
            {
                case 0:
                    searchInfo = "companyname";
                    break;
                case 1:
                    searchInfo = "contactname";
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvSupplier.Rows.Clear();
            loadData();
        }

        public void loadData()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "LoadSuppliers";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();
                dgvSupplier.Rows.Clear();
                while (reader.Read())
                {
                    dgvSupplier.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                        reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(),
                        reader[10].ToString());
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

        private void loadCombobox()
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
                    cbbSearchBy.Items.Add(reader[0].ToString());
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select Supplier!");
                return;
            }
            DataGridViewRow r = dgvSupplier.SelectedRows[0];
            AddSupp frm = new AddSupp();
            frm.setInfo(r.Cells["clmId"].Value.ToString(), r.Cells["clmCompanyName"].Value.ToString(), r.Cells["clmContactName"].Value.ToString(),
                 r.Cells["clmContactTitle"].Value.ToString(), r.Cells["clmAddress"].Value.ToString(), r.Cells["clmCity"].Value.ToString(),
                 r.Cells["clmRegion"].Value.ToString(), r.Cells["clmPostalCode"].Value.ToString(), r.Cells["clmCountry"].Value.ToString(),
                 r.Cells["clmPhone"].Value.ToString(), r.Cells["clmFax"].Value.ToString());
            frm.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select Supplier!");
                return;
            }
            DataGridViewRow r = dgvSupplier.SelectedRows[0];

            try
            {
                command = new SqlCommand();
                command.CommandText = "DeleteSupplier";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@supplierid", SqlDbType.NVarChar).Value = r.Cells["clmId"].Value.ToString();

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
                loadData();
                MessageBox.Show("Delete Successfull!");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                command = new SqlCommand();
                command.CommandText = "SreachCountry";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@value", SqlDbType.NVarChar).Value = cbbSearchBy.GetItemText(cbbSearchBy.SelectedItem);

                connection.Open();

                reader = command.ExecuteReader();
                dgvSupplier.Rows.Clear();
                while (reader.Read())
                {
                   dgvSupplier.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                        reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(),
                        reader[10].ToString());
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


    
        string searchInfo = "";
        private void btnSreach_Click(object sender, EventArgs e)
        {
            if (searchInfo == "")
            {
                MessageBox.Show("Please select search type!");
                return;
            }
            try
            {
                command = new SqlCommand();
                if (searchInfo == "companyname")
                {
                    command.CommandText = "SearchCompany";
                }
                else
                {
                    command.CommandText = "SearchContactName";
                }
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@value", SqlDbType.NVarChar).Value = txtSreach.Text;

                connection.Open();

                reader = command.ExecuteReader();
                dgvSupplier.Rows.Clear();
                while (reader.Read())
                {
                    dgvSupplier.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),
                        reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(),
                        reader[10].ToString());
                }
                reader.Close();
                connection.Close();
               txtSreach.Clear();
            }
            catch (Exception ex)
            {
                reader.Close();
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
