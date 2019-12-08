using Northwind.BLL;
using Northwind.Entities;
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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }

        private void BtnProductShow_Click(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            dgvGetProducts.DataSource = productController.GetProducts();
        }

        ProductController productController = new ProductController();

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            Product product = new Product
            {
                ProductId = Convert.ToInt32(txtProductId.Text),
                ProductName = txtProductName.Text,
                SupplierId = Convert.ToInt32(txtSupplierId.Text),
                CategoryId = Convert.ToInt32(txtPCategoryId.Text),
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice=Convert.ToDouble(txtUnitPrice),
                UnitsInStock=Convert.ToInt32(txtUnitsInStock.Text),
                UnitsOnOrder=Convert.ToInt32(txtUnitsOnOrder),
                ReorderLevel=Convert.ToInt32(txtReorderLevel),
                Discontinued = Convert.ToInt32(txtDiscontinued)

            };
            productController.AddProduct(product);
            
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductId = Convert.ToInt32(txtProductId.Text)

            };
            productController.DeleteProduct(product);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductId = Convert.ToInt32(txtProductId.Text),
                ProductName = txtProductName.Text,
                SupplierId = Convert.ToInt32(txtSupplierId.Text),
                CategoryId = Convert.ToInt32(txtPCategoryId.Text),
                QuantityPerUnit = txtQuantityPerUnit.Text,
                UnitPrice = Convert.ToDouble(txtUnitPrice),
                UnitsInStock = Convert.ToInt32(txtUnitsInStock.Text),
                UnitsOnOrder = Convert.ToInt32(txtUnitsOnOrder),
                ReorderLevel = Convert.ToInt32(txtReorderLevel),
                Discontinued = Convert.ToInt32(txtDiscontinued)

            };
            productController.UpdateProduct(product);
        }
    }
}
