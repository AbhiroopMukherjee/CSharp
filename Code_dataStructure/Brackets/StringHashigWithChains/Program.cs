using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHashigWithChains
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var m = Convert.ToInt32(Console.ReadLine());
            int NoOfQueries = Convert.ToInt32(Console.ReadLine());

            List<string>[] CardinalArray = new List<string>[m];
            List<string> Inputs = new List<string>();

            for(int i = 0; i < NoOfQueries; i++)
            {
                Inputs.Add(Console.ReadLine());
            }

            foreach(string input in Inputs)
            {
                string[] inputArray = input.Split(' ');

                if (inputArray[0].Contains("add"))
                    Add(inputArray[1],CardinalArray,m);
                else if (inputArray[0].Contains("find"))
                    Console.WriteLine(Find(inputArray[1], CardinalArray,m)); 
                else if (inputArray[0].Contains("del"))
                    Del(inputArray[1], CardinalArray,m);
                else if (inputArray[0].Contains("check"))
                {
                    var checks = Check(inputArray[1], CardinalArray);

                    if(checks == null)
                        Console.WriteLine();
                    else
                    {
                        foreach(string str in checks)
                            Console.Write(str+" ");
                        Console.WriteLine();
                    }
                }
                    
            }
        }

        private static List<string> Check(string v, List<string>[] cardinalArray)
        {
            long index = Convert.ToInt64(v);

            return cardinalArray[index];
        }

        private static void Del(string v, List<string>[] cardinalArray, int m)
        {
            long hash = GetHash(v,m);

            if (cardinalArray[hash] == null)
                return;

            foreach (string str in cardinalArray[hash])
            {

                if (str == v)
                {
                    cardinalArray[hash].Remove(v);
                    break;
                }
                    
            }
        }

        private static string Find(string v, List<string>[] cardinalArray, int m)
        {
            long hash = GetHash(v,m);

            string result = "no";

            if (cardinalArray[hash] != null)
            {
                foreach (string str in cardinalArray[hash])
                {
                    if (str == v)
                        result = "yes";
                }
            }
            return result;
        }

        private static void Add(string v, List<string>[] cardinalArray, int m)
        {
            if (Find(v, cardinalArray, m) == "yes")
            {
                return;
            }

            long hash = GetHash(v,m);

            if(cardinalArray[hash]==null)
                cardinalArray[hash] = new List<string>();


            cardinalArray[hash].Insert(0, v);
        }

        private static long GetHash(string v, int m)
        {
            ulong hash = 0;
            //int i = 0;
            long x = 263;
            ulong p = 1000000007;
            int l = v.Length;

            for(int i = v.Length - 1; i >= 0; --i)
            {

                //hash = hash + (((ulong)Convert.ToInt64(ch) * Convert.ToUInt64(Math.Pow(x, i))));
                hash = (hash * 263 + (ulong)v[i]) % p;
                //i++;
            }

            return (long)((hash%p) %(ulong)m);
        }
    }
}
