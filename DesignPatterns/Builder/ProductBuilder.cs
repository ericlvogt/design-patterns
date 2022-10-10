using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class ProductBuilder : IProductBuilder
    {
        private IProduct _product;

        public void BuildProduct()
        {
            _product = new Product();
        }

        public void BuildSubProduct()
        {
            _product.AddSubProduct(new SubProduct());
        }

        public IProduct GetProduct()
        {
            return _product;
        }
    }
}
