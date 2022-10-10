using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Flyweight
{
    public class FlyweightContext : IFlyweightContext
    {
        public int Index { get; set; }

        public FlyweightContext(int index)
        {
            Index = index;
        }
    }
}
