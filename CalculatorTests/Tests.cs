using System;
using NUnit.Framework;
using static Calculator.Program;

namespace CalculatorTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AddOneNumber()
        {
            int answer = CalculateAnswer("+", new[] {5});
            Assert.AreEqual(5, answer);
        }

        [Test]
        public void AddTwoNumbers()
        {
            int answer = CalculateAnswer("+", new[] {5, 7});
            Assert.AreEqual(12, answer);
        }

        [Test]
        public void AddManyNumbers()
        {
            int answer = CalculateAnswer("+", new[] {1, 2, 3, 4, 5, 6});
            Assert.AreEqual(21, answer);
        }

        [Test]
        public void ThrowException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => CalculateAnswer("+", new int[] {}));
        }
    }
}
