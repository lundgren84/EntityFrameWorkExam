using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VG_del_8
{
    public class Application
    {
        internal void Start()
        {
            while (true)
            {
                Console.WriteLine($@"Menu
1. Add student
2. Add Course
3. Remove Student with ID");
                ConsoleKeyInfo key;
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case '1':
                        AddStudent();
                        break;
                    case '2':
                        AddCourse();
                        break;
                    case '3':
                        RemoveStudetnWithID();
                        break;
                    default:
                        break;
                }

            }

        }

        private void RemoveStudetnWithID()
        {
            throw new NotImplementedException();
        }

        private void AddCourse()
        {
            Course course = new Course();
            Console.WriteLine("Enter coursename");
            course.CourseName = Console.ReadLine();
            CRUD.AddCourse(course);
        }

        private void AddStudent()
        {
            Student student = new Student();
            Console.WriteLine("Enter Firstname");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Enter CourseID");
            int courseID = int.Parse(Console.ReadLine());
            student.Course = CRUD.GetCourseByID(courseID);

            if (CRUD.AddStudent(student))
            {
                Console.WriteLine("Student added!");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
