using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkOOP.lesson5
{
    class RacNumber
    {
        private float _chislitel, _znamenatel;

        public RacNumber() { }
        public RacNumber(float chislitel, float znamenatel)
        {
            _chislitel = chislitel;
            _znamenatel = znamenatel;
        }

        public float Chislitel
        {
            get
            {
                return _chislitel;
            }
            set
            {
                _chislitel = value;
            }
        }

        public float Znamenatel
        {
            get
            {
                return _znamenatel;
            }
            set
            {
                _znamenatel = value;
            }
        }


        public static RacNumber operator +(RacNumber r1, RacNumber r2)
        {
            RacNumber sumRN = new RacNumber();
            sumRN.Znamenatel = r1.Znamenatel * r2.Znamenatel;
            sumRN.Chislitel = r1.Chislitel * r2.Znamenatel + r2.Chislitel * r1.Znamenatel;
            return sumRN;
        }

        public static RacNumber operator -(RacNumber r1, RacNumber r2)
        {
            RacNumber eRN = new RacNumber();
            eRN.Znamenatel = r1.Znamenatel * r2.Znamenatel;
            eRN.Chislitel = r1.Chislitel * r2.Znamenatel - r2.Chislitel * r1.Znamenatel;
            return eRN;
        }

        public static bool operator ==(RacNumber r1, RacNumber r2)
        {
            return r1.Chislitel * r2.Znamenatel == r2.Chislitel * r1.Znamenatel;
        }
        public static bool operator !=(RacNumber r1, RacNumber r2)
        {
            return r1.Chislitel * r2.Znamenatel != r2.Chislitel * r1.Znamenatel;
        }
        public static bool operator <(RacNumber r1, RacNumber r2)
        {
            return r1.Chislitel * r2.Znamenatel < r2.Chislitel * r1.Znamenatel;
        }
        public static bool operator >(RacNumber r1, RacNumber r2)
        {
            return r1.Chislitel * r2.Znamenatel > r2.Chislitel * r1.Znamenatel;
        }
        public static bool operator <=(RacNumber r1, RacNumber r2)
        {
            return r1.Chislitel * r2.Znamenatel <= r2.Chislitel * r1.Znamenatel;
        }
        public static bool operator >=(RacNumber r1, RacNumber r2)
        {
            return r1.Chislitel * r2.Znamenatel >= r2.Chislitel * r1.Znamenatel;
        }
        public static RacNumber operator ++(RacNumber rn)
        {
            rn.Chislitel = rn.Chislitel + rn.Znamenatel;
            return rn;
        }

        public static explicit operator int (RacNumber rn)
        {
            float k = rn.Chislitel / rn.Znamenatel;
            return (int)k;
        }

        public static explicit operator float(RacNumber rn)
        {
            float k = rn.Chislitel / rn.Znamenatel;
            return k;
        }

        public static RacNumber operator --(RacNumber rn)
        {
            rn.Chislitel = rn.Chislitel + rn.Znamenatel;
            return rn;
        }

        public static RacNumber operator * (RacNumber rn1, RacNumber rn2)
        {
            RacNumber rn3 = new RacNumber();
            rn3.Chislitel = rn1.Chislitel * rn2.Chislitel;
            rn3.Znamenatel = rn1.Znamenatel * rn2.Znamenatel;
            return rn3;
        }

        public static RacNumber operator /(RacNumber rn1, RacNumber rn2)
        {
            RacNumber rn3 = new RacNumber();
            rn3.Chislitel = rn1.Chislitel * rn2.Znamenatel;
            rn3.Znamenatel = rn3.Znamenatel * rn3.Chislitel;
            return rn3;
        }
        public override string ToString()
        {
            if (Chislitel < Znamenatel)
            {
                return $"{Chislitel}/{Znamenatel}";
            }
            else
            {
                return $"{Chislitel % Znamenatel} {Chislitel-(Chislitel%Znamenatel*Znamenatel)}/{Znamenatel}";
            }
        }

        public override bool Equals(object obj)
        {
            return this == (RacNumber)obj;
        }
    }
}
