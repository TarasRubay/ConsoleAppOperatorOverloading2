using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionNS
{
    public class Fraction : IComparable<Fraction>
    {
        static public int Precision { get; set; } = 4;
        readonly int numerator = 0;
        readonly int denominator = 1;

        public Fraction()
        { }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int Numerator => numerator;
        // public int Numerator { get => numerator; }

        public int Denominator => denominator;

        public override bool Equals(object obj)
        {

            if (obj is null)
                return false;
            //if (this.GetType() != obj.GetType())
                if (this.GetType() != obj.GetType())
                return false;
            Fraction f = obj as Fraction; //n/d f.n/f.d

            return Numerator * f.Denominator == f.Numerator * Denominator;


        }


        public override int GetHashCode()=> this.Simplification().ToString().GetHashCode();
        //{
        //int hashCode = -1534900553;
        //hashCode = hashCode* -1521134295 + Numerator.GetHashCode();
        //hashCode = hashCode* -1521134295 + Denominator.GetHashCode();
        //return hashCode;


        //}

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return object.Equals(f1, f2);
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        //public static bool operator <(Fraction f1, Fraction f2)
        //{
        //    return f1.CompareTo(f2) < 0;
        //}
        //public static bool operator >(Fraction f1, Fraction f2)
        //{
        //    return f1.CompareTo(f2) > 0;//!(f1<f2)
        //}

        //public static Fraction operator +(Fraction f1, Fraction f2)
        //{
        //    return new Fraction(f1.Numerator * f2.Denominator + f1.Denominator * f2.Numerator, f1.Denominator * f2.Denominator).Simplification();
        //}

        //public static Fraction operator -(Fraction f1, Fraction f2)
        //{
        //    return new Fraction(f1.Numerator * f2.Denominator - f1.Denominator * f2.Numerator, f1.Denominator * f2.Denominator).Simplification();
        //}

        //public static Fraction operator ++(Fraction fraction)
        //{
        //    return fraction + new Fraction(1, 1);
        //}

        //public static Fraction operator --(Fraction fraction)
        //{
        //    return fraction - new Fraction(1, 1);
        //}

        //public static bool operator true(Fraction fraction)
        //{
        //    return fraction.Numerator != 0;
        //}
        //public static bool operator false(Fraction fraction)
        //{
        //    return fraction.Numerator == 0;
        //}

        //public static explicit operator double(Fraction fraction)
        //{
        //    return (double)fraction.Numerator / fraction.Denominator;
        //}
        //public static explicit operator Fraction(double number)
        //{
        //    return new Fraction((int)Math.Round(number * Math.Pow(10, Precision)), (int)Math.Pow(10, Precision)).Simplification();
        //}
        public override string ToString() => $"{Numerator}/{Denominator}";

        public Fraction Simplification()
        {
            int n = Numerator, d = Denominator;
            int min = (Math.Abs(n) < d) ? Math.Abs(n) : d;
            for (int i = 2; i < min + 1; i++)
            {
                while (n % i == 0 && d % i == 0)
                {
                    n /= i;
                    d /= i;
                }
            }
            return new Fraction(n, d);
        }



        public int CompareTo(Fraction other)
        {
            return this.Numerator * other.Denominator - this.Denominator * other.Numerator;
        }
    }
}
