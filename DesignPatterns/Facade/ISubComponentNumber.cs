using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public interface ISubComponentNumber
    {
        public void Add(int value);
        public void Subtract(int value);
        public int GetValue();
    }
}
