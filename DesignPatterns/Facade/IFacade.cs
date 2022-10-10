using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public interface IFacade
    {
        public List<string> GetText();
        public int GetNumber();
    }
}
