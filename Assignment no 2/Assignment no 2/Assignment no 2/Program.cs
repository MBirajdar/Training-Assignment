using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_no_2
{
    internal class program
    {
        static void Main(string[] args)
        {
            // 1, avarage maximum and minimum.
            Console.WriteLine("Q no 1");
            int[] Num = { 10, 20, 30, 40, 50 };
            Console.WriteLine("(10,20,30,40,50)");
            Console.WriteLine(" The avarage element :" + " " + Num.Average());
            Console.WriteLine(" The largest element :" + " " + Num.Max());
            Console.WriteLine(" The smallest element :" + " " + Num.Min());



            // marks avarage, maximum and minimum, sum of all marks, accending , decending order.
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Q no 2");
            int[] m = { 30,40,60,70,50,80,20 };
            Console.WriteLine("(marks: 30,40,60,70,50,80,20)");

            Console.WriteLine(" Minimum Marks :" + " " + m.Min());
            Console.WriteLine(" Maximum Marks :" + " " + m.Max());
            Console.WriteLine(" Avarage Marks:" + " " + m.Average());
            Console.WriteLine("Total Marks: " + m.Sum());

            Array.Sort(m);
            Console.WriteLine("array ascending order...");
            foreach (int i in m)
            {
                Console.WriteLine(i + " ");
            }
            Array.Reverse(m);
            Console.WriteLine("array decending order...");
            foreach (int i in m)
            {
                Console.WriteLine(i + " ");
            }


            // reverse string
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Q no 3-A");
            Console.WriteLine(" Enter  a string ");
            string Orginal = Console.ReadLine();
            string Reverse = string.Empty;

            for (int i = Orginal.Length - 1; i >= 0; i--)
            {
                Reverse += Orginal[i];
            }
            Console.WriteLine(" REVERESE STRING IS : " + Reverse);

            // both words are same or not
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Q no 3-B");
            Console.WriteLine("(two words are same or not)");
            Console.WriteLine(" Enter  a word 1:- ");
            string s1 = Console.ReadLine();
            Console.WriteLine(" Enter  a word 2:- ");
            string s2 = Console.ReadLine();

            if (s1 == s2)
            {
                Console.WriteLine(" both words are same ");
            }
            else if (s2 != s1)
            {
                Console.WriteLine(" both words are  not same ");
            }
           

            // lenght of string

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Q no 3-C");
            Console.WriteLine("Length of string");
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            Console.WriteLine(s.Length);
            Console.ReadLine();

            // To check whether the given word is a palindrome or not. 
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Q no 4");
            Console.WriteLine("Enter the word");
            string inputStr = Console.ReadLine();
            char[] letter = inputStr.ToCharArray();
            Array.Reverse(letter);
            string r;
            r = new string(letter);
            bool bool1 = inputStr.Equals(r, StringComparison.OrdinalIgnoreCase);
            if (bool1 == true)
            {
                Console.WriteLine("This string " + inputStr + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine("This string " + inputStr + " is not a Palindrome!");
            }
            Console.ReadLine();

        }
    }
}
