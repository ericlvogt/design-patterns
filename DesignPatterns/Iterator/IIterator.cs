using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public interface IIterator<T>
    {
        public void First();
        public void Next();
        public bool IsDone();
        public T CurrentItem();
    }
}
