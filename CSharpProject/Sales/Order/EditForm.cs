using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3;
using ProjectGroup;

namespace CSharpProject.Sales.Order
{
    public partial class EditForm : Form
    {
        private Order _orderDefault;
        private Order _order;
        private ErrorManager _errorManager;
        private FormType _formType;
        //todo check validate when not touch the field
        //todo fix buggy Shipper and EmpName
        //TODO buggy error provider of shipper
        public EditForm(FormType type)
        {
            InitializeComponent();
            _errorManager = new ErrorManager();
            _formType = type;
            if (type == FormType.edit)
            {
                this.Text = "Edit Form";
                this.titleLabel.Text = "EDIT";
                this.editBtn.Text = "Edit";
            }
            else
            {
                this.Text = "Add form";
                this.titleLabel.Text = "ADD";
                this.editBtn.Text = "Add";
            }

            shippedDateTimePicker.Format = DateTimePickerFormat.Custom;
            shippedDateTimePicker.CustomFormat = " ";
        }

        public void SetDefaultValue(Order order)
        {
            _orderDefault = order.Clone() as Order;
            _order = order;
            SetInput(_order);
        }

        public void UpdateOrder()
        {
            if (_errorManager.IsAnyHavingError() == false)
            {
                Order order = GetOrder();

                if (order != null)
                {
                    order.Orderid = _orderDefault.Orderid;
                    new OrderDAO().UpdateOrder(order);
                }
            }
        }

        public void AddOrder()
        {
            if (_errorManager.IsAnyHavingError() == false)
            {
                Order order = GetOrder();
                if (order != null)
                {
                    new OrderDAO().AddOrder(order);
                }
            }
        }

        public void ClearInput()
        {
            customerComboBox.Text = "";
            employeeComboBox.Text = "";
            orderDateTimePicker.Value = DateTime.Now;
            requiredDateTimePicker.Value = DateTime.Now;
            shippedDateTimePicker.Value = DateTime.Now;
            shippedDateTimePicker.CustomFormat = " ";
            freightTextBox.Text = @"0";
            shipperComboBox.Text = "";
            shipnameTextBox.Text = "";
            shipaddressTextBox.Text = "";
            shipcityTextBox.Text = "";
            shipregionTextBox.Text = "";
            shippostalcodeTextBox.Text = "";
            shipCountryTextBox.Text = "";

            UpdateSuggestedCustomer("");
            UpdateSuggestedEmployee("");
            UpdateSuggestedShipper("");
        }

        public void SetInput(Order order)
        {
            customerComboBox.Text = order.Contactname;
            employeeComboBox.Text = order.Firstname + " " + _order.Lastname;
            orderDateTimePicker.Value = order.Orderdate;
            requiredDateTimePicker.Value = order.Requireddate;
            if (order.Shippeddate != null)
            {
                shippedDateTimePicker.Value = order.Shippeddate.Value;
            }
            else
            {
                shippedDateTimePicker.Format = DateTimePickerFormat.Custom;
                shippedDateTimePicker.CustomFormat = " ";
            }
            freightTextBox.Text = order.Freight.ToString();
            shipperComboBox.Text = order.ShipCompanyname;
            shipnameTextBox.Text = order.Shipname;
            shipaddressTextBox.Text = order.Shipaddress;
            shipcityTextBox.Text = order.Shipcity;
            shipregionTextBox.Text = order.Shipregion;
            shippostalcodeTextBox.Text = order.Shippostalcode;
            shipCountryTextBox.Text = order.Shipcountry;

            UpdateSuggestedCustomer("");
            UpdateSuggestedEmployee("");
            UpdateSuggestedShipper("");
        }

//        private Order GetOrder()
//        {
//            Order order = new Order();
//            order.Contactname = customerComboBox.SelectedValue.ToString();
//            return order;
//        }

        private void UpdateSuggestedCustomer(string value, bool dropdown = false)
        {
            List<Order> orders = GetOrders();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            foreach (Order order in orders)
            {
                if (order.Custid != null)
                {
                    if (order.Contactname.ToUpper().StartsWith(value.ToUpper()))
                    {
                        if (!dic.ContainsKey(order.Custid.Value))
                            dic.Add(order.Custid.Value, order.Contactname);
                    }
                }
            }

            if (dic.Any())
            {
                customerComboBox.DataSource = new BindingSource(dic, null);
                customerComboBox.ValueMember = "Key";
                customerComboBox.DisplayMember = "Value";
            }

            customerComboBox.DroppedDown = dropdown;
            customerComboBox.Text = value;
            customerComboBox.SelectionStart = value.Length;
        }

        private void UpdateSuggestedEmployee(string value, bool dropdown = false)
        {
            List<Order> orders = GetOrders();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            foreach (Order order in orders)
            {
                if (order.EmpName.ToUpper().StartsWith(value.ToUpper()))
                {
                    if (!dic.ContainsKey(order.Empid))
                        dic.Add(order.Empid, order.EmpName);
                }
            }

            if (dic.Any())
            {
                employeeComboBox.DataSource = new BindingSource(dic, null);
                employeeComboBox.ValueMember = "Key";
                employeeComboBox.DisplayMember = "Value";
            }

            employeeComboBox.DroppedDown = dropdown;
            employeeComboBox.Text = value;
            employeeComboBox.SelectionStart = value.Length;
        }

        private void UpdateSuggestedShipper(string value, bool dropdown = false)
        {
            List<Order> orders = GetOrders();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            foreach (Order order in orders)
            {
                if (order.ShipCompanyname.ToUpper().StartsWith(value.ToUpper()))
                {
                    if (!dic.ContainsKey(order.Shipperid))
                        dic.Add(order.Shipperid, order.ShipCompanyname);
                }
            }

            if (dic.Any())
            {
                shipperComboBox.DataSource = new BindingSource(dic, null);
                shipperComboBox.ValueMember = "Key";
                shipperComboBox.DisplayMember = "Value";
            }

            shipperComboBox.DroppedDown = dropdown;
            shipperComboBox.Text = value;
            shipperComboBox.SelectionStart = value.Length;
        }

        private void ValidateCustomer()
        {
            //Can null
            string text = customerComboBox.Text;
            if (string.IsNullOrWhiteSpace(text) == false)
            {
                var list =
                    from order in GetOrders()
                    where order.Contactname.Equals(text)
                    select order;
                if (list.Any())
                {
                    _errorManager.Clear(customerComboBox);
                }
                else
                {
                    _errorManager.ShowError(customerComboBox, "Customer not exist");
                }
            }
        }

        private void ValidateEmployee()
        {
            //Can null
            string text = employeeComboBox.Text;
            if (string.IsNullOrWhiteSpace(text) == false)
            {
                var list =
                    from order in GetOrders()
                    where order.EmpName.Equals(text)
                    select order;
                if (list.Any())
                {
                    _errorManager.Clear(employeeComboBox);
                }
                else
                {
                    _errorManager.ShowError(employeeComboBox, "Employee not exist");
                }
            }
            else
            {
                _errorManager.ShowError(employeeComboBox, "Employee can't be empty");
            }
        }

        private void ValidateRequiredDate()
        {
            DateTime orderTime = orderDateTimePicker.Value;
            DateTime requiredTime = requiredDateTimePicker.Value;

            if (requiredTime.Date < orderTime.Date)
            {
                _errorManager.ShowError(requiredDateTimePicker, "Required date must be after Order date");
            }
            else
            {
                _errorManager.Clear(requiredDateTimePicker);
            }
        }

        private void ValidateShippedDate()
        {
            DateTime orderTime = orderDateTimePicker.Value;
            DateTime shippedTime = shippedDateTimePicker.Value;

            if (shippedDateTimePicker.CustomFormat.Equals(" ") == false)
            {
                if (shippedTime.Date < orderTime.Date)
                {
                    _errorManager.ShowError(shippedDateTimePicker, "Shipped date must be after Order date");
                }
                else
                {
                    _errorManager.Clear(shippedDateTimePicker);
                }
            }
        }

        private void ValidateFreight()
        {
            string text = freightTextBox.Text;
            try
            {
                Decimal dec = Decimal.Parse(text);
                if (dec.CompareTo(Decimal.Zero) < 0)
                {
                    _errorManager.ShowError(freightTextBox, "Can't be negative");
                }
                else
                {
                    _errorManager.Clear(freightTextBox);
                }
            }
            catch (Exception)
            {
                _errorManager.ShowError(freightTextBox, "Invalid decimal");
            }
        }

        private void ValidateShipper()
        {
            string text = shipperComboBox.Text;
            if (string.IsNullOrWhiteSpace(text) == false)
            {
                var list =
                    from order in GetOrders()
                    where order.ShipCompanyname.Equals(text)
                    select order;
                if (list.Any())
                {
                    _errorManager.Clear(shipperComboBox);
                }
                else
                {
                    _errorManager.ShowError(shipperComboBox, "Shipper not exist");
                }
            }
            else
            {
                _errorManager.ShowError(shipperComboBox, "Shipper can't be empty");
            }
        }

        private void ValidateShipName()
        {
            string text = shipnameTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                _errorManager.ShowError(shipnameTextBox, "Ship name can't be empty");
            }
            else
            {
                if (text.Length > 40)
                {
                    _errorManager.ShowError(shipnameTextBox, "Ship name can't be over 40 characters");
                }
                else
                {
                    _errorManager.Clear(shipperComboBox);
                }
            }
        }

        private void ValidateShipAddress()
        {
            string text = shipaddressTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                _errorManager.ShowError(shipaddressTextBox, "Ship address can't be empty");
            }
            else
            {
                if (text.Length > 60)
                {
                    _errorManager.ShowError(shipaddressTextBox, "Ship address can't be over 60 characters");
                }
                else
                {
                    _errorManager.Clear(shipaddressTextBox);
                }
            }
        }

        private void ValidateShipCity()
        {
            string text = shipcityTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                _errorManager.ShowError(shipcityTextBox, "Ship city can't be empty");
            }
            else
            {
                if (text.Length > 15)
                {
                    _errorManager.ShowError(shipcityTextBox, "Ship city can't be over 15 characters");
                }
                else
                {
                    _errorManager.Clear(shipcityTextBox);
                }
            }
        }

        private void ValidateShipRegion()
        {
            string text = shipregionTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                // can be empty
            }
            else
            {
                if (text.Length > 15)
                {
                    _errorManager.ShowError(shipregionTextBox, "Ship region can't be over 15 characters");
                }
                else
                {
                    _errorManager.Clear(shipregionTextBox);
                }
            }
        }

        private void ValidateShipPostalCode()
        {
            string text = shippostalcodeTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                // can be empty
            }
            else
            {
                if (text.Length > 10)
                {
                    _errorManager.ShowError(shippostalcodeTextBox, "Ship postal code can't be over 10 characters");
                }
                else
                {
                    _errorManager.Clear(shippostalcodeTextBox);
                }
            }
        }

        private void ValidateShipCountry()
        {
            string text = shipCountryTextBox.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                _errorManager.ShowError(shipCountryTextBox, "Ship country can't be empty");
            }
            else
            {
                if (text.Length > 15)
                {
                    _errorManager.ShowError(shipCountryTextBox, "Ship country can't be over 15 characters");
                }
                else
                {
                    _errorManager.Clear(shipCountryTextBox);
                }
            }
        }


        private void shippedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            shippedDateTimePicker.Format = DateTimePickerFormat.Custom;
            shippedDateTimePicker.CustomFormat = @"dd/MM/yyyy";

            ValidateShippedDate();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (_orderDefault == null)
            {
                ClearInput();
            }
            else
            {
                SetDefaultValue(_orderDefault);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            ValidateCustomer();
            ValidateEmployee();
            ValidateRequiredDate();
            ValidateShippedDate();
            ValidateFreight();
            ValidateShipper();
            ValidateShipName();
            ValidateShipAddress();
            ValidateShipCity();
            ValidateShipRegion();
            ValidateShipPostalCode();
            ValidateShipCountry();

            switch (_formType)
            {
                case FormType.add:
                    AddOrder();
                    (Owner as OrderForm)?.LoadAll();
                    break;
                case FormType.edit:
                    UpdateOrder();
                    (Owner as OrderForm)?.LoadAll();
                    break;
            }
        }

        private Order GetOrder()
        {
            Order order = null;

            try
            {
                int? custId = null;
                string contractName = null;
                if (string.IsNullOrWhiteSpace(customerComboBox.Text) == false)
                {
                    custId = (int) customerComboBox.SelectedValue;
                    contractName = customerComboBox.SelectedText;
                }

                int empId = (int) employeeComboBox.SelectedValue;
                var list =
                    from orderTmp in GetOrders()
                    where orderTmp.Empid.Equals(empId)
                    select orderTmp;
                string firstName = list.First().Firstname;
                string lastName = list.First().Lastname;
                DateTime orderDateTime = orderDateTimePicker.Value;
                DateTime requireDateTime = requiredDateTimePicker.Value;
                DateTime? shippedDateTime = null;
                if (shippedDateTimePicker.CustomFormat.Equals(" "))
                {
                    shippedDateTime = shippedDateTimePicker.Value;
                }

                Decimal freight = Decimal.Parse(freightTextBox.Text);
                int shipperId = (int) shipperComboBox.SelectedValue;
                string shipCompanyName = shipperComboBox.Text;
                string shipName = shipnameTextBox.Text;
                string shipAddress = shipaddressTextBox.Text;
                string shipCity = shipcityTextBox.Text;
                string shipRegion = shipregionTextBox.Text;
                if (string.IsNullOrWhiteSpace(shipRegion))
                {
                    shipRegion = null;
                }
                string shipPostalCode = shippostalcodeTextBox.Text;
                if (string.IsNullOrWhiteSpace(shipPostalCode))
                {
                    shipPostalCode = null;
                }
                string shipCountry = shipCountryTextBox.Text;

                order = new Order(contractName, custId, empId, firstName, freight, lastName,
                    orderDateTime, requireDateTime, shipAddress, shipCity, shipCompanyName,
                    shipCountry, shipName, shippedDateTime, shipperId, shipPostalCode, shipRegion);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, "Invalid input");
                exception.log();
            }
            return order;
        }

        private void employeeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateSuggestedEmployee(employeeComboBox.Text, true);
        }

        private List<Order> GetOrders()
        {
            OrderForm orderForm = Owner as OrderForm;
            Debug.WriteIf(orderForm == null, "Order");
            return orderForm?.Orders;
        }


        private void customerComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateSuggestedCustomer(customerComboBox.Text, true);
        }

        private void shipperComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateSuggestedShipper(shipperComboBox.Text, true);
        }

        private void requiredDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ValidateRequiredDate();
            ValidateShippedDate();
        }

        private void customerComboBox_Leave(object sender, EventArgs e)
        {
            ValidateCustomer();
        }

        private void employeeComboBox_Leave(object sender, EventArgs e)
        {
            ValidateEmployee();
        }

        private void freightTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFreight();
        }

        private void shipperComboBox_Leave(object sender, EventArgs e)
        {
            ValidateShipper();
        }

        private void shipnameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateShipName();
        }

        private void shipaddressTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateShipAddress();
        }

        private void shipcityTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateShipCity();
        }

        private void shipregionTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateShipRegion();
        }

        private void shippostalcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateShipPostalCode();
        }

        private void shipCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateShipCountry();
        }

        private void orderDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ValidateRequiredDate();
            ValidateShippedDate();
        }
    }

    public enum FormType
    {
        edit,
        add
    }
}