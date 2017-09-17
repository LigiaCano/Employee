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
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["ModelEmployee"].ConnectionString);
        //private IDbConnection _db = Conexion.Instance;

        public Person Add(Person employee)
        {
            var sqlQuery = "INSERT INTO Person (EmpName, EmpScore) VALUES(@EmpName, @EmpScore); " + "SELECT CAST(SCOPE_IDENTITY() as int)";
            var employeeId = _db.Query<int>(sqlQuery, employee).Single();
            employee.EmpID = employeeId;
            return employee;
        }

        public Person Find(int? id)
        {
            string query = "SELECT * FROM Person WHERE EmpID = " + id + "";
            return _db.Query<Person>(query).SingleOrDefault();
        }

        public List<Person> GetAll()
        {
                List<Person> empList = _db.Query<Person>("SELECT * FROM Person").ToList();
            return empList;   
        }

        public void Remove(int id)
        {
            var sqlQuery = ("Delete From Person Where EmpID = " + id + "");
            _db.Execute(sqlQuery);
        }

        public Person Update(Person employee)
        {
            var sqlQuery = "UPDATE Person " +
                    "SET EmpName = @EmpName, " +
                    " EmpScore = @EmpScore " +
            "WHERE EmpID = @EmpID";
            _db.Execute(sqlQuery, employee);
            return employee;
        }
    }
}