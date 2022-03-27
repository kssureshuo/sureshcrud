using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDEMO.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }

        [DisplayName("Student Name")]
        public string name { get; set; }

        [DisplayName("Student Age")]
        public int age { get; set; }

        [DisplayName("Student Standard")]
        public string standard { get; set; }

        [DisplayName("Student Country")]
        public int country { get; set; }

        [DisplayName("Student State")]
        public int State { get; set; }

    }
}
