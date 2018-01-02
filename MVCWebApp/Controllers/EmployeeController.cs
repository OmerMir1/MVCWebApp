using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebApp.Models;


namespace MVCWebApp.Controllers
{
    public class EmployeeController : Controller
    {

        // GET: Get all employees into a List and pass that list to the view.
        //public ActionResult EmployeeList()
        //{
        //    EmployeeContext employeeContext = new EmployeeContext();
        //    List <Employee> employees = employeeContext.employees.ToList();

        //    return View(employees);
        //}


        public ActionResult EmployeeList(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> EmployeesInDepartment = employeeContext.employees.Where(emp => emp.DepartmentId == id).ToList();

            return View(EmployeesInDepartment);
        }


        //GET: Employee but only single employee because we use LINQ single and specify a condition
        public ActionResult EmployeeDetails(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> EmployeesInDepartment = employeeContext.employees.Where(emp => emp.EmployeeID == id).ToList();

            return View(EmployeesInDepartment);
        }
    }
}