using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Receiver : IReceiver
    {
        private string _text = string.Empty;

        public void Action()
        {
            _text += "a";
        }

        public string GetText()
        {
            return _text;
        }
    }
}
