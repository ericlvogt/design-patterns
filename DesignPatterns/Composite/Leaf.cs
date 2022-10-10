using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Leaf : IComponent
    {
        private string _text;

        public Leaf(string text)
        {
            _text = text;
        }

        public IComposite GetComposite()
        {
            return null;
        }

        public string GetText()
        {
            return _text;
        }

    }
}
