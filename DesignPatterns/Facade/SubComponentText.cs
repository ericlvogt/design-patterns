using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class SubComponentText : ISubComponentText
    {
        private List<string> _text = new();

        public void Add(string text)
        {
            _text.Add(text);
        }

        public List<string> GetText()
        {
            return _text.ToList();
        }

        public void Remove(string text)
        {
            _text.Remove(text);
        }
    }
}
