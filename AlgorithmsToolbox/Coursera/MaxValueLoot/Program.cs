using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueLoot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            long[] input1 = Array.ConvertAll(input.Split(' '), long.Parse);
            int entries = (int)input1[0];
            long TotalWeight = input1[1];

            long[] weights = new long[entries];
            long[] values = new long[entries];

            for(int i=0;i<entries; i++)
            {
                var input2 = Console.ReadLine();
                values[i] = Array.ConvertAll(input2.Split(' '), long.Parse)[0];
                weights[i] = Array.ConvertAll(input2.Split(' '), long.Parse)[1];
            }

            double value = 0;

            for (int i = 0; i < entries; i++)
            {
                if (TotalWeight == 0)
                    break;

                double ValuePerUnit = 0;
                int index = 0;
                for (int j = 0; j < entries; j++)
                {
                    if(weights[j]>0 && (ValuePerUnit < (double)values[j] / (double)weights[j]))
                    {
                        ValuePerUnit = (double)values[j] / (double)weights[j];
                        index = j;
                    }

                }

                if(TotalWeight> weights[index])
                {
                    value += values[index];
                    TotalWeight -= weights[index];
                    weights[index] = 0;
                }
                else if (TotalWeight <= weights[index])
                {
                    value += ((double)values[index] / (double)weights[index])* TotalWeight;
                    TotalWeight = 0;
                }
            }

            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
