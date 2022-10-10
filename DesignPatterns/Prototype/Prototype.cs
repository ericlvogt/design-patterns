using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class Prototype : IPrototype
    {
        public int ListCount => _list.Count;

        private List<int> _list = new();

        public Prototype(int listCount)
        {
            for (int i = 0; i < listCount; i++)
                _list.Add(i);
        }

        public IPrototype Clone()
        {
            return new Prototype(_list.Count);
        }

        public void AddToList(int value)
        {
            _list.Add(value);
        }
    }
}
