using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Mediator : IMediator
    {
        private List<IColleague> _receivers = new();

        public void AddValueToReceivers(int value)
        {
            foreach(IColleague receiver in _receivers)
            {
                receiver.AddValue(value);
            }
        }

        public void AddReceiver(IColleague colleague)
        {
            _receivers.Add(colleague);
        }
    }
}
