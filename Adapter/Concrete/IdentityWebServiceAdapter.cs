using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class IdentityWebServiceAdapter : IUserService
    {
        public User GetByTcNumber(string tc)
        {
            User user = null;
            if (tc.Length == 11)
            {
                IdentityWebService identityWebService = new IdentityWebService();
                CitizenWebService citizenWebService = identityWebService.TcNumberQuestioning(tc.ToCharArray());
                if (citizenWebService == null)
                {
                    Console.WriteLine("Böyle bir kullanıcı yok");
                    Console.ReadLine();
                    return user;
                }
                user = new User
                {
                    Name = citizenWebService.FirstName,
                    Surname = citizenWebService.LastName,
                    TcNumber = new string(citizenWebService.TcNumber)
                };
            }

            return user;
        }
    }
}
