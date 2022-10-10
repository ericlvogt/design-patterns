using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Abstraction : IAbstraction
    {
        private IImplementor _implementor;

        public Abstraction(IImplementor implementor)
        {
            _implementor = implementor;
        }

        public string FormatText(string text)
        {
            return _implementor.FormatText(text);
        }
    }
}
