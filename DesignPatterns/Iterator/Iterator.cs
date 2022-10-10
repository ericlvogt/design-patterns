using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class Iterator<T> : IIterator<T>
    {
        private int _currentIndex;
        private IAggregate<T> _aggregate;

        public Iterator(IAggregate<T> aggregate)
        {
            _aggregate = aggregate;
        }

        public T CurrentItem()
        {
            return ((Aggregate<T>)_aggregate).GetItem(_currentIndex);
        }

        public void First()
        {
            _currentIndex = 0;
        }

        public bool IsDone()
        {
            return _currentIndex >= ((Aggregate<T>)_aggregate).Count;
        }

        public void Next()
        {
            _currentIndex++;
        }
    }
}
