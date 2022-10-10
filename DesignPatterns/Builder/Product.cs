using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Product : IProduct
    {
        public int SubProductCount => _subProducts.Count;

        List<ISubProduct> _subProducts = new();

        public void AddSubProduct(ISubProduct subProduct)
        {
            _subProducts.Add(subProduct);
        }
    }
}
