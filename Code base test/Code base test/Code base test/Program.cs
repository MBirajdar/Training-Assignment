using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_base_test
{
    class Program
    {
        public static void Main()
        {
            // a query that returns list of numbers and their squares only if square is greater than 20
            Console.WriteLine("Q no 1-----");
            List<int> Numbers = new List<int> { 7,2,30 };

            var SelectedNumbers = Numbers.Where(m => m * m > 20);

            foreach (var n in SelectedNumbers)
            {
                Console.Write($"{n} - {n * n}, "); 
            }


            // a query that returns words starting with letter 'a' and ending with letter 'm'.
            Console.WriteLine("          ");
            Console.WriteLine("Q no 2------");

            List<string> words = new List<string> { "mum", "amsterdam", "bloom" };

            var selectedWords = words.Where(s => s.StartsWith("a")).Where(s => s.EndsWith("m"));

            foreach (var word in selectedWords)
            {
                Console.Write($"{word}, ");
              
            }

            Console.ReadLine();
        }

    }
   
}
