using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operator_OverLoading
{
    internal class Complex
    {

        public int Real { get; set; }
        public int Imag { get; set; }

        public Complex(int _real, int _imag)
        {
            Real = _real;
            Imag = _imag;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public override bool Equals(object? obj)
        {
            return obj is Complex complex &&
                   Real == complex.Real &&
                   Imag == complex.Imag;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Real, Imag);
        }

        public static Complex operator +(Complex a, Complex b)
        {
            int realPart = (a?.Real ?? 0) + (b?.Real ?? 0);
            int imagPart = (a?.Imag ?? 0) + (b?.Imag ?? 0);

            //Complex result = new Complex(realPart, imagPart);
            //return result;

            return new Complex(realPart, imagPart);

        }
        public static Complex operator -(Complex a, Complex b)
        {
            int realPart = (a?.Real ?? 0) - (b?.Real ?? 0);
            int imagPart = (a?.Imag ?? 0) - (b?.Imag ?? 0);

            //Complex result = new Complex(realPart, imagPart);
            //return result;

            return new Complex(realPart, imagPart);
        }


        public static Complex operator ++(Complex a)
        {
            int realPart = (a?.Real ?? 0) + 1;
            int imagPart = (a?.Imag ?? 0) + 1;

            //Complex result = new Complex(realPart, imagPart);
            //return result;

            return new Complex(realPart, imagPart);
        }

        public static Complex operator --(Complex a)
        {
            int realPart = (a?.Real ?? 0) - 1;
            int imagPart = (a?.Imag ?? 0) - 1;

            //Complex result = new Complex(realPart, imagPart);
            //return result;

            return new Complex(realPart, imagPart);
        }

        public static bool operator >(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return ((a?.Imag ?? 0) > (b?.Imag ?? 0));

            return (a?.Real ?? 0) > (b?.Real ?? 0);
        }

        public static bool operator <(Complex a, Complex b)
        {
            if ((a?.Real ?? 0) == (b?.Real ?? 0))
                return ((a?.Imag ?? 0) < (b?.Imag ?? 0));

            return (a?.Real ?? 0) < (b?.Real ?? 0);
        }

        public static bool operator ==(Complex? left, Complex? right)
        {
            return EqualityComparer<Complex>.Default.Equals(left, right);
        }

        public static bool operator !=(Complex? left, Complex? right)
        {
            return !(left == right);
        }

        //public static bool operator ==(Complex a, Complex b)
        //{
        //    if ((a?.Real ?? 0) == (b?.Real ?? 0))
        //        return ((a?.Imag ?? 0) == (b?.Imag ?? 0));
        //    return false;
        //}

        //public static bool operator !=(Complex a, Complex b)
        //{
        //    return !(a == b);
        //}


    }
}
