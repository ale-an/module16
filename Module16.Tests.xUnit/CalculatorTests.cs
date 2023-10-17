using System;
using Module16;
using Xunit;

namespace Modul16.Test.xUnit
{
    public class CalculatorTests
    {
        [Fact]
        public void Subtraction_Two()
        {
            var calculator = new Calculator();
            Assert.Equal(8, calculator.Subtraction(10, 2));
        }

        [Fact]
        public void Division_Two()
        {
            var calculator = new Calculator();
            Assert.Equal(5, calculator.Division(25, 5));
        }

        [Fact]
        public void Division_Zero_Two()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>((() => calculator.Division(100, 0)));
        }
    }
}