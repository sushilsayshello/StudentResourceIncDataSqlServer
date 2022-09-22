using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment3.Models
{
    public class StudentModel
    {
        [Key]
	[Required(ErrorMessage = "StudentID is required")]
	[StringLength(7, ErrorMessage = "Max 7 digits")]
        public int StudentId { get; set; }
	    
        [Required(ErrorMessage = "FirstName is required")]
	[StringLength(16, MinimumLength = 4, ErrorMessage = "at least 4 characters but no more than 16 characters.")]
        public string FirstName { get; set; }
	    
	[Required(ErrorMessage = "LastName is required")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = " at least 4 characters but no more than 16 characters.")]   
        public string LastName { get; set; }

      	[Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}+$", ErrorMessage = "Email is required with matching regular expression"]
        public string Email { get; set; }

        [DisplayName("Address")]
        [StringLength(1024)]
        public string Address { get; set; }
			   
	[Required(ErrorMessage = "Contact is required")
	[StringLength(10, ErrorMessage = "Max 10 digits")]
        public string Contact { get; set; }


        [

        //public ICollection<StudentResourceModel> StudentResourceModels { get; set; }
    }
}
