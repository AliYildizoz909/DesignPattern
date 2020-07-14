using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class UserManager : IUserService
    {
        private List<User> users;

        public UserManager()
        {
            users = new List<User>
            {
                new User {Name = "Ali", Surname = "Yıldızöz",TcNumber = "15356648912"},
                new User {Name = "Merve", Surname = "Çiçek",TcNumber = "12345895613"},
                new User {Name = "Burak", Surname = "Kaya",TcNumber = "56789423561"},
                new User {Name = "Engin", Surname = "Yılmaz",TcNumber = "15913569486"}
            };
        }

        public User GetByTcNumber(string tc)
        {
            Console.WriteLine($"UserManager.GetByTcNumber({tc}) metodu ÇALIŞTI.");
            var user = users.FirstOrDefault(u => u.TcNumber == tc);
            if (user ==null)
            {
                Console.WriteLine("Böyle bir kullanıcı yok");
                Console.ReadLine();
            }

            return user;
        }
    }
}
