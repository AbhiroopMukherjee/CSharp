using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            long[] array = Array.ConvertAll(input.Split(' '), long.Parse);

            long a, b, c;

            a = array[1]; b = array[0];
            if (array[0] > array[1])
            {
                a = array[0]; b = array[1];
            }

            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }

            Console.WriteLine(a);
        }
    }
}
