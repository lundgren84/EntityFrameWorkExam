using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VG_del_8
{
    public class Course
    {
        public int id { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public Course()
        {
            Students = new HashSet<Student>();
        }
    }
}
