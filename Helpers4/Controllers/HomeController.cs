using System;
using System.Collections.Generic;
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

        public ActionResult Create()
        {
            return View();
        }
    }
}