using Northwind.Entities;
using Northwind.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class EmployeeManagement
    {
        SqlConnection sqlConnection;

        public EmployeeManagement()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(ConnectionTools.ConnectionString);

            }

        }

        public List<Employee> GetEmployeesList()
        {
            List<Employee> employees = new List<Employee>();

            SqlCommand sqlCommand = new SqlCommand(@"SELECT * FROM Employees", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlDataReader dr = sqlCommand.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Employee employee = new Employee()
                    {
                        EmployeeId = Convert.ToInt32(dr["EmployeeId"]),
                        FirstName = dr["FirstName"].ToString(),
                        LastName = dr["LastName"].ToString(),
                        Title = dr["Title"].ToString(),
                        TitleOfCourtesy = dr["TitleOfCourtesy"].ToString(),
                        BirthDate = Convert.ToDateTime(dr["BirthDate"]),
                        HireDate = Convert.ToDateTime(dr["HireDate"]),
                        Address = dr["Address"].ToString(),
                        City = dr["City"].ToString(),
                        Region = dr["Region"].ToString(),
                        PostalCode = dr["PostalCode"].ToString(),
                        Country = dr["Country"].ToString(),
                        HomePhone = dr["HomePhone"].ToString(),
                        Extension = dr["Extension"].ToString(),
                        Notes = dr["Notes"].ToString(),
                        PhotoPath = dr["PhotoPath"].ToString()

                    };
                    employees.Add(employee);
                }
            }
            sqlConnection.Close();
            return employees;
        }

        public bool AddEmployee(Employee employee)
        {
            string AddQuery = @"INSERT INTO Employees(FirstName,LastName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,PhotoPath) 
                    VALUES(@firstname,@lastname,@title,@titleofcourtesy,@birthdate,@hiredate,@address,@city,@region,@postalcode,@country,@homephone,@extension,@notes,@photopath)";

            SqlCommand sqlCommand = new SqlCommand(AddQuery, sqlConnection);

            
            sqlCommand.Parameters.AddWithValue("@firstname", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@lastname", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@title", employee.Title);
            sqlCommand.Parameters.AddWithValue("@titleofcourtesy", employee.TitleOfCourtesy);
            sqlCommand.Parameters.AddWithValue("@birthdate", employee.BirthDate);
            sqlCommand.Parameters.AddWithValue("@hiredate", employee.HireDate);
            sqlCommand.Parameters.AddWithValue("@address", employee.Address);
            sqlCommand.Parameters.AddWithValue("@city", employee.City);
            sqlCommand.Parameters.AddWithValue("@region", employee.Region);
            sqlCommand.Parameters.AddWithValue("@postalcode", employee.PostalCode);
            sqlCommand.Parameters.AddWithValue("@country", employee.Country);
            sqlCommand.Parameters.AddWithValue("@homephone", employee.HomePhone);
            sqlCommand.Parameters.AddWithValue("@extension", employee.Extension);
            sqlCommand.Parameters.AddWithValue("@notes", employee.Notes);
            sqlCommand.Parameters.AddWithValue("@photopath", employee.PhotoPath);



            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            bool isAdded = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isAdded;
        }

        public bool DeleteEmployee(Employee employee)
        {
            string deleteQuery = @"DELETE FROM Employees WHERE EmployeeID=@employeeId";
            SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@employeeId", employee.EmployeeId);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            bool isDeleted = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isDeleted;

        }

        public bool UpdateEmployee(Employee employee)
        {
            string updateQuery = @"UPDATE Employees 
                                    SET  FirstName=@firstname,LastName=@lastname,Title=@title,TitleOfCourtesy=@titleofcourtesy,BirthDate=@birthdate,HireDate=@hiredate,Address=@address,City=@city,Region=@region,PostalCode=@postalcode,Country=@country,HomePhone=@homephone,Extension=@extension,Notes=@Notes,PhotoPath=@photopath
                                        WHERE EmployeeId=@employeeId";
            SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@employeeId", employee.EmployeeId);
            sqlCommand.Parameters.AddWithValue("@firstname", employee.FirstName);
            sqlCommand.Parameters.AddWithValue("@lastname", employee.LastName);
            sqlCommand.Parameters.AddWithValue("@title", employee.Title);
            sqlCommand.Parameters.AddWithValue("@titleofcourtesy", employee.TitleOfCourtesy);
            sqlCommand.Parameters.AddWithValue("@birthdate", employee.BirthDate);
            sqlCommand.Parameters.AddWithValue("@hiredate", employee.HireDate);
            sqlCommand.Parameters.AddWithValue("@address", employee.Address);
            sqlCommand.Parameters.AddWithValue("@city", employee.City);
            sqlCommand.Parameters.AddWithValue("@region", employee.Region);
            sqlCommand.Parameters.AddWithValue("@postalcode", employee.PostalCode);
            sqlCommand.Parameters.AddWithValue("@country", employee.Country);
            sqlCommand.Parameters.AddWithValue("@homephone", employee.HomePhone);
            sqlCommand.Parameters.AddWithValue("@extension", employee.Extension);
            sqlCommand.Parameters.AddWithValue("@notes", employee.Notes);
            sqlCommand.Parameters.AddWithValue("@photopath", employee.PhotoPath);
            if (sqlConnection.State==ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            bool isUpdated = sqlCommand.ExecuteNonQuery() > 0 ? true : false;
            sqlConnection.Close();
            return isUpdated;
        }
    }
}
