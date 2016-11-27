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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication2
{
    public partial class Sorder : Form
    {
        public Sorder()
        {
            InitializeComponent();
            loadOrderDetails();
        }

        private DataTable loadCBB(string tableName)
        {
            //establish connection to sqlserver
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString;
            cn.Open();
            //query statement
            String sql = "SELECT * FROM " + tableName;
            SqlCommand command = new SqlCommand(sql, cn);
            //load info to table
            SqlDataReader myDataReader;
            myDataReader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(myDataReader);
            //close all valid connection
            myDataReader.Close();
            cn.Close();

            return table;
        }
        public void loadOrderDetails()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sales.OrderDetails",
                                    @"server=(local);Database=TSQLFundamentals2008;integrated security= true");
            DataSet ds = new DataSet();
            da.Fill(ds, "Sales.OrderDetails");
            ViewOrderDetails.DataSource = ds.Tables["Sales.OrderDetails"];
            //remodify header
            ViewOrderDetails.Columns[0].HeaderText = "Order ID";
            ViewOrderDetails.Columns[1].HeaderText = "Product ID";
            ViewOrderDetails.Columns[2].HeaderText = "Unit Price";
            ViewOrderDetails.Columns[3].HeaderText = "Quantity";
            ViewOrderDetails.Columns[4].HeaderText = "Discount";

            txtSearchOrderID.DataSource = null;
            txtSearchOrderID.DataSource = loadCBB("Sales.Orders");
            txtSearchOrderID.DisplayMember = "orderid";

            txtSearchProductID.DataSource = null;
            txtSearchProductID.DataSource = loadCBB("Production.Products");
            txtSearchProductID.DisplayMember = "productid";
            txtSearchProductID.ValueMember = "productname";
            txtSearchOrderID.SelectedIndex = -1;
            txtSearchProductID.SelectedIndex = -1;
           


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void resea()
        {
            if (this.soder.Checked)
            {
                string orderID = txtSearchOrderID.Text.Trim();
                string sql = string.Format("select * from Sales.OrderDetails where orderid = '{0}'", orderID);
                SqlDataAdapter da = new SqlDataAdapter(sql,
                                      @"server=(local);Database=TSQLFundamentals2008;integrated security= true");
                DataSet ds = new DataSet();
                da.Fill(ds, "Sales.OrderDetails");

                ViewOrderDetails.DataSource = ds.Tables["Sales.OrderDetails"];
            }
            else
            {
                string productID = txtSearchProductID.Text.Trim();
                string sql = string.Format("select * from Sales.OrderDetails where productid = '{0}'", productID);
                SqlDataAdapter da = new SqlDataAdapter(sql,
                                      @"server=(local);Database=TSQLFundamentals2008;integrated security= true");
                DataSet ds = new DataSet();
                da.Fill(ds, "Sales.OrderDetails");

                ViewOrderDetails.DataSource = ds.Tables["Sales.OrderDetails"];

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            resea();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); f.Owner = this;
            f.ShowDialog();
            loadOrderDetails();

        }

        private void soder_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchOrderID.Enabled = true;
            txtSearchProductID.SelectedIndex = -1;
            txtSearchProductID.Enabled = false;

        }

        private void sproduct_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchProductID.Enabled = true;
            txtSearchOrderID.SelectedIndex = -1;
            txtSearchOrderID.Enabled = false;
       
        }
        Form2 f = new Form2(); 
        private void button3_Click(object sender, EventArgs e)
        {

            f = new Form2();
            //f.infor("10248","11","fyufy","ugiuk","jyvj");

            f.infor(ViewOrderDetails.CurrentRow.Cells[0].Value.ToString(),
                ViewOrderDetails.CurrentRow.Cells[1].Value.ToString(),
                 ViewOrderDetails.CurrentRow.Cells[2].Value.ToString(),
                  ViewOrderDetails.CurrentRow.Cells[3].Value.ToString(),
                   ViewOrderDetails.CurrentRow.Cells[4].Value.ToString());
            f.Owner = this;
            f.Show();

            loadOrderDetails();
        }
        public void reload()
        {
            f.infor(ViewOrderDetails.CurrentRow.Cells[0].Value.ToString(),
              ViewOrderDetails.CurrentRow.Cells[1].Value.ToString(),
               ViewOrderDetails.CurrentRow.Cells[2].Value.ToString(),
                ViewOrderDetails.CurrentRow.Cells[3].Value.ToString(),
                 ViewOrderDetails.CurrentRow.Cells[4].Value.ToString());
            f.Owner = this;
            f.Show();
        }
        public void ThucThiSQL1(string sql)
        {
         
            SqlDataAdapter myData = new SqlDataAdapter(sql,
                                 @"server=(local);Database=TSQLFundamentals2008;integrated security= true");

            DataSet myDataSet = new DataSet();
            myData.Fill(myDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string or = ViewOrderDetails.CurrentRow.Cells[0].Value.ToString().Trim();
            
            string pr = ViewOrderDetails.CurrentRow.Cells[1].Value.ToString().Trim();
          
            DialogResult rs = MessageBox.Show(this, "Are you sure to delete?", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                ThucThiSQL1("Delete from Sales.OrderDetails where orderid='" + or + "'AND productid='" + pr + "'");

            }
            else { }
            loadOrderDetails();
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadOrderDetails();
        }
    }
}
