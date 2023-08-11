using System.ComponentModel.DataAnnotations;
namespace EmployeesMvc.Models
{
    public class Employee
    {
		[Display(Name = "Skriv namn")]
		[DataType(DataType.MultilineText)]
		[Required(ErrorMessage ="Skriv anställdas namn")]
        [StringLength(20, MinimumLength = 2, ErrorMessage ="Måste vara mellan 2-20")]
        public string Name { get; set; }
       

        //[Display(Email = "t")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Skriv anställdas Email")]
        [EmailAddress]
        public string Email { get; set; }
        
        public int Id { get; set; }


    }
}
