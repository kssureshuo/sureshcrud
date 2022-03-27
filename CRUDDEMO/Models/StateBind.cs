using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDEMO.Models
{
    public class StateBind
    {
        [Key]
        public int state_id { get; set; }

        //[ForeignKey("CountryId")]
        //public int c_id { get; set; }

        public virtual Country Country { get; set; }
        public string state_name { get; set; }
    }
}
