using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_no_4
{
    abstract class Grade
    {
        public string name;
        public int studentid;
        public string grade;
        abstract public Boolean Ispassed(float grade);
    }
    class Undergraduate : Grade
    {
        public override Boolean Ispassed(float grade)
        {
            Console.WriteLine("-------  Q no 1  -----");
            Console.WriteLine("FOR Undergraduate student:-");
            Console.WriteLine("Enter Name of the Student :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student Id:");
            studentid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the grade;");
            grade = int.Parse(Console.ReadLine());
            Console.WriteLine("Student Name:{0}", name);
            Console.WriteLine("Student Id:{0}", studentid);
            Console.WriteLine("Student's grade",grade);

            if (grade >= 70.0)
            {
               Console.WriteLine("Student is passed: ");
                return true;
            }

            else
            {
                Console.WriteLine("Student is failed: ");
                return false;
            }
        }
    }
    class Graduate : Grade
    {
        public override Boolean Ispassed(float grade)
        {
            Console.WriteLine("For gratuate students :-");
            Console.WriteLine("Enter Name of the Student:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student Id:");
            studentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the grade;");
            grade = int.Parse(Console.ReadLine());
            Console.WriteLine("Student Name:{0}", name);
            Console.WriteLine("StudentId:{0}", studentid);
            Console.WriteLine("Student's grade", grade);

            if (grade >= 80.0)
            {
                Console.WriteLine("Student is passed: ");
                return true;
            }

            else
            {
                Console.WriteLine("Student is failed: ");
                return false;
            }



        }
    }
   
    // Employee=========
    public class Employee
    {
        public int empId;
        public string empName;
        public float salary;

        public Employee(int empId, string empName, float salary)
        {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
        }
        public void dispDetails()
        {
            Console.WriteLine("---Q no 2---");
            Console.WriteLine($"empName {empName} with empid {empId} gets salary of {salary}");
        }
        public class PartTimeemployee
        {
            public int wages = 400;

            public void showDetails()
            {
                Console.WriteLine("the parttime employee gets " , wages);
            }

            static void Main(string[] args)
            {
                Undergraduate ungrd = new Undergraduate();
                Console.WriteLine(ungrd.Ispassed(70.0f));

                Graduate grd = new Graduate();
                Console.WriteLine(grd.Ispassed(80.0f));



                Employee employee = new Employee(67563, "Manoj", 10000f);
                employee.dispDetails();
                PartTimeemployee ptemployee = new PartTimeemployee();
                ptemployee.showDetails();


                Students students = new Students();
                students.payFee();
                students.displayDetails();
                Console.WriteLine("enter the tranport fee you want to pay: ");
                DayScholar dayScholar = new DayScholar(int.Parse(Console.ReadLine()));
                Console.WriteLine("enter the hostel fee you want to pay: ");
                Hosteller hosteller = new Hosteller(int.Parse(Console.ReadLine()));
                Console.ReadLine();


            }
            
        }
    }
    // Student's fees==============
    public class Students
    {
        public int st_Id;
        public string st_Name;
        public double exam_fee;


        public void displayDetails()
        {
            Console.WriteLine($"\nthe student {st_Name} with id {st_Id} paid {exam_fee}");
        }
        public void payFee()
        {
            Console.WriteLine("---Q no 3---");
            Console.WriteLine("enter student id: ");
            st_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the student name: ");
            st_Name = Console.ReadLine();
            Console.WriteLine("the exam fee: is" + 1000);
            Console.WriteLine("enter the amount to pay examfee");
            exam_fee = int.Parse(Console.ReadLine());
            double rem_fee = 1000 - exam_fee;
            if (exam_fee == 1000)
            {
                Console.WriteLine("full fees paid no dues");
            }
            else
            {
                Console.WriteLine("the remaining fee: " + rem_fee);
            }
        }
    }
    class DayScholar
    {
        public double transport_fees;

        public DayScholar(double transport_fees)
        {
            this.transport_fees = transport_fees;
            double rem1_fee = 15000 - transport_fees;

            Console.WriteLine("the transport fee: " + 15000 + "per year ");


            Console.WriteLine($"the day scholar  paid {transport_fees} & remaining fee is {rem1_fee}");
            Console.ReadLine();
        }

    }
    public class Hosteller
    {
        public double hostel_fee;

        public Hosteller(double hostel_fee)
        {

            this.hostel_fee = hostel_fee;

            double rem2_fee = 20000 - hostel_fee;
            Console.WriteLine("the hostel  fee: " + 48000 + "per year ");

            Console.WriteLine($"the dayscholar  paid {hostel_fee} & remaining fee is {rem2_fee} ");
            Console.ReadLine();
        }

    }

}
