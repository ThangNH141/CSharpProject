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


namespace Employees
{
    public partial class InputForm : Form
    {
        bool bAdd = true;
        SqlConnection con;
        SqlCommand cmd;
        frmEmployees frm;
        List<Employee> datalist;
        Employee employee;
        
        public List<Employee> Datalist
        {
            get
            {
                return datalist;
            }

            set
            {
                datalist = value;
            }
        }

        public Employee Employee
        {
            get
            {
                return employee;
            }

            set
            {
                employee = value;
            }
        }

        public InputForm()
        {
            InitializeComponent();
            cbCountry.SelectedIndex = 0;
            cbTOC.SelectedIndex = 0;

            con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (bAdd == true)
            {
                txtAddress.Clear();
                txtCity.Clear();
                txtFirstname.Clear();
                txtLastname.Clear();
                cbMgrID.SelectedIndex = 0;
                txtPostalCode.Clear();
                txtRegion.Clear();
                txtTitle.Clear();
                dtBirthdate.ResetText();
                dtHiredate.ResetText();
                cbCountry.SelectedIndex = 0;
                cbTOC.SelectedIndex = 0;
                mtxtPhone.Clear();
            } else
            {
                setInfo();
            }
            
        }

        //end reset


        bool validateInput()
        {
            bool check = true;

            // Firstname
            if (txtFirstname.Text.Trim().Length == 0)
            {
                erFirstname.SetError(txtFirstname, "Please enter firstname");
                check = false;
            }
            else
            {
                erFirstname.Clear();
            }

            // Lastname
            if (txtLastname.Text.Trim().Length == 0)
            {
                erLastname.SetError(txtLastname, "Please enter lastname");
                check = false;
            }
            else
            {
                erLastname.Clear();
            }

            // Title
            if (txtTitle.Text.Trim().Length == 0)
            {
                erTitle.SetError(txtTitle, "Please enter Title");
                check = false;
            }
            else
            {
                erTitle.Clear();
            }

            // TOC
            if (cbTOC.SelectedIndex == 0)
            {
                erTOC.SetError(cbTOC, "Please choose TOC");
                check = false;
            }
            else
            {
                erTOC.Clear();
            }

            // Birthdate
            DateTime now = DateTime.Now;
            DateTime hiredate = dtHiredate.Value;
            DateTime bd = dtBirthdate.Value;
            if ((hiredate.Year - bd.Year) < 18)
            {
                erBD.SetError(dtBirthdate, "Your age must greater than 18");
                check = false;
            }
            else
            {
                erBD.Clear();
            }

            // Hiredate
            if (now < dtHiredate.Value)
            {
                erHiredate.SetError(dtHiredate, "Please choose hiredate");
                check = false;
            }
            else
            {
                erHiredate.Clear();
            }

            // Address
            if (txtAddress.Text.Trim().Length == 0)
            {
                erAddress.SetError(txtAddress, "Please enter address");
                check = false;
            }
            else
            {
                erAddress.Clear();
            }

            // City
            if (txtCity.Text.Trim().Length == 0)
            {
                erCity.SetError(txtCity, "Please enter city");
                check = false;
            }
            else
            {
                erCity.Clear();
            }

            // country
            if (cbCountry.SelectedIndex == 0)
            {
                erCounty.SetError(cbCountry, "Please choose your country");
                check = false;
            }
            else
            {
                erCounty.Clear();
            }

            // Phone
            Console.WriteLine(mtxtPhone.Text.Trim());
            if (mtxtPhone.Text.Trim() == "")
            {             
                erPhone.SetError(mtxtPhone, "Please enter yourphone");
                check = false;
            }
            else
            {
                erPhone.Clear();
            }

            return check;
        }

        //end validate

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateInput() == false)
            {
                return;
            }
            else if (bAdd == true)
            {
                AddNewEmployee();
            }
            else
            {
                UpdateEmployee();
            }
        }
        // end btnadd

        public void setMgrID()
        {
            cbMgrID.Items.Add("");
            foreach (Employee emp in datalist)
            {
                cbMgrID.Items.Add(emp.Id);
            }
            cbMgrID.SelectedIndex = 0;
        }
        //end setMgrID

        private void AddNewEmployee()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "[InsertEmployees]";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameterCollection paramCollection = cmd.Parameters;
                
                paramCollection.Add("@Lastname", SqlDbType.NVarChar, 20);
                paramCollection.Add("@Firstname", SqlDbType.NVarChar, 10);
                paramCollection.Add("@Title", SqlDbType.NVarChar, 30);
                paramCollection.Add("@Titleofcourtesy", SqlDbType.NVarChar, 25);
                paramCollection.Add("@Birthdate", SqlDbType.DateTime);
                paramCollection.Add("@Hiredate", SqlDbType.DateTime);
                paramCollection.Add("@Address", SqlDbType.NVarChar, 60);
                paramCollection.Add("@City", SqlDbType.NVarChar, 15);
                paramCollection.Add("@Region", SqlDbType.NVarChar, 15);
                paramCollection.Add("@Postalcode", SqlDbType.NVarChar, 10);
                paramCollection.Add("@Country", SqlDbType.NVarChar, 15);
                paramCollection.Add("@Phone", SqlDbType.NVarChar, 24);
                paramCollection.Add("@Mgrid", SqlDbType.Int);


                paramCollection["@Lastname"].Value = txtLastname.Text.Trim();
                paramCollection["@Firstname"].Value = txtFirstname.Text.Trim();
                paramCollection["@Title"].Value = txtTitle.Text.Trim();
                paramCollection["@Titleofcourtesy"].Value = cbTOC.SelectedItem;
                paramCollection["@Birthdate"].Value = dtBirthdate.Value;
                paramCollection["@Hiredate"].Value = dtHiredate.Value;
                paramCollection["@Address"].Value = txtAddress.Text.Trim();
                paramCollection["@City"].Value = txtCity.Text.Trim();
                if (txtRegion.Text.Trim().Length > 0)
                {
                    paramCollection["@Region"].Value = txtRegion.Text.Trim();
                }
                else
                {
                    paramCollection["@Region"].Value = DBNull.Value;
                }
                if (txtPostalCode.Text.Trim().Length > 0)
                {
                    paramCollection["@Postalcode"].Value = txtRegion.Text.Trim();
                }
                else
                {
                    paramCollection["@Postalcode"].Value = DBNull.Value;
                }

                paramCollection["@Country"].Value = cbCountry.SelectedItem;
                paramCollection["@Phone"].Value = mtxtPhone.Text.Trim();
                if (cbMgrID.SelectedItem.ToString() != "")
                {
                    paramCollection["@Mgrid"].Value = int.Parse(cbMgrID.SelectedItem.ToString());
                }
                else
                {
                    paramCollection["@Mgrid"].Value = DBNull.Value;
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add success");
            }catch(Exception ex)
            {
                MessageBox.Show("Can't Add");
                ex.log();
            }
            finally
            {
                con.Close();
            }
            
        }
        //end add
        
        public void UpdateEmployee()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "[UpdateEmployee]";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameterCollection paramCollection = cmd.Parameters;

                paramCollection.Add("@ID", SqlDbType.Int);
                paramCollection.Add("@Lastname", SqlDbType.NVarChar, 20);
                paramCollection.Add("@Firstname", SqlDbType.NVarChar, 10);
                paramCollection.Add("@Title", SqlDbType.NVarChar, 30);
                paramCollection.Add("@Titleofcourtesy", SqlDbType.NVarChar, 25);
                paramCollection.Add("@Birthdate", SqlDbType.DateTime);
                paramCollection.Add("@Hiredate", SqlDbType.DateTime);
                paramCollection.Add("@Address", SqlDbType.NVarChar, 60);
                paramCollection.Add("@City", SqlDbType.NVarChar, 15);
                paramCollection.Add("@Region", SqlDbType.NVarChar, 15);
                paramCollection.Add("@Postalcode", SqlDbType.NVarChar, 10);
                paramCollection.Add("@Country", SqlDbType.NVarChar, 15);
                paramCollection.Add("@Phone", SqlDbType.NVarChar, 24);
                paramCollection.Add("@Mgrid", SqlDbType.Int);

                paramCollection["@ID"].Value = int.Parse(txtID.Text.Trim());
                paramCollection["@Lastname"].Value = txtLastname.Text.Trim();
                paramCollection["@Firstname"].Value = txtFirstname.Text.Trim();
                paramCollection["@Title"].Value = txtTitle.Text.Trim();
                paramCollection["@Titleofcourtesy"].Value = cbTOC.SelectedItem;
                paramCollection["@Birthdate"].Value = dtBirthdate.Value;
                paramCollection["@Hiredate"].Value = dtHiredate.Value;
                paramCollection["@Address"].Value = txtAddress.Text.Trim();
                paramCollection["@City"].Value = txtCity.Text.Trim();
                if (txtRegion.Text.Trim().Length > 0)
                {
                    paramCollection["@Region"].Value = txtRegion.Text.Trim();
                }
                else
                {
                    paramCollection["@Region"].Value = DBNull.Value;
                    ;
                }
                if (txtPostalCode.Text.Trim().Length > 0)
                {
                    paramCollection["@Postalcode"].Value = txtRegion.Text.Trim();
                }
                else
                {
                    paramCollection["@Postalcode"].Value = DBNull.Value;
                }

                paramCollection["@Country"].Value = cbCountry.SelectedItem;
                paramCollection["@Phone"].Value = mtxtPhone.Text.Trim();
                if (cbMgrID.SelectedItem.ToString() != "")
                {
                    paramCollection["@Mgrid"].Value = int.Parse(cbMgrID.SelectedItem.ToString());
                }
                else
                {
                    paramCollection["@Mgrid"].Value = DBNull.Value;
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Update");
                ex.log();
            }
            finally
            {
                con.Close();
            }
        }

        public void setInfo()
        {
            btnAdd.Text = "Update";
            txtID.Text = employee.Id.ToString();
            txtLastname.Text = employee.Lastname;
            txtFirstname.Text = employee.Firstname;
            txtTitle.Text = employee.Title;
            cbTOC.SelectedItem = employee.TitleOfCourtesy;
            dtBirthdate.Value = employee.Birthdate;
            dtHiredate.Value = employee.Hiredate;
            cbMgrID.SelectedItem = employee.Mgrid;
            txtAddress.Text = employee.Address;
            txtCity.Text = employee.City;
            txtRegion.Text = employee.Region;
            cbCountry.SelectedItem = employee.Country;
            mtxtPhone.Text = employee.Phone;
            txtPostalCode.Text = employee.Postalcode;
            bAdd = false;
        }

        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           frm = (frmEmployees)this.Owner;
           frm.LoadEmployees();  
        }
    }
}
