using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var Userinput1 = Console.ReadLine();
            long[] input1 = Array.ConvertAll(Userinput1.Split(' '), long.Parse);

            var Userinput2 = Console.ReadLine();
            long[] input2 = Array.ConvertAll(Userinput2.Split(' '), long.Parse);

            long[] InputArray = new long[input1[0]];

            for(int i = 1; i <= input1[0]; i++)
            {
                InputArray[i - 1] = input1[i];
            }

            for (int i = 1; i <= input2[0]; i++)
            {
                Console.Write(BinarySearch(InputArray,0,Convert.ToInt32(input1[0]-1),input2[i]) + " ");;
            }
        }

        private static int BinarySearch(long[] inputArray,int low ,int high, long v)
        {
            if (high < low)
                return -1;
            int mid = (low + ((high - low) / 2));

            if (v == inputArray[mid])
                return mid;

            else if (v > inputArray[mid])
                return BinarySearch(inputArray, mid + 1, high, v);
            else
                return BinarySearch(inputArray, low, mid - 1, v);
        }
    }
}
