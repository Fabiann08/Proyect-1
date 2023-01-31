// Fabian Echevarria Rational Number GUI
using System;

namespace Asig5_Rational_GUI
{
    public struct RationalNumber
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        //Initializing Defualt Constructor
        public RationalNumber()
        {
            this.Numerator = 0;
            this.Denominator = 1; //Denominator default is 1 since dividing by 0 is undefined.
        }
        public RationalNumber(int numerator, int denominator)
        {
            int CommonDivisor = CalculateFractionReducer(numerator, denominator);

            this.Numerator = numerator / CommonDivisor;
            this.Denominator = denominator / CommonDivisor;
        }


        //recursive method to calculate minimun common divisor to reduce a fraction
        private static int CalculateFractionReducer(int numerator, int denominator)
        {
            if (denominator == 0)
                return numerator;
            return CalculateFractionReducer(denominator, numerator % denominator);
        }


        //Sum of rational numbers
        public RationalNumber Sum(RationalNumber obj)
        {
            if (obj.Denominator == Denominator)
            {
                return new RationalNumber((Numerator + obj.Numerator), (Denominator));
            }

            //calculating values if denominators are not equal
            int commonDenominator = obj.Denominator * this.Denominator;
            int calculatedNumerator1 = obj.Numerator * this.Denominator;
            int calculatedNumerator2 = this.Numerator * obj.Denominator;

            return new RationalNumber(calculatedNumerator1 + calculatedNumerator2, commonDenominator);
        }

        //Substract Rational Numbers
        public RationalNumber Substract(RationalNumber obj)
        {
            if (obj.Denominator == Denominator)
            {
                return new RationalNumber((Numerator - obj.Numerator), (Denominator));
            }

            //calculating values if denominators are not equal
            int commonDenominator = obj.Denominator * this.Denominator;
            int calculatedNumerator1 = this.Numerator * obj.Denominator;
            int calculatedNumerator2 = obj.Numerator * this.Denominator;

            return new RationalNumber(calculatedNumerator1 - calculatedNumerator2, commonDenominator);
        }

        //Multiply Rational Numbers
        public RationalNumber Multiply(RationalNumber obj)
        {
            if (obj.Denominator == 0 || Denominator == 0)
            {
                throw new DivideByZeroException("Can't divide by 0");
            }
            else
            {
                return new RationalNumber(Numerator * obj.Numerator, Denominator * obj.Denominator);
            }
        }

        //Divider Rational Numbers
        public RationalNumber Division(RationalNumber obj)
        {
            int ReciprocalNumerator = obj.Denominator;
            int ReciprocalDenominator = obj.Numerator;

            return new RationalNumber(Numerator * ReciprocalNumerator, Denominator * ReciprocalDenominator);
        }

        // Method for parsing a string representation of a rational number
        public static RationalNumber Parse(string s)
        {
            // Split the string at the '/' character
            string[] parts = s.Split('/');
            int numerator = int.Parse(parts[0]);
            int denominator = int.Parse(parts[1]);
            return new RationalNumber(numerator, denominator);
        }

        //format output
        public override string ToString()
        {
            return string.Format("({0} / {1})", Numerator, Denominator);
        }

    }
}


