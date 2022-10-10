using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public interface IContext
    {
        public bool GetVariableValue(string variable);
        public void AssignVariable(string variable, bool value);
    }
}
