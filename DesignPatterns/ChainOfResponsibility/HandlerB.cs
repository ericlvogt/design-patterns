using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class HandlerB : IHandler
    {
        private IHandler _successor;

        public HandlerB(IHandler successor)
        {
            _successor = successor;
        }

        public string HandleRequest()
        {
            return _successor.HandleRequest();
        }
    }
}
