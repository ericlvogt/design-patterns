using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface ISubject
    {
        public void Attach(IObserver observer);
        public void Dettach(IObserver observer);
        public void Notify();
    }
}
