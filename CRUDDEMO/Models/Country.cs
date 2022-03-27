using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDEMO.Models
{
    public class Country
    {
        [Key]
        public int c_id { get; set; }

        public string c_name { get; set; }
    }
}
