using System.ComponentModel.DataAnnotations;
namespace EmployeesMvc.Models
{
    public class Employee
    {
		[Display(Name = "Skriv namn")]
		[DataType(DataType.MultilineText)]
		[Required(ErrorMessage ="Namn är tomt")]
        [StringLength(20, MinimumLength = 2, ErrorMessage ="Måste vara mellan 2-20")]
        public string Name { get; set; }
       

        [Display(Name = "Skriv Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email är tomt")]
        [EmailAddress]
        public string Email { get; set; }
        
        public int Id { get; set; }
        //public string Details { get; set; }


    }
}
