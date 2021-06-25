using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var Userinput1 = Console.ReadLine();
            var Userinput2 = Console.ReadLine();

            int x = EditDistance(Userinput1, Userinput2);
            Console.WriteLine(x);
        }

        private static int EditDistance(string string1, string string2)
        {
            int l1 = string1.Length;
            int l2 = string2.Length;
            int[,] dist = new int[l1+1,l2+1];

            for (int i = 0; i <= l1; i++)
                dist[i, 0] = i;

            for (int i = 0; i <= l2; i++)
                dist[0, i] = i;

            for(int i = 1; i <= l1; i++)
            {
                for (int j = 1; j <= l2; j++)
                {
                    int insertion = dist[i, j - 1] + 1;
                    int deletion = dist[i - 1, j] + 1;
                    int match = dist[i - 1, j - 1];
                    int mismatch = dist[i - 1, j - 1] + 1;

                    if (string1[i-1] == string2[j-1])
                        dist[i, j] = min(insertion, deletion, match);
                    else
                        dist[i, j] = min(insertion, deletion, mismatch);
                }
            }

            return dist[l1, l2];
        }

        private static int min(int A, int B, int C)
        {
            if (A <= B && A <= C)
                return A;
            else if (B <= C)
                return B;
            else
                return C;
        }
    }
}
