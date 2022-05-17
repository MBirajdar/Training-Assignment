using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_base_test_2
{
    class Program
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        public delegate void divnum(int a, int b);
        public delegate void mulnum(int a, int b);




        public void sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void divison(int a, int b)
        {
            Console.WriteLine(a / b);
        }



        public static void Main()
        {
            Program app = new Program();
            addnum sum1 = new addnum(app.sum);
            subnum sub1 = new subnum(app.subtract);
            divnum div1 = new divnum(app.divison);
            mulnum mul1 = new mulnum(app.multiplication);
         
            Console.ReadLine();
        }
    }
}
