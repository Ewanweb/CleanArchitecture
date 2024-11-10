using CleanArch.Dom.Users.Value_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Dom.Users
{
    public class User
    {
        public User(string name, string lastName, PhoneNumber phoneNumber)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            
        }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
    }
}
