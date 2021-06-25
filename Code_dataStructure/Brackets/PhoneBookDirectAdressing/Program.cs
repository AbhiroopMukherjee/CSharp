using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookDirectAdressing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Output = new List<string>();
            int NoOfQueries = Convert.ToInt32(Console.ReadLine());

            string[] phoneBook = new string[10000000];

            for(int i = 0; i < NoOfQueries; i++)
            {
                var Userinput = Console.ReadLine().Split(' ');

                if (Userinput[0].Contains("add"))
                    Add(Userinput[1], Userinput[2], phoneBook);

                else if (Userinput[0].Contains("del"))
                    Del(Userinput[1], phoneBook);

                else if (Userinput[0].Contains("find"))
                    Output.Add(Find(Userinput[1], phoneBook));

                else
                    Console.WriteLine("Invalid input");
            }
            foreach(var str in Output)
                Console.WriteLine(str);
        }

        private static string Find(string v, string[] phoneBook)
        {
            long index = Convert.ToInt64(v);
            if(phoneBook[index] == null)
                return "not found";
            return phoneBook[index];
        }

        private static void Del(string v, string[] phoneBook)
        {
            long number = Convert.ToInt64(v);
            phoneBook[number] = null;
        }

        private static void Add(string v1, string v2, string[] phoneBook)
        {
            long number = Convert.ToInt64(v1);

            phoneBook[number] = v2;
        }
    }
}
