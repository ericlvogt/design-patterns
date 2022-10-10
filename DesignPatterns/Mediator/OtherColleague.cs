using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class OtherColleague : IColleague
    {
        private int _value = 0;

        public void AddValue(int value)
        {
            _value += value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
