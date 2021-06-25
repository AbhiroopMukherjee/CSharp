using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboSumLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            ulong[] fibo = new ulong[n + 1];

            if (n < 2)
            {
                Console.WriteLine(n);
            }
            int i = 0;
            fibo[0] = 0;
            fibo[1] = 1;
            ulong[] sum = new ulong[100];
            sum[1] = 1;
            for (i = 2; i <= n; i++)
            {
                fibo[i] = (fibo[i - 1] + fibo[i - 2]) ;
                sum[i]= sum[i-1] + fibo[i];
                Console.WriteLine(sum[i]);
            }

            //Console.WriteLine(sum[i]);
            Console.ReadKey();
        }
    }
}
