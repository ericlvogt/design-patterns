using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class Context : IContext
    {
        private Dictionary<string, bool> _variableLookup = new();

        public void AssignVariable(string variable, bool value)
        {
            _variableLookup.Add(variable, value);
        }

        public bool GetVariableValue(string variable)
        {
            return _variableLookup[variable];
        }
    }
}
