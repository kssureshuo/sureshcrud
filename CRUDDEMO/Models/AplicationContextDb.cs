using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDEMO.Models
{
    public class AplicationContextDb : DbContext
    {
        public AplicationContextDb(DbContextOptions<AplicationContextDb> options):base(options)
        {

        }
        public DbSet<Student> tblStudent { get; set; } // get=> read or set=?write

        public DbSet<Country> tblCountry { get; set; } // get=> read or set=?write

        public DbSet<StateBind> tblState { get; set; } // get=> read or set=?write

    }
}
