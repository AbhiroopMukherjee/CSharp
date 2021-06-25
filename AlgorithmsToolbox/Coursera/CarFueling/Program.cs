using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFueling
{
    class Program
    {
        static void Main(string[] args)
        {
            var TotalDistance = Convert.ToInt32(Console.ReadLine());
            var MileAge = Convert.ToInt32(Console.ReadLine());
            var NoOfStations = Convert.ToInt32(Console.ReadLine());

            var input = Console.ReadLine();
            int[] Stations = new int[NoOfStations + 2];
            Stations[0] = 0;
            Stations[NoOfStations+1] = TotalDistance;

            int[] input1 = Array.ConvertAll(input.Split(' '), int.Parse);
            for (int i=1; i <= NoOfStations; i++)
            {
                Stations[i] = input1[i - 1];
            }
            


            int numRefill = 0, currentRefill = 0;

            while (currentRefill <= NoOfStations)
            {
                int lastRefill = currentRefill;

                while (currentRefill <= NoOfStations && (Stations[currentRefill+1] - Stations[lastRefill] <= MileAge))
                    currentRefill += 1;

                if (currentRefill == lastRefill)
                {
                    numRefill = -1;
                    break;
                }

                if (currentRefill <= NoOfStations)
                    numRefill += 1;
            }
            Console.WriteLine(numRefill);
            Console.ReadKey();
        }
    }
}
