using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Caretaker
    {
        private IMemento _memento;

        public void StoreMemento(IMemento memento)
        {
            _memento = memento;
        }

        public IMemento GetMemento()
        {
            return _memento;
        }
    }
}
