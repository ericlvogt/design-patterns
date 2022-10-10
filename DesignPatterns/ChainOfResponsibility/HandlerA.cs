using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class HandlerA : IHandler
    {
        public string HandleRequest()
        {
            return "A";
        }
    }
}
