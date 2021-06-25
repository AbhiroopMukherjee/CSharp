using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfInversions
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var Size = Convert.ToInt32(Console.ReadLine());

            var Userinput = Console.ReadLine();
            long[] A = Array.ConvertAll(Userinput.Split(' '), long.Parse);
            long[] B = new long[Convert.ToInt32(Userinput)];



            var NumberOfInversions = getNumberOfInversions(A,B,0, Convert.ToInt32(Userinput));

            Console.WriteLine(NumberOfInversions);
        }

        private static long getNumberOfInversions(long[] a, long[] b, int left, int right)
        {
            long numberOfInversions = 0;
            if (right <= left + 1)
            {
                return numberOfInversions;
            }
            int ave = (left + right) / 2;
            numberOfInversions += getNumberOfInversions(a, b, left, ave);
            numberOfInversions += getNumberOfInversions(a, b, ave, right);

            long[] F = Merge(D, E);
            return numberOfInversions;
        }

        private static long[] Merge(long[] d, long[] e)
        {
            int size = d.Count() + e.Count();

            long[] G = new long[size];

            int counter = 0;
            int i = 0;
            int j = 0;

            while (counter < size)
            {
                if (i >= d.Count())
                {
                    G[counter] = e[j];
                    j += 1;
                }
                else if (j >= e.Count())
                {
                    G[counter] = d[i];
                    i += 1;
                }
                else if (d[i] <= e[j])
                {
                    G[counter] = d[i];
                    i += 1;
                }
                else
                {
                    G[counter] = e[j];
                    j += 1;
                    //inversions++;
                }
                counter += 1;
            }

            return G;
        }
    }
}
