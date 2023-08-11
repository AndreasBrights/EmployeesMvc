using static System.Net.Mime.MediaTypeNames;

namespace EmployeesMvc.Models
{
    public class DataService
    {
        List<Employee> employees = new List<Employee>
		{

        };

		public void Add(Employee employee)
			{
				employees.Add(employee);

			}
		public Employee[] GetAllEmployees()
		{
			return employees.ToArray();
		}

		public Employee GetById(int id)
		{
			return employees[id];
		}

	}
}
