using Microsoft.VisualStudio.TestTools.UnitTesting;
//using FluentAssertions;
using LearnMyCalculatorApp;

namespace LearnMyCalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            Assert.IsNotNull(calculator);
        }

        [TestMethod]
        public void AddTest()
        {
            // arrange
            var calculator = new Calculator();

            // act
            var actual = calculator.Add(21, 21);
            var subtractActual = calculator.Subtract(actual, 1) == 1;

            // Assert
            Assert.IsNotNull(calculator);
            Assert.AreEqual(42, actual);
            Assert.IsFalse(subtractActual);
            StringAssert.Contains(actual.ToString(), "2");
            //actual.Should().Be(2).And.NotBe(1); // Este faz parte do FluentAssertions
        }

        [TestMethod]
        public void SubTract()
        {
            var calculator = new Calculator();

            var actual = calculator.Subtract(10, 5);

            Assert.AreEqual(5, actual);
        }

        // --------------------------------------------------------------------------------------------------
        // Data-driven tests
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        [DataRow(0, 0, 1)] // The test run with this row fails
        public void AddDataTests(int x, int y, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}