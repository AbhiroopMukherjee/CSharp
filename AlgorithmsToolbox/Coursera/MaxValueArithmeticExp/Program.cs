using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValueArithmeticExp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Userinput1 = Console.ReadLine();
            char[] expression = Userinput1.ToCharArray();

            int Explength = expression.Count();

            int opCount = Explength / 2;

            char[] Operations = new char[opCount];
            char[] values = new char[Explength - opCount];

            int c1=0, c2 = 0;

            for(int i = 0; i < Explength; i++)
            {
                if (i % 2 == 0)
                {
                    values[c1] = expression[i];
                    c1++;
                }
                else
                {
                    Operations[c2] = expression[i];
                    c2++;
                }     
            }

            int ValueLength = values.Count();

            long[,] M = new long[ValueLength+1, ValueLength+1];
            long[,] m = new long[ValueLength+1, ValueLength+1];


            for(int i = 1; i <= ValueLength; i++)
            {
                m[i, i] = long.Parse(values[i-1].ToString());
                M[i, i] = long.Parse(values[i-1].ToString());
            }

            for (int s = 1; s <= ValueLength; s++)
            {
                for (int i = 1; i < (ValueLength + 1) - s; i++)
                {
                    int j = i + s;
                    long[] minMax = MinAndMax(m,M,i, j, Operations);
                    m[i, j] = minMax[0];
                    M[i, j] = minMax[1];
                }
            }

            Console.WriteLine(M[1, ValueLength]);
        }

        private static long[] MinAndMax(long[,] m, long[,] M,int i, int j, char[] Operations)
        {
            long max = Int32.MinValue; long min = Int32.MaxValue;

            for(int k = i; k < j; k++)
            {
                long a = Calculate(M[i, k], M[k + 1, j], Operations[k-1]);
                long b = Calculate(M[i, k], m[k + 1, j], Operations[k - 1]);
                long c = Calculate(m[i, k], M[k + 1, j], Operations[k - 1]);
                long d = Calculate(m[i, k], m[k + 1, j], Operations[k - 1]);

                long[] numbers1 = new[] { a, b, c, d, min };
                long[] numbers2 = new[] { a, b, c, d, max };
                min = numbers1.Min();
                max = numbers2.Max();
            }

            return new long[] { min, max };
        }


        private static long Calculate(long v1, long v2, char v3)
        {
            if (v3.Equals('*'))
                return v1 * v2;

            else if (v3.Equals('+'))
                return v1 + v2;

            else if (v3.Equals('-'))
                return v1 - v2;

            else
                throw new InvalidOperationException();
        }
    }
}
