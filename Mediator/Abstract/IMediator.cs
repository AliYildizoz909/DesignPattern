using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Abstract
{
    public interface IMediator
    {
        void Send(string giverId, string receiveId, string message);
        void SendAll(string giverId, string message);
        void Register(Colleague manager);
    }
}
