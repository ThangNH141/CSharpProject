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
using EmployeeProject.HR;
using EmployeeProject.Production;
using EmployeeProject.Sale;

namespace EmployeeProject
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm form = new EmployeeForm();
            form.MdiParent = this;
            form.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.MdiParent = this;
            form.Show();
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetailForm form = new OrderDetailForm();
            form.MdiParent = this;
            form.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.MdiParent = this;
            form.Show();
        }

        private void shipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipperForm form = new ShipperForm();
            form.MdiParent = this;
            form.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.MdiParent = this;
            form.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.MdiParent = this;
            form.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm form = new SupplierForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}