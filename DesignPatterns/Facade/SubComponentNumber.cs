using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class SubComponentNumber : ISubComponentNumber
    {
        private int _value = 0;

        public void Add(int value)
        {
            _value += value;
        }

        public int GetValue()
        {
            return _value;
        }

        public void Subtract(int value)
        {
            _value -= value;
        }
    }
}
