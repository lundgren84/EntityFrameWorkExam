using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_VGDEL
{
   public class Registry:DbContext
    {
       public DbSet<Student> Students { get; set; }
       public DbSet<Course> Courses { get; set; }
    }
}
