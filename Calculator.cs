using System;

namespace lab1
{
    /// <summary>
    /// Calculator class
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Sum of numbers
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>sum</returns>
        public static double SumOfTwo(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// multiplying of numbers
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>multiply answer</returns>
        public static double MultiplyTwo(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// difference of two numbers
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>difference</returns>
        public static double DifferenceOfTwo(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// sqrt
        /// </summary>
        /// <param name="a">number</param>
        /// <returns>sqrt(number)</returns>
        public static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        /// <summary>
        /// exponentiation
        /// </summary>
        /// <param name="number">number</param>
        /// <param name="degree">degree</param>
        /// <returns>number^degree</returns>
        public static double Exponentiation(double number, int degree)
        {
            double temp = number;

            for (int i = 1; i < degree; i++)
            {
                temp = temp * number;
            }

            return temp;
        }

        /// <summary>
        /// is palindrome?
        /// </summary>
        /// <param name="a">string</param>
        /// <returns>true or false</returns>
        public static bool IsPalindrome(string a)
        {
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);

            return new string(arr) == a ? true : false;
        }

        /// <summary>
        /// sum of rationals
        /// </summary>
        /// <param name="r1">first rational</param>
        /// <param name="r2">second rational</param>
        /// <returns>sum</returns>
        public static Rational SumOfRationals(Rational r1, Rational r2)
        {
            Rational sum = r1 + r2;
            return sum;
        }

        /// <summary>
        /// simplify rational
        /// </summary>
        /// <param name="r">rational</param>
        /// <returns>simplified rational</returns>
        public static Rational SimplifyRational(Rational r)
        {
            r.Simplify();
            return r;
        }

        /// <summary>
        /// compare rationals
        /// </summary>
        /// <param name="r1">first rational</param>
        /// <param name="r2">second rational</param>
        /// <returns>true or false</returns>
        public static bool CompareRationals(Rational r1, Rational r2)
        {
            if (r1 > r2)
            {
                return true;
            }
            else if (r1 < r2)
            {
                return false;
            }

            return false;
        }
    }
}