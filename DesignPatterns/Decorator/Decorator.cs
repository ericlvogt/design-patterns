using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class Decorator : IComponent
    {
        private IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public virtual string GetText()
        {
            return _component.GetText();
        }
    }
}
