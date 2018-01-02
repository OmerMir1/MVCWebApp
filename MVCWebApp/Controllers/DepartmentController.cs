using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class DepartmentController : Controller
    {
        
        public ActionResult DepartmentList()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List <Department> departments = employeeContext.departments.ToList();
            return View(departments);
        }
    }
}