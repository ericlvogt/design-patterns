using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class AdapterMultipleInheritance : ITarget, IAdaptee
    {
        private string _text;

        public AdapterMultipleInheritance(string text)
        {
            _text = text;
        }

        public string GetMessage()
        {
            return _text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
