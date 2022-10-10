using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Median : IStrategy
    {
        public int GetMiddle(int x, int y, int z)
        {
            bool xgty = x > y;
            bool xgtz = x > z;
            bool ygtz = y > z;
            if (xgty && !xgtz || !xgty && xgtz)
                return x;
            else if (xgty && ygtz || !xgty && !ygtz)
                return y;
            else
                return z;
        }
    }
}
