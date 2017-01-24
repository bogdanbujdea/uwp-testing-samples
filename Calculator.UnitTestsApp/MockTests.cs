using HyperMock;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using UWPCalculator;

namespace Calculator.UnitTestsApp
{
    [TestClass]
    public class MockTests
    {
        private Mock<ICalculator> _mockService;

        [TestMethod]
        public void mock_Test()
        {
            _mockService = Mock.Create<ICalculator>();
            _mockService.Setup(c => c.AddNumbers(Param.IsAny<int>(), Param.IsAny<int>())).Returns(4);
            var viewModel = new ViewModel(_mockService.Object);
            var result = viewModel.AddNumbers(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}
