using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingTables
{
    class Program
    {
        static void Main(string[] args)
        {
            var Userinput1 = Console.ReadLine();
            int[] input = Array.ConvertAll(Userinput1.Split(' '), int.Parse);

            int noOfTables = input[0];
            int noOfQueries = input[1];

            long[] parent = new long[noOfTables];
            long[] rank = new long[noOfTables];
            long[] max = new long[noOfQueries];

            var Userinput2 = Console.ReadLine();
            long[] values = Array.ConvertAll(Userinput2.Split(' '), long.Parse);

            foreach(var i in values)
            {
                if (i > max[0])
                    max[0] = i;
            }

            for (int i = 0; i < noOfTables; i++)
            {
                parent[i] = i;
                rank[i] = 0;
            }
                
            for(int i = 0; i < noOfQueries; i++)
            {
                var Userinput3 = Console.ReadLine();
                long[] unions = Array.ConvertAll(Userinput3.Split(' '), long.Parse);
                Union(unions[0]-1, unions[1]-1,parent, rank, values,i,max);

            }

            foreach(var i in max)
                Console.WriteLine(i);
        }

        private static long FindMax(long[] values)
        {
            long max = 0;
            foreach(var i in values)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }

        private static void Union(long v1, long v2, long[] parent, long[] rank, long[] values,int ix,long[] max)
        {
            long maximum = 0;
            if (ix == 0)
                maximum = max[0];
            else
                maximum = max[ix - 1];

            long v1_id = Find(v1,parent);
            long v2_id = Find(v2,parent);

            if (v1_id == v2_id)
            {
                max[ix] = maximum;
                return;
            }
            if (rank[v1_id] > rank[v2_id])
            {
                parent[v2_id] = v1_id;
                values[v1_id] += values[v2_id];
                if (values[v1_id] >maximum)
                    max[ix] = values[v1_id];
                else
                    max[ix] = maximum;
            } 
            else
            {
                values[v2_id] += values[v1_id];
                if (values[v2_id] > maximum)
                    max[ix] = values[v2_id];
                else
                    max[ix] = maximum;
                parent[v1_id] = v2_id;
                if (rank[v1_id] == rank[v2_id])
                    rank[v2_id] += 1;
            }

        }

        private static long Find(long v1, long[] parent)
        {
            if (v1 != parent[v1])
            {
                parent[v1] = Find(parent[v1], parent);
            }
            return parent[v1];
        }
    }
}
