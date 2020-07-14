using System.Collections.Generic;

namespace Adapter
{
    public interface IUserService
    {
        User GetByTcNumber(string tc);
    }
}