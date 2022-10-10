using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public interface IOriginator
    {
        public IMemento CreateMemento();
        public void SetMemento(IMemento memento);
    }
}
