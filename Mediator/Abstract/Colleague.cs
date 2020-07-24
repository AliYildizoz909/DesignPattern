using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Concrete;

namespace Mediator.Abstract
{
    public abstract class Colleague
    {
        public string Id { get; set; }
        protected IMediator ConcreteMediator;

        protected Colleague(IMediator concreteMediator)
        {
            ConcreteMediator = concreteMediator;
        }

        public void Receive(string giveId, string message)
        {
            Console.WriteLine($"{Id} received a message from {giveId} message:\"{message}\" ");
        }
        public virtual void Send(string receive, string message)
        {
            ConcreteMediator.Send(Id, receive, message);
        }
    }
}
