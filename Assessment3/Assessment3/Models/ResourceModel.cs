using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment3.Models
{
    public class ResourceModel
    {
        [Key]
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceType { get; set; }
        public bool ResourceAvailability { get; set; }
        public int ResourceQuantity { get; set; }

        //public ICollection<StudentResourceModel> StudentResourceModels { get; set; }
        
    }
}
