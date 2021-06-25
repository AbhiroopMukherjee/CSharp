using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChangeDP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = { 1, 3, 4 };

            int money = Convert.ToInt32(Console.ReadLine());

            var NoOfCoins = DPChange(money, coins);

            Console.WriteLine(NoOfCoins);
        }

        private static int DPChange(int money, int[] coins)
        {
            int[] MinNumCoins = new int[money+1];
            MinNumCoins[0] = 0;

            for (int m = 1; m <= money; m++)
            {
                MinNumCoins[m] = 100000;

                for (int i = 1; i<= coins.Count(); i++)
                {
                    if (m >= coins[i-1])
                    {
                        int numCoins = MinNumCoins[m - coins[i-1]] + 1;
                        if (numCoins < MinNumCoins[m])
                            MinNumCoins[m] = numCoins;
                    }
                }
            }
            return MinNumCoins[money];
        }
    }
}
