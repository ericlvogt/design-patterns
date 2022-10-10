using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public interface ISingleton
    {
        public static ISingleton Instance { get; }
    }
}
