using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public interface ISubComponentText
    {
        public void Add(string text);
        public void Remove(string text);
        public List<string> GetText();
    }
}
