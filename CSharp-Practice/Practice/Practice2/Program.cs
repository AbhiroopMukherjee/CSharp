using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
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

            //Console.WriteLine((int)Math.Floor(Math.Sqrt(21)));
            //if (FindPrime(21))
            //{
            //    Console.WriteLine("Prime");
            //}
            //else
            //{
            //    Console.WriteLine("Not Prime");
            //}

            //RemoveDuplicates("CSharpCorner");

            //LeftCircularRotation(new int[]{1,2,3,4,5,});

            //SumOfDigits(5259);
            //SumOfDigitsActual(5259);

            //FindSecondLargestInteger(new[] {48, 22, 55, 33, 44});
            //FindThirdLargestInteger(new[] { 48, 22, 55, 33, 44, 66,77,99,88 });

            //TwoDToOneD(new int[,]{{1,2,3},{4,5,6}});
            //OneDToTwoD(new int[] {1, 2, 3, 4, 5, 6}, 2, 3);

            //FindTimeInAngle(13, 20);

            foreach (var fib in fibo(5))
            {
                Console.WriteLine(fib);
            }

        }

        private static IEnumerable<int> fibo(int length)
        {
            var result =  new int[length-1];

           throw new NotImplementedException();


        }

        public static void FindTimeInAngle(int hours, int mins)
        {
            int hourAngle = (hours % 12) * 30;
            int minAngle = mins * 6;

            if (hourAngle > minAngle)
            {
                Console.WriteLine(hourAngle - minAngle);
            }
            else if (minAngle > hourAngle)
            {
                Console.WriteLine(minAngle - hourAngle);
            }
            else{
                Console.WriteLine("0");
            }

        }

        public static void OneDToTwoD(int[] input,int row, int columns)
        {
            int[,] result = new int[row, columns];
            int index = 0;

            for (int i = 0; i < row; i++)
            {
                for(int j=0;j<columns;j++)
                {
                    result[i, j] = input[index];
                    index++;
                    Console.Write(result[i, j]+" ");
                }

                Console.WriteLine();
            }

        }

        public static void TwoDToOneD(int[,] input)
        {
            int index = 0;

            int length = input.GetLength(0);
            int width = input.GetLength(1);

            int[] single = new int[length*width];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(input[i,j]+" ");
                }
            }

        }

        public static void FindThirdLargestInteger(int[] input)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue; int max3 = int.MinValue;
           
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = input[i];
                }
                else if (input[i] > max2)
                {
                    max3 = max2;
                    max2 = input[i];
                }
                else if (input[i] > max3)
                {
                    max3 = input[i];
                }
            }

            Console.WriteLine(max3);
        }

        public static void FindSecondLargestInteger(int[] input)
        {
            int max1 = int.MinValue; int max2 = int.MinValue;
           
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max1)
                {
                    max2 = max1;
                    max1 = input[i];
                }
                else if (input[i] > max2)
                {
                    max2 = input[i];
                }
            }

            Console.WriteLine(max2);
        }

        public static void SumOfDigits(int input)
        {
            double temp = 0;double result = 0;
            double number = 0;
            int i=1;

            while (number != input)
            {
                number = input % (Math.Pow(10, i));
                

                if (i == 1)
                {
                    result = number;
                    temp = number;
                    i++;
                    continue;
                }

                result += (number - temp) / (Math.Pow(10, i - 1));
                temp = number;
                i++;
            }

            Console.WriteLine(result);
        }

        public static void SumOfDigitsActual(int input)
        {
            int sum = 0;

            while (input > 0)
            {
                sum += input % 10;
                input /= 10;
            }

            Console.WriteLine(sum);
        }

        public static void LeftCircularRotation(int[] input)
        {


            var temp1 = input[0];
            var temp2 = input[input.Length - 1];

            input[input.Length - 1] = temp1;

            Console.WriteLine("Before");
            foreach (var number in input)
            {
                Console.WriteLine(number);
            }

            for (int i = input.Length - 2; i >= 0; i--)
            {
                
                temp1 = input[i];
                input[i] = temp2;
                temp2 = temp1;
                
            }

            Console.WriteLine("After");
            foreach (var number in input)
            {
                Console.WriteLine(number);
            }

        }

        public static void RemoveDuplicates(string input)
        {
            string output = string.Empty;

            foreach (char ch in input)
            {
                if (!output.Contains(ch))
                {
                    output += ch;
                }
            }

            Console.WriteLine(output);
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
