using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Observer : IObserver
    {
        public string State { get; set; }

        public void Update(ISubject subject)
        {
            State = ((Subject)subject).State;
        }
    }
}
