using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGroup
{
    public partial class Categories : Form
    {
      
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString);
        SqlCommand command;
        SqlDataReader reader;
        public Categories()
        {
           
            
            InitializeComponent();
            loadData();
           
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            AddCategories frm = new AddCategories();
            frm.ShowDialog(this);
        }

       

        
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select Categories!");
                return;
            }
            DataGridViewRow r = dgvCategories.SelectedRows[0];
           AddCategories frm = new AddCategories();
            frm.setInfo(r.Cells["clmID"].Value.ToString(), r.Cells["clmCategoryName"].Value.ToString(),
                r.Cells["clmDescription"].Value.ToString());
            frm.ShowDialog(this);
        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        public void loadData()
        {
            try
            {
                command = new SqlCommand();
                command.CommandText = "LoadCategories";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();
                dgvCategories.Rows.Clear();
                while (reader.Read())
                {
                    dgvCategories.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
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

        

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select Category!");
                return;
            }
            DataGridViewRow r = dgvCategories.SelectedRows[0];

            try
            {
                command = new SqlCommand();
                command.CommandText = "DeleteCategories";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@categoryid", SqlDbType.NVarChar).Value = r.Cells["clmID"].Value.ToString();

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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvCategories.Rows.Clear();
            loadData();
        }

        private void btnSreach_Click(object sender, EventArgs e)
        {
            
            try
            {
                command = new SqlCommand();
               
                    command.CommandText = "SearchCategories";
                    command.Parameters.Add("@value", SqlDbType.NVarChar).Value = txtSearch.Text;
                
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();

                reader = command.ExecuteReader();
                dgvCategories.Rows.Clear();
                while (reader.Read())
                {
                    dgvCategories.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                }
                reader.Close();
                connection.Close();
                txtSearch.Clear();
            }
            catch (Exception ex)
            {
                reader.Close();
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
