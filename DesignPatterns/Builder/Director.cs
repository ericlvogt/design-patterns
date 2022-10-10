using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Director : IDirector
    {
        private IProductBuilder _builder;

        public Director(IProductBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildProduct();
            _builder.BuildSubProduct();
            _builder.BuildSubProduct();
        }
    }
}
