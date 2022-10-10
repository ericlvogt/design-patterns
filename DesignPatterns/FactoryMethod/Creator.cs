using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class Creator : ICreator
    {
        public IProduct CreateProduct()
        {
            return new Product();
        }
    }
}
