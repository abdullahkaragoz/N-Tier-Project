using Northwind.BLL;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        CategoryController categoryController = new CategoryController();

        private void BtnShowCategory_Click(object sender, EventArgs e)
        {
            CategoryController categoryController = new CategoryController();

            dgvGetCategories.DataSource = categoryController.GetCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                CategoryName = txtCategoryName.Text,
                CategoryDescription = txtCategoryDescription.Text
            };

            categoryController.AddCategory(category);



        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            //dgvGetCategories.DataSource = categoryController.GetCategories();
        }

        private void BtnRemoveCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                CategoryId = Convert.ToInt32(txtCategoryId.Text)

            };
            categoryController.DeleteCategory(category);
        }



        private void BtnUpdateCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                CategoryId = Convert.ToInt32(txtCategoryId.Text),
                CategoryName = txtCategoryName.Text,
                CategoryDescription = txtCategoryDescription.Text,
            };
            categoryController.UpdateCategory(category);
        }




    }
}