using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majorityElement
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var Size = Convert.ToInt32(Console.ReadLine());

            var Userinput = Console.ReadLine();
            long[] input = Array.ConvertAll(Userinput.Split(' '), long.Parse);

            var sortedArray = MergeSort(input);

            int repeat = 0;
            bool majority=false;

            for(int i = 1; i < Size; i++)
            {
                if (sortedArray[i - 1] == sortedArray[i])
                    repeat += 1;
                else
                    repeat = 0;

                if (repeat >= (Size / 2))
                {
                    majority = true;
                    break;
                }     
            }

            if(majority)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }

        private static long[] MergeSort(long[] input)
        {
            if (input.Count() == 1)
                return input;

            var m = input.Count() / 2;
            long[] B = new long[m];
            long[] C;

            if (input.Count()%2==0)
                C = new long[m];
            else
                C = new long[m+1];


            for (int i = 0; i < m; i++)
                B[i] = input[i];
            for (int i = m; i < input.Count(); i++)
                C[i-m] = input[i];

            long[] D = MergeSort(B);
            long[] E = MergeSort(C);

            long[] F = Merge(D, E);

            return F;
        }

        private static long[] Merge(long[] d, long[] e)
        {
            int size = d.Count() + e.Count();

            long[] G = new long[size];

            int counter = 0;
            int i=0 ; 
            int j = 0;

            while (counter < size)
            {
                if (i >= d.Count())
                {
                    G[counter] = e[j];
                    j += 1;
                }
                else if(j >= e.Count())
                {
                    G[counter] = d[i];
                    i += 1;
                }
                else if(d[i] <= e[j])
                {
                    G[counter] = d[i];
                    i += 1;
                }
                else
                {
                    G[counter] = e[j];
                    j += 1;
                  
                }
                counter += 1;
            }

            return G;
        }
    }
}
