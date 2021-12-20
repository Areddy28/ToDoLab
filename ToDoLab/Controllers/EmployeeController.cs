using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoLab.Models;

namespace ToDoLab.Controllers
{
    public class EmployeeController : Controller 
    {
        EmployeeDAL dbEmployee = new EmployeeDAL();
        ToDoDAL dbToDo = new ToDoDAL();
        public IActionResult Index()
        {
            //List<Employee> employees = dbEmployee.GetEmployees();



            EmployeeTaskViewModel evtm = new EmployeeTaskViewModel();
            return View(evtm);
        }



        public IActionResult Details(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee e)
        {

            dbEmployee.AddEmployee(e);
            return RedirectToAction("Index", "Employee");

        }

        public IActionResult Delete(int id )
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e); 
        }

        public IActionResult DeleteFromDB(int id)
        {
            dbEmployee.DeleteEmployee(id);
            return RedirectToAction("Index", "Employee");
        }

        public IActionResult Edit(int id)
        {
            Employee e = dbEmployee.GetEmployee(id);
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(Employee e)
        {
            dbEmployee.UpdateEmployee(e);
            return RedirectToAction("Index", "Employee");
        }

    }

  
}
