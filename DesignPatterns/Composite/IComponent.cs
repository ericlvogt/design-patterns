using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public interface IComponent
    {
        public string GetText();
        public IComposite GetComposite();
    }
}
