using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class IdentityWebService : IIdentityWebService
    {
        private List<CitizenWebService> citizensWebServices = null;

        public IdentityWebService()
        {
            citizensWebServices = new List<CitizenWebService>
            {
                new CitizenWebService{FirstName = "Ali", LastName = "Yıldızöz", TcNumber = "15356648912".ToCharArray(), IsCriminal = false,Age = 21},
                new CitizenWebService{FirstName = "Merve",LastName = "Çiçek",TcNumber ="12345895613".ToCharArray(),IsCriminal = false,Age=24},
                new CitizenWebService{FirstName = "Burak",LastName = "Kaya",TcNumber ="56789423561".ToCharArray(),IsCriminal = true,Age=35},
                new CitizenWebService{FirstName = "Engin",LastName = "Yılmaz",TcNumber = "15913569486".ToCharArray(),IsCriminal = false,Age=22}
            };
        }

        public CitizenWebService TcNumberQuestioning(char[] tcNumber)
        {
            Console.WriteLine($"identityWebService.TcNumberQuestioning({ new string(tcNumber)}) metodu ÇALIŞTI.");
            return citizensWebServices.FirstOrDefault(service => new string(service.TcNumber) == new string(tcNumber));
        }

        public bool CriminalRecordQuestioning(char[] tcNumber)
        {
            var result =
                citizensWebServices.FirstOrDefault(service => new string(service.TcNumber) == new string(tcNumber));
            return result != null && result.IsCriminal;
        }

        public int AgeQuestioning(char[] tcNumber)
        {
            var result =
                citizensWebServices.FirstOrDefault(service => new string(service.TcNumber) == new string(tcNumber));
            return result?.Age ?? 0;
        }
    }
}
