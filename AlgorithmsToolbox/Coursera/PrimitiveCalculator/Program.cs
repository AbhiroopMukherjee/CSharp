using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            //var sequence = PC_wrong(input);
            var sequence = PC(input);

            Console.WriteLine(sequence.Count - 1);

            foreach(var x in sequence)
                Console.Write(x+"\t");
        }

        private static List<int> PC(int n)
        {
            List<int> sequence = new List<int>();

            int[] arr = new int[n + 1];

            for (int i = 1; i < arr.Count(); i++)
            {
                arr[i] = arr[i - 1] + 1;
                if (i % 2 == 0) arr[i] = min(1 + arr[i / 2], arr[i]);
                if (i % 3 == 0) arr[i] = min(1 + arr[i / 3], arr[i]);

            }

            for (int i = n; i > 1;)
            {
                sequence.Add(i);
                if (arr[i - 1] == arr[i] - 1)
                    i = i - 1;
                else if (i % 2 == 0 && (arr[i / 2] == arr[i] - 1))
                    i = i / 2;
                else if (i % 3 == 0 && (arr[i / 3] == arr[i] - 1))
                    i = i / 3;
            }
            sequence.Add(1);

            sequence.Reverse();
            return sequence;
        }

        private static int min(int v1, int v2)
        {
            if (v1 > v2)
                return v2;
            else
                return v1;
        }

        private static List<int> PC_wrong(int input)
        {
            List<int> sequence = new List<int>();

            while (input >= 1)
            {
                sequence.Add(input);
                if (input % 3 == 0)
                {
                    input /= 3;
                }
                else if ((input - 1) % 3 == 0)
                {
                    input -= 1;
                }
                else if (input % 2 == 0)
                {
                    input /= 2;
                }
                else
                {
                    input -= 1;
                }
            }
            sequence.Reverse();

            return sequence;
        }
    }
}
