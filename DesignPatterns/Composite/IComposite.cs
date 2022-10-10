using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public interface IComposite : IComponent
    {
        public void Add(IComponent component);
        public void Remove(IComponent component);
        public List<IComponent> GetChildren();
    }
}
