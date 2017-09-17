using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDashBoard employeeDashBoard = new EmployeeDashBoard();
        // GET: Employee
        public ActionResult Index()
        {
            return View(employeeDashBoard.GetAll());
        }
    }
}