﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpers4.Models;

namespace Helpers4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            SampleDBContext db = new SampleDBContext();
            Employee employee = db.Employees.Single(x => x.Id == id);

            return View(employee);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            SampleDBContext db = new SampleDBContext();
            Employee employee = db.Employees.Single(x => x.Id == id);

            return View(employee);
        }

        //[HttpPost]
        //public string Edit()
        //{
        //    return "Form has been saved";
        //}

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                SampleDBContext db = new SampleDBContext();
                Employee employeeFromDB = db.Employees.Single(x => x.Id == employee.Id);

                // Populate all the properties except EmailAddrees
                employeeFromDB.FullName = employee.FullName;
                employeeFromDB.Gender = employee.Gender;
                employeeFromDB.Age = employee.Age;
                employeeFromDB.HireDate = employee.HireDate;
                employeeFromDB.Salary = employee.Salary;
                employeeFromDB.PersonalWebSite = employee.PersonalWebSite;

                db.Entry(employeeFromDB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = employee.Id });
            }
            return View(employee);
        }
    }
}