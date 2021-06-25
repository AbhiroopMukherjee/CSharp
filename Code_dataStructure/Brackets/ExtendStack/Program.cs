using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendStack
{
    class Program
    {
        internal class Stack
        {
            static readonly int max = 100000;
            int top;
            int[] stack = new int[max];
            int[] maxNos = new int[max];
            int maxValue = int.MinValue;
            int counter = -1;

            public Stack()
            {
                top = -1;
            }

            internal bool IsEmpty()
            {
                return (top < 0);
            }

            internal bool Push(int data)
            {
                if (top >= max)
                {
                    Console.WriteLine("Stack overflow");
                    return false;
                }
                else
                {
                    stack[++top] = data;
                    if (data >= maxValue)
                    {
                        maxNos[++counter] = data;
                        maxValue = data;
                    }
                        
                    return true;
                }
            }

            internal int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack uderflow");
                    return '0';
                }
                else
                {
                    int value = stack[top--];
                    if(value == maxValue)
                    {
                        maxValue = maxNos[--counter];
                    }
                    return value;
                }
            }

            internal int Max()
            {
                return maxValue;
            }

        }
        static void Main(string[] args)
        {
            int NumberOfnputs = Convert.ToInt32(Console.ReadLine());
            String[] inputs = new String[NumberOfnputs];
            Stack stack = new Stack();

            for (int i = 0; i < NumberOfnputs; i++)
            {
                inputs[i] = Console.ReadLine(); 
            }

            foreach(var str in inputs)
            {
                if (str.Contains("push"))
                {
                    int value = Convert.ToInt32(str.Split(' ')[1]);
                    stack.Push(value);
                }
                else if (str.Contains("pop"))
                {
                    int value = stack.Pop();
                }
                else if (str.Contains("max"))
                {
                    int value = stack.Max();
                    Console.WriteLine(value);
                }
            }
        }
    }
}
