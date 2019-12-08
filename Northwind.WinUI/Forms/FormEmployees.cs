using Northwind.BLL;
using Northwind.Entities;
using System;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms
{
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
        }
        EmployeeController employeeController = new EmployeeController();
        private void button1_Click(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = employeeController.GetEmployees();
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Title = txtTitle.Text,
                TitleOfCourtesy = txtTitleOfCourtesy.Text,
                BirthDate = dtpBirthDate.Value,
                HireDate = dtpHireDate.Value,
                Address = txtAdress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                HomePhone = txtHomePhone.Text,
                Extension = txtExtension.Text,
                PhotoPath = txtPhotoPath.Text,
                Notes = txtNotes.Text

            };
            employeeController.AddEmployee(employee);
            dgvEmployee.DataSource = employeeController.GetEmployees();

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmployeeId = Convert.ToInt32(txtEmployeeId.Text)
            };
            employeeController.DeleteEmployee(employee);
            dgvEmployee.DataSource = employeeController.GetEmployees();


        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmployeeId = Convert.ToInt32(txtEmployeeId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Title = txtTitle.Text,
                TitleOfCourtesy = txtTitleOfCourtesy.Text,
                BirthDate = dtpBirthDate.Value,
                HireDate = dtpHireDate.Value,
                Address = txtAdress.Text,
                City = txtCity.Text,
                Region = txtRegion.Text,
                PostalCode = txtPostalCode.Text,
                Country = txtCountry.Text,
                HomePhone = txtHomePhone.Text,
                Extension = txtExtension.Text,
                PhotoPath = txtPhotoPath.Text,
                Notes = txtNotes.Text
            };
            employeeController.UpdateEmployee(employee);

        }
    }
}
