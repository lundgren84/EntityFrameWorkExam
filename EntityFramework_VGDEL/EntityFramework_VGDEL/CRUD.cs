using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_VGDEL
{
    class CRUD
    {

        internal static Course GetCourseByID(int id)
        {
            using (var ctx = new Registry())
            {
                return ctx.Courses.FirstOrDefault(x=> x.id == id);
            }
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

        internal static void RemoveStudentWithID(int id)
        {
            using (var ctx = new Registry())
            {
                var studentToRemove = ctx.Students.FirstOrDefault(x => x.id == id);
                ctx.Students.Remove(studentToRemove);
                ctx.SaveChanges();
            }
       
        }
    }
}
