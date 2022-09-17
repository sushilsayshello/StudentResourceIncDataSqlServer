using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment3.Models
{
    public class UnitModel
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitSpecification { get; set; }
        public string ResourceRequirements { get; set; }

        //public TeacherModel TeacherModel { get; set; }
        

    }
}
