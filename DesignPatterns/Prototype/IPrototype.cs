using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public interface IPrototype
    {
        public int ListCount { get; }
        public IPrototype Clone();
        public void AddToList(int value);
    }
}
