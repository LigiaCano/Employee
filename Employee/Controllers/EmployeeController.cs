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
        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View(employeeDashBoard.Find(id));
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "EmpID,EmpName,EmpScore")] Person employee)
        {
            try
            {
                employeeDashBoard.Add(employee);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View(employeeDashBoard.Find(id));
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                employeeDashBoard.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(employeeDashBoard.Find(id));
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "EmpID,EmpName,EmpScore")] Person employee, int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    employeeDashBoard.Update(employee);
                    return RedirectToAction("Index");
                }

                return View(employee);
            }
            catch
            {
                return View();
            }
        }
    }
}