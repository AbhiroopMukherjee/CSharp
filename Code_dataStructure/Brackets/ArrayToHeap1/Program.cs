using System;
using System.Collections.Generic;

namespace ArrayToHeap1
{
    public class Program
    {
        private static List<int> swaps = new List<int>();
        private static int counter = 0;
        static void heapSort(int[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                swaps.Add(arr[i]);
                swaps.Add(arr[largest]);
                counter++;
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }
        public static void Main()
        {
            int maxSize = Convert.ToInt32(Console.ReadLine());

            var Userinput1 = Console.ReadLine();
            int[] input = Array.ConvertAll(Userinput1.Split(' '), int.Parse);
            heapSort(input, maxSize);

            foreach(var x in input)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine(counter);
            int[] result = swaps.ToArray();

            int i = 0;
            while ((i / 2) < counter)
            {
                Console.WriteLine(result[i] + " " + result[i + 1]);
                i += 2;
            }
        }
    }
}