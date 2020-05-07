using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace demo.test
{
    [TestClass]
    public class UnitTest1
    {
        private Random random;

        [TestInitialize]
        public void Initialize()
        {
            random = new Random(DateTime.Now.Millisecond);
        }

        [TestMethod]
        public void TestMethod1()
        {
            for(var i = 0; i < 10; i++)
            {
                var number = random.Next(0,1);
                Assert.AreEqual(0, number);
            }
        }
    }
}
