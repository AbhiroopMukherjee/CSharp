using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>[] array = new List<string>[5];

            array[0] = new List<string>();
            array[1] = new List<string>();

            array[0].Add("Hello1");
            array[0].Add("Hello2");
            array[0].Insert(0,"Hello1");

            foreach(var x in array[0])
                Console.WriteLine(x);

            if(array[1]==null)
                Console.WriteLine("null");
            else
                Console.WriteLine("Not null");

            foreach (var x in array)
                Console.WriteLine(x);
        }
    }
}
