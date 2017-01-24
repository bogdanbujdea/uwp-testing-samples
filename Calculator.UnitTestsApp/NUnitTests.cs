using NUnit.Framework;

namespace Calculator.UnitTestsApp
{
    public class NUnitTests
    {
        [Test]
        public void SimpleClassTest()
        {
            var result = new UWPCalculator.Calculator().AddNumbers(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CaliburnViewModelTest()
        {
            var result = new UWPCalculator.ViewModel().MultiplyNumbers(2, 3);
            Assert.AreEqual(6, result);
        }
    }
}
