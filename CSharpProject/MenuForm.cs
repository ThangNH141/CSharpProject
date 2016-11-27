using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpProject.Sales.Order;
using CustomersShippersForm;
using Employees;
using suppliers;
using ProjectGroup;

namespace CSharpProject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BringToFront<frmEmployees>() == false)
            {
                frmEmployees frmEmp = new frmEmployees();
                frmEmp.MdiParent = this;
                frmEmp.Show();
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BringToFront<OrderForm>() == false)
            {
                OrderForm frmOrder = new OrderForm();
                frmOrder.MdiParent = this;
                frmOrder.Show();
            }
        }

        private bool BringToFront<T>() where T:Form
        {
            var mdiChild = 
                from form in this.MdiChildren
                where form is T
                select form;
            if (mdiChild.Any())
            {
                T form = mdiChild.First() as T;
                form.BringToFront();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BringToFront<Supplier>() == false)
            {
                Supplier frmOrder = new Supplier();
                frmOrder.Owner = this;
                frmOrder.MdiParent = this;
                frmOrder.Show();
            }
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BringToFront<Categories>() == false)
            {
                Categories frmOrder = new Categories();
                frmOrder.Owner = this;
                frmOrder.MdiParent = this;
                frmOrder.Show();
            }
        }

        private void shipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BringToFront<ShippersForm>() == false)
            {
                ShippersForm frmOrder = new ShippersForm();
                frmOrder.Owner = this;
                frmOrder.MdiParent = this;
                frmOrder.Show();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BringToFront<CustomersForm>() == false)
            {
                CustomersForm frmOrder = new CustomersForm();
                frmOrder.Owner = this;
                frmOrder.MdiParent = this;
                frmOrder.Show();
            }
        }
    }
}
