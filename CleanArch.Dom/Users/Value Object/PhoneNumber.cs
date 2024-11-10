using CleanArch.Dom.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Dom.Users.Value_Object
{
    public class PhoneNumber : BaseValueObject
    {
        public string Phone { get; }

        public PhoneNumber(string phone)
        {
            if (phone.Length < 11 && phone.Length>11)
                throw new InvalidDataException();
            Phone = phone;
        }
    }
}
