using Caliburn.Micro;

namespace UWPCalculator
{
    public class ViewModel: Screen
    {
        private readonly ICalculator _calculator;

        public ViewModel()
        {
            
        }

        public ViewModel(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int AddNumbers(int x, int y)
        {
            return _calculator.AddNumbers(x, y);
        }

        public int MultiplyNumbers(int x, int y)
        {
            return x*y;
        }
    }
}
