using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            IBook Book = new DiskBook("book2");

            List<double> numbers = new List<double>();
            EnterGrades(Book, numbers);

            var stats = Book.BookStats();
            Console.WriteLine($"For the book named {Book.Name}");
            Console.WriteLine($"The Highest Grade is {stats.high}");
            Console.WriteLine($"The Lowest Grade is {stats.low}");
            Console.WriteLine($"The average is {stats.average}");
            Console.WriteLine($"The Letter Grade is {stats.letter}");
            Console.ReadLine();

        }

        private static void EnterGrades(IBook Book, List<double> numbers)
        {
            Console.WriteLine("Enter your marks. Press q to exit");
            string input = "";

            while (input != "q")
            {
                input = Console.ReadLine();
                if (input != "q")
                {
                    try
                    {
                        if (double.Parse(input) > 100)
                        {
                            Console.WriteLine("You got more than 100!! Mad or what :X. Pease enter valid marks.");
                            continue;
                        }
                        numbers.Add(double.Parse(input));
                    }
                    catch (System.FormatException Se)
                    {
                        Console.WriteLine("Enter numbers or q to quit");
                        Console.WriteLine(Se.Message);
                    }

                }

            }

            Book.AddGrade(numbers);
        }
    }


}