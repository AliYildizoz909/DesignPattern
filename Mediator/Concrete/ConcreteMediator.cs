using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Abstract;

namespace Mediator.Concrete
{
    public class ConcreteMediator : IMediator
    {

        private Dictionary<string, Colleague> _dictionary;

        public ConcreteMediator()
        {
            _dictionary = new Dictionary<string, Colleague>();
        }

        public void Register(Colleague manager)
        {
            if (_dictionary.ContainsKey(manager.Id))
            {
                throw new Exception("Fail");
            }
            _dictionary.Add(manager.Id, manager);
        }

        public void Send(string giverId, string receiveId, string message)
        {
            var receiveManager = _dictionary[receiveId];
            receiveManager.Receive(giverId, message);
        }

        public void SendAll(string giverId, string message)
        {
            foreach (var chatMemberBase in _dictionary.Values)
            {
                chatMemberBase.Receive(giverId, message);
            }
        }
    }
}
