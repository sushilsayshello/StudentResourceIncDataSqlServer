using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment3.Models
{
    public class RequestModel
    {
        [Key]
        public int RequestId { get; set; }

        public bool Approval { get; set; }
     

    }
}
