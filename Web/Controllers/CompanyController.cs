using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CompanyController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Company> companies = _dbContext.Companies.Where(s => s.IsInactive == false).ToList();
            return View(companies);
        }

        [HttpPost]
        public IActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Companies.Add(company);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
