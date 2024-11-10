using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Dom.Shared
{
    ///<summary>
    /// Rial
    ///</summary>
    public class Money : BaseValueObject
    {
        public int Value { get; }

        public Money(int Rialvalue)
        {
            if (Rialvalue < 0)
                throw new InvalidDataException();
            Value = Rialvalue;
        }

        public static Money FromRial(int Value)
        {
            return new Money(Value);
        }

        public static Money FromTooman(int Value)
        {
            return new Money(Value * 10);
        }

        public override string ToString()
        {
            return Value.ToString("#,0");
        }

        public static Money operator + (Money fMoney, Money lMoney)
        {
            return new Money(fMoney.Value + lMoney.Value);
        }


        public static Money operator -(Money fMoney, Money lMoney)
        {
            return new Money(fMoney.Value - lMoney.Value);
        }
    }
}
