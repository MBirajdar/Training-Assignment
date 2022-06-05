using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Course course1 = new Course(01, "C++", 3, 3000);
            Course course2 = new Course(02, "SQL", 3, 5000);
            Course course3 = new Course(03, ".net", 3, 10000);



            Student student = new Student(101, "Manoj", "18/09/1999");
            Student student1 = new Student(102, "Ganesh", "05/11/1999");
            Student student2 = new Student(103, "Mahesh", "19/09/1999");



            AppEngine appengine = new AppEngine();
            appengine.introduce(course1);
            appengine.introduce(course2);
            appengine.introduce(course3);



            appengine.register(student);
            appengine.register(student1);
            appengine.register(student2);





            appengine.enroll(student, course1);
            appengine.enroll(student1, course2);
            appengine.enroll(student2, course3);



            Student[] students = appengine.listOfStudents();
            for (int i = 0; i < appengine.studentlistsize; i++)
            {
                Info.display(students[i]);
            }
            Course[] courses = appengine.listOfCourses();
            for (int i = 0; i < appengine.courselistsize; i++)
            {
                Info.display(courses[i]);
            }
            Enroll[] enrolls = appengine.listOfEnrollments();
            for (int i = 0; i < appengine.enrolllistsize; i++)
            {
                Info.display(enrolls[i]);
            }
            Console.ReadLine();
        }
    }
}
