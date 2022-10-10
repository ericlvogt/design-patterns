using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Adaptee : IAdaptee
    {
        private string _message;

        public Adaptee(string message)
        {
            _message = message;
        }

        public string GetMessage()
        {
            return _message;
        }
    }
}
