using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_no_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1==num2)
            {
                Console.WriteLine("Two numbers are equal");
            }
            else
            {
                Console.WriteLine("Two numbers are not equal");
            }

            //to check whether a given number is positive or negative
           
            Console.WriteLine("Enter the number to check whether a given number is positive or negative");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Given number is positive");
            }
            else
            {
                Console.WriteLine("Given number is negitive");
            }
            //program that takes two numbers as input and perform an operation (+,-,*,/) on them and displays the result of that operation.
            int n1, n2, result;
            char operation;
            Console.WriteLine("enter the frist number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose the operation");
            Console.WriteLine("1 addition");
            Console.WriteLine("2 subtraction");
            Console.WriteLine("3 multiplication");
            Console.WriteLine("4 division");
            operation = Convert.ToChar(Console.ReadLine());
            switch(operation)
            {
                case '1':
                    result = n1 + n2;
                    Console.WriteLine("the addition of two number is :{0}",result);
                    break;
                case '2':
                    result = n1 - n2;
                    Console.WriteLine("the subtraction of two number is :{0}",result);
                    break;
                case '3':
                    result = n1 * n2;
                    Console.WriteLine("the miltiplication of two number is:{0}",result);
                    break;
                case '4':
                    result = n1 / n2;
                    Console.WriteLine("the division of two number is:{0}",result);
                    break;
                default:
                    Console.WriteLine("invilid");
                    break;
            }
            Console.ReadLine();










        }
    }
}
