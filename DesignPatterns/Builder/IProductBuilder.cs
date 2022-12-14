using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public interface IProductBuilder
    {
        public void BuildProduct();
        public void BuildSubProduct();
        public IProduct GetProduct();
    }
}
