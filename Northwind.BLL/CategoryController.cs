﻿using Northwind.DAL;
using Northwind.Entities;
using System.Collections.Generic;

namespace Northwind.BLL
{
    public class CategoryController
    {
        CategoryManagement categoryManagment = new CategoryManagement();

        public List<Category> GetCategories()
        {
            List<Category> categories = categoryManagment.GetCategoryList();

            return categories;
        }

        public bool AddCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName) & category.CategoryName.Length > 15)
            {
                return false;
            }

            bool isAdded = categoryManagment.AddCategory(category);

            return isAdded;
        }

       public bool DeleteCategory(Category category)
        {
            
                bool isDeleted = categoryManagment.DeleteCategory(category);
                return isDeleted;

        }

        public bool UpdateCategory(Category category)
        {
            bool isUpdated = categoryManagment.UpdateCategory(category);
            return isUpdated;
        }

       

    }
}