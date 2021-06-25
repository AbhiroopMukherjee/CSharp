using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            long[] array = Array.ConvertAll(input.Split(' '), long.Parse);

            long a, b;

            a = array[1]; b = array[0];
            if (array[0] > array[1])
            {
                a = array[0]; b = array[1];
            }
            int i = 1;
            while(true)
            {
                if ((b * i) % a == 0)
                {
                    Console.WriteLine(b * i);
                    break;
                }
                i++;
            }
        }
    }
}
