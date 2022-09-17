using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment3.Models
{
    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseUnits { get; set; }
        public string CourseDescription { get; set; }

       

    }
}
