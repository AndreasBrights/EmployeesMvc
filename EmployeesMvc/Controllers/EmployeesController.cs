﻿using Microsoft.AspNetCore.Mvc;
using EmployeesMvc.Models;

namespace EmployeesMvc.Controllers
{
    public class EmployeesController : Controller
    {
        static DataService dataService = new DataService(); 

        public EmployeesController()
        {
            //dataService = new DataService();
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            var model = dataService.GetAllEmployees();
            return View(model);
        }

		[HttpGet("/Create")]
		public IActionResult Create(Employee employee)
		{
			return View(employee);
		}

		[HttpPost("")]
		public IActionResult Add(Employee employee)
		{
            if (!ModelState.IsValid)
                return View(nameof(Create));

            dataService.Add(employee);
			return RedirectToAction(nameof(Index));
		}

	}
}

