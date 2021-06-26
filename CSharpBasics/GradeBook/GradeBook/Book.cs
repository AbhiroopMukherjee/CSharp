using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GradeBook
{
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }
        public string Name
        {
            get;
            set;
        }
    }

    public interface IBook
    {
        void AddGrade(List<double> grade);
        Statistics BookStats();
        string Name { get; }
    }
    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(List<double> grade);

        public abstract Statistics BookStats();

    }
    public class InMemoryBook : Book
    {
        List<double> numbers;
        private string name;

        readonly string category = "Science";
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        if (!String.IsNullOrEmpty(value))
        //        {
        //            name = value;
        //        }
        //    }
        //}

        public InMemoryBook(String name) : base(name)
        {
            //var c = new Class1();
            //var ss = c.Print();
            numbers = new List<double>();
            Name = name;
        }

        public void AddGrade(char letter)
        {
            List<double> grade = new List<double>();

            switch (letter)
            {
                case 'A':
                    grade[0] = 90;
                    AddGrade(grade);
                    break;
                case 'B':
                    grade[0] = 80;
                    AddGrade(grade);
                    break;
                case 'C':
                    grade[0] = 70;
                    AddGrade(grade);
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
        }


        public override void AddGrade(List<double> x)
        {
            for (int i = 0; i < x.Count; i++)
            {
                numbers.Add(x[i]);
            }

        }

        public override Statistics BookStats()
        {
            var result = new Statistics(numbers);
            result.computeStats();
            return result;
        }

    }

    // ---- Implementation of Disk Book ----------------------

    public class DiskBook : Book
    {
        List<double> numbers;
        //private string name;

        readonly string category = "Science";

        public DiskBook(String name) : base(name)
        {
            numbers = new List<double>();
            Name = name;
        }


        public override void AddGrade(List<double> x)
        {
            ClearContents();
            for (int i = 0; i < x.Count; i++)
            {
                ////StreamWriter writer = null;
                ////try
                ////{
                ////    writer = File.AppendText($"{Name}.txt");

                ////}

                ////finally
                ////{
                ////    writer.Dispose();
                ////}
                // Use of above syntax is same as below
                // For code readability we use using block

                using (var writer = File.AppendText($"{Name}.txt"))
                {
                    writer.WriteLine(x[i]);
                }

            }

        }

        private void ClearContents()
        {
            File.Delete($"{Name}.txt");
        }

        public override Statistics BookStats()
        {

            var count = GetLineCount();
            using (var reader = File.OpenText($"{Name}.txt"))
            {
                for (int i = 0; i < count - 1; i++)
                {
                    var line = reader.ReadLine();

                    numbers.Add(double.Parse(line));
                }
            }

            var result = new Statistics(numbers);
            result.computeStats();
            return result;

        }

        private int GetLineCount()
        {
            var file = new StreamReader($"{Name}.txt").ReadToEnd(); // big string
            var lines = file.Split(new char[] { '\n' });           // big array
            return lines.Count();
        }

    }
}
