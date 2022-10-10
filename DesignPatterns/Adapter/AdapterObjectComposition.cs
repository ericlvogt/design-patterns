using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class AdapterObjectComposition : ITarget
    {
        private IAdaptee _adaptee;

        public AdapterObjectComposition(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetText()
        {
            return _adaptee.GetMessage();
        }
    }
}
