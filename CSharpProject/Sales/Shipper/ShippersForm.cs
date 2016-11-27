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
    public partial class ShippersForm : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString);
        SqlCommand command;
        SqlDataReader reader;

        public ShippersForm()
        {
            InitializeComponent();
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShipperInputForm frm = new ShipperInputForm();
            frm.ShowDialog(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvShippers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select Customer!");
                return;
            }
            DataGridViewRow r = dgvShippers.SelectedRows[0];
            ShipperInputForm frm = new ShipperInputForm();
            frm.setInfo(r.Cells["clmId"].Value.ToString(), r.Cells["clmCompanyName"].Value.ToString(),
                r.Cells["clmPhone"].Value.ToString());
            frm.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvShippers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select Customer!");
                return;
            }
            DataGridViewRow r = dgvShippers.SelectedRows[0];

            try
            {
                command = new SqlCommand();
                command.CommandText = "DELETE_SHIPPER";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@shipperid", SqlDbType.NVarChar).Value = r.Cells["clmId"].Value.ToString();

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

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            dgvShippers.Rows.Clear();
            loadData();
        }

        public void loadData()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "LOAD_SHIPPERS";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();
                dgvShippers.Rows.Clear();
                while (reader.Read())
                {
                    dgvShippers.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
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
            txtSearchValue.Clear();
            txtSearchValueNumber.Clear();
            switch (cbbSearchType.SelectedIndex)
            {

                case 0:
                    searchType = "companyname";
                    txtSearchValue.Visible = true;
                    txtSearchValueNumber.Visible = false;
                    break;
                case 1:
                    searchType = "phone";
                    txtSearchValue.Visible = false;
                    txtSearchValueNumber.Visible = true;
                    break;
            }
        }

        private void txtSearchValue_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSearchValueNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
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
                    command.CommandText = "SEARCH_SHIPPER_BY_COMPANYNAME";
                    command.Parameters.Add("@value", SqlDbType.NVarChar).Value = txtSearchValue.Text;
                }
                else
                {
                    command.CommandText = "SEARCH_SHIPPER_BY_PHONE";
                    command.Parameters.Add("@value", SqlDbType.NVarChar).Value = txtSearchValueNumber.Text;
                }
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;                

                connection.Open();

                reader = command.ExecuteReader();
                dgvShippers.Rows.Clear();
                while (reader.Read())
                {
                    dgvShippers.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
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
    }
}
