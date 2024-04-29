using first_mvc.Models;
using first_mvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace first_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/GetAllEmpDetails
        public ActionResult GetAllEmpDetails()
        {
            EmpRepository EmpRepo = new EmpRepository();
            ModelState.Clear();
            return View(EmpRepo.GetAllEmployees());
        }

        // GET: Employee/AddEmployee
        public ActionResult AddEmployee()
        {
            return View();
        }

        // POST: Employee/AddEmployee
        [HttpPost]
        public ActionResult AddEmployee(EmpModel objEmp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpRepository EmpRepo = new EmpRepository();

                    if (EmpRepo.AddEmployee(objEmp))
                    {
                        ViewBag.Message = "Employees details added successfully";
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/EditEmpDetails/5
        public ActionResult EditEmpDetails(int id)
        {
            EmpRepository EmpRepo = new EmpRepository();
            return View(EmpRepo.GetAllEmployees().Find(Emp => Emp.Empid == id));
        }

        // POST: Employee/EditEmpDetails/5
        [HttpPost]
        public ActionResult EditEmpDetails(int id, EmpModel obj)
        {
            try
            {
                EmpRepository EmpRepo = new EmpRepository();

                EmpRepo.UpdateEmployee(obj);
                return RedirectToAction("GetAllEmpDetails");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/DeleteEmp/5

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                EmpRepository EmpRepo = new EmpRepository();
                if(EmpRepo.DeleteEmployee(id))
                {
                    ViewBag.AlertMsg = "Employee details deleted successfully";
                }

                return RedirectToAction("GetAllEmpDetails");
            }
            catch
            {
                return View();
            }
        }
    }
}
