using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy2
{
    public class Info
    {
        public static void display(Student student)
        {
            Console.WriteLine("Student id : " + student.StudentId + " ,student name i: " + student.StudentName + ",date of birth : " + student.DateOfBirth);
        }
        public static void display(Course course)
        {
            Console.WriteLine("Course id is " + course.Id + " Course name : " + course.Name + ", course duration : " + course.duration + ", course fees : " + course.fees);
        }
        public static void display(Enroll enroll)
        {
            Console.WriteLine("Enrollment Details");
            display(enroll.students);
            display(enroll.courses);
            Console.WriteLine("Date of Enrollment is " + enroll.datetime);
        }




    }
}
