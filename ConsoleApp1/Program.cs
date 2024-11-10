using CleanArch.Dom.Shared;
using CleanArch.Dom.Users;
using CleanArch.Dom.Users.Value_Object;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var money = Money.FromTooman(10000);
            var money2 = Money.FromTooman(10000);
            var money3 = money2 + money;
            Console.WriteLine(money3.ToString());
            var user = new User("dsds", "sasasa",new PhoneNumber("09157817553"));
            var user2 = new User("dsds", "sasasa",new PhoneNumber("09157817553"));
            Console.WriteLine(user.PhoneNumber ==  user2.PhoneNumber);
        }
    }
}
