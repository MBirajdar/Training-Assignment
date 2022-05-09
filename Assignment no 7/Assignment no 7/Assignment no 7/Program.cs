using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_no_7
{
    public class Employee
    {


        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title;
        public DateTime DOJ { get; set; }
        public DateTime DOB { get; set; }
        string City { get; set; }

        public override string ToString()
        {
            return EmployeeID + " " + FirstName + " " + LastName + " " + Title + " " + DOJ + " " + DOB + " " + City;
        }
        static void Main(string[] args)
        {
            List<Employee> Emp1 = new List<Employee>()
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = DateTime.Parse("11/16/1984"),DOJ =DateTime.Parse("8/6/2011"), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB =DateTime.Parse("08/20/1984"),DOJ =DateTime.Parse("7/7/2012"), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = " Madhavi", LastName = " Oza", Title = "Consultant", DOB =DateTime.Parse("11/14/1987"),DOJ = DateTime.Parse("12/4/2015"), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba ", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("6/3/1990"),DOJ = DateTime.Parse("2/2/2016"), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = DateTime.Parse("3/8/1991"),DOJ = DateTime.Parse("2/2/2016"), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = DateTime.Parse("7/1/1989"),DOJ =DateTime.Parse( " 8/8/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan ", Title = "Consultant", DOB =DateTime.Parse("2/12/1989"),DOJ =DateTime.Parse( "1/6/2015"), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = " Dubey", Title = "Associate", DOB = DateTime.Parse("11/11/1993"),DOJ = DateTime.Parse("6/11/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry ", Title = "Associate", DOB = DateTime.Parse("12/8/1992"),DOJ = DateTime.Parse("3/12/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = " Shah", Title = "Manager", DOB =DateTime.Parse("12/4/1991"),DOJ = DateTime.Parse("2/1/2016"), City = "Pune" },

            };
            IEnumerable<Employee> Query1 = from Employee in Emp1
                                           where Employee.DOB > DateTime.Parse("1/1/1990")
                                           select Employee;
            Console.WriteLine("1]   a list of all the employee whose date of birth is after 1/1/1990");
            foreach (var E in Query1)
            {
                Console.WriteLine(E.ToString());
            }

            IEnumerable<Employee> Query2 = from Employee in Emp1
                                           where Employee.Title == "Associate" || Employee.Title == "Consultant"
                                           select Employee;
            Console.WriteLine("             ");
            Console.WriteLine("2]   a list of all the employee whose designation is Consultant and Associate");

            foreach (Employee e in Query2)
            {

                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("             ");


            Console.WriteLine("3]   total number of employees:{0}", Emp1.Count());
            Console.WriteLine("             ");

            var Query4 = (from Emp in Emp1
                          where Emp.City == "Chennai"
                          select Emp).Count();
            Console.WriteLine("4]    total number of employees belonging to “Chennai”: {0}", Query4);
            Console.WriteLine("             ");

            var Query5 = Emp1.Max(Emp => Emp.EmployeeID);
            Console.WriteLine(" 5]    highest employee id from the list: {0}", Query5);
            Console.WriteLine("             ");

            var Query6 = (from Emp in Emp1
                          where Emp.DOJ > DateTime.Parse("1/1/2015")
                          select Emp).Count();
            Console.WriteLine("6]   total number of employee who have joined after 1/1/2015  : {0}", Query6);
            Console.WriteLine("             ");


            var Query7 = (from Emp in Emp1
                          where Emp.Title != "Associate"
                          select Emp).Count();
            Console.WriteLine("7]     total number of employee whose designation is not “Associate” : {0}", Query7);
            Console.WriteLine("             ");


            var Query8 = (from Emp in Emp1
                          orderby Emp.City
                          select Emp).Count();
            Console.WriteLine(" 8]   total number of employee based on City:{0}", Query8);
            Console.WriteLine("             ");

            var Query9 = (from Emp in Emp1
                          orderby Emp.City
                          orderby Emp.Title
                          select Emp).Count();
            Console.WriteLine(" 9]  total number of employee based on city and title:{0}", Query9);
            Console.WriteLine("             ");


            var Query10 = (Emp1.OrderByDescending(A => A.DOB).Take(1));
            Console.WriteLine("10]  A employee who is youngest in the list");

            foreach (var Em in Query10)
            {
                Console.WriteLine(Em.ToString());
            }



            Console.ReadLine();

        }


    }
}
