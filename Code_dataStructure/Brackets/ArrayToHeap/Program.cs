using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToHeap
{
    class Program
    {
        private static List<long> swaps = new List<long>();
        private static int counter = 0; 
        static void Main(string[] args)
        {
            long maxSize = Convert.ToInt32(Console.ReadLine());

            var Userinput1 = Console.ReadLine();
            long[] input = Array.ConvertAll(Userinput1.Split(' '), long.Parse);

            HeapSort(input,maxSize);

            Console.WriteLine(counter);
            long[] result = swaps.ToArray();

            int i = 0;
            while ((i/2)<counter)
            {
                Console.WriteLine(result[i+1]+" "+result[i]);
                i += 2;
            }


        }

        private static void HeapSort(long[] input, long maxSize)
        {
            for(long i = (maxSize - 1)/2; i >= 0; i--)
            {
                input = shiftDown(i, input);
            }

        }

        private static long[] shiftDown(long i, long[] input)
        {
            long maxIndex = i;
            long l = (2*i)+1;
            long r = (2*i)+2;
            int size = input.Length - 1;
            if (l <= size && input[l] < input[maxIndex])
                maxIndex = l;
            if (r <= size && input[r] < input[maxIndex])
                maxIndex = r;

            if (i != maxIndex)
            {
                Swap(maxIndex, i, input);
                shiftDown(maxIndex,input);
            }
            return input;
        }

        private static long[] shiftUp(long i, long[] input)
        {
            long temp = i;
            while (i>0 && (input[parent(i)] > input[i]))
            {
                input = Swap(parent(i),i,input);
                i = parent(i);
            }

            return input;
        }

        private static long[] Swap(long v1, long v2, long[] input)
        {
            //Console.WriteLine(v1+"  "+v2);
            swaps.Add(v1);
            swaps.Add(v2);
            counter++;
            long temp = input[v1];

            input[v1] = input[v2];
            input[v2] = temp;

            return input;

        }

        private static long parent(long i)
        {
            return (i-1)/2;
        }
    }
}
