using Northwind.DAL;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public class ProductController
    {
        ProductManagement productManagement = new ProductManagement();

        public List<Product> GetProducts()
        {
            List<Product> products = productManagement.GetProductsList();
            return products;
        }

        public bool AddProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName) & product.ProductName.Length > 15)
            {
                return false;
            }

            bool isAdded = productManagement.AddProduct(product);

            return isAdded;
        }

        public bool DeleteProduct(Product product)
        {
            bool isDeleted = productManagement.DeleteProduct(product);
            return isDeleted;
        }

        public bool UpdateProduct(Product product)
        {
            bool isUpdated = productManagement.UpdateProduct(product);
            return isUpdated;
        }

    }
}
