using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Colleague : IColleague
    {
        private IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void AddToOtherColleagues(int value)
        {
            _mediator.AddValueToReceivers(value);
        }

        public void AddValue(int value)
        {
            return;
        }

        public int GetValue()
        {
            return 0;
        }
    }
}
