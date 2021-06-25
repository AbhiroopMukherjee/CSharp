using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var Userinput = Console.ReadLine();
            long[] a = Array.ConvertAll(Userinput.Split(' '), long.Parse);

            randomizedQuickSort(a, 0, n - 1);
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        private static void randomizedQuickSort(long[] a, int l, int r)
        {
            if (l >= r)
            {
                return;
            }
            long k = random.Next(r - l + 1) + l;
            long t = a[l];
            a[l] = a[k];
            a[k] = t;
            //use partition3
            int[] m = partition3(a, l, r);
            //int m = partition2(a, l, r);
            randomizedQuickSort(a, l, m[0] - 1);
            randomizedQuickSort(a, m[1] + 1, r);
        }

        private static int[] partition3(long[] a, int l, int r)
        {
            int lt = l;
            int i = l;
            int gt = r;
            long pivot = a[l];


            while (i <= gt)
            {
                if (a[i] < pivot)
                {
                    long t = a[lt];
                    a[lt] = a[i];
                    a[i] = t;
                    lt += 1;
                    i += 1;
                }
                else if (a[i] > pivot)
                {
                    long t = a[gt];
                    a[gt] = a[i];
                    a[i] = t;
                    gt -= 1;
                }
                else
                    i += 1;
            }

            int[] m = { lt, gt };
            return m;
        }


        private static int partition2(long[] a, int l, int r)
        {
            long x = a[l];
            int j = l;
            for (int i = l + 1; i <= r; i++)
            {
                if (a[i] <= x)
                {
                    j++;
                    long u = a[i];
                    a[i] = a[j];
                    a[j] = u;
                }
            }
            long t = a[l];
            a[l] = a[j];
            a[j] = t;
            return j;
        }
    }
}
