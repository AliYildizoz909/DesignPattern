using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserService userManager = new IdentityWebServiceAdapter();
            User user = userManager.GetByTcNumber("15356648912");
            if (user!=null)
            {
                Console.WriteLine();
                Console.WriteLine($"{user.TcNumber} - {user.Name} - {user.Surname}");
                Console.ReadLine();
            }

        }
    }
}