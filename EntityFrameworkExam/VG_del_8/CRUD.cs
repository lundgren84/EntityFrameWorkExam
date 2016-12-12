using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VG_del_8
{
    class CRUD
    {
    

        internal static Course GetCourseByID(int v)
        {
            throw new NotImplementedException();
        }

        internal static bool AddStudent(Student student)
        {
            
            using (var ctx = new Registry())
            {
                try
                {
                    ctx.Students.Add(student);
                    ctx.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        internal static void AddCourse(Course course)
        {
            using (var ctx = new Registry())
            {
                ctx.Courses.Add(course);
                ctx.SaveChanges();
            }
        }
    }
}
