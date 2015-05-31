using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsTrue()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void IsFalse()
        {
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void AddsTwoNumbers()
        {

            Assert.AreEqual(5,Calc.Addition(2,3),"Doesn't Add Up");
            Assert.AreEqual(35, Calc.Addition(12, 23), "Doesn't Add Up");
            Assert.AreEqual(5.9, Calc.Addition(2.2, 3.7), "Doesn't Add Up");
        }
    }
}
