using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Subject : ISubject
    {
        public string State { 
            get {
                return _state;
            } 
            set {
                _state = value;
                this.Notify();
            } }

        private string _state;
        private List<IObserver> _observers = new();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Dettach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
                observer.Update(this);
        }
    }
}
