using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Data;

namespace WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DatabaseContext _context;

        public EmployeeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var data = (from emp in _context.Employees select emp).ToList();

            var data = _context.Employees.Select(emp => emp).ToList();

            return View(data);
        }

        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                // save
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
