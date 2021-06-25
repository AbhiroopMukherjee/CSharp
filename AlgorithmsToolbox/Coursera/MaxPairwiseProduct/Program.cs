using System;

namespace MaxPairwiseProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long range = (long)Convert.ToDouble(Console.ReadLine());
            var input = Console.ReadLine();
            long[] array = Array.ConvertAll(input.Split(' '),long.Parse);

            long result = MaxWiseProduct(array);

            Console.WriteLine(result);
        }

        private static long MaxWiseProduct(long[] array)
        {
            long max1=0 , max2 = 0;
            int j=0;

            for(int i=0;i<array.Length;i++)
            {
                if (array[i] > max1)
                {
                    max1 = array[i];
                    j = i;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max2 && i!=j)
                {
                    max2 = array[i];
                }
            }

            return max1 * max2;
        }
    }
}
