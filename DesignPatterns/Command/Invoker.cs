using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Invoker : IInvoker
    {
        private List<ICommand> _commands = new();

        public void InvokeCommands()
        {
            foreach(ICommand command in _commands)
            {
                command.Execute();
            }
        }

        public void StoreCommand(ICommand command)
        {
            _commands.Add(command);
        }
    }
}
