using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ReverseString("Hello"));

            //IsPalindrome("abcba ");

            //ReverseEachWordsInSentence("Hello Sir, how are you?  ");

            //CountCharacters("Hello World");

            //FindAllSubstring("abcd");
            //findallsubstring("abcd");

            Console.WriteLine((int)Math.Floor(Math.Sqrt(21)));
            if (FindPrime(21))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
        internal static bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static string ReverseString(string input)
        {
            char[] output = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[input.Length - 1 - i];
            }

            return new string(output);
        }

        public static void IsPalindrome(string input)
        {
            bool ispd = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (!(input[i] == input[input.Length - 1 - i]))
                {
                    ispd = false;
                    break;
                }
            }
            if(ispd)
                Console.WriteLine("Is Palindrome");
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }

        public static void ReverseWordsInSentence(string input)
        {
            string temp1 = string.Empty;
            string temp2 = string.Empty;

            for (int j = input.Length - 1; j >= 0; j--)
            {
               
                if (input[j]!=' ')
                {
                    temp2 += input[j];
                }
                else
                {
                    for (int i = temp2.Length - 1; i >= 0; i--)
                    {
                        temp1 += temp2[i];
                    }

                    temp2 = string.Empty;
                    temp1 += " ";
                }
            }
            for (int i = temp2.Length - 1; i >= 0; i--)
            {
                temp1 += temp2[i];
            }

            Console.WriteLine(temp1);
        }

        public static void ReverseEachWordsInSentence(string input)
        {
            string temp1 = string.Empty;
            string temp2 = string.Empty;

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    temp1 += ch;
                }
                else
                {
                    for (int i = temp1.Length - 1; i >= 0; i--)
                    {
                        temp2 += temp1[i];
                    }
                    temp1 = String.Empty;
                    temp2 += " ";
                }
            }

            Console.WriteLine(temp2);
        }

        public static void CountCharacters(string input)
        {
            var dict1 = new Dictionary<char, int>();

            foreach (var ch in input)
            {
                if (dict1.ContainsKey(ch))
                {
                    dict1[ch] += 1;
                }
                else
                {
                    dict1.Add(ch,1);
                }
            }

            foreach(var kvp in dict1)
            {
                Console.WriteLine(kvp.Key +":"+kvp.Value);
            }
        }

        public static void FindAllSubstring(string input)
        {
            StringBuilder temp1 = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; (j + i) < input.Length; j++)
                {
                    for (int k=j; k <= j+i; k++)
                    {
                        temp1.Append(input[k]);
                    }

                    Console.WriteLine(temp1);
                    temp1.Clear();
                }
            }
        }

        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }
    }
}
