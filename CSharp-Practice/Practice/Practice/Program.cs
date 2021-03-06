// using SendGrid's C# Library
// https://github.com/sendgrid/sendgrid-csharp
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Practice;

namespace Example
{
    internal class Example
    {
        private static void Main()
        {
            //Execute().Wait();

            //int i = 10;

            //callfunc(ref i);

            //Console.WriteLine(i);
            Console.WriteLine(StaticVariable.value1);
            Console.WriteLine(StaticVariable.value2);

            StaticVariable.value1 = 2;
            Console.WriteLine(StaticVariable.value1);

            StaticVariable.value1 = 3;
            Console.WriteLine(StaticVariable.value1);

            StaticVariable.value1 = 4;
            Console.WriteLine(StaticVariable.value1);


            StaticVariable.value2 = "ABCD";
            Console.WriteLine(StaticVariable.value2);

            StaticVariable.value2 = "efgh";
            Console.WriteLine(StaticVariable.value2);

            StaticVariable.value2 = "ijkl";
            Console.WriteLine(StaticVariable.value2);
        }

        private static void callfunc(ref int i)
        {
            i=i-2;
            Console.WriteLine(i);
        }

        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }


        static async Task Execute()
        {

            Console.WriteLine(GetEnumDescription(enumdemo.FunctionStarted));

        }
    }
}