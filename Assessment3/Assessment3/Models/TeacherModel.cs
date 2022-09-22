using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment3.Models
{
    public class TeacherModel
    {
        [Key]
        [Required(ErrorMessage = "TeacherID is required")]
        public int TeacherId { get; set; }
        
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [DisplayName("ABC St NSW 2000")]
        [StringLength(1024)]
        public string Address { get; set; }
        
        public string Contact { get; set; }

        //public int UnitForeignKey { get; set; }
        //public UnitModel UnitModel { get; set; }

        


    }
}
