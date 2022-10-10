using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public interface IFlyweightFactory
    {
        public IFlyweight CreateFlyweight(int identifier);
    }
}
