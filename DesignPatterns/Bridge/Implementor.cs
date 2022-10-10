using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Implementor : IImplementor
    {
        public string FormatText(string text)
        {
            return $"\"{text}\"";
        }
    }
}
