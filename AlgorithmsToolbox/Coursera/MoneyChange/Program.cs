using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int counter = 0;
            while (sum < n)
            {
                if (n-sum >= 10)
                    sum += 10;
                else if (n-sum >= 5)
                    sum += 5;
                else if (n-sum >= 1)
                    sum += 1;
                counter++;
            }

            Console.WriteLine(counter);

        }
    }
}
