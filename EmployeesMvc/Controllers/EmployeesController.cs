using Microsoft.AspNetCore.Mvc;
using EmployeesMvc.Models;
using System.Security.Cryptography.Xml;

namespace EmployeesMvc.Controllers
{
    public class EmployeesController : Controller
    {
		DataService dataService;
        public EmployeesController(DataService dataService)
        {
			this.dataService = dataService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            var model = dataService.GetAllEmployees();
            return View(model);
        }

		[HttpGet("/Create")]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost("")]
		public IActionResult Add(Employee employee)
		{
            if (!ModelState.IsValid)
                return View(nameof(Create));

            dataService.Add(employee);
			return RedirectToAction(nameof(Index));
		}

		[HttpGet("/Details/{id}")]
		public IActionResult Details(Employee employee)
		{
			var model = dataService.GetById(employee);
			return View(model);
		}

	}
}

