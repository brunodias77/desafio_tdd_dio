using System;
using Xunit;

namespace Calculator.tests
{
    public class CalculatorTests
    {
        public Calculator Class()
        {
            string date = new DateTime().ToString();
            Calculator calc = new Calculator(date);

            return calc;
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(8, 5, 13)]
        public void AddTwoNumbers(int value1, int value2, int result)
        {
            Calculator calc = Class();
            int sumResult = calc.Add(value1, value2);
            Assert.Equal(result, sumResult);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(8, 5, 3)]
        public void SubtractTwoNumbers(int value1, int value2, int result)
        {
            Calculator calc = Class();
            int subtractionResult = calc.Subtract(value1, value2);
            Assert.Equal(result, subtractionResult);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(8, 5, 40)]
        public void MultiplyTwoNumbers(int value1, int value2, int result)
        {
            Calculator calc = Class();
            int multiplicationResult = calc.Multiply(value1, value2);
            Assert.Equal(result, multiplicationResult);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(9, 3, 3)]
        public void DivideTwoNumbers(int value1, int value2, int result)
        {
            Calculator calc = Class();
            int divisionResult = calc.Divide(value1, value2);
            Assert.Equal(result, divisionResult);
        }

        [Fact]
        public void DivideNumberBy0()
        {
            Calculator calc = Class();
            Assert.Throws<DivideByZeroException>(
                () => calc.Divide(6, 0)
            );
        }

        [Fact]
        public void TestHistory()
        {
            Calculator calc = Class();
            calc.Add(1, 2);
            calc.Add(3, 4);
            calc.Add(4, 5);
            calc.Add(5, 6);

            var list = calc.History();

            Assert.NotEmpty(list);
            Assert.Equal(3, list.Count);
        }
    }
}