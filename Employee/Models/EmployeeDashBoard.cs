using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class EmployeeDashBoard : IEmployeeDashBoard
    {
        //private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["ModelPrueba"].ConnectionString);
        private IDbConnection _db = Conexion.Instance;

        public Employee Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Find(int? id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
                List<Employee> empList = _db.Query<Employee>("SELECT * FROM Employee").ToList();
            _db.Close();
            return empList;   
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}