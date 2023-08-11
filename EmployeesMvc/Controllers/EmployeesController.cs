using Microsoft.AspNetCore.Mvc;
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
		public IActionResult Create(Employee dog)
		{
			return View(dog);
		}

		[HttpPost("")]
		public IActionResult Add(Employee employee)
		{
			dataService.Add(employee);
			return RedirectToAction(nameof(Index));
		}

	}
}

