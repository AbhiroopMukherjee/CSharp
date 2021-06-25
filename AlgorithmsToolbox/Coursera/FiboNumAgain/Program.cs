using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboNumAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            ulong[] inputs = Array.ConvertAll(input.Split(' '), ulong.Parse);

            ulong n = inputs[0], m = inputs[1];

            ulong[] pattern = new ulong[10000];
            pattern[0] = 0;
            pattern[1] = 1;

            ulong[] series = new ulong[10000];
            series[0] = 0;
            series[1] = 1;

            int count = 0;

            for (ulong i = 2; i < n - 1; i++)
            {
                series[i] = series[i-1] + series[i-2];
                pattern[i] = series[i] % (ulong)m;

                if(pattern[i] == 1 && pattern[i-1] == 0 && count > 0)
                {
                    break;
                }
                count++;
            }

            //long interval = pattern.Count() - 2;
            ulong index = n % ((ulong)count+1);

            Console.WriteLine(pattern[index]);

            Console.ReadKey();
        }
    }
}
