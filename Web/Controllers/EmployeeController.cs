using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.stateDropdown = _dbContext.Dropdowns.Where(s => s.DropdownName == "State").ToList().Select(u => new SelectListItem { Text = u.Text, Value = u.Value }).ToList();
            ViewBag.genderDropdown = _dbContext.Dropdowns.Where(s => s.DropdownName == "Gender").ToList().Select(u => new SelectListItem { Text = u.Text, Value = u.Value }).ToList();
            ViewBag.raceDropdown = _dbContext.Dropdowns.Where(s => s.DropdownName == "Race").ToList().Select(u => new SelectListItem { Text = u.Text, Value = u.Value }).ToList();
            ViewBag.hireSourceDropdown = _dbContext.Companies.Where(s => s.IsInactive == false).ToList().Select(u => new SelectListItem { Text = u.Name, Value = u.Name }).ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Employees.Add(employee);
                _dbContext.SaveChanges();
                employee = _dbContext.Employees.FirstOrDefault(s => s.SSN == employee.SSN);
                //return RedirectToAction("Index", "Onboarding", new { id = employee.Id });
                return View("Index");
            }
            return View(employee);
        }

    }
}
