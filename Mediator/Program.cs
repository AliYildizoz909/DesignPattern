using System;
using Mediator.Concrete;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Concrete.ConcreteMediator concreteMediator=new Concrete.ConcreteMediator();

            ChatMember chatMember1=new ChatMember(concreteMediator);
            ChatMember chatMember2=new ChatMember(concreteMediator);
            ChatMember chatMember3=new ChatMember(concreteMediator);
            ChatMember chatMember4=new ChatMember(concreteMediator);
            ChatAdmin chatAdmin=new ChatAdmin(concreteMediator);



            chatMember1.Send(chatMember2.Id, "Hello how are you.");
            chatMember2.Send(chatMember1.Id,"I'm fine and you.'");
            chatMember3.Send(chatMember2.Id, "You haven't seen for a while");
            chatMember4.Send(chatMember3.Id, "She told me that the project is currently developing.");
            chatAdmin.SendAll("Guys, let's talk about private issues outside the group.");
            Console.ReadLine();
        }
    }
}
