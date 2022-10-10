using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public interface IInvoker
    {
        public void StoreCommand(ICommand command);
        public void InvokeCommands();
    }
}
