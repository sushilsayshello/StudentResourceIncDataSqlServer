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
        public int StudentId { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [DisplayName("Address")]
        [StringLength(1024)]
        public string Address { get; set; }
        public string Contact { get; set; }
        
        
		
		public int StudentID { get; set; }

		[Required(ErrorMessage = "LastName is required")]
		[StringLength(16, MinimumLength = 4 ,ErrorMessage = "Must be atleast 4 characters but no more than 16 characters")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "FirstName is required")]
		[StringLength(16, MinimumLength = 4, ErrorMessage = "Must be atleast 4 characters but no more than 16 characters")]
		public string FirstName { get; set; }

		public string Phone { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
		public string Email { get; set; 

        //public ICollection<StudentResourceModel> StudentResourceModels { get; set; }
    }
}
