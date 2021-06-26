using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;
using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Xunit;

namespace Test
{
    public delegate string WriteLog(string msg);

    [TestClass]
    public class TypeTest
    {
        [TestMethod]
        public void Test2()
        {
            //int x = 12;
            //string x = "x";
            //var e = x.GetHashCode();
            //x = x + 1;

            //var f = x.GetHashCode();
            //var s = x.CompareTo(x);

            //var t = x.GetHashCode();

            //Console.WriteLine(x);
            var book1 = GetBook("book1");
            var book2 = GetBook("book2");

            Assert.AreEqual("book1", book1.Name);
            Assert.AreEqual("book2", book2.Name);
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }

        [TestMethod]
        public void Test3()
        {
            var book1 = GetBook("book1");
            //var book2 = GetBook("book2");
            var book2 = book1;

            Assert.AreSame(book1, book2);
            Assert.IsTrue(object.ReferenceEquals(book1, book2));
        }

        [TestMethod]
        public void Test4()
        {
            var book1 = GetBook("book1");
            SetName(book1, "New name");

            Assert.AreEqual("book1", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            //book = new Book(name);
            book.Name = name;
        }

        [TestMethod]
        public void Test5()
        {
            var book1 = GetBook("book1");
            //var y = book1.GetHashCode();
            InMemoryBook book2 = book1;
            var y = book2.Equals(book1);
            Console.WriteLine(y);

            book2 = GetBook("book2");
            var ru = book2.Equals(book1);
            Console.WriteLine(ru);

            SetNameref(book1, "New name");

            Assert.AreEqual("book1", book1.Name);
        }

        private void SetNameref(InMemoryBook book, string name)
        {
            // book = new Book(name);
            var z = book.GetHashCode();
            Console.WriteLine(z);
        }
        [TestMethod]
        public void Test6()
        {
            String str = "Abhi";
            string str1 = MakeUpper(str);

            Console.WriteLine("str- "+str);
            Console.WriteLine("str1 -"+str1);
        }
        private string MakeUpper(string str1)
        {
            return str1.ToUpper();
        }

        int count = 0;
        [TestMethod]
        public void Test7()
        {
            WriteLog log = ReturnMsg;
            log += IncrementCount;
            var result = log("hello!");
            //Assert.AreEqual("hello!", result);
            Console.WriteLine(result);
            Assert.AreEqual(2, count);
            

        }

        private string IncrementCount(string msg)
        {
            count++;
            Console.WriteLine("A1");
            return ("A");
        }

        private string ReturnMsg(string msg)
        {
            count++;
            Console.WriteLine("B1");
            return ("B");
        }
    }
}
