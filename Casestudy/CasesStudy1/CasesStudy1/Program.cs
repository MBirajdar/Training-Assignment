using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasesStudy1
{
    internal class Program
    {
        public class Student
        {
            public string id;
            public string name;
            public string dob;
            public override string ToString()
            {
                return "'\n'StudentId:" + " " + this.id + "\n " + "Student Name:" + " " + this.name + "\n " + "Student Dob:" + " " + this.dob;
            }



            public Student(string id, string name, string dob)
            {
                this.id = id;
                this.name = name;
                this.dob = dob;
            }
            public Student()
            {



            }



            public void setId(string id)
            {
                this.id = id;
            }
            public string getId()
            {
                return id;
            }
            public void setName(string name)
            {
                this.name = name;
            }
            public string getName()
            {
                return name;
            }
            public void setDob(string dob)
            {
                this.dob = dob;
            }
            public string getDob()
            {
                return dob;
            }
        }
        public class Info
        {
            public static void display(Student student)
            {
                Console.WriteLine($"The student details is student id {student.id}, student name {student.name}, student dob {student.dob}");
            }



        }
        public class App
        {
            public void scenerio1()
            {
                Student student = new Student("1", "Manoj Birajdar", "19/09/1999");
                Student student1 = new Student("2", "Ganesh Sagar", "11/05/1999");
                Student student2 = new Student("3", "Mahesh Shinde", "02/05/1999");
                Info.display(student);
                Info.display(student1);
                Info.display(student2);
            }
            public void scenerio2()
            {
                Student[] students = new Student[3];



                students[0] = new Student("11", "Rahul Dravid", "21/06/1995");
                students[1] = new Student("12", "Virat Kohali", "15/08/1997");
                students[2] = new Student("13", "Rohit Sharma", "03/11/1992");
                for (int i = 0; i < students.Length; i++)
                {
                    Info.display(students[i]);
                }
            }



            public void Scenerio3()
            {
                Console.WriteLine("Enter number of students:");
                var n = Convert.ToInt32(Console.ReadLine());
                object[] array = new object[n];
                for (int i = 0; i < n; i++)
                {
                    Student s = new Student();
                    Console.WriteLine("Enter id:");
                    s.id = Console.ReadLine();
                    Console.WriteLine("Enter Name:");
                    s.name = Console.ReadLine();
                    Console.WriteLine("Enter dob");
                    s.dob = Console.ReadLine();
                    array[i] = s;
                }
                foreach (object obj in array)
                {
                    Console.WriteLine("Student Details:- " + obj);
                }
            }



        }
        public class Test
        {
            public static void Main(string[] args)
            {
                do
                {
                    Console.WriteLine("Choose one");
                    Console.WriteLine("1.Scenerio1");
                    Console.WriteLine("2.Scenerio2");
                    Console.WriteLine("3.Scenerio3");
                    Console.WriteLine("4.Exit");
                    int x = Convert.ToInt32(Console.ReadLine());
                    App ap = new App();
                    if (x == 1)
                    {



                        ap.scenerio1();
                    }
                    if (x == 2)
                    {
                        ap.scenerio2();
                    }
                    if (x == 3)
                    {
                        ap.Scenerio3();
                    }
                    else _ = (x == 4);
                    {
                        Environment.Exit(0);
                    }




                } while (true);
            }
        }
    }
}
