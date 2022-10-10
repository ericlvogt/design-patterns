using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class Aggregate<T> : IAggregate<T>
    {
        public int Count => _array.Length;

        private T[] _array;

        public Aggregate(int arraySize)
        {
            _array = new T[arraySize];
        }

        public T GetItem(int index)
        {
            return _array[index];
        }

        public void SetItem(int index, T value)
        {
            _array[index] = value;
        }

        public IIterator<T> CreateIterator()
        {
            return new Iterator<T>(this);
        }
    }
}
