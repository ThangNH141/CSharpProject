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
    public partial class Form2 : Form
    {
        bool up = false;
        SqlConnection conn;
        public Form2()
        {
            InitializeComponent();
            
            txtSearchOrderID.DataSource = null;
            txtSearchOrderID.DataSource = loadCBB("Sales.Orders");
            txtSearchOrderID.DisplayMember = "orderid";

            txtSearchProductID.DataSource = null;
            txtSearchProductID.DataSource = loadCBB("Production.Products");
            txtSearchProductID.DisplayMember = "productid";
            txtSearchProductID.ValueMember = "productname";
            reset();


        }
        void reset()
        {
            txtProductName.Text = "";

            txtSearchOrderID.SelectedIndex = -1;
            txtSearchProductID.SelectedIndex = -1;


        }
        public void info(string orderId, string proID, string unitp, string discount)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
        public static decimal Parse(string input)
        {
            return decimal.Parse(Regex.Replace(input, @"[^\d.]", ""));
        }
        public void infor(string oID,string oPr,string uP,string qua,string dis)
        {
            txtSearchOrderID.Text = oID;
            int price = int.Parse(oPr.Replace(",", "."));
            txtSearchProductID.Text = price.ToString();
            decimal nup = Parse(uP);
            Unitp.Text = nup.ToString();
            Quality.Text = qua;
            Dis.Text = dis;
            txtSearchOrderID.Enabled= false;
            txtSearchProductID.Enabled = false;
           txtProductName.Text = txtSearchProductID.SelectedValue.ToString();
            txtProductName.Enabled = false;
            up = true;
        }
     int el = 0;
        private void txtSearchProductID_SelectedIndexChanged(object sender, EventArgs e)
         {

            }

        private void txtSearchOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchProductID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (el >2)
            {
                txtProductName.Text = txtSearchProductID.SelectedValue.ToString();
            }
            el =el+1;
        }

        private void button2_Click(object sender, EventArgs e)
        {if (up == true)
            {
                Sorder f = (Sorder)this.Owner;
                f.reload();
            }
            else {
                el = 2;
                reset(); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (hople())
            {
                if (up == false)
                {
                    using (SqlConnection connection = new SqlConnection(@"server=(local);Database=TSQLFundamentals2008;integrated security= true"))
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;            // <== lacking
                            command.CommandType = CommandType.Text;
                            command.CommandText = "INSERT into Sales.OrderDetails (orderid, productid, unitprice, qty, discount) VALUES (@orderid, @productid, @unitprice, @qty, @discount)";
                            command.Parameters.AddWithValue("@orderid", txtSearchOrderID.Text);
                            command.Parameters.AddWithValue("@productid", txtSearchProductID.Text);
                            command.Parameters.AddWithValue("@unitprice", Unitp.Text);
                            command.Parameters.AddWithValue("@qty", Quality.Text);
                            command.Parameters.AddWithValue("@discount", Dis.Text);


                            try
                            {
                                connection.Open();
                                int recordsAffected = command.ExecuteNonQuery();
                            }
                            catch (SqlException)
                            {
                                // error here
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(@"server=(local);Database=TSQLFundamentals2008;integrated security= true"))
                    {
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = connection;            // <== lacking
                            command.CommandType = CommandType.Text;
                            command.CommandText = "Update Sales.OrderDetails  set unitprice=@unitprice, qty=@qty, discount=@discount where orderid=@orderid AND productid=@productid";
                            command.Parameters.AddWithValue("@orderid", txtSearchOrderID.Text);
                            command.Parameters.AddWithValue("@productid", txtSearchProductID.Text);
                            command.Parameters.AddWithValue("@unitprice", Unitp.Text);
                            command.Parameters.AddWithValue("@qty", Quality.Text);
                            command.Parameters.AddWithValue("@discount", Dis.Text);


                            try
                            {
                                connection.Open();
                                int recordsAffected = command.ExecuteNonQuery();
                            }
                            catch (SqlException)
                            {
                                // error here
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }

                }
               Sorder f = (Sorder)this.Owner;
                f.loadOrderDetails();
                Close();
                
            }

        }
        

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Quality_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) && e.KeyCode != Keys.Back)
                e.SuppressKeyPress = true;
        }

        private void Dis_KeyDown(object sender, KeyEventArgs e)
        {
        }
        bool hople()
        {
            bool h = true;
           
            string s = @"(^[0])+[.]+([0-9]{3})$";
            Regex re = new Regex(s);
            if (!re.IsMatch(Dis.Text))
            {
                h = false;
                errorProvider1.SetError(Dis, "This style is 0.000");
            }
            s= @"^[0-9]+[.]+([0-9]{4})$";
            re = new Regex(s);
            if (!re.IsMatch(Unitp.Text))
            {
                h = false;
                errorProvider1.SetError(Unitp, "This style is ..0.0000");
            }
            if (Unitp.Text == "")
            {
                h = false;
                errorProvider1.SetError(Unitp, "Input please");
            }
            if (Dis.Text == "")
            {
                h = false;
                errorProvider1.SetError(Dis, "Input please");
            }
            if (Quality.Text=="")
            {
                h = false;
                errorProvider1.SetError(Quality, "Input please");
            }
            if (Quality.Text == "")
            {
                h = false;
                errorProvider1.SetError(Quality, "Input please");
            }
            else { Quality.Text = Parse(Quality.Text).ToString();
                if (Parse(Quality.Text) == 0)
                {
                    h = false;
                    errorProvider1.SetError(Quality, "quality is more than 0");
                }
            }
           

            if (txtSearchOrderID.SelectedIndex==-1)
            {
                h = false;
                errorProvider1.SetError(txtSearchOrderID, "please chose one");
            }
            if (txtSearchProductID.SelectedIndex == -1)
            {
                h = false;
                errorProvider1.SetError(txtSearchProductID, "please chose one");
            }

            return h;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }

}
