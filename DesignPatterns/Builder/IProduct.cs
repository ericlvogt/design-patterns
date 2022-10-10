using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public interface IProduct
    {
        public int SubProductCount { get; }
        public void AddSubProduct(ISubProduct subProduct);
    }
}
