using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public interface IStrategy
    {
        public int GetMiddle(int x, int y, int z);
    }
}
