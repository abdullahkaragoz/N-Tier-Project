using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.MdiParent = this;
            formCategory.Show();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts formProducts = new FormProducts();
            formProducts.MdiParent = this;
            formProducts.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployees formEmployees = new FormEmployees();
            formEmployees.MdiParent = this;
            formEmployees.Show();


        }
    }
}
