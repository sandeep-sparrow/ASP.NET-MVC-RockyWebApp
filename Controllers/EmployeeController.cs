using Microsoft.AspNetCore.Mvc;
using Rocky.Data;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Employee> objList = _db.Employee;
            return View(objList);
        }

        // GET : Create
        public IActionResult Create()
        {
            return View();
        }

        // POST : Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee obj)
        {
            _db.Employee.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index"); // no need to define a constroller as it is in the same constroller
        }
    }
}
