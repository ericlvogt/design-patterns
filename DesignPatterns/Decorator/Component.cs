using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Component : IComponent
    {
        private string _text;

        public Component(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}
