using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book_lst;

namespace MyNamespace2
{
    internal class Fraction
    {
        public double numerator { get; set; } // числитель
        public double denominator { get; set; } // знаменатель

        public Fraction(double num, double den)
        {
            if (den == 0) { throw new ArgumentException("The denominator cannot be zero."); }

            numerator = num;
            denominator = den;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            double D = a.denominator * b.denominator;
            double N = a.numerator * b.denominator + b.numerator * a.denominator;

            return new Fraction(N, D);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            double D = a.denominator * b.denominator;
            double N = a.numerator * b.denominator - b.numerator * a.denominator;

            return new Fraction(N, D);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            double D = a.denominator * b.denominator;
            double N = a.numerator * b.numerator;

            return new Fraction(N, D);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            double D = a.numerator * b.denominator;
            double N = a.denominator * b.numerator;

            return new Fraction(N, D);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return (a.numerator * b.denominator == b.numerator * a.denominator);
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
