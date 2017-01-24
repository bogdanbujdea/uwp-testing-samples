using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Calculator.UnitTestsApp
{
    [TestClass]
    public class MSTests
    {
        [TestMethod]
        public void SimpleClassTest()
        {
            var result = new UWPCalculator.Calculator().AddNumbers(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CaliburnViewModelTest()
        {
            var result = new UWPCalculator.ViewModel().MultiplyNumbers(2, 3);
            Assert.AreEqual(6, result);
        }
    }
}
