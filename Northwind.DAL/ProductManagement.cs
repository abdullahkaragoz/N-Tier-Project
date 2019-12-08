using Northwind.Entities;
using Northwind.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Northwind.DAL
{
    public class ProductManagement
    {
        SqlConnection sqlConnection;

        public ProductManagement()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);
            }




        }
        //Show Product
        public List<Product> GetProductsList()
        {
            List<Product> products = new List<Product>();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products", sqlConnection);


            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Product product = new Product
                    {

                        ProductId = Convert.ToInt32(dr["ProductId"]),
                        ProductName = dr["ProductName"].ToString(),
                        SupplierId = Convert.ToInt32(dr["SupplierId"]),
                        CategoryId = Convert.ToInt32(dr["CategoryId"]),
                        QuantityPerUnit = dr["QuantityPerUnit"].ToString(),
                        UnitPrice = Convert.ToDouble(dr["UnitPrice"]),
                        UnitsInStock = Convert.ToInt32(dr["UnitsInStock"]),
                        UnitsOnOrder = Convert.ToInt32(dr["UnitsOnOrder"]),
                        ReorderLevel = Convert.ToInt32(dr["ReorderLevel"]),
                        Discontinued = Convert.ToInt32(dr["Discontinued"])

                    };
                    products.Add(product);
                }

            }

            sqlConnection.Close();
            return products;

        }

        public bool AddProduct(Product product)
        {
            string addQuery = @"INSERT 
                                INTO Products 
                                (
                                ProductID,
                                ProductName,
                                SupplierID,
                                CategoryID,
                                QuantityPerUnit,
                                UnitPrice,
                                UnitsInStock,
                                UnitsOnOrder,
                                ReorderLevel,
                                Discontinued)
                                VALUES('@productName',@supplierID,@categoryID,'@quantityPerUnit',@unitPrice,@unitsInStock,@unitsOnOrder,@reorderLevel,@discontinued)";

            SqlCommand sqlCommand = new SqlCommand(addQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@productID", product.ProductId);
            sqlCommand.Parameters.AddWithValue("@productName", product.ProductName);
            sqlCommand.Parameters.AddWithValue("@supplierID", product.SupplierId);
            sqlCommand.Parameters.AddWithValue("@categoryID", product.CategoryId);
            sqlCommand.Parameters.AddWithValue("@quantityPerUnit", product.QuantityPerUnit);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock);
            sqlCommand.Parameters.AddWithValue("@unitsOnOrder", product.UnitsOnOrder);
            sqlCommand.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel);
            sqlCommand.Parameters.AddWithValue("@discontinued", product.Discontinued);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;


        }

        public bool DeleteProduct(Product product)
        {
            string deleteQuery = @"DELETE FROM Products WHERE ProductID=@productId";

            SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@productId", product.ProductId);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            bool isDeleted = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isDeleted;
        }

        public bool UpdateProduct(Product product)
        {
            string updateQuery = @"UPDATE Products
	    SET ProductName=@productName,
		      CategoryID=@categoryID,
		      SupplierID=@supplierID,
		      QuantityPerUnit=@quantityPerUnit,
		      UnitPrice=@unitPrice,
		      UnitsInStock=@unitsInStock,
		      UnitsOnOrder=@unitsOnOrder,
		      ReorderLevel=@reorderLevel,
		      Discontinued=@discontinued
	    WHERE ProductID=@productId";

            SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@productName", product.ProductName);
            sqlCommand.Parameters.AddWithValue("@categoryID", product.CategoryId);
            sqlCommand.Parameters.AddWithValue("@supplierID", product.SupplierId);
            sqlCommand.Parameters.AddWithValue("@quantityPerUnit", product.QuantityPerUnit);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@unitsInStock", product.UnitsInStock);
            sqlCommand.Parameters.AddWithValue("@unitsOnOrder", product.UnitsOnOrder);
            sqlCommand.Parameters.AddWithValue("@reorderLevel", product.ReorderLevel);
            sqlCommand.Parameters.AddWithValue("@discontinued", product.Discontinued);
            sqlCommand.Parameters.AddWithValue("@productId", product.ProductId);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            bool isUpdated = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isUpdated;
        }

    }


}