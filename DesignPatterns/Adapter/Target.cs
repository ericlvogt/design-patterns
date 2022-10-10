using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class Target : ITarget
    {
        private string _text;

        public string GetText()
        {
            return _text;
        }
    }
}
