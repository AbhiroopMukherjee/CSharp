using System;
using System.Collections;

namespace Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            Stack stack = new Stack();
            int counter = 1; bool success = true;
            ArrayList al = new ArrayList();

            foreach (char ch in str)
            {
                if (ch == '[' || ch == ']' || ch == '{' || ch == '}' || ch == '(' || ch == ')')
                {
                    if (ch == '[' || ch == '(' || ch == '{')
                    {
                        stack.Push(ch);
                        al.Add(counter);
                    }
                    else
                    {
                        if (stack.IsEmpty())
                        {
                            Console.WriteLine(counter);
                            success = false;
                            break;
                        }
                        var top = stack.Pop();
                        al.RemoveAt(al.Count - 1);
                        if (!((top=='[' && ch==']') || (top == '(' && ch == ')') || (top == '{' && ch == '}')))
                        {
                            Console.WriteLine(counter);
                            success = false;
                            break;
                        }      
                    }
                }
                counter++;
            }
            if(success && stack.IsEmpty())
                Console.WriteLine("Success");
            else if(!stack.IsEmpty() && success)
                Console.WriteLine(al[al.Count-1]);   
        }

        internal class Stack
        {
            static readonly int max = 100000;
            int top;
            char[] stack = new char[max];

            public Stack()
            {
                top = -1;
            }

            internal bool IsEmpty()
            {
                return (top < 0);
            }

            internal bool Push(char data)
            {
                if (top >= max)
                {
                    Console.WriteLine("Stack overflow");
                    return false;
                }
                else
                {
                    stack[++top] = data;
                    return true;
                }
            }

            internal char Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack uderflow");
                    return '0';
                }
                else
                {
                    char value = stack[top--];
                    return value;
                }
            }

        }
    }
}
