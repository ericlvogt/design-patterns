using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton : ISingleton
    {
        public static ISingleton Instance 
        {
            get {
                if (_instance is null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        private static ISingleton _instance;

        protected Singleton()
        {
        }

    }
}
