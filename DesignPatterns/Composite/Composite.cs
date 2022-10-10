using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Composite : IComposite
    {
        private List<IComponent> _components = new();

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public List<IComponent> GetChildren()
        {
            return _components.ToList();
        }

        public IComposite GetComposite()
        {
            return this;
        }

        public string GetText()
        {
            string result = String.Empty;
            foreach (IComponent component in _components)
            {
                result += component.GetText();
            }
            return result;
        }

        public void Remove(IComponent component)
        {
            _components.Remove(component);
        }
    }
}
