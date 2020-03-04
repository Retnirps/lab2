using System;

namespace lab1
{
     /// <summary>
     /// Rational class
     /// </summary>
    public class Rational
    {
        double n;
        double m;

        /// <summary>
        /// constructor of Rational class
        /// </summary>
        /// <param name="n">numerator</param>
        /// <param name="m">denominator</param>
        public Rational(double n, double m)
        {
            this.n = n;
            this.m = m;
        }
        /// <summary>
        /// compare two rationals with <
        /// </summary>
        /// <param name="r1">first rational</param>
        /// <param name="r2">second rational</param>
        /// <returns>true or false</returns>
        public static bool operator >(Rational r1, Rational r2)
        {
            if (r1.n / r1.m > r2.n / r2.m)
                return true;
            else
                return false;
        }
        /// <summary>
        /// compare two ratioanls with >
        /// </summary>
        /// <param name="r1">first rational</param>
        /// <param name="r2">second rational</param>
        /// <returns>true or false</returns>
        public static bool operator <(Rational r1, Rational r2)
        {
            if (r1.n / r1.m < r2.n / r2.m)
                return true;
            else
                return false;
        }
        /// <summary>
        /// equality of two rationals
        /// </summary>
        /// <param name="r1">first rational</param>
        /// <param name="r2">second ratioal</param>
        /// <returns>true or false</returns>
        public static bool operator ==(Rational r1, Rational r2)
        {
            if (r1.n / r1.m == r2.n / r2.m)
                return true;
            else
                return false;
        }
        /// <summary>
        /// inequality
        /// </summary>
        /// <param name="r1">first ratioanal</param>
        /// <param name="r2">second rational</param>
        /// <returns>true or false</returns>
        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1 == r2);
        }
        /// <summary>
        /// Least Common Multiple method
        /// </summary>
        /// <param name="m1">first denominator</param>
        /// <param name="m2">second denominator</param>
        /// <returns>LCM number</returns>
        public static int LCM(int m1, int m2)
        {
            int LeastCommonMultiple = 0;

            for (int i = 0; i <= m1 * m2; i++)
            {
                if (i % (int)m1 == 0 && i % (int)m2 == 0)
                {
                    if (i != 0)
                    {
                        LeastCommonMultiple = i;
                        return LeastCommonMultiple;
                    }
                }
            }

            return LeastCommonMultiple;
        }
        /// <summary>
        /// Greatest Common Divisor method
        /// </summary>
        /// <param name="n">first number</param>
        /// <param name="m">second number</param>
        /// <returns>GCD number</returns>
        public static int GCD(int n, int m)
        {
            while (n != m)
            {
                if (n > m)
                {
                    int a = n;
                    n = m;
                    m = a;
                }

                m = m - n;
            }

            return n;
        }

        /// <summary>
        /// Simplify a ratioanal
        /// </summary>
        public void Simplify()
        {
            int gcd = GCD((int)n, (int)m);

            n = n / gcd;
            m = m / gcd;
        }
        /// <summary>
        /// overload +
        /// </summary>
        /// <param name="r1">first rational</param>
        /// <param name="r2">second rational</param>
        /// <returns>sum</returns>
        public static Rational operator +(Rational r1, Rational r2)
        {
            int LeastCommonMultiple = LCM((int)r1.m, (int)r2.m);

            if (r1.m != r2.m)
            {
                int multiple = LeastCommonMultiple / (int)r1.m;

                r1.n = r1.n * multiple;

                multiple = LeastCommonMultiple / (int)r2.m;

                r2.n = r2.n * multiple;
            }

            Rational sum = new Rational(r1.n + r2.n, LeastCommonMultiple);

            return sum;
        }
        /// <summary>
        /// Show rational
        /// </summary>
        public void Show()
        {
            if (n % m == 0)
                Console.WriteLine(n / m);
            else
            {
                //Simplify();
                Console.WriteLine(n + "/" + m);
            }
        }
        /// <summary>
        /// overload ToString() method
        /// </summary>
        /// <returns>ToString() value</returns>
        public override string ToString()
        {
            if (n % m == 0)
                return (n / m).ToString();
            else
            {
                //Simplify();
                return (n + "/" + m).ToString();
            }
        }
    }
}