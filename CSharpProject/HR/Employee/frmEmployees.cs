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
    public partial class frmEmployees : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        List<Employee> dataList;
        List<Employee> searchList;

        public List<Employee> DataList
        {
            get
            {
                return dataList;
            }

            set
            {
                dataList = value;
            }
        }

        public frmEmployees()
        {

            InitializeComponent();

            con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["phongCT"].ConnectionString;

            DataList = new List<Employee>();

            LoadEmployees();
        }

        public void LoadEmployees()
        {
            try
            {
                dataList.Clear();
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "[getEmployees]";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = (int) dr[0];
                    int mgrid;
                    if (dr[13].ToString() == "")
                    {
                        mgrid = -1;
                    } else mgrid = (int) dr[13];
                    Employee emp = new Employee(id, dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),
                        DateTime.Parse(dr[5].ToString()), DateTime.Parse(dr[6].ToString()), dr[7].ToString(), dr[8].ToString(),
                        dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(),
                        mgrid);
                    DataList.Add(emp);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                ex.log();
            }
            updateDgEmployee(dataList);
        }
        // end LoadEmployees


        void updateDgEmployee(List<Employee> list)
        {
            dgEmployees.Rows.Clear();
            foreach (Employee emp in list)
            {
                if (emp.Mgrid == -1)
                {
                    dgEmployees.Rows.Add(emp.Id, emp.Lastname, emp.Firstname, emp.Title, emp.TitleOfCourtesy, emp.Birthdate,
                    emp.Hiredate, emp.Address, emp.City, emp.Region, emp.Postalcode, emp.Country, emp.Phone, "");
                } else
                dgEmployees.Rows.Add(emp.Id, emp.Lastname, emp.Firstname, emp.Title, emp.TitleOfCourtesy, emp.Birthdate,
                    emp.Hiredate, emp.Address, emp.City, emp.Region, emp.Postalcode, emp.Country, emp.Phone, emp.Mgrid);
            }
        }
        //end updateDgEmployee
        private void btnAdd_Click(object sender, EventArgs e)
        {
            InputForm frm = new InputForm();
            frm.Owner = this;
            frm.Datalist = dataList;
            frm.setMgrID();
            frm.ShowDialog();
        }
        //end Add

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select row!");
                return;
            }
            DialogResult rs = MessageBox.Show("Are you sure?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                DataGridViewRow r = dgEmployees.SelectedRows[0];
                
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "[DeleteEmployee]";
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameterCollection paramCollection = cmd.Parameters;
                    paramCollection.Add("@ID", SqlDbType.Int);

                    paramCollection["@ID"].Value = r.Cells["EmpID"].Value;

                    cmd.ExecuteNonQuery();
                    dgEmployees.Rows.RemoveAt(r.Index);
                } 
                catch(Exception ex)
                {
                    MessageBox.Show("Can't delete this employee");
                    ex.log();
                }
                finally
                {
                    con.Close();
                }
            }
        }
        //end Delete

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select row!");
                return;
            }
            Employee emp = new Employee();
            int empid = int.Parse(dgEmployees.SelectedRows[0].Cells["EmpID"].Value.ToString());
            foreach (Employee em in DataList)
            {
                if (em.Id.Equals(empid))
                {
                    emp = em;
                    break;
                }
            }
            InputForm frm = new InputForm();
            frm.Owner = this;
            frm.Datalist = dataList;
            frm.Employee = emp;
            frm.setMgrID();
            frm.setInfo(); // bAdd = false
            frm.ShowDialog();
        }
        //End Update

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            updateDgEmployee(dataList);
        }

        private void btnSearchFn_Click(object sender, EventArgs e)
        {
            string fn = txtFirstname.Text.Trim();
            if (fn.Length == 0)
            {
                erFn.SetError(txtFirstname, "Please enter firstname!!!");
                return;
            }
            else
            {
                erFn.Clear();
                searchEmployees(fn, null, null , null);
            }
            
            
        }

        void searchEmployees(string fn, string ln, DateTime? birthdateF, DateTime? birthdateT)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "[SearchEmployees]";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameterCollection paramCollection = cmd.Parameters;


                paramCollection.Add("@Lastname", SqlDbType.NVarChar, 20);
                paramCollection.Add("@Firstname", SqlDbType.NVarChar, 10);
                paramCollection.Add("@BirthdateF", SqlDbType.DateTime);
                paramCollection.Add("@BirthdateT", SqlDbType.DateTime);

                if (ln == null)
                {
                    paramCollection["@Lastname"].Value = DBNull.Value;
                }
                else
                {
                    paramCollection["@Lastname"].Value = ln;
                }

                if (fn == null)
                {
                    paramCollection["@Firstname"].Value = DBNull.Value;
                }
                else
                {
                    paramCollection["@Firstname"].Value = fn;
                }

                if (birthdateF == null)
                {
                    paramCollection["@BirthdateF"].Value = DBNull.Value;
                    paramCollection["@BirthdateT"].Value = DBNull.Value;
                }
                else
                {
                    paramCollection["@BirthdateF"].Value = birthdateF;
                    paramCollection["@BirthdateT"].Value = birthdateT;
                }

                dr = cmd.ExecuteReader();
                searchList = new List<Employee>();
                while (dr.Read())
                {
                    int id = (int)dr[0];
                    int mgrid;
                    if (dr[13].ToString() == "")
                    {
                        mgrid = -1;
                    }
                    else mgrid = (int)dr[13];
                    Employee emp = new Employee(id, dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),
                        DateTime.Parse(dr[5].ToString()), DateTime.Parse(dr[6].ToString()), dr[7].ToString(), dr[8].ToString(),
                        dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(),
                        mgrid);
                    searchList.Add(emp);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Search");
                ex.log();
            }
            finally
            {
                con.Close();
            }
            updateDgEmployee(searchList);
        }

        private void btnSearchLn_Click(object sender, EventArgs e)
        {
            string ln = txtLastname.Text.Trim();
            if (ln.Length == 0)
            {
                erLn.SetError(txtLastname, "Please enter lastname!!!");
                return;
            }
            else
            {
                erLn.Clear();
                searchEmployees(null, ln, null, null);
            }
        }

        private void btnSerachBd_Click(object sender, EventArgs e)
        {
            DateTime birthdateF = dtBDFrom.Value;
            DateTime birthdateT = dtBDTo.Value;

            if (birthdateF > birthdateT)
            {
                erBd.SetError(dtBDTo, "Birthdate from < birthdate to");
                return;
            }
            else
            {
                erBd.Clear();
                searchEmployees(null, null, birthdateF, birthdateT);
            }
        }

        private void dgEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    //end class
       
}
