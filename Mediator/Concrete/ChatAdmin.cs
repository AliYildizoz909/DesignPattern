using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Abstract;

namespace Mediator.Concrete
{
    public class ChatAdmin : Colleague
    {
        public ChatAdmin(IMediator concreteMediator) : base(concreteMediator)
        {
            Id = $"Admin{new Random().Next(100, 1000)}";
            concreteMediator.Register(this);
        }

        public void SendAll(string message)
        {
            ConcreteMediator.SendAll(Id, message);
        }

    }
}
