using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Command : ICommand
    {
        private Action _receiverAction;
        
        public Command(Action receiverAction)
        {
            _receiverAction = receiverAction;
        }

        public void Execute()
        {
            _receiverAction.Invoke();
        }
    }
}
