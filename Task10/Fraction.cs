using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;


        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("mnishvneloba ver iqneba 0");
            }
            else
            {
                _numerator = numerator;
                _denominator = denominator;
            }
        }

        public override string ToString()
        {
            return $"{_numerator} / {_denominator}";
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a._numerator * b._denominator + b._numerator * a._denominator;
            int denominator = a._denominator * b._denominator;
            return new Fraction(numerator, denominator);
        }

        public static bool operator ==(Fraction a, Fraction b)

        {
            return a._numerator * b._numerator == b._numerator * a._denominator;

        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (_numerator, _denominator).GetHashCode();
        }

    }

}



