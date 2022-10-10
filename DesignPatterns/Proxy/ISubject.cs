using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public interface ISubject
    {
        public int Height { get; }
        public int Width { get; }
        public void CostlyOperation();
    }
}
