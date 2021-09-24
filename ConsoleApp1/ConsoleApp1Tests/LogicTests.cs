using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void countTest()
        {
            
           void Test1()
            {
                var n = 100;
                var message = Logic.count(n);
                Assert.AreEqual("1 рубль ровно", message);
            }

            void Test2()
            {
                var n = 1;
                var message = Logic.count(n);
                Assert.AreEqual("1 копейка", message);
            }

            void Test3()
            {
                var n = 101;
                var message = Logic.count(n);
                Assert.AreEqual("1 рубль 1 копейка", message);
            }

            void Test4()
            {
                var n = 102;
                var message = Logic.count(n);
                Assert.AreEqual("1 рубль 2 копейки", message);
            }

            void Test5()
            {
                var n = 105;
                var message = Logic.count(n);
                Assert.AreEqual("1 рубль 5 копеек", message);
            }

            void Test6()
            {
                var n = 201;
                var message = Logic.count(n);
                Assert.AreEqual("2 рубля 1 копейка", message);
            }

            void Test7()
            {
                var n = 1101;
                var message = Logic.count(n);
                Assert.AreEqual("11 рублей 1 копейка", message);
            }

            
        }
    }
}