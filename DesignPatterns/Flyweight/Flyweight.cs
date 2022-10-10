using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class Flyweight : IFlyweight
    {
        public int Size { get; }

        public Flyweight(int size)
        {
            Size = size;
        }

        public string GetIndexAndSize(IFlyweightContext flyweightContext)
        {
            return $"Index{flyweightContext.Index}Size{Size}";
        }
    }
}
