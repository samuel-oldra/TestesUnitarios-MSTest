using ProjetoExemplo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjetoExemplo.Tests
{
    [TestClass()]
    public class FuncMathTest
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideTest()
        {
            Assert.AreEqual(2, FuncMath.Divide(2, 1));
            Assert.AreEqual(1, FuncMath.Divide(1, 1));
            Assert.AreEqual(-1, FuncMath.Divide(-1, 1));
            Assert.AreEqual(-2, FuncMath.Divide(-2, 1));

            Assert.AreEqual(2.1, FuncMath.Divide(2.1, 1));
            Assert.AreEqual(1.1, FuncMath.Divide(1.1, 1));
            Assert.AreEqual(-1.1, FuncMath.Divide(-1.1, 1));
            Assert.AreEqual(-2.1, FuncMath.Divide(-2.1, 1));

            Assert.AreEqual(new DivideByZeroException(), FuncMath.Divide(1, 0));
            Assert.AreEqual(new DivideByZeroException(), FuncMath.Divide(10.1, 0));
        }

        [TestMethod()]
        public void SomaTest()
        {
            Assert.AreEqual(2, FuncMath.Soma(1, 1));
            Assert.AreEqual(0, FuncMath.Soma(1, -1));
            Assert.AreEqual(0, FuncMath.Soma(-1, 1));
            Assert.AreEqual(-2, FuncMath.Soma(-1, -1));

            Assert.AreEqual(2.2, FuncMath.Soma(1.1, 1.1));
            Assert.AreEqual(0, FuncMath.Soma(1.1, -1.1));
            Assert.AreEqual(0, FuncMath.Soma(-1.1, 1.1));
            Assert.AreEqual(-2.2, FuncMath.Soma(-1.1, -1.1));
        }
    }
}
