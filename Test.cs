using System;
using NUnit.Framework;


namespace lab1
{
    /// <summary>
    /// class of tests
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Test of number's sum
        /// </summary>
        [Test]
        public void SumOfTwoTEST()
        {
            double result = Calculator.SumOfTwo(3.214234, 2.3543);

            Assert.AreEqual(5.6, result, 0.1);
        }

        /// <summary>
        /// Test of multiplying numbers
        /// </summary>
        [Test]
        public void MultiplyTwoTEST()
        {
            double result = Calculator.MultiplyTwo(2.324, 7.213);

            Assert.AreEqual(16.8, result, 0.1);
        }

        /// <summary>
        /// test of number's difference
        /// </summary>
        [Test]
        public void DifferenceOfTwoTEST()
        {
            double result = Calculator.DifferenceOfTwo(231, 21);

            Assert.AreEqual(210, result, 0.1);
        }

        /// <summary>
        /// test of sqrt
        /// </summary>
        [Test]
        public void SqrtTEST()
        {
            double result = Calculator.Sqrt(1.44);

            Assert.AreEqual(1.2, result, 0.1);
        }

        /// <summary>
        /// test of exponentiation
        /// </summary>
        [Test]
        public void ExponentiationTEST()
        {
            double result = Calculator.Exponentiation(3.3, 3);
            Console.WriteLine(result);

            Assert.AreEqual(36, result, 0.1);
        }

        /// <summary>
        /// tets of palindrome
        /// </summary>
        [Test]
        public void IsPalindromeTEST()
        {
            bool result = Calculator.IsPalindrome("11100111");

            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// test of rational's sum
        /// </summary>
        [Test]
        public void SumOfRationalsTEST()
        {
            var result = Calculator.SumOfRationals(new Rational(1, 2), new Rational(-3, 4)).ToString();
            Rational correct = new Rational(-1, 4);

            Assert.AreEqual(correct.ToString(), result);
        }
        
        /// <summary>
        /// test of rational's simplify
        /// </summary>
        [Test]
        public void SimplifyTEST()
        {
            var result = Calculator.SimplifyRational(new Rational(2, 4)).ToString();
            Rational correct = new Rational(1, 2);

            Assert.AreEqual(correct.ToString(), result);
        }

        /// <summary>
        /// test of rationals' compare
        /// </summary>
        [Test]
        public void CompareTEST()
        {
            var result = Calculator.CompareRationals(new Rational(1, 2), new Rational(1, 4));
            Assert.AreEqual(true, result);
        }
    }
}