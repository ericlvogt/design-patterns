using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class FlyweightFactory : IFlyweightFactory
    {
        Dictionary<int, Flyweight> _flyweights = new();

        private static readonly int MAXSTOREDSIZE = 5;

        public IFlyweight CreateFlyweight(int size)
        {
            Flyweight result;
            if (size <= MAXSTOREDSIZE)
            {
                if (_flyweights.ContainsKey(size))
                {
                    result = _flyweights[size];
                }
                else
                {
                    result = new Flyweight(size);
                    _flyweights.Add(size, result);
                }
            }
            else
            {
                result = new Flyweight(size);
            }
            return result;
        }
    }
}
