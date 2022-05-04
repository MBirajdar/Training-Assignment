using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_no_6
{
    interface IStudent
    {
        void DisplayDetails(int Id, string Name);
    }
    class DaySholar : IStudent
    {
        public void DisplayDetails(int Id, string Name)
        {
            Console.WriteLine("Q no 1====");
            Console.WriteLine("Student id is: {0}", Id);
            Console.WriteLine("Name of the Student is: {0}", Name);
        }
    }
    class Resident : IStudent
    {
        public void DisplayDetails(int Id, string Name)
        {
            Console.WriteLine("Student id is :{0}", Id);
            Console.WriteLine("Name of the Student is :{0}", Name);
        }
    }
    // a structure called Books with a private field called Book_id

    struct Books
    {
        public string Name;
        private int BookId { get; set; }

        public int BookID
        {
            get
            {
                return BookId;
            }
            set
            {
                BookId = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("                        ");
            Console.WriteLine("Q no 2===");
            Console.WriteLine("Book Id is: {0}", BookId);
            Console.WriteLine("Book name is: {0}", Name);
        }


    }


    class InterfaeEg
    {
        static void Main()
        {

            IStudent obj = new DaySholar();
            obj.DisplayDetails(1, "Manoj Birajdar");


            IStudent obj1 = new Resident();
            obj1.DisplayDetails(2, "Ganesh Birajdar");



            Books book = new Books();
            book.BookID = 111;
            book.Name = "The Mahabharata";
            book.Display();

            Console.ReadLine();


        }
    }
}
