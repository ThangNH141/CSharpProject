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
using Lab3;

namespace CSharpProject.Sales.Order
{
    //
    public partial class OrderForm : Form
    {
        private List<Order> _orders;
        private OrderDAO _orderDao;

        public List<Order> Orders
        {
            get { return _orders; }
        }

        private string _connectionString;
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;
        private ErrorManager _errorManager;

        public OrderForm()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString;
            _orderDao = new OrderDAO();
            _sqlConnection = new SqlConnection();
            _sqlConnection.ConnectionString = _connectionString;
            _errorManager = new ErrorManager();
            comboBoxSearchCategory.SelectedIndex = 0;
        }


        public void UpdateListView(List<Order> orders)
        {
            dataGridView.Rows.Clear();
            foreach (Order order in orders)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                //Orderid
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Orderid;
                row.Cells.Add(cell);

                //custid
//                cell = new DataGridViewTextBoxCell();
//                cell.Value = order.Orderid;
//                row.Cells.Add(cell);

                //contactname
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Contactname ?? "";
                row.Cells.Add(cell);

                //empid
                //                cell = new DataGridViewTextBoxCell();
                //                cell.Value = order.Orderid;
                //                row.Cells.Add(cell);


                //firstname
//                cell = new DataGridViewTextBoxCell();
//                cell.Value = order.Firstname;
//                row.Cells.Add(cell);

                //firstname
                //lastname
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Firstname + " " + order.Lastname;
                row.Cells.Add(cell);

                //orderdate
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Orderdate.ToString("dd-MM-yyyy");
                row.Cells.Add(cell);

                //requireddate
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Requireddate.ToString("dd-MM-yyyy");
                row.Cells.Add(cell);

                //shippeddate
                cell = new DataGridViewTextBoxCell();
                if (order.Shippeddate != null)
                    cell.Value = order.Shippeddate.Value.ToString("dd-MM-yyyy");
                else
                    cell.Value = "";
                row.Cells.Add(cell);


                //shipperid
//                cell = new DataGridViewTextBoxCell();
//                cell.Value = order.Orderid;
//                row.Cells.Add(cell);

                //shipCompanyname
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.ShipCompanyname;
                row.Cells.Add(cell);

                //freight
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Freight.ToString();
                row.Cells.Add(cell);

                //shipname
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Shipname;
                row.Cells.Add(cell);

                //shipaddress
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Shipaddress;
                row.Cells.Add(cell);

                //shipcity
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Shipcity;
                row.Cells.Add(cell);

                //shipregion
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Shipregion;
                row.Cells.Add(cell);

                //shippostalcode
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Shippostalcode;
                row.Cells.Add(cell);

                //shipcountry
                cell = new DataGridViewTextBoxCell();
                cell.Value = order.Shipcountry;
                row.Cells.Add(cell);

                dataGridView.Rows.Add(row);
            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
//            Order selectedOrder = GetSelectedOrder();
//            if (selectedOrder != null)
//            {
            EditForm form = new EditForm(FormType.add);
            form.Owner = this;
            form.Show();
//            }
        }

        private Order GetSelectedOrder()
        {
            int id = GetSelectedId();
            if (id != -1)
            {
                foreach (Order order in _orders)
                {
                    if (order.Orderid == id)
                    {
                        return order;
                    }
                }
            }
            return null;
        }

        private int GetSelectedId()
        {
            int id = -1;
            try
            {
                string rawId = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                id = Int32.Parse(rawId);
            }
            catch (Exception exception)
            {
                exception.log();
                MessageBox.Show(this, "No order selected", "Notice");
            }

            return id;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Order selectedOrder = GetSelectedOrder();
            if (selectedOrder != null)
            {
                EditForm form = new EditForm(FormType.edit);
                form.Owner = this;
                form.SetDefaultValue(selectedOrder);
                form.Show();
            }
        }

        public void DeleteOrder()
        {
        }

        private void nameSearchBtn_Click(object sender, EventArgs e)
        {
            string searchValue = customerTextBox.Text;
            try
            {
                var orders = _orderDao.SearchName(searchValue);
                UpdateListView(orders);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ex.log();
            }
        }


        private void showallBtn_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        public void LoadAll()
        {
            try
            {
                _orders = _orderDao.LoadAll();
                UpdateListView(_orders);
            }
            catch (Exception exception)
            {
                exception.log();
                MessageBox.Show(this, exception.Message);
            }
        }

        private void dateSearchBtn_Click(object sender, EventArgs e)
        {
            if (ValidateSearchTimeFields() == false)
                return;
            DateTime fromTime;
            DateTime toTime;
            GetSearchTimeRange(out fromTime, out toTime);
            List<Order> orders = new List<Order>();
            try
            {
                switch (comboBoxSearchCategory.Text)
                {
                    //Order date
                    //Required date
                    //Shipped date
                    case "Order date":
                        orders = _orderDao.SearchOrderByDate(DateCategory.Order, fromTime, toTime);
                        break;
                    case "Required date":
                        orders = _orderDao.SearchOrderByDate(DateCategory.Required, fromTime, toTime);
                        break;
                    case "Shipped date":
                        orders = _orderDao.SearchOrderByDate(DateCategory.Shipped, fromTime, toTime);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
                ex.log();
            }
            UpdateListView(orders);
        }

        private bool ValidateSearchTimeFields()
        {
            DateTime fromTime;
            DateTime toTime;
            GetSearchTimeRange(out fromTime, out toTime);

            if (fromTime.Date > toTime.Date)
            {
                _errorManager.ShowError(dateTimePickerToDate, "From date must be smaller than To date");
                return false;
            }
            else
            {
                _errorManager.Clear(dateTimePickerToDate);
                return true;
            }
        }

        private void GetSearchTimeRange(out DateTime fromTime, out DateTime toTime)
        {
            fromTime = dateTimePickerFromDate.Value;
            toTime = dateTimePickerToDate.Value;
        }


        private void dateTimePickerFromDate_ValueChanged(object sender, EventArgs e)
        {
            ValidateSearchTimeFields();
        }

        private void dateTimePickerToDate_ValueChanged(object sender, EventArgs e)
        {
            ValidateSearchTimeFields();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int orderId = GetSelectedId();
            DialogResult dr = MessageBox.Show(this, @"Are you sure you want to delete selected Order",
                @"Delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (new OrderDAO().HaveOrderDetail(orderId))
                {
                    MessageBox.Show(this, @"Can't delete selected Order due to other Order detail's reference ",
                        @"Notice", MessageBoxButtons.YesNo);
                    return;
                }
                else
                {
                    new OrderDAO().DeleteOrder(orderId);
                    LoadAll();
                }
            }
        }
    }
}