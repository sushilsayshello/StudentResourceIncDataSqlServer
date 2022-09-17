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

        //public ICollection<StudentResourceModel> StudentResourceModels { get; set; }
    }
}
