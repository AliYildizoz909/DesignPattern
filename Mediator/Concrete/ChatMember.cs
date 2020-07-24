using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Abstract;

namespace Mediator.Concrete
{
    public class ChatMember : Colleague
    {
        public ChatMember(ConcreteMediator mediator) : base(mediator)
        {
            Id = $"Member{new Random().Next(100, 1000)}";
            mediator.Register(this);
        }

    }
}
