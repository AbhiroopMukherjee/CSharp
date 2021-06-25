using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAmtOfGold
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Userinput1 = Console.ReadLine();
            var Userinput2 = Console.ReadLine();

            int[] a = Array.ConvertAll(Userinput1.Split(' '), int.Parse);
            int[] weights = Array.ConvertAll(Userinput2.Split(' '), int.Parse);

            int W = a[0];
            int noOfBags = a[1];

            int[,] values = new int[noOfBags + 1,W +1];

            for(int i = 0; i <= W; i++)
            {
                values[0, i] = 0;
            }
            for (int i = 0; i <= noOfBags; i++)
            {
                values[i, 0] = 0;
            }

            for(int i=1; i <= noOfBags; i++)
            {
                for(int j = 1; j <= W; j++)
                {
                    values[i, j] = values[i-1, j];

                    if (weights[i - 1] <= j)
                    {
                        int val = values[i - 1, j - weights[i - 1]] + weights[i - 1];
                        if (values[i, j] < val)
                        {
                            values[i, j] = val;
                        }
                    }
                }
            }

            Console.WriteLine(values[noOfBags,W]);
        }
    }
}
