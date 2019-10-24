using System;
using Abcd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPush()
        {
            Stack s = new Stack();
            s.Push("a");
            s.Push("u");
            s.Push("o");
            Assert.AreEqual("o", s.Count());
            Assert.AreEqual("u", s.Pop());
        }

        [TestMethod]
        public void TestPop()
        {
            Stack s = new Stack();
            s.Push("a");
            s.Push("u");
            s.Push("o");
            Assert.AreEqual("o", s.Pop());
            Assert.AreEqual("u", s.Pop());
        }
        [TestMethod]
        public void TestPeek()
        {
            Stack s = new Stack();
            s.Push("a");
            s.Push("u");
            s.Push("o");
            Assert.AreEqual("o", s.Peek());
            Assert.AreEqual("u", s.Count());
        }
        [TestMethod]
        public void TestClear()
        {
            Stack s = new Stack();
            s.Push("a");
            s.Push("u");
            s.Push("o");
            Assert.AreEqual("o", s.Peek());
            Assert.AreEqual("u", s.Count());
        }
    }
}
