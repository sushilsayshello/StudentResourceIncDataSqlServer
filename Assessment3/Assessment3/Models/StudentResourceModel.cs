using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment3.Models
{
    public class StudentResourceModel
    {
        [DataType(DataType.Date)]
        [Display(Name = "Student Resource Date")]
        public DateTime StudentResourceDate { get; set; }
        public int StudentId { get; set; }
        public StudentModel StudentModel { get; set; }
        public int ResourceId { get; set; }
        public ResourceModel ResourceModel { get; set; }

    }
}
