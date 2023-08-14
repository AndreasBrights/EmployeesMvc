using static System.Net.Mime.MediaTypeNames;

namespace EmployeesMvc.Models
{
    public class DataService
    {
        List<Employee> employees = new List<Employee>
		{
			new Employee { Id = 0,  Name ="Felix", Email = "Felix@mail.se", Details = "gillar katter"},
			new Employee { Id = 1,  Name ="Erik", Email = "Erik@mail.se",  Details = "gillar tåg"},
			new Employee { Id = 2 ,  Name ="Movitz", Email = "Movitz@mail.se", Details = "gillar Klockor"},
		};

		public void Add(Employee employee)
			{
			employee.Id = this.employees.Max(i => i.Id) + 1;
				employees.Add(employee);

			}
		public Employee[] GetAllEmployees()
		{
			return employees.ToArray();
		}

		public Employee GetById(Employee employee)
		{
			return employees[employee.Id];
		}

	}
}
