using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DesignPatterns.Proxy
{
    public class Subject : ISubject
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public void CostlyOperation()
        {
            Thread.Sleep(1000);
        }
    }
}
