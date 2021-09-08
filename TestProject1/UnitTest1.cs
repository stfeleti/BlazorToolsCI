using BlazorToolsCI.Tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ICalculator cal;
        [TestInitialize]
        public void Init()
        {
            cal = new Calculator();
        }
        [TestMethod]
        public void AddTest()
        {
            int actual = cal.Add(3, 4);
            Assert.AreEqual<int>(expected: 7, actual: actual);
        }

        [TestMethod]
        public void SubTest()
        {
            int actual = cal.Sub(10, 4);
            Assert.AreEqual<int>(expected: 6, actual: actual);
        }
        [TestMethod]
        public void DivTest()
        {
            int actual = cal.Div(9, 3);
            Assert.AreEqual<int>(expected: 3, actual: actual);
        }
        [TestMethod]
        public void MulTest()
        {
            int actual = cal.Mult(3, 4);
            Assert.AreEqual<int>(expected: 12, actual: actual);
        }
    }
}
