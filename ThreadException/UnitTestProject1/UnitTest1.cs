using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreadException;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new Class1();
            Assert.ThrowsException<TimeoutException>(() => { sut.Timeout(); });
        }
    }
}
