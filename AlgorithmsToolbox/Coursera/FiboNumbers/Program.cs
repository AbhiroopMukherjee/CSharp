using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] fibo = new int[n+1];

            fibo[0] = 0; 

            if (n == 0)
            {
                Console.WriteLine(fibo[0]);
            }
            else if(n == 1)
            {
                fibo[1] = 1;
                Console.WriteLine(fibo[1]);
            }

            else
            {
                fibo[1] = 1;
                for (int i = 2; i <= n; i++)
                {
                    fibo[i] = (fibo[i - 1] + fibo[i - 2])%10;
                }

                Console.WriteLine(fibo[n]%10);
            }

        }
    }
}
