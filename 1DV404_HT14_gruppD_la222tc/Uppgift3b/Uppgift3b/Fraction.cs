using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3b
{
    class Fraction
    {
        private int _numenator;
        private int _denominator;

        private int Numerator
        {
            get { return _numenator; }

            set
            {
                if (value == 0)
                {
                    throw new Exception("Täljaren får inte vara 0");
                }

                _numenator = value;
            }
        }
        private int Denominator
        {
            get { return _denominator; }

            set
            {
                if (value == 0)
                {
                    throw new Exception("Nämnaren får inte vara 0");
                }

                _denominator = value;
            }
        }

        public Fraction(int numenator, int denominator)
        {
            Numerator = numenator;
            Denominator = denominator;
        }

        public bool isNegative()
        {

            int test = devide();

            if (test < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int devide()
        {
            return Numerator / Denominator;
        }

        public string add(Fraction firstFraction, Fraction secondFraction)
        {
            int bothNumerators = firstFraction.Numerator + secondFraction.Numerator;
            int bothDenominators = firstFraction.Denominator + secondFraction.Denominator;
            int result = bothNumerators / bothDenominators;

            return result.ToString();
        }

        public string multiply(Fraction firstFraction, Fraction secondFraction)
        {
            int bothNumerators = firstFraction.Numerator * secondFraction.Numerator;
            int bothDenominators = firstFraction.Denominator * secondFraction.Denominator;
            int result = bothNumerators / bothDenominators;

            return result.ToString();
        }
        public string isEqualTo(Fraction firstFraction, Fraction secondFraction)
        {
            int fraction1 = firstFraction.Numerator / firstFraction.Denominator;
            int fraction2 = secondFraction.Numerator / secondFraction.Denominator;
            string s;

            if (fraction1 == fraction2)
            {
                s = "Det är samma bråktal";
                return s;
            }
            else
            {
                s = "Det INTE samma bråktal";
                return s;
            }
        }

        public override string ToString()
        {
            int result = devide();
            return String.Format("Resultatet av bråktalet är: {0}", result);
        }
    }
}
